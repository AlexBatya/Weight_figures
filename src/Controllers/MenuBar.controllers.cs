using System; // Базовая библиотека C#.
using System.Windows.Forms; // Библиотека для работы с графическим интерфейсом.
using MyApp.Services; // Подключение сервиса для работы с файлами.
using MyApp.Views; // Подключение пространства имен с представлениями (окнами).
using MyApp.Models;

namespace MyApp.Controllers // Пространство имен для логики контроллеров.
{
  public class MainController {
    private readonly Control _view;
    private DriveForm? _driveForm; // Поле для хранения ссылки на окно
    // Поле для хранения ссылки на главное окно. Контроллер будет взаимодействовать с этим окном.
    //
    public FileData? FileData { get; private set; }

    public MainController(Control view) {
      _view = view;
      // Сохраняем ссылку на переданное окно, чтобы можно было взаимодействовать с его элементами.
    }

    public void OpenFile(object sender, EventArgs e) {
      var openFileDialog = new OpenFileDialog {
        Filter = "XML Files|*.xml|All Files|*.*",
        Title = "Выберите XML файл"
      };

      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        try {
          // Создаем новый объект модели
          var fileData = new FileData(new List<int>(), new List<int>(), new List<int>(),
                                      new List<int>(), new List<bool>(), new List<int>(), "");

          // Загружаем данные в модель с помощью сервиса
          FileServices.ReadXmlFile(openFileDialog.FileName, fileData);

          // Теперь можно использовать fileData в дальнейшем, например, передать в представление

        }
        catch (Exception ex)
        {
          Console.WriteLine($"Ошибка: {ex.Message}");
        }
      }
    }

    public void ExitApp(object? sender, EventArgs e) {
      Application.Exit();
      // Закрываем приложение.
    }

    public void ShowAbout(object? sender, EventArgs e) {
      var aboutForm = new AboutForm();
      // Создаем экземпляр окна "О программе".

      aboutForm.ShowDialog();
      // Показываем окно в модальном режиме (пользователь должен закрыть его перед возвращением к основному окну).
    }

    public void ShowDrive(object? sender, EventArgs e){
      if (_driveForm == null || _driveForm.IsDisposed) {
        // Если окно не создано или было закрыто, создаем новое
        _driveForm = new DriveForm();
        _driveForm.FormClosed += (s, args) => _driveForm = null; // Сбрасываем ссылку при закрытии окна
        _driveForm.Show();
      } 
      else {
          // Если окно уже открыто, активируем его
          _driveForm.Activate();
      }
    }

  }
}


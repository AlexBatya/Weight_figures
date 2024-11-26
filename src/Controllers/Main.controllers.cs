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

    public MainController(Control view) {
      _view = view ?? throw new ArgumentNullException(nameof(view));
      // Сохраняем ссылку на переданное окно, чтобы можно было взаимодействовать с его элементами.
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

    public void ShowSettings(object? sender, EventArgs e) {
      var settingsForm = new SettingsForm();
      // Создаем экземпляр окна "О программе".

      settingsForm.Show();
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


using System;
using System.Windows.Forms;
using MyApp.Services; // Подключение сервиса для работы с файлами.
using MyApp.Views; // Подключение пространства имен с представлениями (окнами).
using MyApp.Models; // Подключение пространства имен с представлениями (окнами).

namespace MyApp.Controllers {

  public class FileController {
    private readonly Form _view;

    public FileData? FileData { get; private set; }
    public string fileNamePath { get; private set;}

    public FileController(Form view){
      _view = view ?? throw new ArgumentNullException(nameof(view));
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

          this.fileNamePath = Path.GetFileName(openFileDialog.FileName);

          _view.Text = $"Scales_figures - {fileNamePath}";

          // Теперь можно использовать fileData в дальнейшем, например, передать в представление
          Console.WriteLine("StatW: " + string.Join(", ", fileData.StatW));

        }
        catch (Exception ex)
        {
          MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

  };

}

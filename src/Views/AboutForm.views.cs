using System.Windows.Forms;

namespace MyApp.Views
{
  public class AboutForm : Form {
    public AboutForm() {
      this.CenterToScreen();

      Text = "О программе";
      Width = 300; // Увеличил ширину для удобного отображения текста
      Height = 200;

      var panel = new Panel {
        Dock = DockStyle.Fill,
        Padding = new Padding(10) // Внутренние отступы
      };

      var label = new Label
      {
        Text = "Это приложение предназначено для просмотра и анализа графиков, " +
               "полученных с автомобильных весов \n\n" +
               "Версия приложения: 1.0\n" +
               "Производитель: ООО \"Уссурвеском\"\n" +
               "Сайт: http://ussurvescom.ru",
        AutoSize = false,
        Dock = DockStyle.Fill,
        TextAlign = System.Drawing.ContentAlignment.MiddleCenter // Текст по центру
      };

      panel.Controls.Add(label); // Добавляем Label в Panel
      Controls.Add(panel);       // Добавляем Panel в форму
    }
  }
}


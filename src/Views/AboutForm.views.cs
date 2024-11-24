using System;
using System.Windows.Forms;

namespace MyApp.Views {
  public class AboutForm : Form {

    private readonly Controllers.KeyController _keyController; // Добавим MenuBar как поле

    public AboutForm() {
      this.Icon = new System.Drawing.Icon("C:/Users/user/Desktop/test/src/Assets/Img/info.ico");
      this.Font = new Font("Comic Sans MS", 8, FontStyle.Italic);
      _keyController = new Controllers.KeyController(this); // Инициализация контроллера

      this.KeyDown += new KeyEventHandler(_keyController.OnKeyDown);
      this.KeyPreview = true;

      this.CenterToScreen();

      Text = "О программе";
      Width = 300; // Увеличил ширину для удобного отображения текста
      Height = 200;

      this.MaximizeBox = false;
      this.MinimizeBox = false;

      this.FormBorderStyle = FormBorderStyle.FixedDialog;

      var linkLabel = new LinkLabel {
          AutoSize = false,
          Dock = DockStyle.Fill,
          TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      };

      // Текст с ссылкой
      string labelText = "Это приложение предназначено для просмотра и анализа графиков, " +
                         "полученных с автомобильных весов \n\n" +
                         "Версия приложения: 1.0\n" +
                         "Производитель: ООО \"Уссурвеском\"\n" +
                         "Сайт: http://ussurvescom.ru";

      linkLabel.Text = labelText;
      linkLabel.LinkColor = System.Drawing.Color.Gray; // Цвет обычной ссылки
      linkLabel.VisitedLinkColor = System.Drawing.Color.Gray; // Цвет посещенной ссылки
      linkLabel.ActiveLinkColor = System.Drawing.Color.Gray; // Цвет ссылки при нажатии

      // Добавляем ссылку на сайт
      linkLabel.Links.Add(labelText.IndexOf("http://ussurvescom.ru"), "http://ussurvescom.ru".Length, "http://ussurvescom.ru");

      // Обработчик события для клика по ссылке
      linkLabel.LinkClicked += (sender, e) => {
        if (e.Link.LinkData is string url) {
          // Для .NET 6 и выше, используем Process.Start с URI
          if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
          {
              System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true });
          }
        }
      };

      this.Controls.Add(linkLabel); // Добавляем LinkLabel в форму       // Добавляем Panel в форму
    }
  }
}


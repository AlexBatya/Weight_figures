using System;
using System.Windows.Forms;

namespace MyApp.Views {

  public class DriveForm: Form {
    private readonly Controllers.KeyController _keyController; // Добавим MenuBar как поле

    public DriveForm() {
      this.Icon = new System.Drawing.Icon("C:/Users/user/Desktop/test/src/Assets/Img/drive.ico");
      _keyController = new Controllers.KeyController(this); // Инициализация контроллера

      Text = "Производная";

      AutoSize = false;
      Width = 400; // Увеличил ширину для удобного отображения текста
      Height = 300;

      this.KeyDown += new KeyEventHandler(_keyController.OnKeyDown);
      this.KeyPreview = true;

    }

  }

}


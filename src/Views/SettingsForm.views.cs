using System;
using System.Windows.Forms;

namespace MyApp.Views {

  public class SettingsForm: Form {
    private readonly Controllers.KeyController _keyController; // Добавим MenuBar как поле
    
    public SettingsForm(){
      _keyController = new Controllers.KeyController(this); // Инициализация контроллера

      InitializeContent();
    }

    private void InitializeContent(){
      this.Icon = new System.Drawing.Icon("C:/Users/user/Desktop/test/src/Assets/Img/settings.ico");
      Text = "Настройки";

      AutoSize = false;
      Width = 400; // Увеличил ширину для удобного отображения текста
      Height = 300;

      this.KeyDown += new KeyEventHandler(_keyController.OnKeyDown);
      this.KeyPreview = true;

    }

  }

}

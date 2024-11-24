using System;
using System.Windows.Forms;

namespace MyApp.Views
{
  public class MainForm : Form
  {
    private readonly Controllers.MainController _controller;
    private readonly Controllers.KeyController _keyController; // Добавим MenuBar как поле
    private readonly MenuBar _menuBar; // Добавим MenuBar как поле

    public MainForm()
    {

      this.Font = new Font("Comic Sans MS", 8, FontStyle.Italic);
      _keyController = new Controllers.KeyController(this); // Инициализация контроллера
      this.Icon = new System.Drawing.Icon("C:/Users/user/Desktop/test/src/Assets/Img/icon.ico");

      InitializeComponent(); // Инициализация интерфейса
      _controller = new Controllers.MainController(this); // Создание контроллера
      _menuBar = new MenuBar(); // Инициализация MenuBar как компонента
      _menuBar.Dock = DockStyle.Top; // Закрепляем MenuBar в верхней части окна
      this.Controls.Add(_menuBar); // Добавляем MenuBar в MainForm

      this.KeyDown += new KeyEventHandler(_keyController.OnKeyDown);
      this.KeyPreview = true;

      this.AllowDrop = true;
    }

    private void InitializeComponent()
    {
      StartPosition = FormStartPosition.CenterScreen; // Устанавливаем появление окна по центру экрана
      this.Text = "Scales_figures";
      this.Size = new System.Drawing.Size(600, 400);
    }
  }
}


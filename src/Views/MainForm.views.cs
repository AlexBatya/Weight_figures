using System;
using System.Windows.Forms;

namespace MyApp.Views
{
  public class MainForm : Form
  {
    private readonly Controllers.MainController _controller;
    private readonly MenuBar _menuBar; // Добавим MenuBar как поле

    public MainForm()
    {
      InitializeComponent(); // Инициализация интерфейса
      _controller = new Controllers.MainController(this); // Создание контроллера
      _menuBar = new MenuBar(); // Инициализация MenuBar как компонента
      _menuBar.Dock = DockStyle.Top; // Закрепляем MenuBar в верхней части окна
      this.Controls.Add(_menuBar); // Добавляем MenuBar в MainForm
    }

    private void InitializeComponent()
    {
      this.CenterToScreen();
      this.Text = "Пащенко Индастриз";
      this.Size = new System.Drawing.Size(600, 400);
    }
  }
}


using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyApp.Views
{
  public class MainForm : Form
  {
    private readonly Controllers.MainController _controller;
    private readonly Controllers.KeyController _keyController;
    private readonly MenuBar _menuBar;

    public MainForm()
    {
      this.Font = new Font("Comic Sans MS", 8, FontStyle.Italic);
      _keyController = new Controllers.KeyController(this);
      this.Icon = new System.Drawing.Icon("C:/Users/user/Desktop/test/src/Assets/Img/icon.ico");

      InitializeComponent();
      _controller = new Controllers.MainController(this);

      // Инициализация MenuBar
      _menuBar = new MenuBar();
      _menuBar.Dock = DockStyle.Top;  // Меню прикрепляется к верхней части формы

      // Добавляем MenuBar в MainForm
      this.Controls.Add(_menuBar);

      // Обработчик нажатия клавиш
      this.KeyDown += new KeyEventHandler(_keyController.OnKeyDown);
      this.KeyPreview = true;

      this.AllowDrop = true;

      // Инициализация Figure (графика)
      var figure = new Figure
      {
        Dock = DockStyle.Fill // График заполняет всё оставшееся пространство
      };

      // Используем TableLayoutPanel для правильного размещения
      var tableLayoutPanel = new TableLayoutPanel
      {
        Dock = DockStyle.Fill, // Растягиваем на всю форму
        RowCount = 2,
        ColumnCount = 1
      };

      // Разделение на две строки: одна для MenuBar, другая для Figure
      tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); // Для меню (отступ сверху)
      tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); // График будет занимать все оставшееся место
      tableLayoutPanel.Controls.Add(_menuBar, 0, 0); // Добавляем MenuBar в первую строку
      tableLayoutPanel.Controls.Add(figure, 0, 1); // Добавляем Figure во вторую строку

      // Добавляем TableLayoutPanel в форму
      this.Controls.Add(tableLayoutPanel); // Теперь меню и график правильно расположены на форме
    }

    private void InitializeComponent()
    {
      StartPosition = FormStartPosition.CenterScreen; // Центрируем окно
      this.Text = "Scales_figures"; // Название окна
      this.Size = new System.Drawing.Size(800, 600); // Размер окна
    }
  }
}


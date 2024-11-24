using System;
using System.Windows.Forms;

namespace MyApp.Views {
  public class MenuBar : UserControl { // Используем UserControl вместо Form 

    private readonly Controllers.MainController _controller;

    public MenuBar() {
      _controller = new Controllers.MainController(this); // Инициализация контроллера
      InitializeMenu(); // Инициализация меню (после создания контроллера)
    }

    private void InitializeMenu() {
      // Создаём меню
      var menuStrip = new MenuStrip();

      // Меню "Файл"
      var fileMenu = new ToolStripMenuItem("Файл"){Font = new Font("Comic Sans MS", 8, FontStyle.Italic)};
      var openMenuItem = new ToolStripMenuItem("Открыть", null, _controller.OpenFile){ShortcutKeys = Keys.Control | Keys.C, Font = new Font("Comic Sans MS", 8, FontStyle.Italic)};
      var exitMenuItem = new ToolStripMenuItem("Выход", null, _controller.ExitApp){ShortcutKeys = Keys.Control | Keys.W};

      fileMenu.DropDownItems.Add(openMenuItem);
      fileMenu.DropDownItems.Add(new ToolStripSeparator());
      fileMenu.DropDownItems.Add(exitMenuItem);

      // Меню "Дополнительно"
      var driveMenu = new ToolStripMenuItem("Дополнительно"){Font = new Font("Comic Sans MS", 8, FontStyle.Italic)};
      var driveMenuItem = new ToolStripMenuItem("Производная", null, _controller.ShowDrive){ShortcutKeys = Keys.Control | Keys.D};

      driveMenu.DropDownItems.Add(driveMenuItem);

      var figureMenu = new ToolStripMenuItem("График"){Font = new Font("Comic Sans MS", 8, FontStyle.Italic)};
      var ADCCODE1 = new ToolStripMenuItem("ADCCODE1") { CheckOnClick = true };
      var ADCCODE2 = new ToolStripMenuItem("ADCCODE2") { CheckOnClick = true };
      var ADCCODE3 = new ToolStripMenuItem("ADCCODE3") { CheckOnClick = true };
      var ADCCODE4 = new ToolStripMenuItem("ADCCODE4") { CheckOnClick = true };
      var StatW = new ToolStripMenuItem("StatW") { CheckOnClick = true };

      figureMenu.DropDownItems.AddRange(new ToolStripItem[] { ADCCODE1,  ADCCODE2, ADCCODE3, ADCCODE4, new ToolStripSeparator(), StatW });

      // Меню "Справка"
      var aboutMenu = new ToolStripMenuItem("Справка"){Font = new Font("Comic Sans MS", 8, FontStyle.Italic)};
      var aboutMenuItem = new ToolStripMenuItem("О программе", null, _controller.ShowAbout){ShortcutKeys = Keys.Control | Keys.I};

      aboutMenu.DropDownItems.Add(aboutMenuItem);

      // Добавляем всё в меню
      menuStrip.Items.Add(fileMenu);
      menuStrip.Items.Add(figureMenu);
      menuStrip.Items.Add(driveMenu);
      menuStrip.Items.Add(aboutMenu);

      // Привязываем меню к контролу
      this.Controls.Add(menuStrip);
    }
  }
}


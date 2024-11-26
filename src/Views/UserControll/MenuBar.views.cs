using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyApp.Views {
  public class MenuBar : UserControl {
    private readonly Controllers.MainController _controller;
    private readonly Controllers.FileController _fileController;

    public MenuBar() {
      // Инициализация контроллеров
      _controller = new Controllers.MainController(this);
      _fileController = new Controllers.FileController(this);

      // Инициализация меню
      InitializeMenu();
    }

    private void InitializeMenu() {
      // Создаём меню
      var menuStrip = new MenuStrip
      {
          Dock = DockStyle.Top // Размещаем меню сверху
      };

      // Меню "Файл"
      var fileMenu = new ToolStripMenuItem("Файл") { Font = GetMenuFont() };
      var openMenuItem = new ToolStripMenuItem("Открыть", null, _fileController.OpenFile) { ShortcutKeys = Keys.Control | Keys.O };
      var settingsMenuItem = new ToolStripMenuItem("Настройки", null, _controller.ShowSettings) { ShortcutKeys = Keys.Control | Keys.S };
      var exitMenuItem = new ToolStripMenuItem("Выход", null, _controller.ExitApp) { ShortcutKeys = Keys.Control | Keys.W };

      fileMenu.DropDownItems.AddRange(new ToolStripItem[]
      {
          openMenuItem,
          new ToolStripSeparator(),
          settingsMenuItem,
          exitMenuItem
      });

      // Меню "Дополнительно"
      var driveMenu = new ToolStripMenuItem("Дополнительно") { Font = GetMenuFont() };
      var driveMenuItem = new ToolStripMenuItem("Производная", null, _controller.ShowDrive) { ShortcutKeys = Keys.Control | Keys.D };

      driveMenu.DropDownItems.Add(driveMenuItem);

      // Меню "График"
      var figureMenu = new ToolStripMenuItem("График") { Font = GetMenuFont() };
      var ADCCODE1 = new ToolStripMenuItem("ADCCODE1") { CheckOnClick = true };
      var ADCCODE2 = new ToolStripMenuItem("ADCCODE2") { CheckOnClick = true };
      var ADCCODE3 = new ToolStripMenuItem("ADCCODE3") { CheckOnClick = true };
      var ADCCODE4 = new ToolStripMenuItem("ADCCODE4") { CheckOnClick = true };
      var StatW = new ToolStripMenuItem("StatW") { CheckOnClick = true };

      figureMenu.DropDownItems.AddRange(new ToolStripItem[]
      {
        ADCCODE1,
        ADCCODE2,
        ADCCODE3,
        ADCCODE4,
        new ToolStripSeparator(),
        StatW
      });

      // Меню "Справка"
      var aboutMenu = new ToolStripMenuItem("Справка") { Font = GetMenuFont() };
      var aboutMenuItem = new ToolStripMenuItem("О программе", null, _controller.ShowAbout) { ShortcutKeys = Keys.Control | Keys.I };

      aboutMenu.DropDownItems.Add(aboutMenuItem);

      // Добавляем меню
      menuStrip.Items.AddRange(new ToolStripItem[]
      {
        fileMenu,
        figureMenu,
        driveMenu,
        aboutMenu
      });

      // Добавляем MenuStrip в контрол
      this.Controls.Add(menuStrip);
    }

    // Метод для получения шрифта меню
    private Font GetMenuFont()
    {
        return new Font("Comic Sans MS", 8, FontStyle.Italic);
    }
  }
}


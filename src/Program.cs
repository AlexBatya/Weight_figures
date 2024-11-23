using System;
using System.Windows.Forms;
using MyApp.Views;

namespace MyApp {
  internal static class Program {

    [STAThread]

    static void Main() {
      // Включаем визуальные стили для элементов управления
      Application.EnableVisualStyles();

      // Устанавливаем совместимость рендеринга текста
      Application.SetCompatibleTextRenderingDefault(false);

      // Запускаем приложение с главной формой MainForm
      Application.Run(new MainForm());
    }
  }
}


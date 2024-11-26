using System; // Базовая библиотека C#.
using System.Windows.Forms; // Библиотека для работы с графическим интерфейсом.

namespace MyApp.Controllers {

  public class KeyController {
    private readonly Control _view;

    public KeyController(Control view){
      _view = view ?? throw new ArgumentNullException(nameof(view));
    }

    public void OnKeyDown(object? sender, KeyEventArgs e) {
      // Проверяем, нажаты ли Ctrl и Q одновременно
      if (e.Control && e.KeyCode == Keys.Q) {
          Application.Exit(); // Закрываем приложение
      }
      // Проверка комбинации клавиш Ctrl + W
      if (e.Control && e.KeyCode == Keys.W) {
        // Закрытие текущего окна
        if (_view is Form form) {
            form.Close(); // Закрытие формы
        }
      }
    }

  }

}

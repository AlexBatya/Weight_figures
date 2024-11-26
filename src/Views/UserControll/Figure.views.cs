using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Windows.Forms;

namespace MyApp.Views
{
  public class Figure : UserControl
  {
    private PlotView plotView;

    public Figure()
    {
      InitializeComponent();
      InitializePlot();
    }

    private void InitializeComponent()
    {
      this.Dock = DockStyle.Fill; // Растягиваем Figure на всю доступную площадь
    }

    private void InitializePlot()
    {
      // Создаем PlotView
      plotView = new PlotView
      {
        Dock = DockStyle.Fill // Занимает всю площадь UserControl
      };

      // Создаем модель графика
      var plotModel = new PlotModel { Title = "", TitleFont = "Comic Sans MS" };


      plotModel.Axes.Add(new OxyPlot.Axes.LinearAxis
      {
        Title = "Ось X",
        Position = OxyPlot.Axes.AxisPosition.Bottom,
        MajorGridlineStyle = LineStyle.Solid,
        MinorGridlineStyle = LineStyle.Dot,
        MajorGridlineColor = OxyColor.FromAColor(100, OxyColors.Gray), // Прозрачный серый (100 = ~40% прозрачности)
        MinorGridlineColor = OxyColor.FromAColor(50, OxyColors.LightGray) // Более прозрачный светло-серый
      });

      // Настройка оси Y с полупрозрачной сеткой
      plotModel.Axes.Add(new OxyPlot.Axes.LinearAxis
      {
        Title = "Ось Y",
        Position = OxyPlot.Axes.AxisPosition.Left,
        MajorGridlineStyle = LineStyle.Solid,
        MinorGridlineStyle = LineStyle.Dot,
        MajorGridlineColor = OxyColor.FromAColor(100, OxyColors.Gray),
        MinorGridlineColor = OxyColor.FromAColor(50, OxyColors.LightGray)
      });

      // Добавляем серию точек
      plotModel.Series.Add(new LineSeries
      {
        Title = "Пример данных",
        Color = OxyColors.Red,
        Points = {
          new DataPoint(0, 0),
          new DataPoint(1, 2),
          new DataPoint(2, 4),
          new DataPoint(3, 8)
        }
      });

      // Привязываем модель к PlotView
      plotView.Model = plotModel;

      // Добавляем PlotView в UserControl
      this.Controls.Add(plotView);
    }
  }
}


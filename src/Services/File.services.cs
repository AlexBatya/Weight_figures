using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using MyApp.Models;

namespace MyApp.Services {

  public class FileServices {
    public static void ReadXmlFile(string filePath, FileData fileData) {
      try {
        // Загружаем XML файл
        XDocument xmlDocument = XDocument.Load(filePath);

        // Инициализируем списки в модели
        fileData.ADCCODE1.Clear();
        fileData.ADCCODE2.Clear();
        fileData.ADCCODE3.Clear();
        fileData.ADCCODE4.Clear();
        fileData.ST_Flag.Clear();
        fileData.StatW.Clear();

        // Извлекаем строки ROW и наполняем списки модели
        foreach (var row in xmlDocument.Descendants("ROW"))
        {
          fileData.ADCCODE1.Add(int.Parse(row.Attribute("ADCCODE1")?.Value ?? "0"));
          fileData.ADCCODE2.Add(int.Parse(row.Attribute("ADCCODE2")?.Value ?? "0"));
          fileData.ADCCODE3.Add(int.Parse(row.Attribute("ADCCODE3")?.Value ?? "0"));
          fileData.ADCCODE4.Add(int.Parse(row.Attribute("ADCCODE4")?.Value ?? "0"));
          fileData.ST_Flag.Add(bool.Parse(row.Attribute("ST_Flag")?.Value ?? "false"));
          fileData.StatW.Add(int.Parse(row.Attribute("StatW")?.Value ?? "0"));
        }

        // Устанавливаем путь к файлу
        fileData.FilePath = filePath;
      }
      catch (Exception ex) {
          Console.WriteLine($"Ошибка при чтении XML файла: {ex.Message}");
          // Можно обработать ошибку, например, записать пустые данные в модель.
          fileData.ADCCODE1.Clear();
          fileData.ADCCODE2.Clear();
          fileData.ADCCODE3.Clear();
          fileData.ADCCODE4.Clear();
          fileData.ST_Flag.Clear();
          fileData.StatW.Clear();
          fileData.FilePath = string.Empty; // Очистить путь
      }
    }
  };

  public static class FileServicesAvion {
    public static void ReadXmlFile(string filePath, FileDataAvion fileData) {
      try {
        // Загружаем XML файл
        XDocument xmlDocument = XDocument.Load(filePath);

        // Инициализируем списки в модели
        fileData.OSWES.Clear();
        fileData.WES12.Clear();
        fileData.WES34.Clear();
        fileData.WES56.Clear();
        fileData.WES78.Clear();
        fileData.WES910.Clear();
        fileData.WES1112.Clear();
        fileData.ADCCODE1.Clear();
        fileData.ADCCODE2.Clear();
        fileData.ADCCODE3.Clear();
        fileData.ADCCODE4.Clear();
        fileData.ADCCODE5.Clear();
        fileData.ADCCODE6.Clear();
        fileData.ADCCODE7.Clear();
        fileData.ADCCODE8.Clear();
        fileData.ADCCODE9.Clear();
        fileData.ADCCODE10.Clear();
        fileData.ADCCODE11.Clear();
        fileData.ADCCODE12.Clear();

          // Извлекаем строки ROW и наполняем списки модели
        foreach (var row in xmlDocument.Descendants("ROW")) {
          fileData.OSWES.Add(int.Parse(row.Attribute("OSWES")?.Value ?? "0"));
          fileData.WES12.Add(int.Parse(row.Attribute("WES12")?.Value ?? "0"));
          fileData.WES34.Add(int.Parse(row.Attribute("WES34")?.Value ?? "0"));
          fileData.WES56.Add(int.Parse(row.Attribute("WES56")?.Value ?? "0"));
          fileData.WES78.Add(int.Parse(row.Attribute("WES78")?.Value ?? "0"));
          fileData.WES910.Add(int.Parse(row.Attribute("WES910")?.Value ?? "0"));
          fileData.WES1112.Add(int.Parse(row.Attribute("WES1112")?.Value ?? "0"));

          fileData.ADCCODE1.Add(int.Parse(row.Attribute("ADCCODE1")?.Value ?? "0"));
          fileData.ADCCODE2.Add(int.Parse(row.Attribute("ADCCODE2")?.Value ?? "0"));
          fileData.ADCCODE3.Add(int.Parse(row.Attribute("ADCCODE3")?.Value ?? "0"));
          fileData.ADCCODE4.Add(int.Parse(row.Attribute("ADCCODE4")?.Value ?? "0"));
          fileData.ADCCODE5.Add(int.Parse(row.Attribute("ADCCODE5")?.Value ?? "0"));
          fileData.ADCCODE6.Add(int.Parse(row.Attribute("ADCCODE6")?.Value ?? "0"));
          fileData.ADCCODE7.Add(int.Parse(row.Attribute("ADCCODE7")?.Value ?? "0"));
          fileData.ADCCODE8.Add(int.Parse(row.Attribute("ADCCODE8")?.Value ?? "0"));
          fileData.ADCCODE9.Add(int.Parse(row.Attribute("ADCCODE9")?.Value ?? "0"));
          fileData.ADCCODE10.Add(int.Parse(row.Attribute("ADCCODE10")?.Value ?? "0"));
          fileData.ADCCODE11.Add(int.Parse(row.Attribute("ADCCODE11")?.Value ?? "0"));
          fileData.ADCCODE12.Add(int.Parse(row.Attribute("ADCCODE12")?.Value ?? "0"));
        }

          // Устанавливаем путь к файлу
        fileData.FilePath = filePath;
      }
      catch (Exception ex) {
        Console.WriteLine($"Ошибка при чтении XML файла: {ex.Message}");
        // Очистить данные в случае ошибки
        fileData.OSWES.Clear();
        fileData.WES12.Clear();
        fileData.WES34.Clear();
        fileData.WES56.Clear();
        fileData.WES78.Clear();
        fileData.WES910.Clear();
        fileData.WES1112.Clear();
        fileData.ADCCODE1.Clear();
        fileData.ADCCODE2.Clear();
        fileData.ADCCODE3.Clear();
        fileData.ADCCODE4.Clear();
        fileData.ADCCODE5.Clear();
        fileData.ADCCODE6.Clear();
        fileData.ADCCODE7.Clear();
        fileData.ADCCODE8.Clear();
        fileData.ADCCODE9.Clear();
        fileData.ADCCODE10.Clear();
        fileData.ADCCODE11.Clear();
        fileData.ADCCODE12.Clear();
        fileData.FilePath = string.Empty; // Очистить путь
      }
    }
  }

}


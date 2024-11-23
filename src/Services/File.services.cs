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
  }
}


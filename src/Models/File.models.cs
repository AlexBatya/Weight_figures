namespace MyApp.Models {

  public class FileData {
    public List<int> ADCCODE1 { get; set; }
    public List<int> ADCCODE2 { get; set; }
    public List<int> ADCCODE3 { get; set; }
    public List<int> ADCCODE4 { get; set; }
    public List<bool> ST_Flag { get; set; }
    public List<int> StatW { get; set; }
    public string FilePath { get; set; } // Ссылка на путь файла

    // Конструктор для удобного создания объекта
    public FileData(
      List<int> adcCode1,
      List<int> adcCode2,
      List<int> adcCode3,
      List<int> adcCode4,
      List<bool> stFlag,
      List<int> statW,
      string filePath)
    {
      ADCCODE1 = adcCode1;
      ADCCODE2 = adcCode2;
      ADCCODE3 = adcCode3;
      ADCCODE4 = adcCode4;
      ST_Flag = stFlag;
      StatW = statW;
      FilePath = filePath;
    }
  };

  public class FileDataAvion {
    // Переменные для хранения данных WES
    public List<int> OSWES { get; set; }
    public List<int> WES12 { get; set; }
    public List<int> WES34 { get; set; }
    public List<int> WES56 { get; set; }
    public List<int> WES78 { get; set; }
    public List<int> WES910 { get; set; }
    public List<int> WES1112 { get; set; }

    // Переменные для ADC-кодов
    public List<int> ADCCODE1 { get; set; }
    public List<int> ADCCODE2 { get; set; }
    public List<int> ADCCODE3 { get; set; }
    public List<int> ADCCODE4 { get; set; }
    public List<int> ADCCODE5 { get; set; }
    public List<int> ADCCODE6 { get; set; }
    public List<int> ADCCODE7 { get; set; }
    public List<int> ADCCODE8 { get; set; }
    public List<int> ADCCODE9 { get; set; }
    public List<int> ADCCODE10 { get; set; }
    public List<int> ADCCODE11 { get; set; }
    public List<int> ADCCODE12 { get; set; }

    public string FilePath { get; set; } // Ссылка на путь файла

    // Конструктор для создания объекта
    public FileDataAvion(
        List<int> oswes,
        List<int> wes12,
        List<int> wes34,
        List<int> wes56,
        List<int> wes78,
        List<int> wes910,
        List<int> wes1112,
        List<int> adcCode1,
        List<int> adcCode2,
        List<int> adcCode3,
        List<int> adcCode4,
        List<int> adcCode5,
        List<int> adcCode6,
        List<int> adcCode7,
        List<int> adcCode8,
        List<int> adcCode9,
        List<int> adcCode10,
        List<int> adcCode11,
        List<int> adcCode12,
        string filePath)
    {
        OSWES = oswes;
        WES12 = wes12;
        WES34 = wes34;
        WES56 = wes56;
        WES78 = wes78;
        WES910 = wes910;
        WES1112 = wes1112;

        ADCCODE1 = adcCode1;
        ADCCODE2 = adcCode2;
        ADCCODE3 = adcCode3;
        ADCCODE4 = adcCode4;
        ADCCODE5 = adcCode5;
        ADCCODE6 = adcCode6;
        ADCCODE7 = adcCode7;
        ADCCODE8 = adcCode8;
        ADCCODE9 = adcCode9;
        ADCCODE10 = adcCode10;
        ADCCODE11 = adcCode11;
        ADCCODE12 = adcCode12;

        FilePath = filePath;
    }
  };

}

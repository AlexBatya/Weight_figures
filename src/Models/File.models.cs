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
  }

}

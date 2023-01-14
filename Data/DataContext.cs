namespace CursTest.Data
{
    /// <summary>
    /// Класс с свойствами для общения с БД
    /// </summary>
    public class DataContext
    {
        public string Database_Name { get; set; }
        public string Companies_Collection_Name { get; set;}
        public string Connection_String { get; set;}
        public string Jsonfilename_Collection_Name { get; set;}
    }
}

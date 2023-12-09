namespace tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLibrary.DataModels
{
    public class Book
    {
        public int Id { get; set; }
        public int? BookShelf { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
    }
}

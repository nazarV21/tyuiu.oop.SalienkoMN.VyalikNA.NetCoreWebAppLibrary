namespace tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLibrary.DataModels
{
    public class People
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public ICollection<BooksUsers> Books { get; set; }
    }
}

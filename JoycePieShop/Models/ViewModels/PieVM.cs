namespace JoycePieShop.Models.ViewModels
{
    public class PieVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool IsInStock { get; set; }
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}

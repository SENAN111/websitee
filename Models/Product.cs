namespace Website.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string image { get; set; }
        public decimal price { get; set; }  
        public string description { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public string CatagoryId { get; set; }
        public Catagorycs catagorycs { get; set; }
        public Size size { get; set; }
        public Color color { get; set; }
         
    }
}

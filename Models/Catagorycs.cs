namespace Website.Models
{
    public class Catagorycs
    {   
        string Name { get; set; }
        int Id { get; set; }
        string Image { get; set; }
        List<Product> products { get; set; }

    }
}

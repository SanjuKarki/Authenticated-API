namespace Autheticated.models 
{
    public class Shopping_Cart
    {
        public int Id { get; set; }
        public string? User { get; set; }

        public List<Product> Products {get; set;} = [];
    }
}

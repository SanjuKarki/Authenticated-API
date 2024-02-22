namespace Autheticated.models;

public class Product
{
    public int Id {get; set;}
    public string? Price {get; set;}
    public string? Name {get; set;}
    public string? Description {get; set;}

    // Add Category property
    public Category? Category { get; set; }

}

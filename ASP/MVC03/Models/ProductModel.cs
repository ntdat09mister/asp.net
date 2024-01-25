public class ProductModel
{
    public int ProductID { get; set; }
    public required string ProductName { get; set; }
    public required string ImageURL { get; set; }
    public double ProductPrice { get; set; }
    public required string Description { get; set; }
}

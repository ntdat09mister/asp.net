using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    private readonly ProductRepository _productRepository;

    public ProductController()
    {
        _productRepository = new ProductRepository();
    }

    public IActionResult ProductList()
    {
        var products = _productRepository.GetProducts();
        return View(products);
    }

    public IActionResult ProductDetail(int id)
    {
        var product = _productRepository.GetProductById(id);
        return View(product);
    }
}

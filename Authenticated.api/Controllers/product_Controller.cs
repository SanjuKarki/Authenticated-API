using Authenticated.api.Data;
using Autheticated.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authenticated.api.Controllers;
[Authorize]
[ApiController]
[Route("[controller]/[action]")]
public class Product_Controller : ControllerBase
{
    private readonly DBContext _DbContext;

    public Product_Controller(ILogger<Product_Controller> logger, DBContext DbContext)
    {
        _DbContext = DbContext;
    }
[HttpGet]
public IActionResult Get_All_Products()
{
    return Ok(_DbContext.Products);
}
[HttpGet]
public IActionResult Get_Products_By_Category(int categoryId)
{
    var products_Category = _DbContext.Products.Where(prod => prod.Category.Id == categoryId).ToList();
    return Ok(products_Category);
}
[HttpPost]
public IActionResult AddProduct(Product product){
    if(product == null)
    {
        return BadRequest();
    }
    _DbContext.Products.Add(product);
    _DbContext.SaveChanges();
    return Ok(product);
}
}
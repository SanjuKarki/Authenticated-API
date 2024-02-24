using Authenticated.api.Data;
using Autheticated.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Authenticated.api.Controllers;
[Authorize]
[ApiController]
[Route("[controller]/[action]")]
public class Shopping_Card_Controller : ControllerBase
{
  private readonly DBContext _DbContext;

    public Shopping_Card_Controller(ILogger<Shopping_Card_Controller> logger, DBContext DbContext)
    {
        _DbContext = DbContext;
    }

[HttpGet]
    public async Task<List<Product>?> GetUserProduct()
    {
        var user = User.Identity?.Name ?? string.Empty;

        var Scart = await _DbContext.ShoppingCarts.Where(Scart => Scart.User == user).FirstOrDefaultAsync();

        return Scart?.Products;
    }
  [HttpPost]
    public async Task<IActionResult> DeleteUserProduct(int id)
    {
        var user = User.Identity?.Name ?? string.Empty;

        var Scart = await _DbContext.ShoppingCarts.Where(Scart => Scart.User == user).FirstOrDefaultAsync();

        Scart?.Products.RemoveAll(product => product.Id == id);

        await _DbContext.SaveChangesAsync();

        return Ok();
    }
    [HttpPost]
    public async Task<IActionResult> CreateUserProduct(int id)
    {
        var user = User.Identity?.Name ?? string.Empty;

        var Scart = await _DbContext.ShoppingCarts.Where(Scart => Scart.User == user).FirstOrDefaultAsync();

        if (Scart is null)
        {
            _DbContext.Add(new Shopping_Cart()
            {
                User = user,
                Products = [new Product()
                {Id = id}]
            });
        }
        else
        {
            Scart.Products.Add(new Product() { Id = id });
        }

        await _DbContext.SaveChangesAsync();

        return Ok();
}

}
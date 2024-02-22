using Authenticated.api.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authenticated.api.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class ShoppingCartController : ControllerBase
{
    private readonly DBContext _applicationDbContext;

    public ShoppingCartController(ILogger<ShoppingCartController> logger, DBContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    [HttpGet]
    public async Task<List<Product>?> GetUsersProducts()
    {
        var user = User.Identity?.Name ?? string.Empty;

        var cart = await _applicationDbContext.ShoppingCarts.Where(cart => cart.User == user).FirstOrDefaultAsync();

        return cart?.Products;
    }

    [HttpPost]
    public async Task<IActionResult> DeleteUsersProduct(int id)
    {
        var user = User.Identity?.Name ?? string.Empty;

        var cart = await _applicationDbContext.ShoppingCarts.Where(cart => cart.User == user).FirstOrDefaultAsync();

        cart?.Products.RemoveAll(product => product.Id == id);

        await _applicationDbContext.SaveChangesAsync();

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateUsersProduct(int id)
    {
        var user = User.Identity?.Name ?? string.Empty;

        var cart = await _applicationDbContext.ShoppingCarts.Where(cart => cart.User == user).FirstOrDefaultAsync();

        if (cart is null)
        {
            _applicationDbContext.Add(new DBContext()
            {
                User = user,
                Products = [new Product()
                {
                    Id = id
                }]
            });
        }
        else
        {
            cart.Products.Add(new Product() { Id = id });
        }

        await _applicationDbContext.SaveChangesAsync();

        return Ok();
    }
}
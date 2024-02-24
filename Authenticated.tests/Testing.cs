using Autheticated.models;

namespace Authenticated.api;

public class UnitTest1
{
    [Fact]
    public void ProductTest()
    {
var Item = new Product(){
  Id = 1,
  Description = "Tesla"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Tesla", Item.Description);
  }
  [Fact]
    public void ProductTest_2()
    {
var Item = new Product(){
  Id = 1,
  Description = "DJI Drone"
};
Assert.Equal(1, Item.Id);
Assert.Equal("DJI Drone", Item.Description);
  }
    [Fact]
    public void ProductTest_3()
    {
var Item = new Product(){
  Id = 1,
  Description = "MacBook Pro 2023"
};
Assert.Equal(1, Item.Id);
Assert.Equal("MacBook Pro 2023", Item.Description);
  }
    [Fact]
    public void ProductTest_4()
    {
var Item = new Product(){
  Id = 1,
  Description = "Colgate"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Colgate", Item.Description);
  }

//Category Testing
   [Fact]
    public void Category_test1()
    {
var Item = new Category(){
  Id = 1,
  Description = "SUV"
};
Assert.Equal(1, Item.Id);
Assert.Equal("SUV", Item.Description);
  }

     [Fact]
    public void Category_test2()
    {
var Item = new Category(){
  Id = 1,
  Description = "Apple"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Apple", Item.Description);
  }

     [Fact]
    public void Category_test3()
    {
var Item = new Category(){
  Id = 1,
  Description = "Men Clothing"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Men Clothing", Item.Description);
  }

     [Fact]
    public void Category_test4()
    {
var Item = new Category(){
  Id = 1,
  Description = "Women Clothing"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Women Clothing", Item.Description);
  }

  //shoppingCart Testing
     [Fact]
    public void ShoppingCart_test1()
    {
var Item = new Shopping_Cart(){
  Id = 1,
  User = "Sanju"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Sanju", Item.User);
  }

       [Fact]
    public void ShoppingCart_test2()
    {
var Item = new Shopping_Cart(){
  Id = 2,
  User = "Bob"
};
Assert.Equal(2, Item.Id);
Assert.Equal("Bob", Item.User);

}
     [Fact]
    public void ShoppingCart_test3()
    {
var Item = new Shopping_Cart(){
  Id = 3,
  User = "Kathy"
};
Assert.Equal(3, Item.Id);
Assert.Equal("Kathy", Item.User);
}

     [Fact]
    public void ShoppingCart_test4()
    {
var Item = new Shopping_Cart(){
  Id = 4,
  User = "Kenny"
};
Assert.Equal(4, Item.Id);
Assert.Equal("Kenny", Item.User);
}
}
using Xunit;

using CS = Implementation.CoffeeShop;

namespace Implementation.Test.CoffeeShop.Test
{
    public class Test_CoffeeShop
    {
        public static void CreateMenu(CS.CoffeeShop shop)
        {
            shop.Menu.Add(new CS.CoffeeShop.MenuItem { Item = "Coffee", Type = "Drink", Price = 3.99m });
            shop.Menu.Add(new CS.CoffeeShop.MenuItem { Item = "Tea", Type = "Drink", Price = 2.99m });
            shop.Menu.Add(new CS.CoffeeShop.MenuItem { Item = "Water", Type = "Drink", Price = 1.49m });
            shop.Menu.Add(new CS.CoffeeShop.MenuItem { Item = "Orange Juice", Type = "Drink", Price = 1.99m });

            shop.Menu.Add(new CS.CoffeeShop.MenuItem { Item = "Scone", Type = "Food", Price = 4.99m });
            shop.Menu.Add(new CS.CoffeeShop.MenuItem { Item = "Muffin", Type = "Food", Price = 2.99m });
            shop.Menu.Add(new CS.CoffeeShop.MenuItem { Item = "Bagel", Type = "Food", Price = 2.49m });
            shop.Menu.Add(new CS.CoffeeShop.MenuItem { Item = "Sandwich", Type = "Food", Price = 6.99m });
        }

        [Fact]
        public void Test_AddOrder_ListOrder()
        {
            var sut = new CS.CoffeeShop("Starbucks");
            CreateMenu(sut);

            sut.AddOrder("Coffee");
            sut.AddOrder("Tea");
            sut.AddOrder("Bagel");

            Assert.Collection(sut.ListOrders(),
                order => Assert.Equal("Coffee", order),
                order => Assert.Equal("Tea", order),
                order => Assert.Equal("Bagel", order)
            );
        }

        [Fact]
        public void Test_FulfillOrder()
        {
            var sut = new CS.CoffeeShop("Bruger's");
            CreateMenu(sut);

            sut.AddOrder("Coffee");
            sut.AddOrder("Bagel");

            Assert.Equal("The Coffee is ready!", sut.FulfillOrder());
            Assert.Equal("The Bagel is ready!", sut.FulfillOrder());
            Assert.Equal("All orders have been fulfilled!", sut.FulfillOrder());
            Assert.Equal("All orders have been fulfilled!", sut.FulfillOrder());
        }

        [Fact]
        public void Test_InvalidItem()
        {
            var sut = new CS.CoffeeShop("Seattle's Best");
            CreateMenu(sut);

            Assert.Throws<System.ArgumentException>(() => sut.AddOrder("Fake Item 1"));
            Assert.Throws<System.ArgumentException>(() => sut.AddOrder("Popcorn"));
        }

        [Fact]
        public void Test_ListOrder()
        {
            var sut = new CS.CoffeeShop("Starbucks");
            CreateMenu(sut);

            sut.AddOrder("Coffee");
            sut.AddOrder("Tea");
            sut.AddOrder("Bagel");

            Assert.Collection(sut.ListOrders(),
                order => Assert.Equal("Coffee", order),
                order => Assert.Equal("Tea", order),
                order => Assert.Equal("Bagel", order)
            );

            Assert.Equal("The Coffee is ready!", sut.FulfillOrder());
            Assert.Collection(sut.ListOrders(),
                order => Assert.Equal("Tea", order),
                order => Assert.Equal("Bagel", order)
            );
        }

        [Fact]
        public void Test_DueAmount()
        {
            var sut = new CS.CoffeeShop("Starbucks");
            CreateMenu(sut);

            sut.AddOrder("Coffee");
            sut.AddOrder("Tea");
            sut.AddOrder("Bagel");

            Assert.Equal(9.47m, sut.DueAmount());
        }

        [Fact]
        public void Test_CheapestItem()
        {
            var sut = new CS.CoffeeShop("Starbucks");
            CreateMenu(sut);

            Assert.Equal("Water", sut.CheapestItem());
        }

        [Fact]
        public void Test_DrinksOnly()
        {
            var sut = new CS.CoffeeShop("Starbucks");
            CreateMenu(sut);

            Assert.Collection(sut.DrinksOnly(),
                drink => Assert.Equal("Coffee", drink),
                drink => Assert.Equal("Tea", drink),
                drink => Assert.Equal("Water", drink),
                drink => Assert.Equal("Orange Juice", drink)
            );
        }

        [Fact]
        public void Test_FoodOnly()
        {
            var sut = new CS.CoffeeShop("Starbucks");
            CreateMenu(sut);

            Assert.Collection(sut.FoodOnly(),
                food => Assert.Equal("Scone", food),
                food => Assert.Equal("Muffin", food),
                food => Assert.Equal("Bagel", food),
                food => Assert.Equal("Sandwich", food)
            );
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace Implementation.CoffeeShop
{
    public class CoffeeShop
    {
        public class MenuItem
        {
            public string Item { get; set; }
            public string Type { get; set; }
            public decimal Price { get; set; }
        }

        public string Name { get; set; }
        public List<MenuItem> Menu { get; set; }
        private List<string> Orders { get; set; }

        public CoffeeShop(string name)
        {
            Name = name;
            Menu = new List<MenuItem>();
            Orders = new List<string>();
        }

        public void AddOrder(string item)
        {
            // check for valid item
            if (Menu.Exists(x => x.Item == item))
            {
                Orders.Add(item);
            }
            else
            {
                throw new System.ArgumentException("Invalid item");
            }
        }

        public string FulfillOrder()
        {
            if (Orders.Count == 0)
            {
                return "All orders have been fulfilled!";
            }
            else
            {
                var item = Orders[0];
                Orders.RemoveAt(0);
                return $"The {item} is ready!";
            }
        }

        public List<string> ListOrders()
        {
            return Orders;
        }

        public decimal DueAmount()
        {
            decimal total = 0m;
            foreach (var item in Orders)
            {
                var menuItem = Menu.Find(x => x.Item == item);
                if (menuItem == null)
                {
                    // shouldn't ever happen since we check for invalid items when adding orders
                    throw new System.Exception("Found an order for an invalid item");
                }
                total += menuItem.Price;
            }
            return total;
        }

        public string CheapestItem()
        {
            var cheapest = Menu.OrderBy(x => x.Price).First();
            return cheapest.Item;
        }

        public List<string> DrinksOnly()
        {
            return Menu.Where(x => x.Type.ToLower() == "drink").Select(x => x.Item).ToList();
        }

        public List<string> FoodOnly()
        {
            return Menu.Where(x => x.Type.ToLower() == "food").Select(x => x.Item).ToList();
        }
    }
}
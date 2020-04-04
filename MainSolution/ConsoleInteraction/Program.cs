using Core;
using Core.Discounts;
using System;

namespace ConsoleInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product {ProductID = 1, Name = "Lays", Price = 20},
                new Product {ProductID = 2, Name = "Pringles", Price = 40}
            };

            Discount_1 discount1 = new Discount_1();
            Discount_5 discount5 = new Discount_5();

            ValueCalculator calculator = new ValueCalculator();

            ShoppingCart cart1 = new ShoppingCart(discount1, calculator) { Products = products };
            ShoppingCart cart2 = new ShoppingCart(discount5, calculator) { Products = products };

            Console.WriteLine(cart1.CalculateTotal());
            Console.WriteLine(cart2.CalculateTotal());
        }
    }
}

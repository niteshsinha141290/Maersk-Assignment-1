using Assignment1.Entity;
using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter total numbers of products");
            int totalProduct = Convert.ToInt32(Console.ReadLine());

            List<Product> products = new List<Product>();
            for (int i = 0; i < totalProduct; i++)
            {
                Console.WriteLine("Please enter the product type (A,B,C,D)");
                string type = Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }

            int totalPrice = GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        private static int GetTotalPrice(List<Product> products)
        {
            int promotionalPriceForA = 50;
            int promotionalPriceForB = 30;
            int promotionalPriceForC = 20;
            int promotionalPriceForD = 15;

            int totalNumberOfProductsOfTypeA = 0;
            int totalNumberOfProductsOfTypeB = 0;
            int totalNumberOfProductsOfTypeC = 0;
            int totalNumberOfProductsOfTypeD = 0;

            foreach (Product pr in products)
            {
                switch (pr.Type)
                {
                    case "A": totalNumberOfProductsOfTypeA += 1;
                        break;
                    case "B":
                        totalNumberOfProductsOfTypeB += 1;
                        break;
                    case "C":
                        totalNumberOfProductsOfTypeC += 1;
                        break;
                    case "D":
                        totalNumberOfProductsOfTypeD += 1;
                        break;

                }
            }

            int totalPriceOfProductTypeA = (totalNumberOfProductsOfTypeA / 3) * 130 + (totalNumberOfProductsOfTypeA % 3 * promotionalPriceForA);
            int totalPriceOfProductTypeB = (totalNumberOfProductsOfTypeB / 2) * 45 + (totalNumberOfProductsOfTypeB % 2 * promotionalPriceForB);
            int totalPriceOfProductTypeC = (totalNumberOfProductsOfTypeC * promotionalPriceForC);
            int totalPriceOfProductTypeD = (totalNumberOfProductsOfTypeD * promotionalPriceForD);
            return totalPriceOfProductTypeA + totalPriceOfProductTypeB + totalPriceOfProductTypeC + totalPriceOfProductTypeD;

        }
    }
    
}


using ManangerProducts.Entities;
using System.Globalization;

namespace ManangerProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<Product> List = new List<Product>();

            Console.Write("Enter number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"product #{i} data:");
                Console.Write("Common, used or ipoprted (C/U/I)");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'c')
                {
                    List.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    List.Add(new UsedProduct(date, name, price));
                }
                else
                {
                    Console.WriteLine("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    List.Add(new ImportedProduct(customsFee, name, price));
                }

                Console.WriteLine();
                Console.Write("Price tag: ");
                foreach (Product prod in List)
                {
                    Console.WriteLine(prod.PriceTag());
                }
            }
        }
    }
}
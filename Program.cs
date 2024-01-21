using System.Globalization;
using Imported_Products.Entities;

namespace Course
{
    class Program
    {
        static void Main (string [] args)
        {
            List<Product> list = new List<Product>();
            System.Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine ("Product #" + i + " data");
                Console.Write("Common, used or imported (c/u/i): ");
                char letter = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (letter == 'c')
                {
                    list.Add(new Product(name, price));
                } else if (letter == 'u')
                {
                    Console.Write ("Manufacture date (MM/DD/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }else
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, fee));
                }
            }
            foreach (Product prod in list)
            {
                System.Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
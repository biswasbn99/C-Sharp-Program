/*PID	PName	EntryDate	Price
217	   Banana	14.05.25	120
520	   Lemon	07.02.25	300
122	   Apple	03.04.25	610
307	   Orange	10.04.25	200
 Suppose,Add a new product with ProductID=6 and Price<200, Now Select Product 
	
Use LINQ to search the information where price is less than 300. Now write a c# program
 to solve and display it.
 */
 using System;
using System.Linq;

public class Product
{
    public int PID { get; set; }
    public string PName { get; set; }
    public string EntryDate { get; set; }
    public int Price { get; set; }
}

public class Myclass
{
    public static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { PID = 217, PName = "Banana", EntryDate = "14.05.25", Price = 120 },
            new Product { PID = 520, PName = "Lemon", EntryDate = "07.02.25", Price = 300 },
            new Product { PID = 122, PName = "Apple", EntryDate = "03.04.25", Price = 610 },
            new Product { PID = 307, PName = "Orange", EntryDate = "10.04.25", Price = 200 },
            new Product { PID = 6, PName = "Guava", EntryDate = "15.05.25", Price = 150 }
        };

        // LINQ query: Select products with price < 300
        var selectedProducts = from p in products
                               where p.Price < 300
                               select p;

        Console.WriteLine("Products with price less than 300:");
        foreach (var i in selectedProducts)
        {
            Console.WriteLine("PID:"+ i.PID+", PName: "+i.PName+", EntryDate: "+i.EntryDate+", Price: "+i.Price);
        }
    }
}

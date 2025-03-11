/*Create a class ShoppingCart that stores a list of products using an array of strings.
 Implement an indexer to access the products in the shopping cart by index. Write a program
  that adds products to the shopping cart, retrieves them using the indexer, and displays them.
   */
   using System;

namespace Test
{
    public class ShoppingCart
    {
        private string[] products = new string[5]; // Array to store products

        // Indexer to access products using an index
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < products.Length)
                {
                    return products[index]; // Return "Empty" if the slot is null
                }
                throw new IndexOutOfRangeException("Invalid index.");
            }
            set
            {
                if (index >= 0 && index < products.Length)
                {
                    products[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
            }
        }
    }

    public class MyClass
    {
        public static void Main()
        {
            ShoppingCart cart = new ShoppingCart();

            // Using indexer to set values
            cart[0] = "Laptop";
            cart[1] = "Phone";
            cart[2] = "Headphones";

            // Using indexer to get values
            Console.WriteLine("Product at index 0: " + cart[0]);
            Console.WriteLine("Product at index 1: " + cart[1]);
            Console.WriteLine("Product at index 2: " + cart[2]);
        }
    }
}

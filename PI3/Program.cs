/* How can we create a CarCollection class in C# that holds a fixed array of Car objects
 and allows accessing them using an indexer while ensuring proper exception handling?*/
 using System;

namespace Test
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }

        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }
    }

    public class CarCollection
    {
        private Car[] cars = new Car[5];

        // Indexer to access Car objects using an index
        public Car this[int index]
        {
            get
            {
                if (index >= 0 && index < cars.Length)
                {
                    return cars[index];
                }
                throw new IndexOutOfRangeException("Invalid index.");
            }
            set
            {
                if (index >= 0 && index < cars.Length)
                {
                    cars[index] = value;
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
            CarCollection c = new CarCollection();

            // Using indexer to set values
            c[0] = new Car("Corolla", "Toyota");
            c[1] = new Car("Civic", "Honda");

            // Using indexer to get values
            Console.WriteLine("Model: " + c[0].Model);
            Console.WriteLine("Brand: " + c[1].Brand);
        }
    }
}

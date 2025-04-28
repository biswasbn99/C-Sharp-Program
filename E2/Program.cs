/*Create a C# program that attempts to read from a file called data.txt. Handle
exceptions that might occur, such as the file not being found
(**FileNotFoundException**) or any other general exceptions. Display a
user-friendly message if the file is not found, and ensure the program continues
running gracefully. */

using System;
using System.IO;
namespace Test
{
    public class Myclass
    {
        public static void Main()
        {
            try
            {
                string filepath= "data.txt";
            string content=File.ReadAllText(filepath);
            Console.WriteLine("File Contents :"+content);

            }
            catch(FileNotFoundException)
            {
             Console.WriteLine("ERROR!! The File 'data.txt' was not found.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: "+ex.Message);
            }
            finally
            {
                Console.WriteLine("The program is completed.....");
            }
        }

    }
}
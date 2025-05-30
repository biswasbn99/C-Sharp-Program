/*Given an array named scores with the values {97, 95, 90, 70, 85, 60, 50, 98, 96},

a) Search and display all the scores which are greater than or equal to 90.
b) Search and display all the scores which are greater than or equal to 70,

First in ascending order,

Then in descending order.

Finally, display the output of each operation. */
using System;
using System.Linq;
namespace Test
{
    public class Myclass
    {
        public static void Main()
        {
            int[] scores = { 97, 95, 90, 70, 85, 60, 50, 98, 96 };

            // a) Scores >= 90
            Console.WriteLine("Scores >= 90:");
            var queryA = from score in scores
                         where score >= 90
                         select score;
            foreach (var i in queryA)
            {
                Console.WriteLine(i + " ");
            }

            // b) Scores >= 70 in ascending order
            Console.WriteLine("\nScores >= 70 in ascending order:");
            var queryBAsc = from score in scores
                            where score >= 70
                            orderby score ascending
                            select score;
            foreach (var i in queryBAsc)
            {
                Console.WriteLine(i + " ");
            }

            // b) Scores >= 70 in descending order
            Console.WriteLine("\nScores >= 70 in descending order:");
            var queryBDesc = from score in scores
                             where score >= 70
                             orderby score descending
                             select score;
            foreach (var i in queryBDesc)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}

/* Jagged arrays :-
1 2
3 4 5
6 7
8 9 10 11
 */
using System;
namespace Test{
    class Myclass{
        public static void Main(){
            int[][] jaggedArray=new int[][]
            {
            new int[]{1, 2},
            new int[]{3, 4, 5},
            new int[]{6, 7},
            new int[]{8, 9, 10, 11}  
            };
            Console.WriteLine("The Array: ");
            for(int row=0;row<jaggedArray.Length;row++){
                for(int col=0;col<jaggedArray[row].Length;col++){
                    Console.Write(jaggedArray[row][col]+ " ");
                }
                Console.WriteLine();
            }

            //print using foreach loop
            Console.WriteLine("Using foreach loop,the array:");
            foreach(var row in jaggedArray){
               foreach(var item in row){
                  Console.Write(item+" ");
               }
               Console.WriteLine();
            }
        }
    }
}
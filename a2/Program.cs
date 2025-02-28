/*Array---> Take input from user and print them */
using System;
namespace Test{
    class ABC{
        public static void Main(){
            Console.Write("Enter the number of the elements of the array: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] numbers=new int[n];
            Console.WriteLine("Enter the elements of the array: ");
            for(int i=0;i<numbers.Length;i++){
                Console.Write("Element -"+ (i+1)+ " :");
                numbers[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The arrays are:");
            Console.WriteLine(String.Join(" ",numbers));

            //print using foreach loop:
            Console.WriteLine("The arrays are:");
            foreach(int number in numbers){

             Console.WriteLine("Element-" + Array.IndexOf(numbers,number) + " :" +number);
            }
        }
    }
}
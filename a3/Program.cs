/*Sum of array elements */

using System;

namespace Test{
    class SumArray{
        public static void Main(){
       
       Console.WriteLine("Enter the number of the elements of the array: ");
       int n= Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter the elements of the array: ");
       int[] numbers=new int[n];
       for(int i=0; i<numbers.Length;i++){
        Console.Write("Element-"+(i+1)+ " :");
        numbers[i]=Convert.ToInt32(Console.ReadLine());
       }

       Console.WriteLine("Sum of the array element:"+numbers.Sum());
           //sum of array ,using foreach loop
           int sum=0;
           foreach(int number in numbers){
            sum+=number;
            
           }
           Console.Write("Using foreach loop,Sum of array :"+sum);
        }
    }
}
/*Take an array from user and search an element from the array */

using System;
namespace Test{
    class SearchElement{
        public static void Main(){
            Console.Write("Enter the number of the elements ?? \t");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] numbers=new int[n];

            Console.WriteLine("Enter the elements: ");
            for(int i=0;i<numbers.Length;i++){
                Console.Write("Element-"+(i+1)+" : ");
                numbers[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Array: ");
            foreach(int number in numbers){
                Console.Write(number+ "  ");

            }
            Console.Write("\nEnter an element for search : ");
            int m=Convert.ToInt32(Console.ReadLine());

                bool found = false;
            for(int i=0;i<numbers.Length;i++){
                if(numbers[i]==m){
                    Console.WriteLine(m+" is found at index "+i);
                    found=true;
                    break;
                }
                
            }
            if(!found){
             Console.WriteLine(m+" is not found");
            }


        }
    }
}
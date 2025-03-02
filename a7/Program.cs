/* Get input all elements of the array from user and  print the array elements, 
Reverse the elements ,sort the elements,Copy all elements ,  Copies a range of elements
 from one array to another, remove duplicate elements, sum all elements, find max and min 
 within the elements,  */
using System;

namespace Test{
    class ArrayElement{
        public static void Main(){

            Console.Write("Enter the number of element of the array: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array: ");
            int[] numbers=new int[n];

              //Input the array
            for(int i=0;i<numbers.Length;i++){       
                Console.Write("Element-"+(i+1)+" :");
                
              numbers[i]= Convert.ToInt32(Console.ReadLine());
                
            }
            //print the array
            Console.WriteLine("The array:");  
            foreach(int number in numbers){   
                Console.Write(number +" ");
            }
           
           

           //Reverse the elements
           Array.Reverse(numbers);
           Console.WriteLine("\nReverse Array: ");
           foreach(int number in numbers){
            Console.Write(number +" " );
           }

           //Sorts the elements
           Array.Sort(numbers);
           Console.WriteLine("\nSorted Array :");
           foreach(int number in numbers){
            Console.Write(number+" ");
           }
         
         //copy all elements
          int[] copy=new int[numbers.Length];
          Array.Copy(numbers,copy,numbers.Length);
          Console.WriteLine("\n Copied all elements of the array: ");
          foreach(int number in copy){
            Console.Write(number +" ");
          }
          // Copy a range of elements from one array to another
            int[] rangeCopy = new int[4]; // Change the size as needed
            Array.Copy(numbers, 1, rangeCopy, 0, rangeCopy.Length); // Copying elements from index 1 to 3
            Console.WriteLine("\nCopied range of elements from the array: ");
            foreach (int number in rangeCopy)
            {
                Console.Write(number + " ");
            }

          //Remove duplicate elements
          numbers=numbers.Distinct().ToArray();
          Console.WriteLine("\n Array after removing duplicates : ");
          foreach(int number in numbers){
            Console.Write(number + " ");
          }
          
            //sum all elements
           int sum=numbers.Sum();
           Console.WriteLine("\nSum of all elements = "+ sum);

         //Find max and min elements
         int max=numbers.Max();
         int min=numbers.Min();

         Console.WriteLine("\n Maximum Elements: "+ max);
         Console.WriteLine("\n Minimun Elements: "+ min);

        }
    }
}
/* The number is a prime number or not  */
using System;
namespace Test{
    class Prime{
        public static void Main(){
            Console.WriteLine("Enter a number:");
            int n= Convert.ToInt32(Console.ReadLine());
            int f=0;
            for(int d=2 ;d<=(n/2); d++)
            {
                if(n%d==0){
                    f++;
                    break;
                }
            }
            if(f==0){
                Console.WriteLine(n+" is a prime number");
            }
            else{
                Console.WriteLine(n+" is not a prime number");
            }
        }
    }
}
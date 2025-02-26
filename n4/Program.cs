/*The number is Palindrome number or not */
using System;
namespace Test{
    class Palindrome{
        public static void Main(){
            Console.Write("Enter a number : ");
            int num=Convert.ToInt32(Console.ReadLine());
            int i =num;
            int rev= 0;
            while(i !=0){
                int R=(i%10);
                rev=(rev*10)+R;
                i/=10;
            }
            if(rev==num){
                Console.WriteLine(num + " is a Palindrome Number");

            }
            else{
                Console.WriteLine(num + " is not a palindrome number");
            }


        }
    }
}
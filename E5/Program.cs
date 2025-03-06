/*Define an enumeration AccessRights with the Flags attribute that represents different levels
 of user permissions (Read = 1, Write = 2, Execute = 4).Then write a C# program that allows the
 user to input a combination of permissions and displays the selected rights.*/
 using System;
 namespace Test{
    public class FlagAttribute{
        public enum AccessRights{
            Read=1,
            Write=2,
            Execute=4
        }
        //for different levels user permissions (Read = 1, Write = 2, Execute = 4)
        public void UserPermission(int d){
          switch(d){
            case 1:
            Console.WriteLine("This Flags Attribute represents \"Read Operation\" ");
            break;
            
            case 2:
            Console.WriteLine("This Flags Attribute represents \"Write Operation\" ");
            break;

            case 3:
            Console.WriteLine("This is an Invalid Number!! Please ,press 1,2 or 4");
            break;

            case 4:
            Console.WriteLine("This Flags Attribute represents \"Execution\" ");
            break;

          }


        }
        //To display all messages that is represented by Flags Attributes
        public void DisplayAllPermissions() {
            Console.WriteLine("This Flags Attribute represents \"Read Operation\" ");
            Console.WriteLine("This Flags Attribute represents \"Write Operation\" ");
            Console.WriteLine("This Flags Attribute represents \"Execute Operation\" ");
        }
        //display Flags Attributes
        public void DisplaysAll(){
            foreach(AccessRights flag in Enum.GetValues(typeof(AccessRights))){
                Console.WriteLine(flag);
            }
        }
    }

    public class Myclass{
        public static void Main(){
            FlagAttribute c=new FlagAttribute();
            Console.WriteLine("Enter 1,2 or 4 :");
            int d=Convert.ToInt32(Console.ReadLine());
            c.UserPermission(d);

           Console.WriteLine("\n To display all of the message for flag attribute, press \"Enter key\"");
           Console.ReadKey();
           c.DisplayAllPermissions();

            Console.WriteLine("\n To display all of the permission press \"Enter key\"");
            Console.ReadKey();
            c.DisplaysAll();
        }
    }
 }




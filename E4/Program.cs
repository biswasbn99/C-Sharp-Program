/* Define an enumeration AccessRights with the Flags attribute that represents different levels
 of user permissions (Read = 1, Write = 2, Execute = 4). Then write a C# program that displays
  all user permissions. */
  using System;

  namespace Test{
    public class FlagAttribute{
       public enum AccessRights{
        Read=1,
        Write=2,
        Execute=3
       }
    
    public void PermissionClass(AccessRights d){
        switch(d){
            case AccessRights.Read:
            Console.WriteLine("This Flag Attribute represents \"Read Operation\" ");
            break;
            case AccessRights.Write:
            Console.WriteLine("This Flag Attribute represents \"Write Operation\"  ");
            break;
            case AccessRights.Execute:
            Console.WriteLine("This Flag Attribute represents the \"Execution\" ");
            break;
        }
    }
    }
    class Myclass{
        static void Main(){
            FlagAttribute c=new FlagAttribute();
            c.PermissionClass(FlagAttribute.AccessRights.Read);
            c.PermissionClass(FlagAttribute.AccessRights.Write);
            c.PermissionClass(FlagAttribute.AccessRights.Execute);
        }
    }


  }
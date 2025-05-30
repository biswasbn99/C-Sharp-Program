/*| PatientNo | LastName | FirstName | DateOfBirth | WardNo |
| --------- | -------- | --------- | ----------- | ------ |
| 223       | Smith    | John      | 14.05.2000  | 6      |
| 107       | Jones    | Petter    | 07.03.1998  | 3      |
| 503       | Brown    | Alex      | 12.07.1997  | 2      |
| 197       | Jerkins  | Alan      | 10.05.2003  | 5      |
| 250       | Smith    | Petter    | 12.07.2005  | 6      |
 Use LINQ to search the information where Last Name is Smith and Who are also present in
  the ward no 6. Now write a C# program to solve and display it
  */

using System;
using System.Linq;


public class Patient
{
    public int PatientNo { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string DateOfBirth { get; set; }
    public int WardNo { get; set; }
}

public class Myclass
{
    public static void Main()
    {
        List<Patient> patients = new List<Patient>
        {
            new Patient { PatientNo = 223, LastName = "Smith", FirstName = "John", DateOfBirth = "14.05.2000", WardNo = 6 },
            new Patient { PatientNo = 107, LastName = "Jones", FirstName = "Petter", DateOfBirth = "07.03.1998", WardNo = 3 },
            new Patient { PatientNo = 503, LastName = "Brown", FirstName = "Alex", DateOfBirth = "12.07.1997", WardNo = 2 },
            new Patient { PatientNo = 197, LastName = "Jerkins", FirstName = "Alan", DateOfBirth = "10.05.2003", WardNo = 5 },
            new Patient { PatientNo = 250, LastName = "Smith", FirstName = "Petter", DateOfBirth = "12.07.2005", WardNo = 6 }
        };

        var result = from p in patients
                     where p.LastName == "Smith" && p.WardNo == 6
                     select p;

        Console.WriteLine("Patients with Last Name 'Smith' in Ward 6:");
        foreach (var patient in result)
        {
            Console.WriteLine("PatientNo: " + patient.PatientNo + ", Name: " + patient.FirstName + " " + patient.LastName + ", DOB: " + patient.DateOfBirth + ", Ward: " + patient.WardNo);
        }
    }
}

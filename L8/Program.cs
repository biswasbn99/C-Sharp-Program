/*Given the following C# code that defines two classes (Patient and Ward) and performs two
 LINQ queries, analyze the output.

The code defines the following patient data:
PatientNo	LastName	FirstName	Sex	     DateOfBirth	WardNo
223	         Smith	      John	     M	     14.05.2000	      6
107	         Jones	     Petter	     M	     07.03.1998	      3
503	         Brown	     Brends	     F	     12.07.1997	      2
197	         Jerkins	  Alan	     M	     10.05.2003	      5
250	         Smith	     Petter	     M	     12.07.2005	      6

And the following ward data:
WardNo	WardName	Type	 NoOfBed
3	    Cary	   Medical	   8
6	    Bracken    Medical	   16
7	    Brent	   Surgical	   12
8	    Maevy	   Surgical	   10

The program performs two queries:
Selects and displays all male patients.

Selects and displays all wards with more than 10 beds. */

using System;
using System.Collections.Generic;
using System.Linq;

class Patient
{
    public int PatientNo { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Sex { get; set; }
    public string DateOfBirth { get; set; }
    public int WardNo { get; set; }
}

class Ward
{
    public int WardNo { get; set; }
    public string WardName { get; set; }
    public string Type { get; set; }
    public int NoOfBed { get; set; }
}

class Program
{
    static void Main()
    {
        // Patient data
        List<Patient> patients = new List<Patient>
        {
            new Patient { PatientNo = 223, LastName = "Smith", FirstName = "John", Sex = "M", DateOfBirth = "14.05.2000", WardNo = 6 },
            new Patient { PatientNo = 107, LastName = "Jones", FirstName = "Petter", Sex = "M", DateOfBirth = "07.03.1998", WardNo = 3 },
            new Patient { PatientNo = 503, LastName = "Brown", FirstName = "Brends", Sex = "F", DateOfBirth = "12.07.1997", WardNo = 2 },
            new Patient { PatientNo = 197, LastName = "Jerkins", FirstName = "Alan", Sex = "M", DateOfBirth = "10.05.2003", WardNo = 5 },
            new Patient { PatientNo = 250, LastName = "Smith", FirstName = "Petter", Sex = "M", DateOfBirth = "12.07.2005", WardNo = 6 }
        };

        // Ward data
        List<Ward> wards = new List<Ward>
        {
            new Ward { WardNo = 3, WardName = "Cary", Type = "Medical", NoOfBed = 8 },
            new Ward { WardNo = 6, WardName = "Bracken", Type = "Medical", NoOfBed = 16 },
            new Ward { WardNo = 7, WardName = "Brent", Type = "Surgical", NoOfBed = 12 },
            new Ward { WardNo = 8, WardName = "Maevy", Type = "Surgical", NoOfBed = 10 }
        };

        // Query 1: Male patients
        var malePatients = from p in patients
                           where p.Sex == "M"
                           select p;

        Console.WriteLine("Male Patients:");
        foreach (var p in malePatients)
        {
            Console.WriteLine("Patient No: "+p.PatientNo+", Name: "+p.FirstName+" "+p.LastName +", DOB: "+p.DateOfBirth+", Ward No:" +p.WardNo);
        }

        // Query 2: Wards with more than 10 beds
        var largeWards = from w in wards
                         where w.NoOfBed > 10
                         select w;

        Console.WriteLine("\nWards with more than 10 beds:");
        foreach (var w in largeWards)
        {
            Console.WriteLine("Ward No: "+w.WardNo+", Name: "+w.WardName+", Type: "+w.Type+", Beds: "+w.NoOfBed);
        }
    }
}

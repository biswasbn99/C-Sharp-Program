/* You are developing a file management system that supports reading from and writing to
different file formats, such as CSV, JSON, and XML. The requirements specify that:Every file
format should have methods to readFile() and writeFile().For XML files specifically, you need to
implement a method validateSchema() to ensure the data conforms to a predefined schema.Future
file formats might require additional specific functionality. Write a program to design this system
using appropriate use of abstract classes, interfaces, or a combination of both. Implement
readFile() and writeFile() for at least one file format (e.g., CSV). */


using System;

namespace Test
{
    public interface IFileFormat
    {
        public void ReadFile();
        public void WriteFile();
    }

    public interface IXMLValidator
    {
        public void ValidateSchema();
    }

    public abstract class FileFormat : IFileFormat
    {
        public string FilePath { get; set; }
        public string Content { get; set; }

        public FileFormat(string filePath, string content)
        {
            FilePath = filePath;
            Content = content;
        }

        public abstract void ReadFile();
        public abstract void WriteFile();
    }

    public class CSVFile : FileFormat
    {
        public CSVFile(string filePath, string content) : base(filePath, content) { }

        public override void ReadFile()
        {
            Console.WriteLine("Reading CSV File : " + FilePath);
        }

        public override void WriteFile()
        {
            Console.WriteLine("Writing to CSV File : " + FilePath);
        }
    }

    public class JSONFile : FileFormat
    {
        public JSONFile(string filePath, string content) : base(filePath, content) { }

        public override void ReadFile()
        {
            Console.WriteLine("Reading JSON File : " + FilePath);
        }

        public override void WriteFile()
        {
            Console.WriteLine("Writing to JSON File : " + FilePath);
        }
    }

    public class XMLFile : FileFormat, IXMLValidator
    {
        public XMLFile(string filePath, string content) : base(filePath, content) { }

        public override void ReadFile()
        {
            Console.WriteLine("Reading XML File : " + FilePath);
        }

        public override void WriteFile()
        {
            Console.WriteLine("Writing to XML File : " + FilePath);
        }

        public void ValidateSchema()
        {
            Console.WriteLine("Validating XML SCHEMA For File : " + FilePath);
        }
    }

    public class MyClass
    {
        public static void Main()
        {
            CSVFile csvFile = new CSVFile("data.csv", "name,age \n kamal ,30");
            csvFile.ReadFile();
            csvFile.WriteFile();

            Console.WriteLine("\n \n \n");

            JSONFile jsonFile = new JSONFile("data.json", "{\"name\":\"jamal\",\"age\": 20}");
            jsonFile.ReadFile();
            jsonFile.WriteFile();

            Console.WriteLine("\n \n \n");

            XMLFile xmlFile = new XMLFile("data.xml", "<user><name>John</name></user>");
            xmlFile.ReadFile();
            xmlFile.WriteFile();
            xmlFile.ValidateSchema();
        }
    }
}

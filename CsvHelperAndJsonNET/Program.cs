using System;

namespace CsvHelperAndJsonNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CSVHelper & JSON.NET Library.");
            Console.WriteLine("\n1. Read from CSV and Copy to CSV\n2. Read from CSV and Copy to JSON.\n3. Read from JSON and Copy to CSV.\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CSVtoCSVOperation.ImplimentCSVHandling();
                    break;
                case 2:
                    CSVToJSONOperation.CSVToJSONFn();
                    break;
                case 3:
                    JSONToCSVOperation.JSONToCSVOperationFn();
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
            Console.ReadLine();
        }
    }
}

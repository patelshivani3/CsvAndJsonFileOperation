using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelperAndJsonNET
{
    public class CSVToJSONOperation
    {
        public static void CSVToJSONFn()
        {
            string importFilePath = @"C:\Users\shivp\source\repos\CsvAndJsonFileOperation\CsvHelperAndJsonNET\Files\Address.csv";
            string exportFilePath = @"C:\Users\shivp\source\repos\CsvAndJsonFileOperation\CsvHelperAndJsonNET\Files\ExportToJSON.json";
            //Reading CSV File
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("\nSuccessfully Read from Address.csv");
                foreach (Contact data in records)
                {
                    Console.WriteLine(data.FirstName + " " + data.LastName + " " + data.City + " " + data.State);
                }
                //Write Data to JSON File
                string jsonData = JsonConvert.SerializeObject(records);
                File.WriteAllText(exportFilePath, jsonData);
                Console.WriteLine("\nData Copied from CSV To JSON");
            }
            
        } 
    }
}

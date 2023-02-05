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
    public class JSONToCSVOperation
    {
        public static void JSONToCSVOperationFn()
        {
            string importFilePath = @"C:\Users\shivp\source\repos\CsvAndJsonFileOperation\CsvHelperAndJsonNET\Files\Address.json";
            string exportFilePath = @"C:\Users\shivp\source\repos\CsvAndJsonFileOperation\CsvHelperAndJsonNET\Files\jsontocsvexport.csv";

            //reading data from csv and storing in contactData
            IList<Contact> contactData = JsonConvert.DeserializeObject<IList<Contact>>( File.ReadAllText(importFilePath));
            Console.WriteLine("Reading from JSON Succesfully done");
            //Writing from json to csv
            using (var writer = new StreamWriter(exportFilePath))
            using(var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(contactData);
            }
            Console.WriteLine("Data Successfully copied from json to csv");

        }
    }
}

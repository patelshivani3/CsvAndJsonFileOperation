using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelperAndJsonNET
{
    internal class CSVtoCSVOperation
    {
        public static void ImplimentCSVHandling()
        {
            string importFilePath = @"C:\Users\shivp\source\repos\CsvAndJsonFileOperation\CsvHelperAndJsonNET\Files\Address.csv";
            string exportFilePath = @"C:\Users\shivp\source\repos\CsvAndJsonFileOperation\CsvHelperAndJsonNET\Files\Export.csv";
            //Reading CSV File
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Successfully Read from Address.csv");
                foreach(Contact data in records)
                {
                    Console.WriteLine(data.FirstName + " " + data.LastName+" "+data.City+" "+data.State);
                }
                //Copy data from Address.csv to Export.csv
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }        
        }
    }
}

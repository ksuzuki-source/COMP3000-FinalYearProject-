using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace Human_Resource_Management
{
    class ReadFile
    {
        static void ReadCsvFile(string filename)
        {
            TextReader textReader = File.OpenText(filename);
            var csv = new CsvReader(textReader);

            var people = csv.GetRecords<Person>();

            foreach (var person in people)
            {
                Console.WriteLine($"Name {person.Name} age : {person.Age}");
            }
            textReader.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace Human_Resource_Management
{
    class WriteFile
    {
        static void WriteCsvFile(string filename, IEnumerable<Person> people)
        {
            TextWriter textWriter = File.CreateText(filename);

            var csvWriter = new CsvWriter(textWriter);
            csvWriter.WriteRecords(people);

            textWriter.Close();

        }

    }
}

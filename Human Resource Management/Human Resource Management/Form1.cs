using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration.Attributes;


namespace Human_Resource_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var filename = Directory.GetCurrentDirectory() + @"\file.csv";
            List<Person> list = new List<Person>() {
                new  Person(){Name= "Ronaldo", Age= 29},
                new  Person(){Name= "Missi", Age= 28}
        };

            WriteFile(filename, list);

            ReadFile(filename);
            Console.ReadLine();


        }

        static void ReadFile(string filename)
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


        static void WriteFile(string filename, IEnumerable<Person> people)
        {
                TextWriter textWriter = File.CreateText(filename);

                var csvWriter = new CsvWriter(textWriter);
                csvWriter.WriteRecords(people);

                textWriter.Close();

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using CsvHelper;

namespace Human_Resource_Management
{
    class Readcsv
    {

        public static DataTable read_csv(string path, bool header = true, char separator = ',')
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
      
                csv.Configuration.HasHeaderRecord = true;
                var people = csv.GetRecords<Person>();

                DataTable dt = new DataTable();
                dt.Columns.Clear();
                dt.Columns.Add("Name");
                dt.Columns.Add("Sex");
                dt.Columns.Add("Role");
                dt.Columns.Add("Password");
                dt.Columns.Add("Postcode");
                dt.Columns.Add("Age");

                foreach (var person in people)
                {
                    
                    dt.Rows.Add(person.Name, person.Sex, person.Role, person.Password, person.Postcode, person.Age);
                }

                return dt;

            }


        }

        
    }
}

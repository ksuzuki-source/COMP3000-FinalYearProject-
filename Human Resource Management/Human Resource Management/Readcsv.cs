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

        public static DataTable Read_csv(string path, bool header = true, char separator = ',')         //read function for lavour`s data
        {
            using (var reader = new StreamReader(path))                     //make instance for SR
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))    //give the arg to csvhelper
            {
      
                csv.Configuration.HasHeaderRecord = true;       //the file has header
                var people = csv.GetRecords<Person>();          

                DataTable dt = new DataTable();                 //make the table
                dt.Columns.Clear();
                dt.Columns.Add("Name");
                dt.Columns.Add("Sex");
                dt.Columns.Add("Role");
                dt.Columns.Add("Password");
                dt.Columns.Add("Postcode");
                dt.Columns.Add("Age");
                    
                foreach (var person in people)                  //flow the data into table
                {
                    
                    dt.Rows.Add(person.Name, person.Sex, person.Role, person.Password, person.Postcode, person.Age);
                }

                return dt;

            }


        }

        public static DataTable Read_PersonCsv(string path, bool header = true, char separator = ',')       //this is a read function for working time
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {

                csv.Configuration.HasHeaderRecord = true;
                var workTime = csv.GetRecords<WorkingTime>();

                DataTable dt = new DataTable();
                dt.Columns.Clear();
                dt.Columns.Add("WorkingIn");
                dt.Columns.Add("LeaveWork");
                dt.Columns.Add("WorkingDuration");
                foreach (var work in workTime)      //flow the data into table
                {

                    dt.Rows.Add(work.WorkingIn, work.LeaveWork, work.WorkingDuration);
                }

                return dt;

            }


        }


    }
}

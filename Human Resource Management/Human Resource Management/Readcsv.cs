using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Human_Resource_Management
{
    class Readcsv
    {

        public static DataTable read_csv(string path, bool header = true, char separator = ',')
        {

            using (TextFieldParser tfp =
                           new TextFieldParser(path))
            {

                tfp.TextFieldType = FieldType.Delimited;


                tfp.Delimiters = new string[] { "," };


                tfp.HasFieldsEnclosedInQuotes = true;

                tfp.TrimWhiteSpace = true;

                string[] headers = tfp.ReadFields();
                int fieldCount = headers.Length;

                DataTable dt = new DataTable();
                DataRow dr;
                DataColumn dc;

                dt.Columns.Clear();

                for (int i = 0; i < fieldCount; i++)
                {
                    dc = new DataColumn(headers[i], typeof(String));
                    dt.Columns.Add(dc);
                }

                while (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    dr = dt.NewRow();
                    for (int i = 0; i < fieldCount; i++)
                    {
                        dr[headers[i]] = fields[i];
                    }
                    dt.Rows.Add(dr);
                }
                return dt;

            }


        }

        
    }
}

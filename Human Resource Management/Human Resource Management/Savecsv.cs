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
    class Savecsv
    {
        public void SaveDataTableAsCsv(DataTable dt, string path, bool isHeaderRequired = true)
        {
            if (dt != null)
            {
                int colCount = dt.Columns.Count;
                int lastColIndex = colCount - 1;

                using (var sr = new StreamWriter(path))
                {

                    if (isHeaderRequired)
                    {
                        for (int i = 0; i < colCount; i++)
                        {
                            string header = dt.Columns[i].Caption;

                            sr.Write(header);
                            if (lastColIndex > i)
                            {
                                sr.Write(',');
                            }
                        }
                        sr.Write("\r\n");
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Unchanged ||
                            row.RowState == DataRowState.Added ||
                            row.RowState == DataRowState.Modified)
                        {

                            for (int i = 0; i < colCount; i++)
                            {
                                string field =
                                    row[i, DataRowVersion.Current].ToString();



                                sr.Write(field);
                                if (lastColIndex > i)
                                {
                                    sr.Write(',');
                                }

                            }
                            sr.Write("\r\n");
                        }
                    }
                }
            }
        }

    }
}

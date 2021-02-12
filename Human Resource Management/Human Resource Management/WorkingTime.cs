using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration.Attributes;

namespace Human_Resource_Management
{
    class WorkingTime
    {
        [Index(0)]
        public string Name { get; set; }

        [Index(1)]
        public DateTime WorkingIn { get; set; }

        [Index(2)]
        public DateTime WorkingOut { get; set; }

        [Index(3)]
        public DateTime WorkingDuration { get; set; }
    }
}

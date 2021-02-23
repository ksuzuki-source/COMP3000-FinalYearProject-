using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration.Attributes;

namespace Human_Resource_Management
{
    class WorkingTime
    {
        [Index(0)]
        public String WorkingIn { get; set; }

        [Index(1)]
        public String LeaveWork { get; set; }

        [Index(2)]
        public String WorkingDuration { get; set; }
    }
}

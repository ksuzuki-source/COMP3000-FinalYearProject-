using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration.Attributes;
namespace Human_Resource_Management
{
    class Person
    {
        [Index(0)]
        public string Name { get; set; }

        [Index(1)]
        public string Sex { get; set; }

        [Index(2)]
        public string Role { get; set; }

        [Index(3)]
        public string Password { get; set; }
        

        [Index(4)]
        public string Postcode { get; set; }

        [Index(5)]
        public string Age { get; set; }
    }
}

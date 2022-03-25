using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoolApplicationCore.Domain.Domains
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Class { get; set; }

        public int Age 
        {
            get 
            { 
                var timeSpan = DateTime.Today - BirthDate;
                var year = timeSpan.Days / 365;
                return year;
            } 
        }
    }
}

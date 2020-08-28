using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp
{
    public class PersonModel
    {
        public string name { get; set; }
        public int totalHours { get; set; }

        public List<string> tags = new List<string>();

    }
}

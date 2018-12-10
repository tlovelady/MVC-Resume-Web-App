using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Certification
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public int ContactID { get; set; }

        public Contact Contact { get; set; }
        public Category Category { get; set; }
    }
}

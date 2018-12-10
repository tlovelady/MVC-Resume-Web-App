using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Responsibility
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int ExperienceID { get; set; }

        public Experience Experience { get; set; }
    }
}

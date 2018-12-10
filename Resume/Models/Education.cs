using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Education
    {
        public int ID { get; set; }
        public string InstitutionName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? GraduationYear { get; set; }
        public float GPA { get; set; }

        public int ContactID { get; set; }

        public Contact Contact { get; set; }
    }
}

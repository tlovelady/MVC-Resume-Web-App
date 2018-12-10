using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models.ResumeViewModel
{
    public class ResumeViewModel
    {
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Certification> Certifications { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Responsibility> Responsibilities { get; set; }
    }
}

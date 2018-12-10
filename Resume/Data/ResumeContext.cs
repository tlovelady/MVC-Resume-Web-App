using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Models;

namespace Resume.Data
{
    public class ResumeContext : DbContext
    {
        public ResumeContext (DbContextOptions<ResumeContext> options)
            : base(options)
        {
        }
        public DbSet<Resume.Models.Contact> Contact { get; set; }
        public DbSet<Resume.Models.Skill> Skill { get; set; }
        public DbSet<Resume.Models.Category> Category { get; set; }
        public DbSet<Resume.Models.Certification> Certification { get; set; }
        public DbSet<Resume.Models.Experience> Experience { get; set; }
        public DbSet<Resume.Models.Responsibility> Responsibility { get; set; }
        public DbSet<Resume.Models.Education> Education { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Resume.Models;

namespace Resume.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ResumeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Contact.Any())
            {
                return;
            }

            var contactInfo = new Contact()
            {
                FirstName = "Tate",
                LastName = "Lovelady",
                PhoneNumber = "(505) 414-9590",
                EmailAddress = "Tatelovelady@Gmail.com"
            };
            context.Add(contactInfo);
            context.SaveChanges();

            var categories = new Category[]
            {
                new Category {Name = "Programming"},
                new Category {Name = "Design"}
            };

            foreach (var c in categories)
            {
                context.Add(c);
            }

            var skills = new Skill[]
            {
                new Skill {Name = "C#", CategoryID = categories.Single(y => y.Name == "Programming").ID, ContactID = contactInfo.ID}
            };

            foreach (var s in skills)
            {
                context.Add(s);
            }

            var certifications = new Certification[]
            {
                new Certification {Name = "Adobe Photoshop", CategoryID = categories.Single(y => y.Name == "Design").ID, ContactID =contactInfo.ID }
            };

            foreach (var crt in certifications)
            {
                context.Add(crt);
            }

            var experiences = new Experience[]
            {
                new Experience {Title = "Professional Bikini Inspector", Workplace = "NASA", StartDate = DateTime.Parse("2007-06-09"), EndDate = DateTime.Parse("2007-09-06"), ContactID =contactInfo.ID }
            };

            foreach (var exp in experiences)
            {
                context.Add(exp);
            }

            var responsibilities = new Responsibility[]
            {
                new Responsibility {Name = "Ensure integrity of space bikini fabric", ExperienceID = experiences.Single(i => i.Title == "Professional Bikini Inspector").ID}
            };

            foreach (var resp in responsibilities)
            {
                context.Add(resp);
            }

            var educations = new Education[]
            {
                new Education {InstitutionName = "TGF", GraduationYear = DateTime.Parse("2007-09-09"), GPA = 4.20f, ContactID =contactInfo.ID }
            };

            foreach (var edu in educations)
            {
                context.Add(edu);
            }

            context.SaveChanges();
        }
    }
}

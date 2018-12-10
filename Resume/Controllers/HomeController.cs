using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resume.Data;
using Resume.Models;
using Resume.Models.ResumeViewModel;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ResumeContext _context;

        public HomeController(ResumeContext context)
        {
            _context = context;
        }

        // GET: Contacts
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                id = 1;
            }

            var viewModel = new ResumeViewModel();
            viewModel.Contacts = _context.Contact.Where(i => i.ID == id);

            if (viewModel.Contacts == null)
            {
                return NotFound();
            }

            viewModel.Skills = await _context.Skill
                .Include(i => i.Category)
                .ToListAsync();
            viewModel.Certifications = await _context.Certification
                .Include(i => i.Category)
                .ToListAsync();
            viewModel.Categories = await _context.Category
                .ToListAsync();
            viewModel.Experiences = await _context.Experience
                .Include(i => i.Responsibilities)
                .ToListAsync();
            viewModel.Educations = await _context.Education
                .ToListAsync();

            return View(viewModel);
        }
        
        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.ID == id);
        }
    }
}

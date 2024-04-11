using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HR_Recruitment.Data;
using HR_Recruitment.Models;

namespace HR_Recruitment.Pages.JobPostings
{
    public class CreateModel : PageModel
    {
        private readonly HR_Recruitment.Data.HR_RecruitmentContext _context;

        public CreateModel(HR_Recruitment.Data.HR_RecruitmentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobPosting JobPosting { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JobPosting.Add(JobPosting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HR_Recruitment.Data;
using HR_Recruitment.Models;

namespace HR_Recruitment.Pages.JobApplications
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
        public JobApplication JobApplication { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JobApplication.Add(JobApplication);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

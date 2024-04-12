using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HR_Recruitment.Data;
using HR_Recruitment.Models;

namespace HR_Recruitment.Pages.JobApplications
{
    public class DeleteModel : PageModel
    {
        private readonly HR_Recruitment.Data.HR_RecruitmentContext _context;

        public DeleteModel(HR_Recruitment.Data.HR_RecruitmentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JobApplication JobApplication { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobapplication = await _context.JobApplication.FirstOrDefaultAsync(m => m.Id == id);

            if (jobapplication == null)
            {
                return NotFound();
            }
            else
            {
                JobApplication = jobapplication;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobapplication = await _context.JobApplication.FindAsync(id);
            if (jobapplication != null)
            {
                JobApplication = jobapplication;
                _context.JobApplication.Remove(JobApplication);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

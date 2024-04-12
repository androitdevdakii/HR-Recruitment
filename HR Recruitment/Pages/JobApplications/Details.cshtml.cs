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
    public class DetailsModel : PageModel
    {
        private readonly HR_Recruitment.Data.HR_RecruitmentContext _context;

        public DetailsModel(HR_Recruitment.Data.HR_RecruitmentContext context)
        {
            _context = context;
        }

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
    }
}

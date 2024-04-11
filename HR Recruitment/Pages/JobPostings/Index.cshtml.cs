using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HR_Recruitment.Data;
using HR_Recruitment.Models;

namespace HR_Recruitment.Pages.JobPostings
{
    public class IndexModel : PageModel
    {
        private readonly HR_Recruitment.Data.HR_RecruitmentContext _context;

        public IndexModel(HR_Recruitment.Data.HR_RecruitmentContext context)
        {
            _context = context;
        }

        public IList<JobPosting> JobPosting { get;set; } = default!;

        public async Task OnGetAsync()
        {
            JobPosting = await _context.JobPosting.ToListAsync();
        }
    }
}

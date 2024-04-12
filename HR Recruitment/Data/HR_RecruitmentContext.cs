using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HR_Recruitment.Models;

namespace HR_Recruitment.Data
{
    public class HR_RecruitmentContext : DbContext
    {
        public HR_RecruitmentContext (DbContextOptions<HR_RecruitmentContext> options)
            : base(options)
        {
        }

        public DbSet<HR_Recruitment.Models.JobPosting> JobPosting { get; set; } = default!;
        public DbSet<HR_Recruitment.Models.JobApplication> JobApplication { get; set; } = default!;
    }
}

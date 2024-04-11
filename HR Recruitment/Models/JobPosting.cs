namespace HR_Recruitment.Models
{
    public class JobPosting
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Overview { get; set; }

        public string? PayGrade { get; set; }

        public string? PrimaryTasks { get; set; }
        public string? SecondaryTasks { get; set; }


        public bool? IsHrApproved { get; set; }

        public bool? IsDirApproved { get; set; }

        public string? CreatedBy { get; set; }
    }
}

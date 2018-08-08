namespace HTI.Models
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string ProfName { get; set; }
        public int Units { get; set; }
        public string PlayListUrl { get; set; }
        public string PdfFileName { get; set; }
        public Specialist Specialist { get; set; }
        public bool IsFavoirate { get; set; }
        public string Image { get; set; }
    }
}

namespace HTI.Models
{
    public class Student : BaseItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Specialist StudentSpecialist { get; set; }
    }
}

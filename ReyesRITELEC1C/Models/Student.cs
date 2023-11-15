using System.ComponentModel.DataAnnotations;

namespace ReyesRITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {
       
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(255, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(255, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        public double GPA { get; set; }
        public Course Course { get; set; }
        public DateTime AdmissionDate { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}

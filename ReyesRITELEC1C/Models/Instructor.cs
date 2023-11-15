using System.ComponentModel.DataAnnotations;

namespace ReyesRITELEC1C.Models
{
    public enum Rank
    {
        instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(255, MinimumLength =1)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(255, MinimumLength =1)]
        public string LastName { get; set; }

        public bool isTenured { get; set; }
        public Rank Rank { get; set; }
        public DateTime HiringDate { get; set; }


    }
}

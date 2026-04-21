using System.ComponentModel.DataAnnotations;

namespace IT3047_Final_Project.Models
{
    public class Members
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the member's name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the member's major.")]
        public string Major { get; set; }

        [Required(ErrorMessage = "Please enter the member's bio.")]
        public string Bio { get; set; }

        [Required(ErrorMessage = "Please enter the member's age.")]
        [Range(1, 5, ErrorMessage = "Age must be between 1 and 50.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter the member's dream job.")]
        public string DreamJob { get; set; }

    }
}

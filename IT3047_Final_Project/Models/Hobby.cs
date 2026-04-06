using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace IT3047_Final_Project.Models
{
    public class Hobby
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a hobby name.")]
        public string HobbyName { get; set; }

        [Required(ErrorMessage = "Please enter a hobby description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a frequency for the hobby.")]
        [Range(1, 5, ErrorMessage = "Frequency must be between 1 and 5.")]
        public int Frequency { get; set; }

        [Required(ErrorMessage = "Please enter years invested")]
        [Range(1, 10, ErrorMessage = "Years invested must be between 0.5 and 10.")]
        public int YearsInvested { get; set; }
    }
}

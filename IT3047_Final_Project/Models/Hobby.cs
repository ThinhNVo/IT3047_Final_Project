using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT3047_Final_Project.Models
{
    public class Hobby
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please select a member.")]
        public int MemberId { get; set; }

        [ForeignKey("MemberId")]
        public Members? Member { get; set; }

        [Required(ErrorMessage = "Please enter a hobby name.")]
        public string? HobbyName { get; set; }

        [Required(ErrorMessage = "Please enter a hobby description.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please enter years invested.")]
        [Range(1, 20, ErrorMessage = "Years invested must be between 1 and 20.")]
        public int YearsInvested { get; set; }

        [Required(ErrorMessage = "Please enter how often they do this hobby.")]
        public string? HowOften { get; set; }
    }
}
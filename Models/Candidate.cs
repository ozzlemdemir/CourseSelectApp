using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
       [Required(ErrorMessage = "Age is required.")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "Surname is required.")]
        public String? Lastname { get; set; } = String.Empty;
        [Required(ErrorMessage = "Email is required.")]
        public String? Email { get; set; } = String.Empty;
        public String? SelectedCourse { get; set; } = String.Empty;

        public String? FullName => $"{FirstName} {Lastname?.ToUpper()}"; 
        public DateTime ApplyAt { get; set; }
        
        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
    
    
    
}
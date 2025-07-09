namespace BtkAkademi.Models
{
    public class Candidate
    {
       
        public int? Age { get; set; }
        public String? FirstName { get; set; } = String.Empty;
        public String? Lastname { get; set; } = String.Empty;
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
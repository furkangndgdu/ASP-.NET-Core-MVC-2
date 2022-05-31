using System.ComponentModel.DataAnnotations;

namespace BEU_ODEV_2.Models
{
    public class Contents
    {
        [Key]
        public string Id { get; set; }   
        [Required]  
        public string Name { get; set; }
        public string Summary { get; set; } 
        public string Detail { get; set; }  
        public bool IsActive { get; set; }  
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }   
    }
}

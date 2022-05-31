using System.ComponentModel.DataAnnotations;

namespace BEU_ODEV_2.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string Name { get; set; }    
        public string SurName { get; set; }   
        public string Email { get; set; }
        public string Password { get; set; } 
        public bool IsActive { get; set; }  
        public DateTime CreateDate { get; set; }    


    }
}

using System.ComponentModel.DataAnnotations;

namespace BEU_ODEV_2.Models
{
    public class Menus
    {
        [Key]
        public int Id { get; set; } 
        [Required]  
        public string Name { get; set; }
        public string Url { get; set; } 
    }
}

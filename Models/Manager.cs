using System.ComponentModel.DataAnnotations;

namespace Goals_Site.Models
{
    public class Manager
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Phone { get; set; }

        Manager()
        {
            
        }
    }
}

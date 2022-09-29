using System.ComponentModel.DataAnnotations;

namespace Goals_Site.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public ICollection<Quote> Quotes { get; set; }

    }
}

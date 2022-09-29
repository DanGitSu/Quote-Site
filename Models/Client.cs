using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Goals_Site.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Contact Name")]
        public string Contact_Name { get; set; }
        [DisplayName("Contact Phone")]
        public int Contact_Phone { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        public ICollection<Quote> Quotes { get; set; }
        public ICollection<Site> Sites { get; set; }
    }
}

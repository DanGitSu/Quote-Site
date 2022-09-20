using System.ComponentModel;

namespace Goals_Site.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; } = null!;
        [DisplayName("Contact Name")]
        public string Contact_Name { get; set; } = null!;
        [DisplayName("Contact Phone")]
        public int Contact_Phone { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; } = null!;
        [DisplayName("Reference")]
        public string Reference { get; set; } = null!;

        // Site Collection
        //public List<Site> Sites { get; set; } // not having a site in the form will prevent creation of a client
    }
}

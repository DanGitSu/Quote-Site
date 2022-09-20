namespace Goals_Site.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string Contact_Name { get; set; } = null!;
        public int Contact_Phone { get; set; }
        public string Email { get; set; } = null!;
        public string Reference { get; set; } = null!;

        Client()
        {

        }
    }
}

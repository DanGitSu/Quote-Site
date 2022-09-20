namespace Goals_Site.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Contact_Name { get; set; }
        public int Contact_Phone { get; set; }
        public string Email { get; set; }
        public string Reference { get; set; }

        // Sites that Client Has
        public List<Site> Sites { get; set; }
        Client()
        {

        }
    }
}

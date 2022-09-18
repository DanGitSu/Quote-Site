using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Goals_Site.Models
{
    public class Site
    {
        public int ID { get; set; }
        public string? Address { get; set; }
        public string? Contact_Name { get; set; }
        public int Contact_Phone { get; set; }
        public Boolean Stairs { get; set; }
        public Boolean Lift { get; set; }
        public Boolean Loading_Dock { get; set; }

        Site() 
        {
        
        }

    }
}

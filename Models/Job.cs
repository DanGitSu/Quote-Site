namespace Goals_Site.Models
{
    public class Job
    {
        public int Job_ID { get; set; } // hidden ID
        public int Job_Number { get; set; } // User Inputtable
        public int Issue { get; set; }
        public string? Project_Manager { get; set; }
        public string? Sales_Manager { get; set; }
        public string? Client_Reference { get; set; }
        public string? Client_Contact { get; set; }
        public string? Account_Info { get; set; }
        public string? Compliance { get; set; }
        public string? Client { get; set; }
        public string? Client_Email { get; set; }
        public DateOnly Date { get; set; } = new DateOnly();
        public TimeOnly Start { get; set; } = new TimeOnly();
        public string? Site_Contact_From { get; set; }
        public int Site_Phone_From { get; set; }
        public string? Address_From { get; set; }
        public string? Site_Contact_To { get; set; }
        public int? Site_Phone2_To { get; set; }
        public string? Address_To { get; set; }



    }
}

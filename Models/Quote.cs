using DocumentFormat.OpenXml.ExtendedProperties;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Goals_Site.Models
{
    public class Quote
    {
        [Key]
        public int QuoteId { get; set; }
        [DisplayName("Job Number")]
        public string JobNumber { get; set; }
        public Client Client { get; set; }
        public Manager Manager { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}

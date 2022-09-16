using System.Threading.Tasks.Dataflow;

namespace Goals_Site.Models
{
    public class Job
    {
        public int JobID { get; set; }
        public string? JobName { get; set; }
        public string? Manager { get; set; }
        public string? Client { get; set; }

        public Job()
        {

        }
    }
    
}

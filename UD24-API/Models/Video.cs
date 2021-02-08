using System.Collections.Generic;

namespace UD24_API.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Cli_id { get; set; }

        public IEnumerable<Video> Videos { get; set; }

    }
}

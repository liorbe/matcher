using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnersMatcher
{
    [Serializable]
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public List<string> postAreas { get; set; }
        public string publisherEmail { get; set; }
        public string city { get; set; }
        public Post(int id, string title, string content, List<string> areas, string publisher,string city)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            postAreas = areas;
            publisherEmail = publisher;
            this.city = city;
        }
        public Post(Post p)
        {

        }
    }
}

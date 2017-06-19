using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreAngular.ViewModels
{
    public class Blog_Posts
    {
        public int BlogId { get; set; }
        public string BlogUrl { get; set; }
        public string BlogName { get; set; }
        public string postName { get; set; }
        public string postContent { get; set; }
    }
}

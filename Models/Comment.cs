using AIR_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIR_Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string AuthorId { get; set; }
        public string Body { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public string UpdateReason { get; set; }

        public virtual ApplicationUser Author { get; set; }
        public virtual Blog Blog { get; set; }

    }
}
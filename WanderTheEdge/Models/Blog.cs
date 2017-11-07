using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WanderTheEdge.Models
{
    [Table("Blogs")]
    public class Blog
    {
        public Blog()
        {
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public DateTime CreateDate { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public Blog(string title, string content, int locationId)
        {
            this.BlogTitle = title;
            this.BlogContent = content;
            this.CreateDate = DateTime.Now;
            this.LocationId = locationId;
        }

    }
}

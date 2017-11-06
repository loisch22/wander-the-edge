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
	[Table("Comments")]
	public class Comment
	{

		[Key]
        public int CommentId { get; set; }
        public string CommentAuthor { get; set; }
        public string CommentBody { get; set; }
        public DateTime CommentDate { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

	}
}

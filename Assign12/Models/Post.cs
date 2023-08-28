﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assign12.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Author { get; set; }

        // Navigation property to represent comments related to this post
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace BeautifulUI
{
    public class Blog : Entity
    {
        public string Title { get; set; }
        public ICollection<Post> Posts { get; set; }
        public DateTime CreationDate { get; set; }
    }

    public class Entity
    {
        public int Id { get; set; }
    }

    public class Post : Entity
    {
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
    }
}
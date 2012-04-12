using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class Blog
    {
        public int Id { get; set; }
        public DateTime Creationdate { get; set; }
        public string ShortDescription { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }
    }
}

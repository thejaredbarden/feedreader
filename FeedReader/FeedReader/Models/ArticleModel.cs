using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedReader.Models
{
    public class ArticleModel
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }
    }
}
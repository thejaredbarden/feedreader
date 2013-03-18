using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedReader.Models
{
    public class FeedModel
    {
        public string FeedName { get; set; }

        public string FeedUrl { get; set; }

        public int UnreadCount { get; set; }

        public DateTime LastChecked { get; set; }
    }
}
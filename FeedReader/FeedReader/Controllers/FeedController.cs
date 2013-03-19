using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel.Syndication;
using System.Xml;

namespace FeedReader.Controllers
{
    public class FeedController : Controller
    {
        //
        // GET: /Feed/

        public ActionResult Index()
        {
            return View();        
        }

        public ActionResult GetTitles(string source)
        {
            if (source.Equals("NPR", StringComparison.OrdinalIgnoreCase))
            {
                var feed = SyndicationFeed.Load(XmlReader.Create("http://www.npr.org/rss/rss.php?id=1001"));
                return PartialView("~/Views/Feed/_FeedTitles.cshtml", feed);
            }
            else
            {
                var feed = SyndicationFeed.Load(XmlReader.Create("http://feeds.dzone.com/dzone/frontpage"));
                return PartialView("~/Views/Feed/_FeedTitles.cshtml", feed);
            }
        }

    }
}

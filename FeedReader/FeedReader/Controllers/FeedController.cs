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
            var feed = SyndicationFeed.Load(XmlReader.Create("http://feeds.dzone.com/dzone/frontpage"));
            return View(feed);
        }

    }
}

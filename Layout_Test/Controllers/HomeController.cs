using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layout_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home
        public ActionResult Index01()
        {
            ViewData["title"] = "即時新聞";
            ViewData["site_name"] = "中時電子報";
            ViewData["meta_description"] = "提供最新鮮、精采、豐富的時事動態，最詳盡的突發新聞資訊，讓您隨時知曉天下大事，掌握新聞脈動。";
            ViewData["keywords"] = "即時, 最新, 行動, 爆料, 樂透, 威力彩, 彩券, 頭彩, 突發, 好看, 轉播, 速報, 快訊";
            ViewData["lastmod"] = "2016-06-05T10:43:19+08:00";
            ViewData["pubdate"] = "2016-06-05T10:43:19+08:00";
            ViewData["medium"] = "news";
            ViewData["chinatimes_google_plus"] = "https://plus.google.com/117097348753143594874";
            ViewData["main_url"] = "http://www.chinatimes.com/";
            ViewData["channel"] = "realtimenews";
            ViewData["twitter:card"] = "summary_large_image";
            ViewData["fb_url"] = "https://www.facebook.com/CTfans";
            ViewData["meta_image"] = "http://img.chinatimes.com/newsphoto/2015-06-18/Clipping/20150618003774_635702388922454097.jpg";
            ViewData["cache_image_url"] = "http://cache.chinatimes.com/images/";
            return View();
        }

        public ActionResult Index02()
        {
            ViewData["title"] = "即時新聞";
            ViewData["site_name"] = "中時電子報";
            ViewData["meta_description"] = "提供最新鮮、精采、豐富的時事動態，最詳盡的突發新聞資訊，讓您隨時知曉天下大事，掌握新聞脈動。";
            ViewData["keywords"] = "即時, 最新, 行動, 爆料, 樂透, 威力彩, 彩券, 頭彩, 突發, 好看, 轉播, 速報, 快訊";
            ViewData["lastmod"] = "2016-06-05T10:43:19+08:00";
            ViewData["pubdate"] = "2016-06-05T10:43:19+08:00";
            ViewData["medium"] = "news";
            ViewData["chinatimes_google_plus"] = "https://plus.google.com/117097348753143594874";
            ViewData["main_url"] = "http://www.chinatimes.com/";
            ViewData["channel"] = "realtimenews";
            ViewData["twitter:card"] = "summary_large_image";
            ViewData["fb_url"] = "https://www.facebook.com/CTfans";
            ViewData["meta_image"] = "http://img.chinatimes.com/newsphoto/2015-06-18/Clipping/20150618003774_635702388922454097.jpg";
            ViewData["cache_image_url"] = "http://cache.chinatimes.com/images/";
            return View();
        }

        public ActionResult Index03()
        {
            return View();
        }

        public ActionResult Index04()
        {
            return View();
        }

        public ActionResult Index04_header()
        {
            return View();
        }

        public ActionResult Index04_nav()
        {
            return View();
        }

        public ActionResult Index04_social_idxbox()
        {
            return View();
        }

        public ActionResult Index04_footer()
        {
            return View();
        }

        public ActionResult Index05()
        {
            return View();
        }
    }
}
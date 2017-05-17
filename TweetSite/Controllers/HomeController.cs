using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using TweetSite.Core;
using static System.String;

namespace TweetSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var numbers = new List<long>();

            if (HttpContext.Request.Query["tweets"].Count != 0)
            {
                var tweets = HttpContext.Request.Query["tweets"].ToString();

                numbers = tweets.Split(',').Select(long.Parse).ToList();

            }

            var generate = new Generate();

            return Content(System.Net.WebUtility.HtmlDecode(generate.SiteFromTweets(numbers)),"text/html");
        }
    }
}

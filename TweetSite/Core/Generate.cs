using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi;

namespace TweetSite.Core
{
    public class Generate
    {
        public string SiteFromTweets(List<long> tweets)
        {
            //Create any app at: https://apps.twitter.com/
            //Generate the Consumer Secret and Key, then generate your user token and secret as well.
            Auth.SetUserCredentials("ConsumerKey", "ConsumerSecret", "UserAccessToken", "UserAccessSecret");
            return tweets.Count == 0 ? "<p class=MsoHeader><span lang=EN-US style='mso-ansi-language:EN-US'>Here's some bad HTML - add some ?tweets=864849490162876416,864849511268716545,864849695797129218,864849714252001280 maybe<o:p></o:p></span></p>" : tweets.Select(Tweet.GetTweet).Aggregate("", (current, tweetToReplyTo) => current + tweetToReplyTo.Text);
        }
    }
}

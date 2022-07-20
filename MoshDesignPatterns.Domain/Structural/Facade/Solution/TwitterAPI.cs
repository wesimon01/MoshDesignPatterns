using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Structural.Facade
{
    public class TwitterAPI
    {
        private readonly string appKey;
        private readonly string secret;

        public TwitterAPI(string appKey, string secret)
        {
            this.appKey = appKey;
            this.secret = secret;
        }

        public List<Tweet> GetRecentTweets()
        {
            var twitterClient = new TwitterClient();
            var accessToken = GetAccessToken();
            var tweets = twitterClient.GetRecentTweets(accessToken);
            return tweets;
        }

        private string GetAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken(appKey, secret);
            var accessToken = oauth.GetAccessToken(requestToken);
            return accessToken;
        }
    }
}

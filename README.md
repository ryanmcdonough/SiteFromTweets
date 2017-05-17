# SiteFromTweets
Generate a site using tweet ids, by passing a comma seperated list using ?tweets= in the URL.

Set your Consumer Secret, Consumer Key, User Token and User Access Secret in: Core/Generate.cs

            Auth.SetUserCredentials("ConsumerKey", "ConsumerSecret", "UserAccessToken", "UserAccessSecret");

Doesn't require the user access token to be per user, just your own will be fine.

## Examples

http://sitefromtweets.azurewebsites.net/?tweets=864863892790530048,864863961040244738

http://sitefromtweets.azurewebsites.net/?tweets=864849490162876416,864849511268716545,864849695797129218,864849714252001280

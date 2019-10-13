using System.Collections.Generic;

namespace _535_EncodeAndDecodeTinyURL
{
    internal class Codec
    {
        private IDictionary<string, string> UrlMap = new Dictionary<string, string>();

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            return encodeUrl(longUrl);
        }

        private string encodeUrl(string url)
        {
            var hash = string.Format("{0:X}", url.GetHashCode());
            var hashedUrl = $"http://tinyurl.com/{hash}";

            UrlMap[hashedUrl] = url;

            return hashedUrl;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            return UrlMap[shortUrl];
        }
    }
}

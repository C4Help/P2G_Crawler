using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2G_Crawler
{
    public struct LinkItem
    {
        public string Href;
        public string Text;

        public override string ToString()
        {
            return Href + "\n\t" + Text;
        }
    }

    static class LinkFinder
    {
        public static List<LinkItem> Find(string file)
        {
            List<LinkItem> list = new List<LinkItem>();

            // 1.
            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",
                RegexOptions.Singleline);

            // 2.
            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                LinkItem i = new LinkItem();

                // 3.
                // Get href attribute.
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                RegexOptions.Singleline);
                if (m2.Success)
                {
                    i.Href = m2.Groups[1].Value;
                }

                // 4.
                // Remove inner tags from text.
                string t = Regex.Replace(value, @"\s*<.*?>\s*", "",
                RegexOptions.Singleline);
                i.Text = t;

                list.Add(i);
            }
            return list;
        }
    }
    class CrawlingManager
    {
        public static Dictionary<string, string> Crawl(string RegNum, string Url, CrawlingSettings cs)
        {
            // Check If the URL is Valid
            if (Url == null) return null;

            //  Check if the Url is working
            if (!IsValidURL(Url)) return null;



            //Crawl
            Dictionary<string, string> list = CrawlUrl(RegNum, Url, cs);
            return list;
        }

        private static Dictionary<string, string> CrawlUrl(string RegNum, string Url, CrawlingSettings cs)
        {
            #region Init
            // fix the url if it doesn't have http in the begining
            if (!Url.ToLower().Contains("http"))
                Url = "http://" + Url;
            // Results 
            Dictionary<string, string> results = new Dictionary<string, string>();
            #endregion
            #region init The dictionary
            switch (cs.CrawlItemType)
            {
                case "Social Media":
                    results.Add("facebook", "");
                    results.Add("twitter", "");
                    results.Add("linkedin", "");
                    results.Add("youtube", "");
                    break;

                case "Contact Info":
                    results.Add("email", "");
                    results.Add("phone", "");
                    results.Add("fax", "");
                    break;


            }
            #endregion
            #region Crawling
            // Crawling all social media everytime
            try
            {
                WebClient w = new WebClient();
                string s = w.DownloadString(Url);
                List<LinkItem> allLinks = LinkFinder.Find(s);
                foreach (LinkItem i in allLinks)
                {

                    if (i.Href == null) continue;

                    if (cs.CrawlItemType == "Social Media")
                    {
                        if (i.Href.ToLower().Contains("www.facebook"))
                            results["facebook"] = i.Href;
                        if (i.Href.ToLower().Contains("www.twitter"))
                            results["twitter"] = i.Href;
                        if (i.Href.ToLower().Contains("www.linkedin"))
                            results["linkedin"] = i.Href;
                        if (i.Href.ToLower().Contains("www.youtube"))
                            results["youtube"] = i.Href;
                    }
                    if (cs.CrawlItemType == "Contact Info")
                    {
                        if (i.Href.ToLower().Contains("email"))
                            results["email"] = i.Href;
                        if (i.Href.ToLower().Contains("phone"))
                            results["phone"] = i.Href;
                        if (i.Href.ToLower().Contains("fax"))
                            results["fax"] = i.Href;

                    }


                }


            }
            catch { return null; }

            #endregion

            return results;
        }



        private static bool IsValidURL(string CharityUrl)
        {
            try
            {
                Application.DoEvents();

                CharityUrl = CharityUrl.ToLower();
                if (!CharityUrl.StartsWith("http"))
                    CharityUrl = "http://" + CharityUrl;
                var request = (HttpWebRequest)WebRequest.Create(CharityUrl);
                request.Method = "HEAD";

                var response = (HttpWebResponse)request.GetResponse();

                var success = response.StatusCode == HttpStatusCode.OK;
                return (bool)success;
            }
            catch { return false; }
        }
    }
}

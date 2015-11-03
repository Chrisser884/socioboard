using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml;

namespace Socioboard.Controllers
{
    public class CompanyDashboardController : AsyncController
    {
        Api.CompanyDashboard.CompanyDashboard apicompanydashboard = new Api.CompanyDashboard.CompanyDashboard();
        private Helper.CompanyProfiles companyprofiles = new Helper.CompanyProfiles();
<<<<<<< HEAD
       // [OutputCache(Duration=180)]
        public ActionResult Company(string q) 
        {
            Domain.Socioboard.Domain.CompanyProfiles companyprofile = new Domain.Socioboard.Domain.CompanyProfiles();
            string result =  apicompanydashboard.SearchCompanyProfile(q);
            //string result = string.Empty;
            if (string.IsNullOrEmpty(result) || result.Equals("Something Went Wrong"))
            {
                companyprofile.Companyname = q;
                companyprofile.Fbprofileid = q.Replace(" ", string.Empty);
                companyprofile.Gplusprofileid = q.Replace(" ", string.Empty);
                companyprofile.Instagramprofileid = q.Replace(" ", string.Empty);
                companyprofile.Linkedinprofileid = q.Replace(" ", string.Empty);
                companyprofile.Tumblrprofileid = q.Replace(" ", string.Empty);
                companyprofile.Twitterprofileid = q.Replace(" ", string.Empty);
                companyprofile.Youtubeprofileid = q.Replace(" ", string.Empty);
=======
        [OutputCache(Duration=180)]
        public ActionResult Company(string q) 
        {
            Domain.Socioboard.Domain.CompanyProfiles companyprofile = new Domain.Socioboard.Domain.CompanyProfiles();
           // string result =  apicompanydashboard.SearchCompanyProfile(q);
            string result = string.Empty;
            if (string.IsNullOrEmpty(result) || result.Equals("Something Went Wrong"))
            {
                companyprofile.CompanyName = q;
                companyprofile.FbProfileId = q.Replace(" ", string.Empty);
                companyprofile.GPlusProfileId = q.Replace(" ", string.Empty);
                companyprofile.InstagramProfileId = q.Replace(" ", string.Empty);
                companyprofile.LinkedinProfileId = q.Replace(" ", string.Empty);
                companyprofile.TumblrProfileId = q.Replace(" ", string.Empty);
                companyprofile.TwitterProfileId = q.Replace(" ", string.Empty);
                companyprofile.YoutubeProfileId = q.Replace(" ", string.Empty);
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            }
            else 
            {
                companyprofile = (Domain.Socioboard.Domain.CompanyProfiles)(new JavaScriptSerializer().Deserialize(result, typeof(Domain.Socioboard.Domain.CompanyProfiles)));
            }
            return View(companyprofile);
        }
<<<<<<< HEAD


        public List<string> getAllCompanyNames(string Name) 
        {
            List<string> CompanyNames = null;
=======
        public List<string> getAllCompanyNames(string Name) 
        {
            List<string> CompanyNames = null;

>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            return CompanyNames;

        }


        //[ChildActionOnly]
<<<<<<< HEAD
       // [OutputCache(Duration = 180)]
=======
        [OutputCache(Duration = 180)]
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public ActionResult CompanyFacebookPageInfo(string CompanyName)
        {
            try
            {
                JObject fbPage = JObject.Parse(companyprofiles.SearchFacebookPage(CompanyName));
                ViewBag.facebookPageDetailsObj = fbPage;
<<<<<<< HEAD
                string fbpageNotesstring = companyprofiles.getFacebookPageFeeds(fbPage["id"].ToString());
                //if (!fbpageNotesstring.StartsWith("["))
                //    fbpageNotesstring = "[" + fbpageNotesstring + "]";
                //JArray fbpageNotes = JArray.Parse(fbpageNotesstring);
                JObject fbpageNotes = JObject.Parse(fbpageNotesstring);
=======
                string fbpageNotesstring = companyprofiles.getFacebookPageNotes(fbPage["id"].ToString());
                if (!fbpageNotesstring.StartsWith("["))
                    fbpageNotesstring = "[" + fbpageNotesstring + "]";
                JArray fbpageNotes = JArray.Parse(fbpageNotesstring);
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
                ViewBag.facebookPageNotes = fbpageNotes;
            }
            catch (Exception e) { }
            return PartialView("_CompanyFacebookPageInfoPartial");
        }
       // [ChildActionOnly]
<<<<<<< HEAD
      //  [OutputCache(Duration = 180)]
=======
        [OutputCache(Duration = 180)]
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public ActionResult CompanyYoutubePageInfo(string CompanyName)
        {
            try
            {
                string result = companyprofiles.YoutubeSearch(CompanyName);
                if (!result.StartsWith("["))
                    result = "[" + result + "]";
                JArray youtubechannels = JArray.Parse(result);
                JObject resultPage = (JObject)youtubechannels[0];
                ViewBag.RPage = resultPage["items"][0];
                ViewBag.PlayList = JObject.Parse(companyprofiles.YoutubeChannelPlayList(resultPage["items"][0]["id"].ToString()));
            }
            catch (Exception e) { }
            return PartialView("_CompanyYoutubePageInfoPartial");
        }
        //[ChildActionOnly]
<<<<<<< HEAD
        //[OutputCache(Duration = 180)]
=======
        [OutputCache(Duration = 180)]
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public ActionResult CompanyTwitterPageInfo(string CompanyName)
        {
            try
            {
                string TwitterPage = companyprofiles.TwitterSearch(CompanyName);
                JObject CompanyTwitterPage = JObject.Parse(TwitterPage);
                ViewBag.CompanyTwitterPageinfo = CompanyTwitterPage;
                ViewBag.TwitterUserTimeLine = companyprofiles.TwitterUserTimeLine(CompanyTwitterPage["screen_name"].ToString());
            }
            catch (Exception e) { }

            return PartialView("_CompanyTwitterPageInfoPartial");
        }
        //[ChildActionOnly]
<<<<<<< HEAD
       // [OutputCache(Duration = 180)]
=======
        [OutputCache(Duration = 180)]
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public ActionResult CompanyInstagramPageInfo(string CompanyName)
        {
            try
            {
                string result = companyprofiles.getInstagramCompanyPage(CompanyName);
                JObject resultPage = JObject.Parse(result);
                ViewBag.RPage = resultPage["data"];
                JObject recentactivities = JObject.Parse(companyprofiles.getInstagramUserRecentActivities(resultPage["data"]["id"].ToString()));
                ViewBag.InstagramRecentActivities = recentactivities["data"][0];
            }
            catch (Exception e) { }
            return PartialView("_CompanyInstagramPageInfoPartial");
        }
        //[ChildActionOnly]
<<<<<<< HEAD
       // [OutputCache(Duration = 180)]
=======
        [OutputCache(Duration = 180)]
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public ActionResult CompanyLinkedinPageInfo(string CompanyName)
        {
            try
            {
                XmlNode ResultCompany = null;
                int followers = 0;
                string result = string.Empty;
                result = companyprofiles.LinkedinSearch(CompanyName);
                XmlDocument XmlResult = new XmlDocument();
                XmlResult.Load(new StringReader(result));
                XmlNodeList Companies = XmlResult.SelectNodes("company-search/companies/company");
                foreach (XmlNode node in Companies)
                {
                    if (Convert.ToInt32(node.SelectSingleNode("num-followers").InnerText) > followers)
                    {
                        ResultCompany = node;
                        followers = Convert.ToInt32(node.SelectSingleNode("num-followers").InnerText);
                    }

                }
                ViewBag.ResultCompany = ResultCompany;

                string companyrecentactivites = companyprofiles.LinkedinCompanyrecentActivites(ResultCompany.SelectSingleNode("id").InnerText);

                XmlDocument RecentActivites = new XmlDocument();
                RecentActivites.Load(new StringReader(companyrecentactivites));
                XmlNodeList activities = RecentActivites.SelectNodes("updates/update");
                ViewBag.racties = activities;

                //string Companyjobs = ApiobjDiscoverySearch.LinkedinCompnayJobs(ResultCompany.SelectSingleNode("id").InnerText);
            }
            catch (Exception e) { }
            return PartialView("_CompanyLinkedinPageInfoPartial");
        }
        //[ChildActionOnly]
<<<<<<< HEAD
       // [OutputCache(Duration = 180)]
=======
        [OutputCache(Duration = 180)]
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public ActionResult CompanyTumblrPageInfo(string CompanyName)
        {
            try
            {
                string TumblrPage = companyprofiles.TumblrSearch(CompanyName);
                JObject CompanyTumblrPage = JObject.Parse(TumblrPage);
                ViewBag.CompanyTumblrPageinfo = CompanyTumblrPage;
            }
            catch (Exception e) { }
            return PartialView("_CompanyTumblrPageInfoPartial");
        }
        //[ChildActionOnly]
<<<<<<< HEAD
      // [OutputCache(Duration = 180)]
=======
        [OutputCache(Duration = 180)]
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public ActionResult CompanyGplusPageInfo(string CompanyName)
        {
            try
            {
                string result = companyprofiles.GooglePlusSearch(CompanyName);
                JObject resultPage = JObject.Parse(result);
                ViewBag.RPage = resultPage;
                JObject RecentActivities = JObject.Parse(companyprofiles.GooglePlusgetUserRecentActivities(resultPage["id"].ToString()));
                ViewBag.RecentActivities = RecentActivities["items"];
            }
            catch (Exception e) { }

            return PartialView("_CompanyGplusPageInfoPartial");
        }
    }






}

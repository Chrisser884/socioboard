﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Xml;
using GlobusInstagramLib.Authentication;
using GlobusLinkedinLib.Authentication;
using GlobusTwitterLib.Authentication;
using log4net;
using Newtonsoft.Json.Linq;

namespace Socioboard.Helper
{
    public class CompanyProfiles
    {
        ILog logger = LogManager.GetLogger(typeof(CompanyProfiles));



<<<<<<< HEAD
       
=======

>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        #region FacebookLogic
        public bool CheckFacebookToken(string fbtoken, string txtvalue)
        {
            bool checkFacebookToken = false;
            try
            {
                string facebookSearchUrl = "https://graph.facebook.com/search?q=" + txtvalue + " &type=post&access_token=" + fbtoken;
                var facerequest = (HttpWebRequest)WebRequest.Create(facebookSearchUrl);
                facerequest.Method = "GET";
                string outputface = string.Empty;
                using (var response = facerequest.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        outputface = stream.ReadToEnd();
                    }
                }
                checkFacebookToken = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return checkFacebookToken;
        }

<<<<<<< HEAD


        //Start Facebook Search Logic

=======
        

        //Start Facebook Search Logic
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string SearchFacebookPage(string Keyword)
        {
            string facebookResultPage = string.Empty;
            int likes = 0;
            facebookResultPage = this.getFacebookPage(Keyword.Replace(" ", string.Empty));
            string error = string.Empty;
            try
            {
                JObject checkpage = JObject.Parse(facebookResultPage);
                error = checkpage["error"].ToString();
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                logger.Error(ex.Message);
=======
                logger.Error(ex.StackTrace);
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            }

            if (!string.IsNullOrEmpty(error) || string.IsNullOrEmpty(facebookResultPage))
            {
                string fbpagelist = this.getFacebookkPageList(Keyword);
                if (!fbpagelist.StartsWith("["))
                    fbpagelist = "[" + fbpagelist + "]";
                JArray fbpageArray = JArray.Parse(fbpagelist);
                foreach (var item in fbpageArray)
                {
                    var data = item["data"];

                    foreach (var page in data)
                    {
                        try
                        {
                            string fbpage = this.getFacebookPage(page["id"].ToString());
                            JObject pageresult = JObject.Parse(fbpage);
                            if (Convert.ToInt32(pageresult["likes"].ToString()) > likes)
                            {
                                facebookResultPage = fbpage;
                                likes = Convert.ToInt32(pageresult["likes"].ToString());
                            }
                        }
                        catch (Exception ex)
                        {
<<<<<<< HEAD
                            logger.Error(ex.Message);

=======
                            logger.Error(ex.StackTrace);
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
                        }
                    }
                }

            }
            //Domain.Socioboard.Domain.facebookpageinfo fbPageInfo = new Domain.Socioboard.Domain.facebookpageinfo();
            //JObject fb = JObject.Parse(facebookResultPage);
            //try
            //{
            //    fbPageInfo.companyname = fb["name"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.about = fb["about"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.founded = fb["founded"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.description = fb["description"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.country = fb["location"]["country"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.city = fb["location"]["city"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.pageid = fb["id"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.pagelikes = fb["likes"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.phone = fb["phone"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.username = fb["username"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.link = fb["link"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.mission = fb["mission"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.talkingabout = fb["talking_about_count"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}
            //try
            //{
            //    fbPageInfo.website = fb["website"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex.StackTrace);
            //}

            return facebookResultPage;
        }


        //search facebook for pages and return page list
<<<<<<< HEAD

        public string getFacebookkPageList(string Keyword)
        {
            Api.Companypage.Companypage apicompany = new Api.Companypage.Companypage();
            string accesstoken = "CAACZB5L4uuV8BACXwWhgpnE6lrSuIz0vdr6HtMQM8rUEKFPBVfhuYr56OCvPmRqsWPoYaMtYmaRGPZCqRqa562eaoSXaa1xScB5zKtE5jHFw07wI0GENjFOnluGrduNhHRqJT1iNUCFnTh5GXmZAtc4AiZAPMvVXS9EidsDo9PNVQwd262eSFapVZCFvxJpIZD";
=======
        
        public string getFacebookkPageList(string Keyword)
        {
            Api.Companypage.Companypage apicompany = new Api.Companypage.Companypage();
            string accesstoken =apicompany.getfacebookActiveAceessTokenFromDb();
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            //foreach (Domain.Socioboard.Domain.FacebookAccount item in asltFbAccount)
            //{
            //    accesstoken = item.AccessToken;
            //    if (this.CheckFacebookToken(accesstoken, Keyword))
            //    {

            //        break;
            //    }
            //}

            // getting search results
            string facebookSearchUrl = "https://graph.facebook.com/v1.0/search?q=" + Keyword + "&type=page&access_token=" + accesstoken + "&limit=10";
            var facebooklistpagerequest = (HttpWebRequest)WebRequest.Create(facebookSearchUrl);
            facebooklistpagerequest.Method = "GET";
            facebooklistpagerequest.Credentials = CredentialCache.DefaultCredentials;
            facebooklistpagerequest.AllowWriteStreamBuffering = true;
            facebooklistpagerequest.ServicePoint.Expect100Continue = false;
            facebooklistpagerequest.PreAuthenticate = false;
            string outputface = string.Empty;
            try
            {
                using (var response = facebooklistpagerequest.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        outputface = stream.ReadToEnd();
                    }
                }
            }
            catch (Exception e) { }
            return outputface;
        }

        //Takes pageId as input and return fb page details
<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string getFacebookPage(string PageId)
        {
            string pageUrl = "http://graph.facebook.com/" + PageId.ToString();
            var fbpage = (HttpWebRequest)WebRequest.Create(pageUrl);
            fbpage.Method = "GET";
            string Outputpage = string.Empty;
            try
            {
                using (var response = fbpage.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        Outputpage = stream.ReadToEnd();
                    }
                }
            }
<<<<<<< HEAD
            catch (Exception e) 
            {
                logger.Error(e.Message);

            }
            return Outputpage;
        }


=======
            catch (Exception e) { }
            return Outputpage;
        }

       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string getFacebookPageNotes(string PageId)
        {
            //FacebookAccountRepository fbAccRepo = new FacebookAccountRepository();
            //ArrayList asltFbAccount = fbAccRepo.getAllFacebookAccounts();
            Api.Companypage.Companypage apicompany = new Api.Companypage.Companypage();
<<<<<<< HEAD
            string accesstoken = "CAACZB5L4uuV8BACXwWhgpnE6lrSuIz0vdr6HtMQM8rUEKFPBVfhuYr56OCvPmRqsWPoYaMtYmaRGPZCqRqa562eaoSXaa1xScB5zKtE5jHFw07wI0GENjFOnluGrduNhHRqJT1iNUCFnTh5GXmZAtc4AiZAPMvVXS9EidsDo9PNVQwd262eSFapVZCFvxJpIZD";
=======
            string accesstoken = apicompany.getfacebookActiveAceessTokenFromDb();
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            //foreach (Domain.Socioboard.Domain.FacebookAccount item in asltFbAccount)
            //{
            //    accesstoken = item.AccessToken;
            //    if (this.CheckFacebookToken(accesstoken, PageId))
            //    {
            //        break;
            //    }
            //}
            string facebookSearchUrl = "https://graph.facebook.com/v1.0/" + PageId + "/notes?access_token=" + accesstoken;
            var facebooklistpagerequest = (HttpWebRequest)WebRequest.Create(facebookSearchUrl);
            facebooklistpagerequest.Method = "GET";
            facebooklistpagerequest.Credentials = CredentialCache.DefaultCredentials;
            facebooklistpagerequest.AllowWriteStreamBuffering = true;
            facebooklistpagerequest.ServicePoint.Expect100Continue = false;
            facebooklistpagerequest.PreAuthenticate = false;
            string outputface = string.Empty;
            try
            {
                using (var response = facebooklistpagerequest.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        outputface = stream.ReadToEnd();
                    }
                }
            }
            catch (Exception e) { }
            return outputface;

        }


<<<<<<< HEAD
        public string getFacebookPageFeeds(string PageId)
        {
            //FacebookAccountRepository fbAccRepo = new FacebookAccountRepository();
            //ArrayList asltFbAccount = fbAccRepo.getAllFacebookAccounts();
            Api.Companypage.Companypage apicompany = new Api.Companypage.Companypage();
            string accesstoken = "CAACZB5L4uuV8BACXwWhgpnE6lrSuIz0vdr6HtMQM8rUEKFPBVfhuYr56OCvPmRqsWPoYaMtYmaRGPZCqRqa562eaoSXaa1xScB5zKtE5jHFw07wI0GENjFOnluGrduNhHRqJT1iNUCFnTh5GXmZAtc4AiZAPMvVXS9EidsDo9PNVQwd262eSFapVZCFvxJpIZD";
            //foreach (Domain.Socioboard.Domain.FacebookAccount item in asltFbAccount)
            //{
            //    accesstoken = item.AccessToken;
            //    if (this.CheckFacebookToken(accesstoken, PageId))
            //    {
            //        break;
            //    }
            //}
            string facebookSearchUrl = "https://graph.facebook.com/v1.0/" + PageId + "/feed?limit=1000&access_token=" + accesstoken;
            var facebooklistpagerequest = (HttpWebRequest)WebRequest.Create(facebookSearchUrl);
            facebooklistpagerequest.Method = "GET";
            facebooklistpagerequest.Credentials = CredentialCache.DefaultCredentials;
            facebooklistpagerequest.AllowWriteStreamBuffering = true;
            facebooklistpagerequest.ServicePoint.Expect100Continue = false;
            facebooklistpagerequest.PreAuthenticate = false;
            string outputface = string.Empty;
            try
            {
                using (var response = facebooklistpagerequest.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        outputface = stream.ReadToEnd();
                    }
                }
            }
            catch (Exception e) { }
            return outputface;

        }



=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public bool IsfacebookAccountVerified(string fbAccountId)
        {
            bool Isverified = false;
            Api.Companypage.Companypage apicompany = new Api.Companypage.Companypage();
<<<<<<< HEAD
            string AccessToken = "CAACZB5L4uuV8BACXwWhgpnE6lrSuIz0vdr6HtMQM8rUEKFPBVfhuYr56OCvPmRqsWPoYaMtYmaRGPZCqRqa562eaoSXaa1xScB5zKtE5jHFw07wI0GENjFOnluGrduNhHRqJT1iNUCFnTh5GXmZAtc4AiZAPMvVXS9EidsDo9PNVQwd262eSFapVZCFvxJpIZD";
=======
            string AccessToken = apicompany.getfacebookActiveAceessTokenFromDb();
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            string Url = "https://graph.facebook.com//v2.1/20528438720?fields=is_verified&access_token=" + AccessToken;
            var fbpage = (HttpWebRequest)WebRequest.Create(Url);
            fbpage.Method = "GET";
            string Outputpage = string.Empty;
            try
            {
                using (var response = fbpage.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        Outputpage = stream.ReadToEnd();
                    }
                }
                JObject JobjResult = JObject.Parse(Outputpage);
                if (JobjResult["is_verified"].ToString().Equals("true"))
                {
                    Isverified = true;
                }
            }
<<<<<<< HEAD
            catch (Exception e) 
            {
                logger.Error(e.Message);

            }
=======
            catch (Exception e) { }
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            return Isverified;
        }

        # endregion

<<<<<<< HEAD
        # region twitter Logic

=======
       # region twitter Logic
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string TwitterSearch(string keyword)
        {
            string SingleTwitterPageResult = string.Empty;
            try
            {
                SingleTwitterPageResult = TwitterAccountPageWithoutLogin("", keyword);
                if (!string.IsNullOrEmpty(SingleTwitterPageResult))
                {
                    return SingleTwitterPageResult;
                }
            }
<<<<<<< HEAD
            catch (Exception eee) 
            {
                logger.Error(eee.Message);

            }
=======
            catch (Exception eee) { }
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            //int Followers = 0;
            bool ischanged = false;
            string TwitterResutPage = string.Empty;
            string TwitterResutPageid = string.Empty;
            string ScreenName = string.Empty;
            List<Domain.Socioboard.Domain.DiscoverySearch> lstDiscoverySearch = new List<Domain.Socioboard.Domain.DiscoverySearch>();
            string profileid = string.Empty;
            try
            {
                oAuthTwitter oauth = new oAuthTwitter();
                //Twitter obj = new Twitter();
                //TwitterAccountRepository twtAccRepo = new TwitterAccountRepository();
                //ArrayList alst = twtAccRepo.getAllTwitterAccounts();
                oauth.AccessToken = Twitterapponlykey();
                //oauth.AccessTokenSecret = "beScSFa1uI7MttvgjoDPjxYMKgC0Mq2EUYzYewbbNvobO";
                //oauth.ConsumerKey = "LvHB4sHi0RWcQF7MmrstXhEJE";
                //oauth.ConsumerKeySecret = "vd5cdLeje1sThW4cYonIhqWuvKkGk1mZLDu1j1IAbSkLLqp5Kd";
                //oauth.ConsumerKey = ConfigurationManager.AppSettings["consumerKey"];
                //oauth.ConsumerKeySecret = ConfigurationManager.AppSettings["consumerSecret"];
                string twitterSearchResult = Get_Search_Users(oauth, keyword);
                JArray twitterpageArray = JArray.Parse(twitterSearchResult);
                foreach (var item in twitterpageArray)
                {
                    if (item["verified"].ToString().Equals("True"))
                    {
                        TwitterResutPageid = item["id"].ToString();
                        ScreenName = item["screen_name"].ToString();
                        ischanged = true;
                    }
                }
                if (ischanged)
                {
                    TwitterResutPage = Get_Search_SingleUser(oauth, TwitterResutPageid, ScreenName);
                }
                return TwitterResutPage;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
<<<<<<< HEAD
                logger.Error(ex.Message);
=======
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
                return "";
            }
        }

        public string Twitterapponlykey()
        {
            string retvalu = string.Empty;
            var oauth_consumer_key = "yNt3tISGJji5poVSgSO1Og";
            var oauth_consumer_secret = "BvJQlpnjBxN7rtiGF6fIbcGlTgmRac8O3cOamwmr8X4";
            //Token URL
            var oauth_url = "https://api.twitter.com/oauth2/token";
            var headerFormat = "Basic {0}";
            var authHeader = string.Format(headerFormat,
            Convert.ToBase64String(Encoding.UTF8.GetBytes(Uri.EscapeDataString(oauth_consumer_key) + ":" +
            Uri.EscapeDataString((oauth_consumer_secret)))
            ));

            var postBody = "grant_type=client_credentials";

            ServicePointManager.Expect100Continue = false;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(oauth_url);
            request.Headers.Add("Authorization", authHeader);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";

            using (Stream stream = request.GetRequestStream())
            {
                byte[] content = ASCIIEncoding.ASCII.GetBytes(postBody);
                stream.Write(content, 0, content.Length);
            }

            request.Headers.Add("Accept-Encoding", "gzip");
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream responseStream = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress);
            using (var reader = new StreamReader(responseStream))
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                var objText = reader.ReadToEnd();
                JObject o = JObject.Parse(objText);
                retvalu = o["access_token"].ToString();

            }
            return retvalu;

        }
<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string TwitterAccountPageWithoutLogin(string UserId, string ScreenName)
        {
            JObject output = new JObject();
            try
            {
                SortedDictionary<string, string> requestParameters = new SortedDictionary<string, string>();
                requestParameters.Add("user_id", UserId);
                requestParameters.Add("screen_name", ScreenName);
                //Token URL
                var oauth_url = "https://api.twitter.com/1.1/users/show.json";
                var headerFormat = "Bearer {0}";
                var authHeader = string.Format(headerFormat, "AAAAAAAAAAAAAAAAAAAAAOZyVwAAAAAAgI0VcykgJ600le2YdR4uhKgjaMs%3D0MYOt4LpwCTAIi46HYWa85ZcJ81qi0D9sh8avr1Zwf7BDzgdHT");

                var postBody = requestParameters.ToWebString();
                ServicePointManager.Expect100Continue = false;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(oauth_url + "?"
                       + requestParameters.ToWebString());

                request.Headers.Add("Authorization", authHeader);
                request.Method = "GET";
                request.Headers.Add("Accept-Encoding", "gzip");
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream responseStream = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress);
                using (var reader = new StreamReader(responseStream))
                {

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    var objText = reader.ReadToEnd();
                    output = JObject.Parse(objText);


                }
            }
<<<<<<< HEAD
            catch (Exception e)
            {
                logger.Error(e.Message);
            }
=======
            catch (Exception e) { }
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b

            return output.ToString();
        }

<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string TwitterUserTimeLine(string ScreenName)
        {
            JArray output = new JArray();
            try
            {
                SortedDictionary<string, string> requestParameters = new SortedDictionary<string, string>();
                //requestParameters.Add("user_id", UserId);
                requestParameters.Add("screen_name", ScreenName);
<<<<<<< HEAD
                requestParameters.Add("count", "198");
=======
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
                //Token URL
                var oauth_url = "https://api.twitter.com/1.1/statuses/user_timeline.json";
                var headerFormat = "Bearer {0}";
                var authHeader = string.Format(headerFormat, "AAAAAAAAAAAAAAAAAAAAAOZyVwAAAAAAgI0VcykgJ600le2YdR4uhKgjaMs%3D0MYOt4LpwCTAIi46HYWa85ZcJ81qi0D9sh8avr1Zwf7BDzgdHT");

                var postBody = requestParameters.ToWebString();
                ServicePointManager.Expect100Continue = false;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(oauth_url + "?"
                       + requestParameters.ToWebString());

                request.Headers.Add("Authorization", authHeader);
                request.Method = "GET";
                request.Headers.Add("Accept-Encoding", "gzip");
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream responseStream = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress);
                using (var reader = new StreamReader(responseStream))
                {

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    var objText = reader.ReadToEnd();
                    output = JArray.Parse(objText);

                }
            }
            catch (Exception ee) { }

            return output.ToString();
        }

        public string Get_Search_Users(oAuthTwitter oAuth, string SearchKeyword)
        {

            string RequestUrl = "https://api.twitter.com/1.1/users/search.json";
            SortedDictionary<string, string> strdic = new SortedDictionary<string, string>();
            strdic.Add("q", SearchKeyword);
            string response = oAuth.oAuthWebRequest(oAuthTwitter.Method.GET, RequestUrl, strdic);
            if (!response.StartsWith("["))
                response = "[" + response + "]";
            return response;
        }

        public string Get_Search_SingleUser(oAuthTwitter oAuth, string SearchKeyword, string ScreenName)
        {

            string RequestUrl = "https://api.twitter.com/1.1/users/show.json";
            SortedDictionary<string, string> strdic = new SortedDictionary<string, string>();
            strdic.Add("user_id", SearchKeyword);
            strdic.Add("screen_name", ScreenName);
            string response = oAuth.oAuthWebRequest(oAuthTwitter.Method.GET, RequestUrl, strdic);

            return response;
        }

<<<<<<< HEAD
        # endregion

        # region Linkedin Logic


=======
        # endregion 

        # region Linkedin Logic

        
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string LinkedinSearch(string keyword)
        {
            string profileid = string.Empty;
            try
            {
<<<<<<< HEAD
                // ArrayList alstLIAccounts = objLinkedinrepo.getAllLinkedinAccounts();
=======
               // ArrayList alstLIAccounts = objLinkedinrepo.getAllLinkedinAccounts();
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
                //Domain.Socioboard.Domain.LinkedInAccount linkacc = (Domain.Socioboard.Domain.LinkedInAccount)alstLIAccounts[0];
                oAuthLinkedIn oauth = new oAuthLinkedIn();
                oauth.ConsumerKey = ConfigurationManager.AppSettings["LiApiKey"];
                oauth.ConsumerSecret = ConfigurationManager.AppSettings["LiSecretKey"];
                //oauth.Token = "49c2202b-2cd4-4c74-b5db-ce8d7f5e029e";
                //oauth.TokenSecret = "a79cfbe5-d268-456e-8fdc-0d12869a1cf3";
                //oauth.Verifier = "52921";
                oauth.Token = "b82db6bb-21bb-44d2-a298-0b093708ddbf";
                oauth.TokenSecret = "f7c9b7b8-9295-46fe-8cb4-914c1c52820f";
                oauth.Verifier = "23836";
                //oauth.AccessTokenGet(linkacc.OAuthToken);
                //TODO: access Token Logic
                oauth.AccessTokenGet("b82db6bb-21bb-44d2-a298-0b093708ddbf");
                //oauth.AccessTokenGet();

                //https://api.linkedin.com/v1/people-search? keywords=[space delimited keywords]
                //oauth.AccessTokenGet(oauth.Token);
                // company.Get_CompanyProfileById(oauth, keyword);
                //string response = oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/companies/" + keyword + ":(id,name,email-domains,description,founded-year,end-year,locations,Specialties,website-url,status,employee-count-range,industries,company-type,logo-url,square-logo-url,blog-rss-url,num-followers,universal-name)", null);
                string response = oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/company-search" + ":(companies:(id,name,universal-name,website-url,industries,status,logo-url,blog-rss-url,twitter-id,employee-count-range,specialties,locations,description,stock-exchange,founded-year,end-year,num-followers))?keywords=" + keyword, null);
                XmlDocument XmlResult = new XmlDocument();
                XmlResult.Load(new StringReader(response));


                XmlNode ResultCompany = null;
                int followers = 0;
                string result = string.Empty;
                XmlNodeList Companies = XmlResult.SelectNodes("company-search/companies/company");
                foreach (XmlNode node in Companies)
                {
                    if (Convert.ToInt32(node.SelectSingleNode("num-followers").InnerText) > followers)
                    {
                        ResultCompany = node;
                        followers = Convert.ToInt32(node.SelectSingleNode("num-followers").InnerText);
                    }

                }



                return response;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return new JavaScriptSerializer().Serialize("Please try Again");
            }
        }

<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string LinkedinCompanyrecentActivites(string CompanyId)
        {
            string response = string.Empty;
            try
            {
                //ArrayList alstLIAccounts = objLinkedinrepo.getAllLinkedinAccounts();
                //Domain.Socioboard.Domain.LinkedInAccount linkacc = (Domain.Socioboard.Domain.LinkedInAccount)alstLIAccounts[0];
                oAuthLinkedIn oauth = new oAuthLinkedIn();
                oauth.ConsumerKey = ConfigurationManager.AppSettings["LiApiKey"];
                oauth.ConsumerSecret = ConfigurationManager.AppSettings["LiSecretKey"];
<<<<<<< HEAD
                //oauth.Token = "49c2202b-2cd4-4c74-b5db-ce8d7f5e029e";
                //oauth.TokenSecret = "a79cfbe5-d268-456e-8fdc-0d12869a1cf3";
                //oauth.Verifier = "52921";
                oauth.Token = "b82db6bb-21bb-44d2-a298-0b093708ddbf";
                oauth.TokenSecret = "f7c9b7b8-9295-46fe-8cb4-914c1c52820f";
                oauth.Verifier = "23836";
                //oauth.AccessTokenGet(linkacc.OAuthToken);
                //TODO: access Token Logic
                oauth.AccessTokenGet("b82db6bb-21bb-44d2-a298-0b093708ddbf");
=======
                oauth.Token = "49c2202b-2cd4-4c74-b5db-ce8d7f5e029e";
                oauth.TokenSecret = "a79cfbe5-d268-456e-8fdc-0d12869a1cf3";
                oauth.Verifier = "52921";
                oauth.AccessTokenGet("e5d90a22-b939-4587-9bd7-b4951921cc00");
                //TODO: Linked in access token logic here
                //oauth.AccessTokenGet();
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b

                //https://api.linkedin.com/v1/people-search? keywords=[space delimited keywords]
                //oauth.AccessTokenGet(oauth.Token);
                // company.Get_CompanyProfileById(oauth, keyword);
                //string response = oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/companies/" + keyword + ":(id,name,email-domains,description,founded-year,end-year,locations,Specialties,website-url,status,employee-count-range,industries,company-type,logo-url,square-logo-url,blog-rss-url,num-followers,universal-name)", null);
<<<<<<< HEAD
                response = oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/companies/" + CompanyId + "/updates?start=0&count=200&event-type=status-update", null);
=======
                response = oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/companies/" + CompanyId + "/updates?start=0&count=10&event-type=status-update", null);
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            }
            catch (Exception e) { }
            return response;

        }

<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string LinkedinCompnayJobs(string CompanyId)
        {
            string response = string.Empty;
            try
            {
<<<<<<< HEAD
                //ArrayList alstLIAccounts = objLinkedinrepo.getAllLinkedinAccounts();
=======
               //ArrayList alstLIAccounts = objLinkedinrepo.getAllLinkedinAccounts();
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
                //Domain.Socioboard.Domain.LinkedInAccount linkacc = (Domain.Socioboard.Domain.LinkedInAccount)alstLIAccounts[0];
                oAuthLinkedIn oauth = new oAuthLinkedIn();
                oauth.ConsumerKey = ConfigurationManager.AppSettings["LiApiKey"];
                oauth.ConsumerSecret = ConfigurationManager.AppSettings["LiSecretKey"];
                oauth.Token = "49c2202b-2cd4-4c74-b5db-ce8d7f5e029e";
                oauth.TokenSecret = "a79cfbe5-d268-456e-8fdc-0d12869a1cf3";
                oauth.Verifier = "52921";
                //oauth.AccessTokenGet(linkacc.OAuthToken);
                oauth.AccessTokenGet("fd200850-37b4-4845-9671-13e5280c7535");
                //TODO : access Token Logic
                //oauth.AccessTokenGet();

                //https://api.linkedin.com/v1/people-search? keywords=[space delimited keywords]
                //oauth.AccessTokenGet(oauth.Token);
                // company.Get_CompanyProfileById(oauth, keyword);
                //string response = oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/companies/" + keyword + ":(id,name,email-domains,description,founded-year,end-year,locations,Specialties,website-url,status,employee-count-range,industries,company-type,logo-url,square-logo-url,blog-rss-url,num-followers,universal-name)", null);
                response = oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/jobs/" + CompanyId, null);
            }
            catch (Exception e) { }
            return response;

        }
        # endregion

        #region Instagram Logic
<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string InstagramSearch(string keyword, string WebUrl)
        {
            string response = string.Empty;
            string resId = string.Empty;
            try
            {
                GlobusInstagramLib.Authentication.ConfigurationIns configi = new GlobusInstagramLib.Authentication.ConfigurationIns("https://api.instagram.com/oauth/authorize/", "f5f052ccbdf94df490020f852863141b", "6c8ac0efa42c4c918bf33835fc98a793", "http://localhost:9821/InstagramManager/Instagram", "http://api.instagram.com/oauth/access_token", "https://api.instagram.com/v1/", "");
                oAuthInstagram _api = new oAuthInstagram();
                _api = oAuthInstagram.GetInstance(configi);
                AccessToken access = new AccessToken();
                //ArrayList arrList = instagramRepo.getAllInstagramAccounts();
                //Domain.Socioboard.Domain.InstagramAccount instaacc = (Domain.Socioboard.Domain.InstagramAccount)arrList[0];
                //string tk = instaacc.AccessToken;
                string tk = "422418207.d89b5cf.7d26304ef400404d816218f2318f6cc6";
                //TODO : Access token Logic
                response = _api.WebRequest(oAuthInstagram.Method.GET, "https://api.instagram.com/v1/users/search?q=" + keyword + "&access_token=" + tk, null);
                if (!response.StartsWith("["))
                    response = "[" + response + "]";
                JArray Instagramaccarray = JArray.Parse(response);
                foreach (var acc in Instagramaccarray)
                {
                    var data = acc["data"];

                    foreach (var page in data)
                    {
                        try
                        {

                            if (page["website"].ToString().Equals(WebUrl))
                            {
                                resId = page["id"].ToString();
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
            if (string.IsNullOrEmpty(resId))
            {
                return string.Empty;
            }
            return InstagramSingleUser(resId);
        }


<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string InstagramSingleUser(string UserId)
        {
            string response = string.Empty;
            try
            {
                GlobusInstagramLib.Authentication.ConfigurationIns configi = new GlobusInstagramLib.Authentication.ConfigurationIns("https://api.instagram.com/oauth/authorize/", "f5f052ccbdf94df490020f852863141b", "6c8ac0efa42c4c918bf33835fc98a793", "http://localhost:9821/InstagramManager/Instagram", "http://api.instagram.com/oauth/access_token", "https://api.instagram.com/v1/", "");
                oAuthInstagram _api = new oAuthInstagram();
                _api = oAuthInstagram.GetInstance(configi);
                AccessToken access = new AccessToken();
                //ArrayList arrList = instagramRepo.getAllInstagramAccounts();
                //Domain.Socioboard.Domain.InstagramAccount instaacc = (Domain.Socioboard.Domain.InstagramAccount)arrList[1];
                //string tk = instaacc.AccessToken;
                string tk = "422418207.d89b5cf.7d26304ef400404d816218f2318f6cc6";
                response = _api.WebRequest(oAuthInstagram.Method.GET, "https://api.instagram.com/v1/users/" + UserId + "/?access_token=" + tk, null);


            }
            catch (Exception ex)
            {

            }

            return response;
        }


<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string getInstagramCompanyPage(string Keyword)
        {
            int followers = 0;
            string ResultPage = string.Empty;
            try
            {
                string instagrampagelist = getInstagramList(Keyword);
                if (!instagrampagelist.StartsWith("["))
                    instagrampagelist = "[" + instagrampagelist + "]";
                JArray fbpageArray = JArray.Parse(instagrampagelist);
                foreach (var item in fbpageArray)
                {
                    var data = item["data"];

                    foreach (var page in data)
                    {
                        try
                        {
                            string instagrampage = this.getInstagramUserDetails(page["id"].ToString());
                            JObject pageresult = JObject.Parse(instagrampage);
                            if (Convert.ToInt32(pageresult["data"]["counts"]["followed_by"].ToString()) > followers)
                            {
                                ResultPage = instagrampage;
                                followers = Convert.ToInt32(pageresult["data"]["counts"]["followed_by"].ToString());
                            }
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
            }
            catch (Exception e) { }

            return ResultPage;
        }
<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string getInstagramList(string Keyword)
        {
            string InstagramUrl = "https://api.instagram.com/v1/users/search?q=" + Keyword + "&client_id=" + ConfigurationManager.AppSettings["InstagramClientKey"] + "&count=10";
            HttpWebRequest Instagramlistpagerequest = (HttpWebRequest)WebRequest.Create(InstagramUrl);
            Instagramlistpagerequest.Method = "GET";
            Instagramlistpagerequest.Credentials = CredentialCache.DefaultCredentials;
            Instagramlistpagerequest.AllowWriteStreamBuffering = true;
            Instagramlistpagerequest.ServicePoint.Expect100Continue = false;
            Instagramlistpagerequest.PreAuthenticate = false;
            string outputface = string.Empty;
            try
            {
                using (var response = Instagramlistpagerequest.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        outputface = stream.ReadToEnd();
                    }
                }
            }
            catch (Exception e) { }
            return outputface;
        }

<<<<<<< HEAD

=======
      
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string getInstagramUserRecentActivities(string UserId)
        {
            string InstagramUrl = "https://api.instagram.com/v1/users/" + UserId + "/media/recent/?client_id=" + ConfigurationManager.AppSettings["InstagramClientKey"];
            var Instagramlistpagerequest = (HttpWebRequest)WebRequest.Create(InstagramUrl);
            Instagramlistpagerequest.Method = "GET";
            Instagramlistpagerequest.Credentials = CredentialCache.DefaultCredentials;
            Instagramlistpagerequest.AllowWriteStreamBuffering = true;
            Instagramlistpagerequest.ServicePoint.Expect100Continue = false;
            Instagramlistpagerequest.PreAuthenticate = false;
            string outputface = string.Empty;
            try
            {
                using (var response = Instagramlistpagerequest.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        outputface = stream.ReadToEnd();
                    }
                }
            }
            catch (Exception e) { }
            return outputface;
        }
<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string getInstagramUserDetails(string UserId)
        {
            string InstagramUrl = "https://api.instagram.com/v1/users/" + UserId + "/?client_id=" + ConfigurationManager.AppSettings["InstagramClientKey"];
            var Instagramlistpagerequest = (HttpWebRequest)WebRequest.Create(InstagramUrl);
            Instagramlistpagerequest.Method = "GET";
            Instagramlistpagerequest.Credentials = CredentialCache.DefaultCredentials;
            Instagramlistpagerequest.AllowWriteStreamBuffering = true;
            Instagramlistpagerequest.ServicePoint.Expect100Continue = false;
            Instagramlistpagerequest.PreAuthenticate = false;
            string outputface = string.Empty;
            try
            {
                using (var response = Instagramlistpagerequest.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        outputface = stream.ReadToEnd();
                    }
                }
            }
            catch (Exception e) { }
            return outputface;
        }
        #endregion

        #region tumblr Logic
<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string TumblrSearch(string keyword)
        {
            string ret = string.Empty;
            string outputface = string.Empty;
            try
            {
                string key = ConfigurationManager.AppSettings["TumblrClientKey"];
                //TumblrAccountRepository tumaccrepo = new TumblrAccountRepository();
                //Domain.Socioboard.Domain.TumblrAccount TumComAcc = tumaccrepo.getTumblrAccountDetailsById(keyword);
                //if (TumComAcc != null && !string.IsNullOrEmpty(TumComAcc.tblrUserName))
                //{
                //    string TumblrSearchUrl = "http://api.tumblr.com/v2/blog/" + TumComAcc.tblrUserName + ".tumblr.com/posts/text?api_key=" + key + "&limit=10";
                //    var TumblrBlogpagerequest = (HttpWebRequest)WebRequest.Create(TumblrSearchUrl);
                //    TumblrBlogpagerequest.Method = "GET";
                //    try
                //    {
                //        using (var response = TumblrBlogpagerequest.GetResponse())
                //        {
                //            using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                //            {
                //                outputface = stream.ReadToEnd();
                //            }
                //        }
                //    }
                //    catch (Exception ex) { }
                //}
                //else
                //{
<<<<<<< HEAD
                string TumblrSearchUrl = string.Empty;
                if (keyword.Contains(".tumblr.com"))
                {
                    if (keyword.Contains("http://")) 
                    {
                        keyword = keyword.Remove(0, 7);
                    }
                     TumblrSearchUrl = "http://api.tumblr.com/v2/blog/" + keyword.Replace(" ", string.Empty) + "posts/text?api_key=" + key + "&limit=10";
                }
                else 
                {
                    TumblrSearchUrl = "http://api.tumblr.com/v2/blog/" + keyword.Replace(" ", string.Empty) + ".tumblr.com/posts/text?api_key=" + key + "&limit=10";                
                }
                var TumblrBlogpagerequest = (HttpWebRequest)WebRequest.Create(TumblrSearchUrl);
                TumblrBlogpagerequest.Method = "GET";
                try
                {
                    using (var response = TumblrBlogpagerequest.GetResponse())
                    {
                        using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                        {
                            outputface = stream.ReadToEnd();
                        }
                    }
                    JObject outputJson = JObject.Parse(outputface);
                    // Domain.Socioboard.Domain.TumblrAccount newtumbobj = new Domain.Socioboard.Domain.TumblrAccount();
                    //newtumbobj.tblrUserName = outputJson["response"]["blog"]["name"].ToString();
                    //TumblrAccountRepository.Add(newtumbobj);
                }
                catch (Exception ex) { }
                // }
=======
                    string TumblrSearchUrl = "http://api.tumblr.com/v2/blog/" + keyword.Replace(" ", string.Empty) + ".tumblr.com/posts/text?api_key=" + key + "&limit=10";
                    var TumblrBlogpagerequest = (HttpWebRequest)WebRequest.Create(TumblrSearchUrl);
                    TumblrBlogpagerequest.Method = "GET";
                    try
                    {
                        using (var response = TumblrBlogpagerequest.GetResponse())
                        {
                            using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                            {
                                outputface = stream.ReadToEnd();
                            }
                        }
                        JObject outputJson = JObject.Parse(outputface);
                       // Domain.Socioboard.Domain.TumblrAccount newtumbobj = new Domain.Socioboard.Domain.TumblrAccount();
                        //newtumbobj.tblrUserName = outputJson["response"]["blog"]["name"].ToString();
                        //TumblrAccountRepository.Add(newtumbobj);
                    }
                    catch (Exception ex) { }
               // }
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b

            }
            catch (Exception ex)
            {
                throw;
            }
            return outputface;
        }

        # endregion

        #region youtube Logic
<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string YoutubeSearch(string keyword)
        {
            string response = string.Empty;
            string Key = "AIzaSyCISaVFe_TJknn92J7xw2diFEi6Z_aroYE";
            //YoutubeAccountRepository ytAccrepo = new YoutubeAccountRepository();
            //Domain.Socioboard.Domain.YoutubeAccount ytAccount = ytAccrepo.getYoutubeAccountDetailsByUserName(keyword);
            //if (ytAccount != null && !string.IsNullOrEmpty(ytAccount.Ytusername))
            //{
            //    //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=" + part + "&maxResults=" + maxResults + "&q=" + keyword + "&key=" + accesstoken;
            //    //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=snippet,id&maxResults=20&q=" + keyword + "&key=" + Key;
            //    string RequestUrl = "https://www.googleapis.com/youtube/v3/channels?part=id,snippet,contentDetails,statistics,topicDetails,invideoPromotion&forUsername=" + ytAccount.Ytusername + "&key=" + Key;
            //    //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=snippet,id&q=" + ytAccount.Ytusername + "&type=channel&key=" + Key;
            //    var facebooklistpagerequest = (HttpWebRequest)WebRequest.Create(RequestUrl);
            //    facebooklistpagerequest.Method = "GET";
            //    try
            //    {
            //        using (var youtuberesponse = facebooklistpagerequest.GetResponse())
            //        {
            //            using (var stream = new StreamReader(youtuberesponse.GetResponseStream(), Encoding.GetEncoding(1252)))
            //            {
            //                response = stream.ReadToEnd();
            //            }
            //        }
            //    }
            //    catch (Exception e) { }
            //}
            //else
            //{
<<<<<<< HEAD
            //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=" + part + "&maxResults=" + maxResults + "&q=" + keyword + "&key=" + accesstoken;
            //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=snippet,id&q=" + ytAccount.Ytusername + "&type=channel&key=" + Key;
            string SearchList = YoutubeSearchList(keyword);
            string RequestUrl = "https://www.googleapis.com/youtube/v3/channels?part=id,snippet,contentDetails,statistics,topicDetails,invideoPromotion&forUsername=" + keyword + "&key=" + Key;

            try
            {
                JObject Listresult = JObject.Parse(SearchList);
                keyword = Listresult["items"][0]["id"]["channelId"].ToString();
                RequestUrl = "https://www.googleapis.com/youtube/v3/channels?part=id,snippet,contentDetails,statistics,topicDetails,invideoPromotion&id=" + keyword + "&key=" + Key;

            }
            catch (Exception eee) { }

            var facebooklistpagerequest = (HttpWebRequest)WebRequest.Create(RequestUrl);
            facebooklistpagerequest.Method = "GET";
            try
            {
                using (var youtuberesponse = facebooklistpagerequest.GetResponse())
                {
                    using (var stream = new StreamReader(youtuberesponse.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        response = stream.ReadToEnd();
                    }
                }
                //if (!response.StartsWith("["))
                //    response = "[" + response + "]";
                //JArray youtubechannels = JArray.Parse(response);
                //JObject resultPage = (JObject)youtubechannels[0];
                //Domain.Socioboard.Domain.YoutubeAccount ytnewacc = new Domain.Socioboard.Domain.YoutubeAccount();
                //ytnewacc.Ytusername = resultPage["items"][0]["snippet"]["title"].ToString();
                //ytnewacc.Ytuserid = resultPage["items"][0]["id"].ToString();
                //YoutubeAccountRepository.Add(ytnewacc);
            }
            catch (Exception e) { }
            //  }
=======
                //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=" + part + "&maxResults=" + maxResults + "&q=" + keyword + "&key=" + accesstoken;
                //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=snippet,id&q=" + ytAccount.Ytusername + "&type=channel&key=" + Key;
                string SearchList = YoutubeSearchList(keyword);
                string RequestUrl = "https://www.googleapis.com/youtube/v3/channels?part=id,snippet,contentDetails,statistics,topicDetails,invideoPromotion&forUsername=" + keyword + "&key=" + Key;

                try
                {
                    JObject Listresult = JObject.Parse(SearchList);
                    keyword = Listresult["items"][0]["id"]["channelId"].ToString();
                    RequestUrl = "https://www.googleapis.com/youtube/v3/channels?part=id,snippet,contentDetails,statistics,topicDetails,invideoPromotion&id=" + keyword + "&key=" + Key;

                }
                catch (Exception eee) { }

                var facebooklistpagerequest = (HttpWebRequest)WebRequest.Create(RequestUrl);
                facebooklistpagerequest.Method = "GET";
                try
                {
                    using (var youtuberesponse = facebooklistpagerequest.GetResponse())
                    {
                        using (var stream = new StreamReader(youtuberesponse.GetResponseStream(), Encoding.GetEncoding(1252)))
                        {
                            response = stream.ReadToEnd();
                        }
                    }
                    //if (!response.StartsWith("["))
                    //    response = "[" + response + "]";
                    //JArray youtubechannels = JArray.Parse(response);
                    //JObject resultPage = (JObject)youtubechannels[0];
                    //Domain.Socioboard.Domain.YoutubeAccount ytnewacc = new Domain.Socioboard.Domain.YoutubeAccount();
                    //ytnewacc.Ytusername = resultPage["items"][0]["snippet"]["title"].ToString();
                    //ytnewacc.Ytuserid = resultPage["items"][0]["id"].ToString();
                    //YoutubeAccountRepository.Add(ytnewacc);
                }
                catch (Exception e) { }
          //  }
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b


            return response;

        }



<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string YoutubeSearchList(string keyword)
        {
            string response = string.Empty;
            string Key = "AIzaSyCISaVFe_TJknn92J7xw2diFEi6Z_aroYE";

            //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=" + part + "&maxResults=" + maxResults + "&q=" + keyword + "&key=" + accesstoken;
            //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=snippet,id&maxResults=20&q=" + keyword + "&key=" + Key;
            //string RequestUrl = "https://www.googleapis.com/youtube/v3/channels?part=id,snippet,contentDetails,statistics,topicDetails,invideoPromotion&forUsername=" + ytAccount.Ytusername + "&key=" + Key;
            string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=snippet,id&q=" + keyword + "&type=channel&key=" + Key;
            var facebooklistpagerequest = (HttpWebRequest)WebRequest.Create(RequestUrl);
            facebooklistpagerequest.Method = "GET";
            try
            {
                using (var youtuberesponse = facebooklistpagerequest.GetResponse())
                {
                    using (var stream = new StreamReader(youtuberesponse.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        response = stream.ReadToEnd();
                    }
                }
            }
            catch (Exception e) { }
            return response;
        }

<<<<<<< HEAD

=======
        
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string YoutubeChannelPlayList(string ChannelId)
        {
            string Key = "AIzaSyCISaVFe_TJknn92J7xw2diFEi6Z_aroYE";
            //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=" + part + "&maxResults=" + maxResults + "&q=" + keyword + "&key=" + accesstoken;
            //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=snippet,id&maxResults=20&q=" + keyword + "&key=" + Key;
<<<<<<< HEAD
            string RequestUrl = "https://www.googleapis.com/youtube/v3/playlists?part=id,snippet,status,contentDetails,player&channelId=" + ChannelId + "&key=" + Key + "&maxResults=49";
=======
            string RequestUrl = "https://www.googleapis.com/youtube/v3/playlists?part=+id,snippet,status,contentDetails&channelId=" + ChannelId + "&key=" + Key;
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b

            var pagerequest = (HttpWebRequest)WebRequest.Create(RequestUrl);
            pagerequest.Method = "GET";
            string response = string.Empty;
            try
            {
                using (var youtuberesponse = pagerequest.GetResponse())
                {
                    using (var stream = new StreamReader(youtuberesponse.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        response = stream.ReadToEnd();
                    }
                }
            }
            catch (Exception e) { }
            return response;
        }
        #endregion

        #region gplus Loigic
        public string GooglePlus(string keyword)
        {
            string ret = string.Empty;
            try
            {
                string Key = "AIzaSyCISaVFe_TJknn92J7xw2diFEi6Z_aroYE";
                //AIzaSyCvTBnEDnr5DEpvlVDCuxz9K9TK84rX0fE
                //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=" + part + "&maxResults=" + maxResults + "&q=" + keyword + "&key=" + accesstoken;
                string RequestUrl = "https://www.googleapis.com/plus/v1/people?query=" + keyword + "&key=" + Key;

                var facebooklistpagerequest = (HttpWebRequest)WebRequest.Create(RequestUrl);
                facebooklistpagerequest.Method = "GET";
                string response = string.Empty;
                try
                {
                    using (var youtuberesponse = facebooklistpagerequest.GetResponse())
                    {
                        using (var stream = new StreamReader(youtuberesponse.GetResponseStream(), Encoding.GetEncoding(1252)))
                        {
                            response = stream.ReadToEnd();
                        }
                    }
                }
                catch (Exception e) { }

                return response;
            }
            catch (Exception ex)
            {

                throw;
            }

            //return ret;
        }

        //Google Plus
<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string GooglePlusSearch(string keyword)
        {
            //GooglePlusAccountRepository gpaccrepo = new GooglePlusAccountRepository();
            //Domain.Socioboard.Domain.GooglePlusAccount gpacc = null;
            //try
            //{
            //    gpacc = gpaccrepo.getUserDetailsByUserName(keyword);

            //}
            //catch (Exception ee) { }
            //if (gpacc != null)
            //{
            //    return GooglePlusgetUser(gpacc.GpUserId);
            //}
            //else
            {
                string ResultPage = string.Empty;
                string FirstResultPage = string.Empty;
                //bool Isfirst = true;
                try
                {
<<<<<<< HEAD
                    ResultPage = GooglePlusgetUser(keyword);
                    if (!string.IsNullOrEmpty(ResultPage)) 
                    {
                        return ResultPage;
                    }
=======
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
                    JObject PageList = JObject.Parse(GooglePlusList(keyword));
                    foreach (JObject item in PageList["items"])
                    {
                        if (item["objectType"].ToString().Equals("page"))
                        {
                            try
                            {
                                FirstResultPage = GooglePlusgetUser(item["id"].ToString());
                                JObject jobjrpage = JObject.Parse(FirstResultPage);
                                if (jobjrpage["verified"].ToString().Equals("True"))
                                {
                                    ResultPage = GooglePlusgetUser(item["id"].ToString());
                                    break;
                                }
                            }
                            catch (Exception e) { }

                            //TODO: write exact page refine logic
                        }
                    }
                    //JObject jobjresult = JObject.Parse(ResultPage);
                    //if (gpacc == null)
                    //{
                    //    try
                    //    {
                    //        gpacc = gpaccrepo.getUserDetailsByUserName(jobjresult["displayName"].ToString());

                    //    }
                    //    catch (Exception eeee) { }
                    //}
                    //if (gpacc == null)
                    //{
                    //    Domain.Socioboard.Domain.GooglePlusAccount newgplusacc = new Domain.Socioboard.Domain.GooglePlusAccount();
                    //    newgplusacc.GpUserId = jobjresult["id"].ToString();
                    //    newgplusacc.GpUserName = jobjresult["displayName"].ToString();
                    //    newgplusacc.EntryDate = DateTime.Now;
                    //    gpaccrepo.addGooglePlusUser(newgplusacc);
                    //}
                }
                catch (Exception e) { }

                return ResultPage;
            }

        }

<<<<<<< HEAD

=======
        
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string GooglePlusList(string keyword)
        {
            string ret = string.Empty;
            try
            {
                string Key = "AIzaSyCISaVFe_TJknn92J7xw2diFEi6Z_aroYE";
                //AIzaSyCvTBnEDnr5DEpvlVDCuxz9K9TK84rX0fE
                //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=" + part + "&maxResults=" + maxResults + "&q=" + keyword + "&key=" + accesstoken;
                string RequestUrl = "https://www.googleapis.com/plus/v1/people?query=" + keyword + "&key=" + Key;

                var facebooklistpagerequest = (HttpWebRequest)WebRequest.Create(RequestUrl);
                facebooklistpagerequest.Method = "GET";
                string response = string.Empty;
                try
                {
                    using (var youtuberesponse = facebooklistpagerequest.GetResponse())
                    {
                        using (var stream = new StreamReader(youtuberesponse.GetResponseStream(), Encoding.GetEncoding(1252)))
                        {
                            response = stream.ReadToEnd();

                        }
                    }
                }
                catch (Exception e) { }

                return response;
            }
            catch (Exception ex)
            {

                throw;
            }

            //return ret;
        }

<<<<<<< HEAD

=======
       
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string GooglePlusgetUser(string UserId)
        {
            string ret = string.Empty;
            string response = string.Empty;

            try
            {
                string Key = "AIzaSyCISaVFe_TJknn92J7xw2diFEi6Z_aroYE";
                //AIzaSyCvTBnEDnr5DEpvlVDCuxz9K9TK84rX0fE
                //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=" + part + "&maxResults=" + maxResults + "&q=" + keyword + "&key=" + accesstoken;
                string RequestUrl = "https://www.googleapis.com/plus/v1/people/" + UserId + "?key=" + Key;

                var facebooklistpagerequest = (HttpWebRequest)WebRequest.Create(RequestUrl);
                facebooklistpagerequest.Method = "GET";
                try
                {
                    using (var youtuberesponse = facebooklistpagerequest.GetResponse())
                    {
                        using (var stream = new StreamReader(youtuberesponse.GetResponseStream(), Encoding.GetEncoding(1252)))
                        {
                            response = stream.ReadToEnd();

                        }
                    }
                }
                catch (Exception e) { }

            }
            catch (Exception ex)
            {
            }
            return response;


            //return ret;
        }

<<<<<<< HEAD

=======
        
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        public string GooglePlusgetUserRecentActivities(string UserId)
        {
            string ret = string.Empty;
            string response = string.Empty;

            try
            {
                string Key = "AIzaSyCISaVFe_TJknn92J7xw2diFEi6Z_aroYE";
                //AIzaSyCvTBnEDnr5DEpvlVDCuxz9K9TK84rX0fE
                //string RequestUrl = "https://www.googleapis.com/youtube/v3/search?part=" + part + "&maxResults=" + maxResults + "&q=" + keyword + "&key=" + accesstoken;
<<<<<<< HEAD
                string RequestUrl = "https://www.googleapis.com/plus/v1/people/" + UserId + "/activities/public/?key=" + Key + "&maxResults=99";
=======
                string RequestUrl = "https://www.googleapis.com/plus/v1/people/" + UserId + "/activities/public/?key=" + Key;
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b

                var gpluspagerequest = (HttpWebRequest)WebRequest.Create(RequestUrl);
                gpluspagerequest.Method = "GET";
                try
                {
                    using (var gplusresponse = gpluspagerequest.GetResponse())
                    {
                        using (var stream = new StreamReader(gplusresponse.GetResponseStream(), Encoding.GetEncoding(1252)))
                        {
                            response = stream.ReadToEnd();

                        }
                    }
                }
                catch (Exception e) { }

            }
            catch (Exception ex)
            {
            }
            return response;


            //return ret;
        }

        #endregion
<<<<<<< HEAD








=======
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
    }
}
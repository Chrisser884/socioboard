using Api.Socioboard.Model;
using log4net;
<<<<<<< HEAD
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
=======
using System;
using System.Collections.Generic;
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
<<<<<<< HEAD
using System.Xml;
=======
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b

namespace Api.Socioboard.Services
{
    /// <summary>
    /// Summary description for CompanyDashboard
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CompanyDashboard : System.Web.Services.WebService
    {

        ILog logger = LogManager.GetLogger(typeof(CompanyDashboard));
<<<<<<< HEAD
        // Domain.Socioboard.Domain.facebookpageevents ObjFbPageEvent = new Domain.Socioboard.Domain.facebookpageevents();
        private Companypage companypage = new Companypage();
        private CompanySocialProfilesRepository ObjCompanySocialProfilesRepository = new CompanySocialProfilesRepository();
        private Domain.Socioboard.Domain.CompanyProfiles ObjCompanyProfiles = new Domain.Socioboard.Domain.CompanyProfiles();
=======
       // Domain.Socioboard.Domain.facebookpageevents ObjFbPageEvent = new Domain.Socioboard.Domain.facebookpageevents();
        CompanySocialProfilesRepository ObjCompanySocialProfilesRepository = new CompanySocialProfilesRepository();
        Domain.Socioboard.Domain.CompanyProfiles ObjCompanyProfiles = new Domain.Socioboard.Domain.CompanyProfiles();
       // facebookPageInfoRepository ObjfacebookPageInfoRepository = new facebookPageInfoRepository();
        //Domain.Socioboard.Domain.facebookpageinfo Objfacebookpageinfo = new Domain.Socioboard.Domain.facebookpageinfo();
        //TwitterPageRepository ObjTwitterPageRepository = new TwitterPageRepository();
       // Domain.Socioboard.Domain.twitterpage Objtwitterpage = new Domain.Socioboard.Domain.twitterpage();
       // LinkedinPageRepository ObjLinkedinPageRepository = new LinkedinPageRepository();
       // GooglePlusInfoRepository ObjGooglePlusInfoRepository = new GooglePlusInfoRepository();
        //InstagramPageRepository ObjInstagramPageRepository = new InstagramPageRepository();
        //YoutubePageRepository ObjYoutubePageRepository = new YoutubePageRepository();

>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b



        [WebMethod]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
<<<<<<< HEAD
        public string getAllCompanyNames()
=======
        public string getAllCompanyNames() 
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
        {
            string output = string.Empty;
            try
            {
                List<string> companyNames = ObjCompanySocialProfilesRepository.getCompanyNames();
                return new JavaScriptSerializer().Serialize(companyNames);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
                return "Something Went Wrong";
            }
        }

<<<<<<< HEAD
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public Domain.Socioboard.Domain.CompanyProfiles AddCompanyInfo(string name)
        {
            string ret = string.Empty;
            Domain.Socioboard.Domain.CompanyProfiles companyProfile = new Domain.Socioboard.Domain.CompanyProfiles();
            companyProfile.Companyname = name;
            try
            {
                companyProfile.Fbprofileid = Getfbpage(name);
            }
            catch (Exception e) { }


            try
            {
                companyProfile.Instagramprofileid = GetInstagramPage(name);
            }
            catch (Exception e)
            {
            }
            try
            {
                companyProfile.Linkedinprofileid = GetLinkedinPage(name);
                //companyProfile.LinkedinProfileId = string.Empty;
            }
            catch (Exception e)
            {

                // throw;
            }
            try
            {
                companyProfile.Tumblrprofileid = GetTumblrPage(name);
            }
            catch (Exception e)
            {

                //throw;
            }
            try
            {
                companyProfile.Twitterprofileid = GetTwitterPage(name);
            }
            catch
            {
            }
            try
            {
                companyProfile.Youtubeprofileid = GetYoutubeChannel(name);
            }
            catch (Exception e)
            {

                //throw;
            }
            try
            {
                companyProfile.Gplusprofileid = GetGplusPage(name);
            }
            catch (Exception e)
            {

            }
            //try
            //{
            //    companyProfile.UserId = Guid.NewGuid().ToString();
=======
        [WebMethod]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public string AddCompanyInfo(string name)
        {
            string ret = string.Empty;
            Domain.Socioboard.Domain.CompanyProfiles companyProfile = new Domain.Socioboard.Domain.CompanyProfiles();
            companyProfile.CompanyName = name;
            companyProfile.FbProfileId = "2356418";

            //try
            //{
            //    companyProfile.Id = Guid.Parse("0x7014C11B81087847B94B4E3A12EE97D1");
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
<<<<<<< HEAD
            companyProfile.Id = Guid.NewGuid();
            ObjCompanySocialProfilesRepository.AddcompanyProfileName(companyProfile);
            return companyProfile;
        }


        //Suresh
        #region  get company information from table
        [WebMethod]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public string getCompanyProfile(string keyword)
        {
            string output = string.Empty;
            Domain.Socioboard.Domain.CompanyProfiles companyProfile = new Domain.Socioboard.Domain.CompanyProfiles();
            try
            {
                Domain.Socioboard.Domain.CompanyProfiles objCompanyName = ObjCompanySocialProfilesRepository.SearchCompanyName(keyword);
                companyProfile.Userid = objCompanyName.Userid;
                companyProfile.Id = objCompanyName.Id;
                companyProfile.Companyname = objCompanyName.Companyname;
                try
                {
                    companyProfile.Fbprofileid = Getfbpage(objCompanyName.Fbprofileid);
                }
                catch (Exception e) { }



                if (!string.IsNullOrEmpty(objCompanyName.Instagramprofileid))
                {
                    try
                    {
                        companyProfile.Instagramprofileid = GetInstagramPage(objCompanyName.Instagramprofileid);
                    }
                    catch (Exception e)
                    {
                    }
                }
                if (!string.IsNullOrEmpty(objCompanyName.Linkedinprofileid))
                {
                    try
                    {
                        companyProfile.Linkedinprofileid = GetLinkedinPage(objCompanyName.Linkedinprofileid);
                        //companyProfile.LinkedinProfileId = string.Empty;
                    }
                    catch (Exception e)
                    {

                        // throw;
                    }
                }
                if (!string.IsNullOrEmpty(objCompanyName.Tumblrprofileid))
                {
                    try
                    {
                        companyProfile.Tumblrprofileid = GetTumblrPage(objCompanyName.Tumblrprofileid);
                    }
                    catch (Exception e)
                    {

                        //throw;
                    }
                }
                if (!string.IsNullOrEmpty(objCompanyName.Twitterprofileid))
                {
                    try
                    {
                        companyProfile.Twitterprofileid = GetTwitterPage(objCompanyName.Twitterprofileid);
                    }
                    catch
                    {
                    }
                }
                if (!string.IsNullOrEmpty(objCompanyName.Youtubeprofileid))
                {
                    try
                    {
                        companyProfile.Youtubeprofileid = GetYoutubeChannel(objCompanyName.Youtubeprofileid);
                    }
                    catch (Exception e)
                    {

                        //throw;
                    }
                }

                if (!string.IsNullOrEmpty(objCompanyName.Gplusprofileid))
                {
                    try
                    {
                        companyProfile.Gplusprofileid = GetGplusPage(objCompanyName.Gplusprofileid);
                    }
                    catch (Exception e)
                    {


                    }
                }
                return new JavaScriptSerializer().Serialize(companyProfile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return "Something Went Wrong";
            }
        }

=======
            companyProfile.InstagramProfileId = string.Empty;
            companyProfile.LinkedinProfileId = string.Empty;
            companyProfile.TumblrProfileId = string.Empty;
            companyProfile.TwitterProfileId = string.Empty;
            companyProfile.YoutubeProfileId = string.Empty;
            companyProfile.GPlusProfileId = string.Empty;
            try
            {
                companyProfile.UserId = Guid.Parse("0xDFBD9BD7AB3D95448B807395E38F5C4C");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            ObjCompanySocialProfilesRepository.AddcompanyProfileName(companyProfile);
            return ret;
        }
        ////Anjani Choubey
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public bool addFbPageInfo(Domain.Socioboard.Domain.facebookpageinfo fbpageinfo) 
        //{
        //    bool output = false;
        //    try
        //    {
        //       output =  ObjfacebookPageInfoRepository.AddFbPageCompanyInfo(fbpageinfo);
               
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex.StackTrace);
        //        output = false;
        //    }
        //    return output;
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public bool AddTwitterPageInfo(Domain.Socioboard.Domain.twitterpage TwitterPageInfo)
        //{
        //    bool ret = false;
        //    try
        //    {
        //        ret = ObjTwitterPageRepository.AddTwitterPageInfo(TwitterPageInfo);
                
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex.StackTrace);
        //        ret = false;
        //    }
        //    return ret;
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public bool AddLinkedinPageInfo(Domain.Socioboard.Domain.linkedinpage LinkedinPageInfo)
        //{
        //    bool ret = false;
        //    try
        //    {
        //        ret = ObjLinkedinPageRepository.AddLinkedinPageInfo(LinkedinPageInfo);

        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex.StackTrace);
        //        ret = false;
        //    }
        //    return ret;
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public bool AddInstagramPageInfo(Domain.Socioboard.Domain.instagrampage InstagramPageInfo)
        //{
        //    bool ret = false;
        //    try
        //    {
        //        ret = ObjInstagramPageRepository.AddInstagramPageInfo(InstagramPageInfo);

        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex.StackTrace);
        //        ret = false;
        //    }
        //    return ret;
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public bool AddGPlusPageInfo(Domain.Socioboard.Domain.googleplusinfo GPlusPageInfo)
        //{
        //    bool ret = false;
        //    try
        //    {
        //        ret = ObjGooglePlusInfoRepository.AddGPlusCompanyInfo(GPlusPageInfo);

        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex.StackTrace);
        //        ret = false;
        //    }
        //    return ret;
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public bool AddYoutubePageInfo(Domain.Socioboard.Domain.youtubepage YoutubePageInfo)
        //{
        //    bool ret = false;
        //    try
        //    {
        //        ret = ObjYoutubePageRepository.AddYoutubePageInfo(YoutubePageInfo);

        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex.StackTrace);
        //        ret = false;
        //    }
        //    return ret;
        //}
        ////Anjani Choubey

        //Suresh
        //#region  get company information from table
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b

        [WebMethod]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public string SearchCompanyProfile(string keyword)
        {
            string output = string.Empty;

            try
            {
                Domain.Socioboard.Domain.CompanyProfiles objCompanyName = ObjCompanySocialProfilesRepository.SearchCompanyName(keyword);
<<<<<<< HEAD
                if (objCompanyName == null)
                {
                    objCompanyName = AddCompanyInfo(keyword);
                }
=======

>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
                return new JavaScriptSerializer().Serialize(objCompanyName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return "Something Went Wrong";
            }
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public string GetCompanyProfile(string id)
        {
            string output = string.Empty;
            try
            {
                Domain.Socioboard.Domain.CompanyProfiles objCompanyProfiles = ObjCompanySocialProfilesRepository.getCompanyProfiles(Guid.Parse(id));

                return new JavaScriptSerializer().Serialize(objCompanyProfiles);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
                return "Something Went Wrong";
            }
        }
<<<<<<< HEAD


        public string Getfbpage(string id)
        {
            string output = string.Empty;
            try
            {

                JObject fbPage = JObject.Parse(companypage.SearchFacebookPage(id));
                output = fbPage["id"].ToString();
            }
            catch { }
            return output;
        }


        public string GetTwitterPage(string id)
        {
            string output = string.Empty;
            try
            {
                JObject twitterPage = JObject.Parse(companypage.TwitterSearch(id));
                output = twitterPage["screen_name"].ToString();
            }
            catch { }
            return output;

        }


        public string GetLinkedinPage(string id)
        {
            string output = string.Empty;
            try
            {

                XmlNode ResultCompany = null;
                int followers = 0;
                string result = string.Empty;
                result = companypage.LinkedinSearch(id);
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



                output = ResultCompany.SelectSingleNode("universal-name").InnerText;
            }
            catch { }
            return output;
        }






        public string GetInstagramPage(string id)
        {
            string output = string.Empty;
            try
            {
                JObject instagramPage = JObject.Parse(companypage.getInstagramCompanyPage(id));


                output = instagramPage["data"]["username"].ToString();


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
                // return "Something Went Wrong";
            }
            return output;

        }



        public string GetTumblrPage(string id)
        {
            string output = string.Empty;
            try
            {
                JObject tumblrPage = JObject.Parse(companypage.TumblrSearch(id));
                output = tumblrPage["response"]["blog"]["url"].ToString();
            }
            catch { }
            return output;

        }










        public string GetGplusPage(string id)
        {
            string output = string.Empty;

            JObject GplusPage = JObject.Parse(companypage.GooglePlusSearch(id));
            try
            {

                output = GplusPage["id"].ToString();
            }
            catch (Exception e) { }

            return output;

        }






        public string GetYoutubeChannel(string id)
        {

            string result = string.Empty;
            result = companypage.YoutubeSearch(id);
            if (!result.StartsWith("["))
                result = "[" + result + "]";
            JArray youtubechannels = JArray.Parse(result);
            JObject resultPage = (JObject)youtubechannels[0];
            JObject YtubeChannel = (JObject)resultPage["items"][0];
            try
            {
                result = YtubeChannel["id"].ToString();
            }
            catch (Exception e) { }
            return result;

        }




        # endregion
=======
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public string Getfbpage(Guid id)
        //{
        //    string output = string.Empty;
        //    try
        //    {
        //        Domain.Socioboard.Domain.facebookpageinfo objFbPage = ObjfacebookPageInfoRepository.getFbPageInfo(id);
               
        //        return new JavaScriptSerializer().Serialize(objFbPage);
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.StackTrace);
        //        return "Something Went Wrong";
        //    }
            
            
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public string GetTwitterPage(Guid id)
        //{
        //    string output = string.Empty;
        //    try
        //    {
        //        Domain.Socioboard.Domain.twitterpage  objTwitterPage = ObjTwitterPageRepository.getTwitterPageInfo(id);
                
        //        return new JavaScriptSerializer().Serialize(objTwitterPage);
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.StackTrace);
        //        return "Something Went Wrong";
        //    }
            
            
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public string GetLinkedinPage(Guid id)
        //{
        //    string output = string.Empty;
        //    try
        //    {
        //        Domain.Socioboard.Domain.linkedinpage objLinkedinPage =ObjLinkedinPageRepository.getLinkedinPageInfo(id);

        //        return new JavaScriptSerializer().Serialize(objLinkedinPage);
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.StackTrace);
        //        return "Something Went Wrong";
        //    }
           
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public string GetTumblrPage(Guid id)
        //{
        //    string output = string.Empty;

        //    //TODO: logic to retrive tumblr of company
        //    return output;
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public string GetGplusPage(Guid id)
        //{
        //    string output = string.Empty;
        //    try
        //    {
        //        Domain.Socioboard.Domain.googleplusinfo  ObjGplusInfo= ObjGooglePlusInfoRepository.getGooglePlusPageInfo(id);

        //        return new JavaScriptSerializer().Serialize(ObjGplusInfo);
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.StackTrace);
        //        return "Something Went Wrong";
        //    }
            
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public string GetYoutubePage(Guid id)
        //{
        //    string output = string.Empty;

        //    try
        //    {
        //        Domain.Socioboard.Domain.youtubepage ObjYoutubePage = ObjYoutubePageRepository.getYoutubePageInfo(id);
        //        return new JavaScriptSerializer().Serialize(ObjYoutubePage);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.StackTrace);
        //        return "Something Went Wrong";
        //    }
        //}
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        //public string GetInstagramPage(Guid id)
        //{
        //    string output = string.Empty;

        //    try
        //    {
        //        Domain.Socioboard.Domain.instagrampage ObjInstagramPage = ObjInstagramPageRepository.getInstagramPageInfo(id);
        //        return new JavaScriptSerializer().Serialize(ObjInstagramPage);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.StackTrace);
        //        return "Something Went Wrong";
        //    }
        //}
        //#endregion


>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b

        #region insert data to tables


        # endregion
        //Suresh 

    }
}

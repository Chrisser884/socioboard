﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using Socioboard.App_Start;

namespace Socioboard.Controllers
{
    [Authorize]
    [CustomAuthorize]
<<<<<<< HEAD
    public class InstagramManagerController : BaseController
=======
    public class InstagramManagerController : Controller
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
    {
        ILog logger = LogManager.GetLogger(typeof(InstagramManagerController));
        //
        // GET: /InstagramManager/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Instagram()
        {
            string AddTwitterAccount = string.Empty;
            Domain.Socioboard.Domain.User objUser = (Domain.Socioboard.Domain.User)Session["User"];
            string code = (String)Request.QueryString["code"];

            Api.Instagram.Instagram apiobjInstagram = new Api.Instagram.Instagram();
            try
            {
                AddTwitterAccount = apiobjInstagram.AddInstagramAccount(ConfigurationManager.AppSettings["consumerKey"], ConfigurationManager.AppSettings["consumerSecret"], ConfigurationManager.AppSettings["callbackurl"], objUser.Id.ToString(), Session["group"].ToString(), code);
                Session["SocialManagerInfo"] = AddTwitterAccount;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (Session["SocialManagerInfo"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
        
        public ActionResult AuthenticateInstagram()
        {
            try
            {
                try
                {
                    Api.Groups.Groups objApiGroups = new Api.Groups.Groups();
                    JObject group = JObject.Parse(objApiGroups.GetGroupDetailsByGroupId(Session["group"].ToString().ToString()));
                    int profilecount = 0;
                    int totalaccount = 0;
                    try
                    {
                        profilecount = (Int16)(Session["ProfileCount"]);
                        totalaccount = (Int16)Session["TotalAccount"];
                    }
                    catch (Exception ex)
                    {
                        logger.Error("ex.Message : " + ex.Message);
                        logger.Error("ex.StackTrace : " + ex.StackTrace);
                    }

                    if (Convert.ToString(group["GroupName"]) == ConfigurationManager.AppSettings["DefaultGroupName"].ToString())
                    {
                        if (profilecount < totalaccount)
                        {
                            Api.Instagram.Instagram ApiobjInstagram = new Api.Instagram.Instagram();
                            string redirecturl = ApiobjInstagram.GetInstagramRedirectUrl(ConfigurationManager.AppSettings["InstagramClientKey"], ConfigurationManager.AppSettings["InstagramClientSec"], ConfigurationManager.AppSettings["InstagramCallBackURL"]);
                            Response.Redirect(redirecturl);
                        }
                        else if (profilecount == 0 || totalaccount == 0)
                        {
                            Api.Instagram.Instagram ApiobjInstagram = new Api.Instagram.Instagram();
                            string redirecturl = ApiobjInstagram.GetInstagramRedirectUrl(ConfigurationManager.AppSettings["InstagramClientKey"], ConfigurationManager.AppSettings["InstagramClientSec"], ConfigurationManager.AppSettings["InstagramCallBackURL"]);
                            Response.Redirect(redirecturl);
                        }
                        else
                        {
                            //return JavaScript("alert(\"You can't add more than "+ totalaccount +" account!\")");
                            Response.Redirect("../Home/Index");
                        }
                    }
                    else
                    {
                        Response.Redirect("../Home/Index");
                    }
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
            }
            return View();
        }



    }
}

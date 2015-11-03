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
    public class TumblrManagerController : BaseController
=======
    public class TumblrManagerController : Controller
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
    {
        ILog logger = LogManager.GetLogger(typeof(TumblrManagerController));
        //
        // GET: /TumblrManager/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Tumblr()
        {
            Domain.Socioboard.Domain.User objUser = (Domain.Socioboard.Domain.User)Session["User"];
            string code = Request.QueryString["oauth_verifier"];
            Api.Tumblr.Tumblr ApiobjTumblr = new Api.Tumblr.Tumblr();
            string AddTumblrAccount = ApiobjTumblr.AddTumblrAccount(ConfigurationManager.AppSettings["TumblrClientKey"], ConfigurationManager.AppSettings["TumblrClientSec"], ConfigurationManager.AppSettings["TumblrCallBackURL"], objUser.Id.ToString(), Session["group"].ToString(), code);
            Session["SocialManagerInfo"] = AddTumblrAccount;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AuthenticateTumblr()
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
                            Api.Tumblr.Tumblr ApiobjTumblr = new Api.Tumblr.Tumblr();
                            string redircturl = ApiobjTumblr.GetTumblrRedirectUrl(ConfigurationManager.AppSettings["TumblrClientKey"], ConfigurationManager.AppSettings["TumblrClientSec"], ConfigurationManager.AppSettings["TumblrCallBackURL"]);
                            Response.Redirect(redircturl);
                        }
                        else if (profilecount == 0 || totalaccount == 0)
                        {
                            Api.Tumblr.Tumblr ApiobjTumblr = new Api.Tumblr.Tumblr();
                            string redircturl = ApiobjTumblr.GetTumblrRedirectUrl(ConfigurationManager.AppSettings["TumblrClientKey"], ConfigurationManager.AppSettings["TumblrClientSec"], ConfigurationManager.AppSettings["TumblrCallBackURL"]);
                            Response.Redirect(redircturl);
                        }
                        else
                        {
                            Response.Redirect("../Home/Index");
                        }
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

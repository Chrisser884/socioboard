﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Socioboard.Domain;
using Socioboard.Helper;
using Socioboard.App_Start;
using System.IO;
using System.Text.RegularExpressions;
<<<<<<< HEAD
using System.Web.Script.Serialization;

namespace Socioboard.Controllers
{
  
    [CustomAuthorize]
    public class PersonalSettingController : BaseController
=======

namespace Socioboard.Controllers
{
    [Authorize]
    [CustomAuthorize]
    public class PersonalSettingController : Controller
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
    {
        //
        // GET: /PersonalSetting/

        public ActionResult Index()
        {
            if (Session["Paid_User"] != null && Session["Paid_User"].ToString() == "Unpaid")
            {
                return RedirectToAction("Billing", "PersonalSetting");
            }
            else
            {
                return View();
            }
            //return View();
        }
        public ActionResult LoadPersonalSetting()
        {
              User objUser = (User)Session["User"];
              return PartialView("_PersonalSettingPartial", objUser);
        }
        //vikash [20/11/2014]
        public ActionResult Billing()
        {
            return View();
        }
        public ActionResult LoadBillingPartial()
        {
            User objUser = (User)Session["User"];
            return PartialView("_BillingPartial", objUser);
        }
        public ActionResult EditUserInfo(string id,string fname,string lname,string email,string dt)
        {
            var fi = Request.Files["file"];
            string file = string.Empty;
            if (Request.Files.Count > 0)
            {
                if (fi != null)
                {
                    var path = Server.MapPath("~/Themes/" + System.Configuration.ConfigurationManager.AppSettings["domain"] + "/Contents/img/user_img");

                    // var path = System.Configuration.ConfigurationManager.AppSettings["MailSenderDomain"]+"Contents/img/upload";
                    file = path + "\\" + fi.FileName;
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    fi.SaveAs(file);
                    path = path + "\\" + fi.FileName;
                    file = file.Replace("\\", "/");
                }
            }
              User objUser = (User)Session["User"];
              Api.User.User ApiobjUser = new Api.User.User();
              string ret = ApiobjUser.UpdateUser(id, fname, lname, dt, file);
              if (ret == "1")
              {
                  objUser.UserName = fname + " " + lname;
                  objUser.TimeZone = dt;
                  objUser.ProfileUrl = file;
                  Session["User"] = objUser;
              }
              return Content(ret);
        }

        //Modified by Sumit Gupta [31-01-15]
        public ActionResult ChangePassword(string id, string oldpass, string newpass, string confirmpass)
        {
            User objUser = (User)Session["User"];
            Api.User.User ApiobjUser = new Api.User.User();
            //UserRepository userrepo = new UserRepository();
            //Domain.Socioboard.Domain.User user = ApiobjUser.getUserInfoByEmail(;
            string user = ApiobjUser.getUserInfoByEmail(id);
            string ret = string.Empty;
            if (newpass.Equals(confirmpass))
            {
                //Modified by Sumit Gupta [31-01-15]
                ret = ApiobjUser.ChangePassword(id, oldpass, newpass);
                //ret = ApiobjUser.ChangePasswordWithoutOldPassword(id, "", newpass);
            }
            else
            {
                ret = "New Password and Confirm Password mismatch";
            }
            //string ret = ApiobjUser.UpdateUser(id, fname, lname, dt);
            //if (ret == "1")
            //{
            //    objUser.UserName = fname + " " + lname;
            //    objUser.TimeZone = dt;
            //    Session["User"] = objUser;
            //}
            return Content(ret);
        }
        // Edited by Antima
        public ActionResult ConfirmPassword(string CnfrmPassword)
        {
            User objUser = (User)Session["User"];
            string Password = SBUtils.MD5Hash(CnfrmPassword);
            string ret = string.Empty;
            if (objUser.Password == Password)
            {
                ret = "Password Confirm";
            }
            else
	        {
                ret = "Password Not Match";
	        }
            return Content(ret);
        }

        public ActionResult CheckEmailIdExist(string newEmailId)
        {
             User objUser = (User)Session["User"];
             Api.User.User ApiobjUser = new Api.User.User();
             Api.MailSender.MailSender ApiobjMailSender = new Api.MailSender.MailSender();
             string ret = string.Empty;
             string mailsender = "";
             ret = ApiobjUser.CheckEmailId(newEmailId); 
            if (ret == "NotExist")
	         {
		      string strRandomUnique = SBUtils.GenerateRandomUniqueString();

              string res_UpdateChangePasswordKey = ApiobjUser.UpdateResetEmailKey(objUser.Id.ToString(), strRandomUnique);
              if (res_UpdateChangePasswordKey == "1")
              {
                  TempData["NewEmailId"] = newEmailId;
                  TempData.Keep("NewEmailId");
                  ViewBag.NewEmailId = newEmailId;
                  objUser.ChangeEmailKey = strRandomUnique;
              }
              Session["User"] = objUser;
              var mailBody = Helper.SBUtils.RenderViewToString1(this.ControllerContext, this.TempData, "_EmailChangeMailBodyPartial", objUser);
              string Subject = "Socioboard";

              mailsender = ApiobjMailSender.SendChangePasswordMail(newEmailId, mailBody, Subject);
              return Content("Mail Send Successfully");
	         }
            else
	         {
                return Content("EmailId already Exist");
	         }
        }

        public ActionResult ResetEmailId(string code,string newEmailId) 
        {
            try
            {
                User objUser = (User)Session["User"];
                Api.User.User ApiobjUser = new Api.User.User();
                string groupid = Session["group"].ToString();
                string ret = string.Empty;
                string IskeyUsed = string.Empty;
                if (objUser.IsKeyUsed == 0 || objUser.IsKeyUsed == null)
                {
                    ret = ApiobjUser.UpdateEmailId(objUser.Id.ToString(), groupid, newEmailId);
                    if (ret == "Updated Successfully")
                    {
                        IskeyUsed = ApiobjUser.UpdateIsEmailKeyUsed(objUser.Id.ToString(), code);
                        objUser.IsKeyUsed = int.Parse(IskeyUsed);
                        objUser.EmailId = newEmailId;
                        Session["User"] = objUser;
                    }
                }
                
                return Content(ret);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Content("SomethingWentWrong");
            }
        }
        

        public ActionResult PaypalUpgradePlan(string UpgradeType)
        {
            string pay = "";
            string amount = "";
            try
            {
                Api.User.User ApiobjUser = new Api.User.User();
                User objUser = (User)Session["User"];
                Helper.Payment payme = new Payment();

                if (UpgradeType == "MonthlyUpgrade")
                {
                    amount = "99.99";
                }
                else
                {
                    amount = "1199.88";
                }
                Session["PaymentAmount"] = amount;
                Session["UpgradeType"] = UpgradeType;
                Session["Ewallet"] = "0";
                string ewallet = objUser.Ewallet;
                if (float.Parse(ewallet) > 0)
                {
                    if (float.Parse(ewallet) >= float.Parse(amount))
                    {
                        ewallet = (float.Parse(ewallet) - float.Parse(amount)).ToString();
                        Session["Ewallet"] = ewallet.ToString();
                        //int ret = ApiobjUser.UpdatePaymentandEwalletStatusByUserId(objUser.Id.ToString(), ewallet, objUser.AccountType, "paid");
                        PaymentSuccessful();
                        amount = "0";
                        pay = "success";
                       
                    }
                    else {
                        amount = (float.Parse(amount) - float.Parse(ewallet)).ToString();
                    }
                }

                if (amount != "0")
                {
                    string AccountType = objUser.AccountType;
                    string UserName = objUser.UserName;
                    string EmailId = objUser.EmailId;

                    string UpgradePlanSuccessURL = ConfigurationManager.AppSettings["UpgradePlanSuccessURL"];
                    string UpgradePlanFailedURL = ConfigurationManager.AppSettings["UpgradePlanFailedURL"];
                    string UpgradePlanpaypalemail = ConfigurationManager.AppSettings["UpgradePlanpaypalemail"];
                    string userId = objUser.Id.ToString();

                    pay = payme.PayWithPayPal(amount, AccountType, UserName, "", EmailId, "USD", UpgradePlanpaypalemail, UpgradePlanSuccessURL,
                                            UpgradePlanFailedURL, UpgradePlanSuccessURL, "", "", userId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return Content(pay);
        }

        public ActionResult PaymentSuccessful()
        {
            User objUser = (User)Session["User"];
            objUser.PaymentStatus = "Paid";
            string paidamount = (string)Session["PaymentAmount"];
            string UpgradeType = (string)Session["UpgradeType"];

            Api.User.User ApiobjUser = new Api.User.User();
    
            if (DateTime.Compare(objUser.ExpiryDate, DateTime.Now) > 0)
            {
                if (UpgradeType == "MonthlyUpgrade")
                {
                    objUser.ExpiryDate = objUser.ExpiryDate.AddDays(30);
                }
                else if (UpgradeType == "YearlyUpgrade")
                {
                    objUser.ExpiryDate = objUser.ExpiryDate.AddDays(365);
                } 
            }
            else
            {
                if (UpgradeType == "MonthlyUpgrade")
                {
                    objUser.ExpiryDate = DateTime.Now.AddDays(30);
                }
                else if (UpgradeType == "YearlyUpgrade")
                {
                    objUser.ExpiryDate = DateTime.Now.AddDays(365);
                } 
            }

            //Change Payment status to 1
            ApiobjUser.changePaymentStatus(objUser.Id.ToString(), "paid");

            //Update Paymenttransaction table
            Api.PaymentTransaction.PaymentTransaction objApiPaymentTransaction = new Api.PaymentTransaction.PaymentTransaction();

            string res_PaymentTransaction = objApiPaymentTransaction.SavePayPalTransaction(objUser.Id.ToString(), paidamount);

            int ret = ApiobjUser.UpdatePaymentandEwalletStatusByUserId(objUser.Id.ToString(), Session["Ewallet"].ToString(), objUser.AccountType, "paid");
            objUser.Ewallet = Session["Ewallet"].ToString();
            objUser.ActivationStatus = "paid";
            Session["User"] = objUser;
            
            Api.Invitation.Invitation ApiInvitation = new Api.Invitation.Invitation();
            try {
                Domain.Socioboard.Domain.Invitation _Invitation = (Domain.Socioboard.Domain.Invitation)(new JavaScriptSerializer().Deserialize(ApiInvitation.UserInvitedInfo(objUser.Id.ToString()), typeof(Domain.Socioboard.Domain.Invitation)));
                if (_Invitation != null)
                {
                    User newUser = (User)(new JavaScriptSerializer().Deserialize(ApiobjUser.getUsersById(_Invitation.SenderUserId.ToString()),typeof(User)));
                    float bonus = (float.Parse(paidamount) * Payment.ReferedAmountDetails(objUser.AccountType)) / 100;
                    newUser.Ewallet = (float.Parse(newUser.Ewallet) + bonus).ToString();
                    int ret1 = ApiobjUser.UpdatePaymentandEwalletStatusByUserId(newUser.Id.ToString(), newUser.Ewallet, newUser.AccountType, newUser.PaymentStatus);
                    Api.Affiliates.Affiliates ApiAffiliates = new Api.Affiliates.Affiliates();
                    ApiAffiliates.AddAffiliateDetail(newUser.Id.ToString(), objUser.Id.ToString(), DateTime.Now, bonus.ToString());
                }
            }
            catch(Exception ex){}

            if (res_PaymentTransaction=="Success")
            {
                RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult PaymentFailed()
        {
            return View();
        }
        // vikash [20/11/2014]
        public ActionResult UpgradeAccountByPayPal(string plan, string price)
        {
            string pay = string.Empty;
            Api.User.User ApiobjUser = new Api.User.User();
            User objUser = (User)Session["User"];
            Helper.Payment payme = new Payment();
            string amount = price.Replace("$", "").Trim();
            Session["PaymentAmount"] = amount;
            Session["AccountType"] = plan;
            if (amount == "FREE")
            {
                amount = "0";
                pay = "success";
            }
            string UserName = objUser.UserName;
            string EmailId = objUser.EmailId;

            string ewallet = objUser.Ewallet;
            Session["Ewallet"] = ewallet;
            if (float.Parse(ewallet) > 0)
            {
                if (float.Parse(ewallet) >= float.Parse(amount))
                {
                    ewallet = (float.Parse(ewallet) - float.Parse(amount)).ToString();
                    Session["Ewallet"] = ewallet;
                    //int ret = ApiobjUser.UpdatePaymentandEwalletStatusByUserId(objUser.Id.ToString(), ewallet, plan, "paid");
                    UpgradeAccountSuccessful();
                    amount = "0";
                    pay = "success";
                    
                }
                else
                {
                    amount = (float.Parse(amount) - float.Parse(ewallet)).ToString();
                    Session["Ewallet"] = "0";
                }
            }
            if (amount != "0")
            {
                string UpgradeAccountSuccessURL = ConfigurationManager.AppSettings["UpgradeAccountSuccessURL"];
                string UpgradeAccountFailedURL = ConfigurationManager.AppSettings["UpgradeAccountFailedURL"];
                string UpgradeAccountpaypalemail = ConfigurationManager.AppSettings["UpgradeAccountpaypalemail"];
                string userId = objUser.Id.ToString();
               
                pay = payme.PayWithPayPal(amount, plan, UserName, "", EmailId, "USD", UpgradeAccountpaypalemail, UpgradeAccountSuccessURL,
                                         UpgradeAccountFailedURL, UpgradeAccountSuccessURL, "", "", userId);
            }
            return Content(pay);
        }

        public ActionResult UpgradeAccountSuccessful()
        {
            User objUser = (User)Session["User"];
            string paidamount = (string)Session["PaymentAmount"];
            string accountType = (string)Session["AccountType"];
            objUser.PaymentStatus = "Paid";
            objUser.AccountType = accountType;
            Api.User.User ApiobjUser = new Api.User.User();
            Api.PaymentTransaction.PaymentTransaction objApiPaymentTransaction = new Api.PaymentTransaction.PaymentTransaction();
            if (DateTime.Compare(objUser.ExpiryDate, DateTime.Now) > 0)
            {
                objUser.ExpiryDate = objUser.ExpiryDate.AddDays(30);
            }
            else
            {
                objUser.ExpiryDate = DateTime.Now.AddDays(30);
            }
            int i = ApiobjUser.UpdateUserAccountInfoByUserId(objUser.Id.ToString(), objUser.AccountType, objUser.ExpiryDate, objUser.PaymentStatus);
            string res_PaymentTransaction = objApiPaymentTransaction.SavePayPalTransaction(objUser.Id.ToString(), paidamount);
            int ret = ApiobjUser.UpdatePaymentandEwalletStatusByUserId(objUser.Id.ToString(), Session["Ewallet"].ToString(), accountType, "paid");
            objUser.Ewallet = Session["Ewallet"].ToString();
            objUser.ActivationStatus = "paid";
            Session["User"] = objUser;
            Api.Invitation.Invitation ApiInvitation = new Api.Invitation.Invitation();
            try
            {
                Domain.Socioboard.Domain.Invitation _Invitation = (Domain.Socioboard.Domain.Invitation)(new JavaScriptSerializer().Deserialize(ApiInvitation.UserInvitedInfo(objUser.Id.ToString()), typeof(Domain.Socioboard.Domain.Invitation)));
                if (_Invitation != null)
                {
                    User newUser = (User)(new JavaScriptSerializer().Deserialize(ApiobjUser.getUsersById(_Invitation.SenderUserId.ToString()), typeof(User)));
                    float bonus = (float.Parse(paidamount) * Payment.ReferedAmountDetails(accountType)) / 100;
                    newUser.Ewallet = (float.Parse(newUser.Ewallet) + bonus).ToString();
                    int ret1 = ApiobjUser.UpdatePaymentandEwalletStatusByUserId(newUser.Id.ToString(), newUser.Ewallet, newUser.AccountType, newUser.PaymentStatus);
                    Api.Affiliates.Affiliates ApiAffiliates = new Api.Affiliates.Affiliates();
                    ApiAffiliates.AddAffiliateDetail(newUser.Id.ToString(), objUser.Id.ToString(), DateTime.Now, bonus.ToString());
                }
            }
            catch (Exception ex) { }
            Session["Paid_User"] = "Paid";
            return RedirectToAction("Index", "Home");
        }
<<<<<<< HEAD

        //public ActionResult RechrgeEwalletByPaypal(string amount)
        //{
        //    string pay = string.Empty;
        //    Api.User.User ApiobjUser = new Api.User.User();
        //    User objUser = (User)Session["User"];
        //    Helper.Payment payme = new Payment();
        //    Session["RechrgeAmount"] = amount;
        //    string UpgradeAccountSuccessURL = ConfigurationManager.AppSettings["RechargeEwalletSuccessURL"];
        //    string UpgradeAccountFailedURL = ConfigurationManager.AppSettings["RechargeEwalletFailedURL"];
        //    string UpgradeAccountpaypalemail = ConfigurationManager.AppSettings["RechargeEwalletpaypalemail"];
        //    string userId = objUser.Id.ToString();
        //    string UserName = objUser.UserName;
        //    string EmailId = objUser.EmailId;
        //    pay = payme.PayWithPayPal(amount, "Recharge Ewallet", UserName, "", EmailId, "USD", UpgradeAccountpaypalemail, UpgradeAccountSuccessURL,
        //                             UpgradeAccountFailedURL, UpgradeAccountSuccessURL, "", "", userId);
        //    Response.Redirect(pay);
        //    return Content("");
        //}

        //public ActionResult RechrgeEwalletSuccessful()
        //{
        //    Api.User.User ApiobjUser = new Api.User.User();
        //    User objUser = (User)Session["User"];
        //    string RechargeAmount = Session["RechrgeAmount"].ToString();
        //    objUser.Ewallet = (float.Parse(objUser.Ewallet) + float.Parse(RechargeAmount)).ToString();

        //    return Content("");
        //}
=======
    
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
    }
}

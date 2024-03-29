﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping;
using System.Collections;

namespace SocioBoard.Domain
{
    public interface IFacebookAccountRepository
    {
        void addFacebookUser(FacebookAccount fbaccount);
        int deleteFacebookUser(string fbuserid,Guid userid);
        void updateFacebookUser(FacebookAccount fbaccount);
        ArrayList getAllFacebookAccountsOfUser(Guid UserId);
        bool checkFacebookUserExists(string FbUserId, Guid Userid);
        FacebookAccount getFacebookAccountDetailsById(string Fbuserid, Guid userId);
        FacebookAccount getUserDetails(string FbUserId);
      
         ArrayList getFacebookAccountsOfUser(Guid UserId);
    }
}
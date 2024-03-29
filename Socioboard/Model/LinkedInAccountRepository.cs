﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocioBoard.Helper;
using SocioBoard.Domain;
using System.Collections;

namespace SocioBoard.Model
{
    public class LinkedInAccountRepository : ILinkedInAccountRepository
    {

        /// <addLinkedinUser>
        /// Add Linked in User
        /// </summary>
        /// <param name="linkedInAccount">Set Values in a LinkedInAccount Class Property and Pass the Object of LinkedInAccount Class (SocioBoard.Domain.LinkedInAccount).</param>
        public void addLinkedinUser(LinkedInAccount linkedInAccount)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction. 
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    //Proceed action, to save data 
                    session.Save(linkedInAccount);
                    transaction.Commit();
                }//End Transaction
            }//End Session
        }


        /// <deleteLinkedinUser>
        /// Delete Linked in User
        /// </summary>
        /// <param name="LinkedInuserid">Id of linkedin account(String)</param>
        /// <param name="userid">User id (Guid)</param>
        /// <returns>Return integer 1 for true and 0 for false.</returns>
        public int deleteLinkedinUser(string LinkedInuserid, Guid userid)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction. 
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Proceed action, to delete linkedin account of user 
                        NHibernate.IQuery query = session.CreateQuery("delete from LinkedInAccount where LinkedinUserId = :LinkedInuserid and UserId = :userid")
                                        .SetParameter("LinkedInuserid", LinkedInuserid)
                                        .SetParameter("userid", userid);
                        int isUpdated = query.ExecuteUpdate();
                        transaction.Commit();
                        return isUpdated;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return 0;
                    }
                }//End Transaction
            }//End Session
        }


        /// <updateLinkedinUser>
        /// Update Linkedin User account details.
        /// </summary>
        /// <param name="liaccount">Set Values in a LinkedInAccount Class Property and Pass the Object of LinkedInAccount Class (SocioBoard.Domain.LinkedInAccount).</param>
        public void updateLinkedinUser(LinkedInAccount liaccount)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction. 
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Proceed action, to update user linkedin account deatils
                        session.CreateQuery("Update LinkedInAccount set LinkedinUserName =:LinkedinUserName,OAuthToken =:OAuthToken,OAuthSecret=:OAuthSecret,OAuthVerifier=:OAuthVerifier,EmailId=:EmailId,Connections=:Connections,ProfileUrl =:profileurl where LinkedinUserId = :LinkedinUserId and UserId = :UserId")
                            .SetParameter("LinkedinUserName", liaccount.LinkedinUserName)
                            .SetParameter("OAuthToken", liaccount.OAuthToken)
                            .SetParameter("OAuthSecret", liaccount.OAuthSecret)
                            .SetParameter("OAuthVerifier", liaccount.OAuthVerifier)
                            .SetParameter("EmailId", liaccount.EmailId)
                            .SetParameter("LinkedinUserId", liaccount.LinkedinUserId)
                            .SetParameter("UserId", liaccount.UserId)
                            .SetParameter("profileurl", liaccount.ProfileUrl)
                            .SetParameter("Connections", liaccount.Connections)
                            .ExecuteUpdate();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        // return 0;
                    }
                }//End Transaction
            }//End Session
        }


        /// <UpdateLDAccessTokenByLDUserId>
        /// Update Linkedin access token of account by user id.
        /// </summary>
        /// <param name="LDUserId">linkedin account id(string)</param>
        /// <param name="accessToken">New access token of account(String)</param>
        /// <returns>Return integer 1 for true and 0 for false.</returns>
        public int UpdateLDAccessTokenByLDUserId(string LDUserId, string accessToken)
        {
            int update = 0;

            try
            {
                //Creates a database connection and opens up a session
                using (NHibernate.ISession session = SessionFactory.GetNewSession())
                {
                    //After Session creation, start Transaction. 
                    using (NHibernate.ITransaction transaction = session.BeginTransaction())
                    {
                        try
                        {
                            update = session.CreateQuery("Update LinkedInAccount set OAuthToken = :accessToken where UserId = :LDUserId")
                                .SetParameter("accessToken", accessToken)
                                .SetParameter("LDUserId", LDUserId)
                                .ExecuteUpdate();

                            transaction.Commit();
                            update = 1;

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                            // return 0;
                        }
                    }//End Transaction
                }//End Session
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.StackTrace);
            }

            return update;
        }


        /// <getAllLinkedinAccountsOfUser>
        /// Get all linkedin accounts of User
        /// </summary>
        /// <param name="UserId">User id (Guid).</param>
        /// <returns>Return value of each account in the form of Arraylist.(Arraylist)</returns>
        public ArrayList getAllLinkedinAccountsOfUser(Guid UserId)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction. 
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    //Proceed action, To get linkedin account by user id.
                    NHibernate.IQuery query = session.CreateQuery("from LinkedInAccount where UserId = :userid");
                    query.SetParameter("userid", UserId);
                    ArrayList alstLIAccounts = new ArrayList();

                    foreach (var item in query.Enumerable())
                    {
                        alstLIAccounts.Add(item);
                    }
                    return alstLIAccounts;

                }//End Transaction
            }//End Session
        }


        /// <getAllLinkedinAccounts>
        /// Get all linkedin accounts.
        /// </summary>
        /// <returns>Return value of each account in the form of Arraylist.(Arraylist)</returns>
        public ArrayList getAllLinkedinAccounts()
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction. 
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    //Proceed action, to get all linkedin accounts.
                    NHibernate.IQuery query = session.CreateQuery("from LinkedInAccount");
                    ArrayList alstLIAccounts = new ArrayList();

                    foreach (var item in query.Enumerable())
                    {
                        alstLIAccounts.Add(item);
                    }
                    return alstLIAccounts;

                }//End Transaction
            }//End Session
        }


        /// <getLinkedinAccountDetailsById>
        /// Get linkedin account details by id
        /// </summary>
        /// <param name="liuserid"></param>
        /// <returns>Return object of LinkedInAccount Class with  value of each member.(Domain.LinkedInAccount)</returns>
        public LinkedInAccount getLinkedinAccountDetailsById(string liuserid)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction. 
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Proceed action, to get account details.
                        NHibernate.IQuery query = session.CreateQuery("from LinkedInAccount where LinkedinUserId = :userid");
                        query.SetParameter("userid", liuserid);
                        LinkedInAccount result = new LinkedInAccount();
                        foreach (LinkedInAccount item in query.Enumerable<LinkedInAccount>())
                        {
                            result = item;
                            break;
                        }
                        return result;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return null;
                    }
                }//End Transaction
            }//End Session
        }


        /// <checkLinkedinUserExists>
        /// Check linkedin user is exist or not.
        /// </summary>
        /// <param name="liUserId">Id of linkedin account (string).</param>
        /// <param name="Userid">User id (Guid)</param>
        /// <returns>True or false (bool)</returns>
        public bool checkLinkedinUserExists(string liUserId, Guid Userid)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction. 
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        NHibernate.IQuery query = session.CreateQuery("from LinkedInAccount where UserId = :userid and LinkedinUserId = :liuserid");
                        query.SetParameter("userid", Userid);
                        query.SetParameter("liuserid", liUserId);
                        var result = query.UniqueResult();

                        if (result == null)
                            return false;
                        else
                            return true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return true;
                    }
                }//End Transaction
            }//End Session
        }


        /// <getUserInformation>
        /// Get user linkedin account information
        /// </summary>
        /// <param name="userid">User id (Guid)</param>
        /// <param name="liuserid">Linkedin account Id (String)</param>
        /// <returns>Return object of LinkedInAccount Class with  value of each member.(Domain.LinkedInAccount)</returns>
        public LinkedInAccount getUserInformation(Guid userid, string liuserid)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction. 
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Proceed action, to get details of account.
                        NHibernate.IQuery query = session.CreateQuery("from LinkedInAccount where LinkedinUserId = :LinkedinUserId And UserId=:UserId");
                        query.SetParameter("UserId", userid);
                        query.SetParameter("LinkedinUserId", liuserid);
                        LinkedInAccount result = query.UniqueResult<LinkedInAccount>();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return null;
                    }
                }//End Transaction
            }//End Session
        }


        /// <DeleteLinkedInAccountByUserid>
        /// Delete linkedIn account by userid
        /// </summary>
        /// <param name="userid">User id()</param>
        /// <returns>Return integer 1 for true and 0 for false.</returns>
        public int DeleteLinkedInAccountByUserid(Guid userid)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction. 
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Proceed action, to delete linkedin account
                        NHibernate.IQuery query = session.CreateQuery("delete from LinkedInAccount where UserId = :userid")
                                        .SetParameter("userid", userid);
                        int isUpdated = query.ExecuteUpdate();
                        transaction.Commit();
                        return isUpdated;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return 0;
                    }
                }//End Transaction
            }//End Session
        }


    }
}
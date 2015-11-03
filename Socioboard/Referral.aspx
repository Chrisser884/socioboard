﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Referral.aspx.cs" Inherits="SocioBoard.Referrals1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Referral</title>
    <script src="Contents/js/jquery-1.9.1.min.js" type="text/javascript"></script>
    <link rel="Stylesheet" type="text/css" href="Contents/css/socialsuite.css" />
    <script type="text/javascript" charset="utf-8">
        // The widget initialization needs to be on the parent frame so
        // that the widget can overlay the entire page


        var csPageOptions = {
            domain_key: "J4FZ2BEGUE3MR8F7Y8ZA",
            afterSubmitContacts: function (array_of_contacts) {
                var allcheckedmail = '';
                for (i in array_of_contacts) {
                    var email = array_of_contacts[i].email[0].address;
                    var firstname = array_of_contacts[i].first_name;
                    if (firstname == undefined) {
                        firstname = '';
                    }

                    var lastname = array_of_contacts[i].last_name;
                    if (lastname == undefined) {
                        lastname = '';
                    }

                    allcheckedmail += firstname + '<~>' + lastname + '<~>' + email + '<:>';
                };
                if (allcheckedmail != "") {
                    //$('.loaderr').css('display', 'block');
                    sendAllSectedMail(allcheckedmail);
                }
                else {
                    alert('Please select mail!');
                }

            }
        };









        var name = "abhay";
        $(document).ready(function () {
            getuserid();
        });

        function getuserid() {
            // alert('asdasd');
            $.ajax({
                type: "POST",
                url: "../Helper/Ajaxfacetwt.aspx?type=getuserid",
                data: '',
                success: function (msg) {
                    debugger;
                    //alert(msg);
                    var arr = msg.split('<:>');
                    if (arr[0] == "success") {
                        //alert('success');
                        $('#txturl').val('');
                        $('#txturl').val(arr[1]);
                    }
                    else {
                        alert('Problem');
                        //  window.location = "Default.aspx";
                    }

                    // alert('Posted successfully');
                }
            });
        };


        function sendAllSectedMail(strmail) {
            $.ajax({
                type: "POST",
                url: "../Helper/AjaxInviteFrndsByCloudSponge.aspx?type=sendselectedmail",
                data: "selectedmail=" + strmail,
                success: function (msg) {
                    //alert('Mail Saved Successfully!');
                    $('.loaderr').css('display', 'none');
                    alert('All Message Send Successfully!')
                }
            });
        };
    </script>


    


      <script type="text/javascript" src="https://api.cloudsponge.com/address_books.js"></script>
</head>
<body style=" background:#FB6947;">


<div class="oran_menu" style=" float:right;">
    <form id="form1" runat="server">
    
   

                     <div id="invit" style=" margin:0 auto; float:none !important;">

                        <a href="Home.aspx" style=" font-family:Arial; color:#fff; font-size:16px;"><< Home</a>
                            <div class="invit_text">
                                <h1>
                                    Get free <strong>Premium Account</strong> by inviting Your Friends to SocioBoard!</h1>
                                <p>
                                    For every friend who joins Socioboard ,we'll give
                                    you 1 month of free <strong>Premium Account</strong>. Get 12 friends to
                                    signup and enjoy a full year of Free Premium SocioBoard Account!</p>
                                   
                                <p>
                                   <%-- If you need even more space,<a href="#">upgrade your account</a></p>--%>
                            </div>
                            <div class="loaderr"><img alt="" src="Contents/img/ssp/Newloader.gif"></div>
                            <div class="invit_form">
                                <div class="invit_emailform">
                                    <h3 style=" font-family:Arial;"> <a href="#" onclick="return parent.cloudsponge.launch();" style=" color:#fff;">Invite your friends by email</a></h3>

                                     

                                    <input id="txtmail" type="text" placeholder="Add names or emails" />
                                    <input id="sendmaill" type="button" class="button" value="Send" />
                                </div>
                            </div>
                            <div class="invit_share">
                                <h3>
                                    More ways to invite your friends</h3>
                                <ul style=" padding-left:160px;">
                                    <li style=" float:left; border-right:none;">
                                        <div class="copylinks">
                                            <a id="cpoylink" class="links" style=" padding:3px 2px;">
                                                <img src="../Contents/img/ssp/link.png" alt="" />
                                                Copy Link</a>
                                            <input id="txturl" type="text" class="url" placeholder="url" style=" width:67%;" />
                                        </div>
                                    </li>
                                    <%-- <li><a id="facebook" href="#">
                                        <img src="../Contents/img/ssp/facebook.png" alt="" /></a></li>
                                    <li><a id="twitter" href="#">
                                        <img src="../Contents/img/ssp/twitter_1.png" alt="" /></a></li>--%>
                                    <li style=" float:left; border-right:none;"> 
                                        <div class="fb-share-button" data-href="http://www.socioboard.com" data-type="button_count">
                                        </div>
                                    </li>
                                    <li style=" float:left; border-right:none;"><a href="https://twitter.com/share" class="twitter-share-button" data-url="http://www.socioboad.com"
                                        data-via="Socioboard">Tweet</a></li>
                                </ul>
                            </div>
                        </div>

 <script>     !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + '://platform.twitter.com/widgets.js'; fjs.parentNode.insertBefore(js, fjs); } } (document, 'script', 'twitter-wjs');</script>
    
    
    
    <div id="fb-root">
    </div>
    <script>        (function (d, s, id) {
            var js, fjs = d.getElementsByTagName(s)[0];
            if (d.getElementById(id)) return;
            js = d.createElement(s); js.id = id;
            js.src = "//connect.facebook.net/en_GB/all.js#xfbml=1&appId=517105231670294";
            fjs.parentNode.insertBefore(js, fjs);
        } (document, 'script', 'facebook-jssdk'));</script>
    
  
    </form>
    </div>
</body>
</html>

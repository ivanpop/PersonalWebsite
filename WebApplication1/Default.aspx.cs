using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {   
        byte id = 0, code, page;
        Random rnd = new Random();        
        protected string conS = @"Server=tcp:rlq2jzpufp.database.windows.net,1433;Database=text;User ID=ivanpop@rlq2jzpufp;Password=Popov123;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
        protected SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["l"] == "en")
            {
                id++;
                switchBulBtn.Enabled = true;
                switchEngBtn.Enabled = false;
                lang.Text = "English";
                navigation.Text = "Navigation";
                aboutMe.Text = "About me";
                biography.Text = "Biography";
                projects.Text = "Projects";
                contacts.Text = "Contacts";
                header1.Text = "Ivan Popov";
                header2.Text = "Personal website";
                goTop.Text = "Top";
            }
            if (Request.QueryString["a"] == "proj")
            {
                projects.Enabled = false;
                projectsPanel.Visible = true;
                getText("projBul");
                artTitle.Text = "Проекти";
                if (id == 1)
                {
                    getText("projEng");
                    artTitle.Text = "Projects";
                    ConverterDescr.Text = "<em>Program for converting metric units.</em>";
                    StopwDescr.Text = "<em>Countdown timer and a stopwatch.</em>";
                    RyuDescr.Text = "<em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em>";
                    CSDescr.Text = "Solutions from The C# book from Telerik";
                }
            }
            if (Request.QueryString["a"] == null)
            {
                aboutMe.Enabled = false;
                getText("aboutMeBul");
                if (id == 1)
                {
                    artTitle.Text = "About me";
                    getText("aboutMeEng");                    
                }
            }
            if (Request.QueryString["a"] == "bio")
            {
                biography.Enabled = false;
                ivanpopov.Visible = true;
                artTitle.Text = "Автобиография";
                getText("biograpBul");
                if (id == 1)
                {
                    artTitle.Text = "Biography";
                    getText("biograpEng");
                }
            }
            if (Request.QueryString["a"] == "con")
            {
                contacts.Enabled = false;
                contactsPanel.Visible = true;
                artTitle.Text = "Контакти";
                getText("contactBul");
                if (id == 1)
                {
                    artTitle.Text = "Contacts";
                    getText("contactEng");
                    subjectLabel.Text = "Subject:";
                    messageLabel.Text = "Message:";
                    submitEmailBtn.Text = "Submit";
                    emailLabel.Text = "*Your E-Mail";
                    emailRegularExpressionValidator.Text = "The E-Mail adress is incorrect!";
                    emailRequiredFieldValidator.Text = "Please enter your E-Mail adress!";
                    messageRequiredFieldValidator.Text = "Please enter a message!";
                    requiredFieldLabel.Text = "Indicates required field";
                    codeLabel.Text = "*Security code:";
                    codeRequiredFieldValidator.Text = "Please enter the security code!";
                    codeCompareValidator.Text = "Wrong code!";
                }
                code = (byte)rnd.Next(1, 11);
                codeImg.Text = "<img src=\"/Resources/codes/" + code.ToString() + ".jpg\">";
                switch (code)
                {
                    case 1: codeCompareValidator.ValueToCompare = "57195";
                        break;
                    case 2: codeCompareValidator.ValueToCompare = "39628";
                        break;
                    case 3: codeCompareValidator.ValueToCompare = "90187";
                        break;
                    case 4: codeCompareValidator.ValueToCompare = "84793";
                        break;
                    case 5: codeCompareValidator.ValueToCompare = "21354";
                        break;
                    case 6: codeCompareValidator.ValueToCompare = "75638";
                        break;
                    case 7: codeCompareValidator.ValueToCompare = "42475";
                        break;
                    case 8: codeCompareValidator.ValueToCompare = "54968";
                        break;
                    case 9: codeCompareValidator.ValueToCompare = "23547";
                        break;
                    case 10: codeCompareValidator.ValueToCompare = "03412";
                        break;
                }                
            }
            if (Request.QueryString["a"] == "converter")
            {                                
                mainContent.Text = "";
                artTitle.Text = "Converter";
                getText("convertBul", 1);
                if (id == 1)
                {                    
                    getText("convertEng", 1);
                }
            }
            if (Request.QueryString["a"] == "countdown")
            {                                
                mainContent.Text = "";
                artTitle.Text = "Countdown timer and stopwatch";                
                pagePanel.Visible = true;                
                pageBtn6.Visible = false;
                pageBtn7.Visible = false;
                pageBtn8.Visible = false;
                pageBtn9.Visible = false;                
                byte.TryParse(Request.QueryString["p"], out page);
                switch (page)
                {
                    case 5: pageBtn5.Enabled = false;
                        break;
                    case 4: pageBtn4.Enabled = false;
                        break;
                    case 3: pageBtn3.Enabled = false;
                        break;
                    case 2: pageBtn2.Enabled = false;
                        break;
                    default: pageBtn1.Enabled = false;
                        break;
                }
                if (id == 0)
                {
                    switch (Request.QueryString["p"])
                    {
                        case "5": getText("stopwBul5", 1);
                            break;
                        case "4": getText("stopwBul4", 1);
                            break;
                        case "3": getText("stopwBul3", 1);
                            break;
                        case "2": getText("stopwBul2", 1);
                            break;
                        default: getText("stopwBul1", 1); ;
                            break;
                    }
                }
                else
                {                    
                    switch (Request.QueryString["p"])
                    {
                        case "5": getText("stopwEng5", 1);
                            break;
                        case "4": getText("stopwEng4", 1);
                            break;
                        case "3": getText("stopwEng3", 1);
                            break;
                        case "2": getText("stopwEng2", 1);
                            break;
                        default: getText("stopwEng1", 1);
                            break;
                    }
                }
            }
            if (Request.QueryString["a"] == "ryu")
            {                               
                pagePanel.Visible = true;
                mainContent.Text = "";
                byte.TryParse(Request.QueryString["p"], out page);
                switch (page)
                {                        
                    case 2: pageBtn2.Enabled = false;
                        break;
                    case 3: pageBtn3.Enabled = false;
                        break;
                    case 4: pageBtn4.Enabled = false;
                        break;
                    case 5: pageBtn5.Enabled = false;
                        break;
                    case 6: pageBtn6.Enabled = false;
                        break;
                    case 7: pageBtn7.Enabled = false;
                        break;
                    case 8: pageBtn8.Enabled = false;
                        break;
                    case 9: pageBtn9.Enabled = false;
                        break;
                    default: pageBtn1.Enabled = false;
                        break;
                }
                artTitle.Text = "Ryu: The Big Adventure!";
                if (id == 0)
                {
                    switch (Request.QueryString["p"])
                    {
                        case "2": getText("ryuTxt2Bul", 1);
                            break;
                        case "3": getText("ryuTxt3Bul", 1);
                            break;
                        case "4": getText("ryuTxt4Bul", 1);
                            break;
                        case "5": getText("ryuTxt5Bul", 1);
                            break;
                        case "6": getText("ryuTxt6Bul", 1);
                            break;
                        case "7": getText("ryuTxt7Bul", 1);
                            break;
                        case "8": getText("ryuTxt8Bul", 1);
                            break;
                        case "9": getText("ryuTxt9Bul", 1);
                            break;
                        default: getText("ryuTxt1Bul", 1);
                            break;
                    }
                }
                else
                {
                    switch (Request.QueryString["p"])
                    {
                        case "2": getText("ryuTxt2Eng", 1);
                            break;
                        case "3": getText("ryuTxt3Eng", 1);
                            break;
                        case "4": getText("ryuTxt4Eng", 1);
                            break;
                        case "5": getText("ryuTxt5Eng", 1);
                            break;
                        case "6": getText("ryuTxt6Eng", 1);
                            break;
                        case "7": getText("ryuTxt7Eng", 1);
                            break;
                        case "8": getText("ryuTxt8Eng", 1);
                            break;
                        case "9": getText("ryuTxt9Eng", 1);
                            break;
                        default: getText("ryuTxt1Eng", 1);
                            break;
                    }                    
                }
            }
            if (Request.QueryString["a"] == "cs")
            {
                mainContent.Visible = false;               
                artTitle.Text = "C# for Dummies.";                
            }
        }

        protected void getText(string id, int index = 0)
        {
            con = new SqlConnection(conS);
            SqlCommand query = new SqlCommand("SELECT mainContent FROM [Table1] WHERE Id='" + id + "';", con);
            con.Open();
            if (index == 0)
            {
                mainContent.Text = query.ExecuteScalar().ToString();
            }
            else
            {
                projectsContent.Text = query.ExecuteScalar().ToString();
            }
            con.Close();
        }

        protected void setQueryString(string s1, string s2 = null)
        {
            var nvc = HttpUtility.ParseQueryString(Request.Url.Query);
            if (s2 == null)
            {
                nvc.Remove(s1);
            }
            else
            {
                nvc.Set(s1, s2);
            }
            if (s1 != "p" && s1 != "l")
            {
                nvc.Remove("p");
            }
            string url = Request.Url.AbsolutePath + "?" + nvc.ToString();
            Response.Redirect(url); 
        }
        
        protected void switchEngBtn_Click(object sender, EventArgs e)
        {
            setQueryString("l", "en");
        }

        protected void switchBulBtn_Click(object sender, EventArgs e)
        {
            setQueryString("l");
        }

        protected void aboutMe_Click(object sender, EventArgs e)
        {
            setQueryString("a");
        }

        protected void biography_Click(object sender, EventArgs e)
        {
            setQueryString("a", "bio");
        }

        protected void projects_Click(object sender, EventArgs e)
        {
            setQueryString("a", "proj");
        }

        protected void contacts_Click(object sender, EventArgs e)
        {
            setQueryString("a", "con");
        }

        protected void converter_Click(object sender, EventArgs e)
        {
            setQueryString("a", "converter");
        }

        protected void countdown_Click1(object sender, EventArgs e)
        {
            setQueryString("a", "countdown");
        }

        protected void ryu_Click(object sender, EventArgs e)
        {
            setQueryString("a", "ryu");
        }

        protected void csDummies_Click(object sender, EventArgs e)
        {
            setQueryString("a", "cs");
        } 

        protected void ryuPage2_Click(object sender, EventArgs e)
        {
            setQueryString("p", "2");
        }

        protected void ryuPage1_Click(object sender, EventArgs e)
        {
            setQueryString("p");
        }

        protected void ryuPage3_Click(object sender, EventArgs e)
        {
            setQueryString("p", "3");
        }

        protected void ryuPage4_Click(object sender, EventArgs e)
        {
            setQueryString("p", "4");
        }

        protected void ryuPage5_Click(object sender, EventArgs e)
        {
            setQueryString("p", "5");
        }

        protected void ryuPage6_Click(object sender, EventArgs e)
        {
            setQueryString("p", "6");
        }

        protected void ryuPage7_Click(object sender, EventArgs e)
        {
            setQueryString("p", "7");
        }

        protected void ryuPage8_Click(object sender, EventArgs e)
        {
            setQueryString("p", "8");
        }

        protected void ryuPage9_Click(object sender, EventArgs e)
        {
            setQueryString("p", "9");
        }

        protected void submitEmailBtn_Click(object sender, EventArgs e)
        {
            using (MailMessage message = new MailMessage())
            {                
                message.From = new MailAddress(emailTextBox.Text.ToString());
                message.To.Add(new MailAddress("unfragablegaming@gmail.com"));
                message.Subject = "Message from My Site: " + subjectBox.Text.ToString();
                message.Body = messageBox.Text.ToString();
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtpcorp.com";
                smtp.Port = 2525;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("ivanpop@abv.bg", "ipb123");
                try
                {
                    smtp.Send(message);
                }
                catch (SmtpFailedRecipientsException ex)
                {
                    contactsPanel.Visible = false;
                    mainContent.Text = "";

                    for (int i = 0; i < ex.InnerExceptions.Length; i++)
                    {
                        SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                        if (status == SmtpStatusCode.MailboxBusy || status == SmtpStatusCode.MailboxUnavailable)
                        {                            
                            artTitle.Text = "Грешка при изпращането на писмото. Ще направя повторен опит за изпращане след 5 секунди.";
                            if (id == 1)
                            {
                                artTitle.Text = "Failed to send message. Retrying in 5 seconds.";
                            }
                            System.Threading.Thread.Sleep(5000);
                            smtp.Send(message);
                        }
                        else
                        {
                            artTitle.Text = "Грешка при изпращането на писмото.";
                            if (id == 1)
                            {
                                artTitle.Text = "Failed to send message.";
                            }
                        }
                    }
                }
                contactsPanel.Visible = false;
                mainContent.Text = "След 5 секунди ще бъдете прехвърлени към началната страница.";
                artTitle.Text = "Писмото е изпратено успешно.";
                if (id == 1)
                {
                    artTitle.Text = "E-mail sent successful.";
                    artTitle.Text = "You will be redirected to the home page in 5 seconds.";
                }
                Response.AddHeader("REFRESH","5;URL=index.aspx");          
            }
        }
    }
}
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

                if (id == 0)
                {
                    mainContent.Text = Strings.projBul;
                    artTitle.Text = "Проекти";
                }
                else
                {
                    mainContent.Text = Strings.projEng;
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
                if (id == 0) mainContent.Text = Strings.aboutMeBul;
                else
                {
                    artTitle.Text = "About me";
                    mainContent.Text = Strings.aboutMeEng;
                }
            }
            if (Request.QueryString["a"] == "bio")
            {
                biography.Enabled = false;
                ivanpopov.Visible = true;
                if (id == 0)
                {
                    artTitle.Text = "Автобиография";
                    mainContent.Text = Strings.biograpBul;
                }
                else
                {
                    artTitle.Text = "Biography";
                    mainContent.Text = Strings.biograpEng;
                }
            }
            if (Request.QueryString["a"] == "con")
            {
                contacts.Enabled = false;
                contactsPanel.Visible = true;
                if (id == 0)
                {
                    artTitle.Text = "Контакти";
                    mainContent.Text = Strings.contactBul;
                }
                else
                {
                    artTitle.Text = "Contacts";
                    mainContent.Text = Strings.contactEng;
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
                    case 1: codeCompareValidator.ValueToCompare = "57195"; break;
                    case 2: codeCompareValidator.ValueToCompare = "39628"; break;
                    case 3: codeCompareValidator.ValueToCompare = "90187"; break;
                    case 4: codeCompareValidator.ValueToCompare = "84793"; break;
                    case 5: codeCompareValidator.ValueToCompare = "21354"; break;
                    case 6: codeCompareValidator.ValueToCompare = "75638"; break;
                    case 7: codeCompareValidator.ValueToCompare = "42475"; break;
                    case 8: codeCompareValidator.ValueToCompare = "54968"; break;
                    case 9: codeCompareValidator.ValueToCompare = "23547"; break;
                    case 10: codeCompareValidator.ValueToCompare = "03412"; break;
                }
            }
            if (Request.QueryString["a"] == "converter")
            {
                commentsBtn.Visible = true;
                mainContent.Text = "";
                artTitle.Text = "Converter";
                if (id == 0) projectsContent.Text = Strings.convertBul;
                else projectsContent.Text = Strings.convertEng;
            }
            if (Request.QueryString["a"] == "countdown")
            {
                commentsBtn.Visible = true;
                mainContent.Text = "";
                artTitle.Text = "Countdown timer and stopwatch";
                pagePanel.Visible = true;
                pageBtn6.Visible = pageBtn7.Visible = pageBtn8.Visible = pageBtn9.Visible = false;
                byte.TryParse(Request.QueryString["p"], out page);
                switch (page)
                {
                    case 5: pageBtn5.Enabled = false; break;
                    case 4: pageBtn4.Enabled = false; break;
                    case 3: pageBtn3.Enabled = false; break;
                    case 2: pageBtn2.Enabled = false; break;
                    default: pageBtn1.Enabled = false; break;
                }
                if (id == 0)
                    switch (Request.QueryString["p"])
                    {
                        case "5": projectsContent.Text = Stopwatch.stopwBul5; break;
                        case "4": projectsContent.Text = Stopwatch.stopwBul4; break;
                        case "3": projectsContent.Text = Stopwatch.stopwBul3; break;
                        case "2": projectsContent.Text = Stopwatch.stopwBul2; break;
                        default: projectsContent.Text = Stopwatch.stopwBul1; break;
                    }
                else
                    switch (Request.QueryString["p"])
                    {
                        case "5": projectsContent.Text = Stopwatch.stopwEng5; break;
                        case "4": projectsContent.Text = Stopwatch.stopwEng4; break;
                        case "3": projectsContent.Text = Stopwatch.stopwEng3; break;
                        case "2": projectsContent.Text = Stopwatch.stopwEng2; break;
                        default: projectsContent.Text = Stopwatch.stopwEng1; break;
                    }
            }
            if (Request.QueryString["a"] == "ryu")
            {
                pagePanel.Visible = commentsBtn.Visible = true;
                mainContent.Text = "";
                byte.TryParse(Request.QueryString["p"], out page);
                switch (page)
                {
                    case 2: pageBtn2.Enabled = false; break;
                    case 3: pageBtn3.Enabled = false; break;
                    case 4: pageBtn4.Enabled = false; break;
                    case 5: pageBtn5.Enabled = false; break;
                    case 6: pageBtn6.Enabled = false; break;
                    case 7: pageBtn7.Enabled = false; break;
                    case 8: pageBtn8.Enabled = false; break;
                    case 9: pageBtn9.Enabled = false; break;
                    default: pageBtn1.Enabled = false; break;
                }
                artTitle.Text = "Ryu: The Big Adventure!";
                if (id == 0)
                    switch (Request.QueryString["p"])
                    {
                        case "2": projectsContent.Text = Ryu.ryuTxt2Bul; break;
                        case "3": projectsContent.Text = Ryu.ryuTxt3Bul; break;
                        case "4": projectsContent.Text = Ryu.ryuTxt4Bul; break;
                        case "5": projectsContent.Text = Ryu.ryuTxt5Bul; break;
                        case "6": projectsContent.Text = Ryu.ryuTxt6Bul; break;
                        case "7": projectsContent.Text = Ryu.ryuTxt7Bul; break;
                        case "8": projectsContent.Text = Ryu.ryuTxt8Bul; break;
                        case "9": projectsContent.Text = Ryu.ryuTxt9Bul; break;
                        default: projectsContent.Text = Ryu.ryuTxt1Bul; break;
                    }
                else
                    switch (Request.QueryString["p"])
                    {
                        case "2": projectsContent.Text = Ryu.ryuTxt2Eng; break;
                        case "3": projectsContent.Text = Ryu.ryuTxt3Eng; break;
                        case "4": projectsContent.Text = Ryu.ryuTxt4Eng; break;
                        case "5": projectsContent.Text = Ryu.ryuTxt5Eng; break;
                        case "6": projectsContent.Text = Ryu.ryuTxt6Eng; break;
                        case "7": projectsContent.Text = Ryu.ryuTxt7Eng; break;
                        case "8": projectsContent.Text = Ryu.ryuTxt8Eng; break;
                        case "9": projectsContent.Text = Ryu.ryuTxt9Eng; break;
                        default: projectsContent.Text = Ryu.ryuTxt1Eng; break;
                    }
            }
            if (Request.QueryString["a"] == "cs")
            {
                if (Request.QueryString["p"] != "") commentsBtn.Visible = true;
                mainContent.Visible = false;
                artTitle.Text = "C# for Dummies.";
                chaptersPanel.Visible = Convert.ToInt32(Request.QueryString["p"]) > 0 ? false : true;
                backBtn.Visible = Convert.ToInt32(Request.QueryString["p"]) > 0 ? true : false;
                byte.TryParse(Request.QueryString["p"], out page);
                if (id == 0)
                    switch (page)
                    {
                        case 1: projectsContent.Text = CS.CSBul1; break;
                        case 2: projectsContent.Text = CS.CSBul2; break;
                        case 3: projectsContent.Text = CS.CSBul3; break;
                        case 4: projectsContent.Text = CS.CSBul4; break;
                        case 5: projectsContent.Text = CS.CSBul5; break;
                        case 6: projectsContent.Text = CS.CSBul6; break;
                        case 7: projectsContent.Text = CS.CSBul7; break;
                        case 8: projectsContent.Text = CS.CSBul8; break;
                        case 9: projectsContent.Text = CS.CSBul9; break;
                        case 10: projectsContent.Text = CS.CSBul10; break;
                        case 11: projectsContent.Text = CS.CSBul11; break;
                    }
                else
                {
                    switch (page)
                    {
                        case 1: projectsContent.Text = CS.CSEng1; break;
                        case 2: projectsContent.Text = CS.CSEng2; break;
                        case 3: projectsContent.Text = CS.CSEng3; break;
                        case 4: projectsContent.Text = CS.CSEng4; break;
                        case 5: projectsContent.Text = CS.CSEng5; break;
                        case 6: projectsContent.Text = CS.CSEng6; break;
                        case 7: projectsContent.Text = CS.CSEng7; break;
                        case 8: projectsContent.Text = CS.CSEng8; break;
                        case 9: projectsContent.Text = CS.CSEng9; break;
                        case 10: projectsContent.Text = CS.CSEng10; break;
                    }

                    chapter1Btn.Text = "Chapter 1. Introduction to Programming";
                    chapter2Btn.Text = "Chapter 2. Primitive Types and Variables";
                    chapter3Btn.Text = "Chapter 3. Operators and Expressions";
                    chapter4Btn.Text = "Chapter 4. Console Input and Output";
                    chapter5Btn.Text = "Chapter 5. Conditional Statements";
                    chapter6Btn.Text = "Chapter 6. Loops";
                    chapter7Btn.Text = "Chapter 7. Arrays";
                    chapter8Btn.Text = "Chapter 8. Numeral Systems";
                    chapter9Btn.Text = "Chapter 9. Methods";
                    chapter10Btn.Text = "Chapter 10. Recursion";
                    chapter11Btn.Text = "Chapter 11. Creating and Using Objects";
                    chapter12Btn.Text = "Chapter 12. Exception Handling";
                    chapter13Btn.Text = "Chapter 13. Strings and Text Processing";
                    chapter14Btn.Text = "Chapter 14. Defining Classes";
                    chapter15Btn.Text = "Chapter 15. Text Files";
                    chapter16Btn.Text = "Chapter 16. Linear Data Structures";
                    chapter17Btn.Text = "Chapter 17. Trees and Graphs";
                    chapter18Btn.Text = "Chapter 18. Dictionaries, Hash-Tables and Sets";
                    chapter19Btn.Text = "Chapter 19. Data Structures and Algorithm Complexity";
                    chapter20Btn.Text = "Chapter 20. Object-Oriented Programming Principles";
                    chapter21Btn.Text = "Chapter 21. High-Quality Programming Code";
                    chapter22Btn.Text = "Chapter 22. Lambda Expressions and LINQ";
                    chapter23Btn.Text = "Chapter 23. Methodology of Problem Solving";
                    chapter24Btn.Text = "Chapter 24. Sample Programming Exam – Topic #1";
                    chapter25Btn.Text = "Chapter 25. Sample Programming Exam – Topic #2";
                    chapter26Btn.Text = "Chapter 26. Sample Programming Exam – Topic #3";
                    backBtn.Text = "Back";
                }
            }
        }

        protected void setQueryString(string s1, string s2 = null)
        {
            var nvc = HttpUtility.ParseQueryString(Request.Url.Query);
            if (s2 == null) nvc.Remove(s1);
            else nvc.Set(s1, s2);
            if (s1 != "p" && s1 != "l") nvc.Remove("p");
            string url = Request.Url.AbsolutePath + "?" + nvc.ToString();
            Response.Redirect(url);
        }

        #region buttonEvents
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

        protected void CSBul1_Click(object sender, EventArgs e)
        {
            setQueryString("p", "1");
        }

        protected void CSBul2_Click(object sender, EventArgs e)
        {
            setQueryString("p", "2");
        }

        protected void CSBul3_Click(object sender, EventArgs e)
        {
            setQueryString("p", "3");
        }

        protected void CSBul4_Click(object sender, EventArgs e)
        {
            setQueryString("p", "4");
        }

        protected void CSBul5_Click(object sender, EventArgs e)
        {
            setQueryString("p", "5");
        }

        protected void CSBul6_Click(object sender, EventArgs e)
        {
            setQueryString("p", "6");
        }

        protected void CSBul7_Click(object sender, EventArgs e)
        {
            setQueryString("p", "7");
        }

        protected void CSBul8_Click(object sender, EventArgs e)
        {
            setQueryString("p", "8");
        }

        protected void CSBul9_Click(object sender, EventArgs e)
        {
            setQueryString("p", "9");
        }

        protected void CSBul10_Click(object sender, EventArgs e)
        {
            setQueryString("p", "10");
        }

        protected void CSBul11_Click(object sender, EventArgs e)
        {
            setQueryString("p", "11");
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            setQueryString("p");
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
                            if (id == 1) artTitle.Text = "Failed to send message. Retrying in 5 seconds.";
                            System.Threading.Thread.Sleep(5000);
                            smtp.Send(message);
                        }
                        else
                        {
                            artTitle.Text = "Грешка при изпращането на писмото.";
                            if (id == 1) artTitle.Text = "Failed to send message.";
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
                Response.AddHeader("REFRESH", "5;URL=index.aspx");
            }
        }

        protected void commentsBtn_Click(object sender, EventArgs e)
        {
            commentsPanel.Visible = true;

            if (Request.QueryString["a"] == "converter")
            {
                if (Request.QueryString["l"] == "en") disqueLabel.Text = Strings.disqueScriptConEN;
                else disqueLabel.Text = Strings.disqueScriptConBG;
            }

            if (Request.QueryString["a"] == "countdown")
            {
                if (Request.QueryString["l"] == "en") disqueLabel.Text = Strings.disqueScriptCountdownEN;
                else disqueLabel.Text = Strings.disqueScriptCountdownBG;
            }

            if (Request.QueryString["a"] == "ryu")
            {
                if (Request.QueryString["l"] == "en") disqueLabel.Text = Strings.disqueScriptRyuEN;
                else disqueLabel.Text = Strings.disqueScriptRyuBG;
            }

            if (Request.QueryString["a"] == "cs")
            {
                if (Request.QueryString["l"] == "en") disqueLabel.Text = Strings.disqueScriptCSEN;
                else disqueLabel.Text = Strings.disqueScriptCSBG;
            }

            commentsPanel.Controls.Add(disqueLabel);
        }

        #endregion
    }
}
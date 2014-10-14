﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string aboutMeBul = "<p>Здравейте,<br><br> Казвам се Иван Попов и съм новозавършил във ФМИТ на Пловдивския Университет \"Паисий Хилендарски\"."+
            "<br><br>Това е моята лична интернет страница.Тук ще намерите информация за мен и актуалните проекти, по които работя активно.<br><br>"+
            "Моите интереси са основно в областта на Информационните Технологии, Езиците за програмиране и Средите за програмиране.";

        string aboutMeEng = "<p>Hello,<br><br>My name is Ivan Popov and I am a graduate in FMIT in Plovdiv University \"Paisii Hilendasrki\".<br><br>"+
            "This is my personal web page. Here you will find information about me and project, I work on.<br><br>"+
            "My interests are mainly in the field of information technology, programming languages ​​and their programming environments.";

        string biographyBul = "&nbsp;Роден съм на 19.01.1990г. в гр. Пловдив, България.<br><br>&nbsp;"+
            "Завърших висшето си образование, степен бакалавър, в &nbsp;Пловдивски университет \"Паисий Хилендарски\" през 2013 г. &nbsp;"+
            "със специалност \"Информатика\".<br><br>&nbsp;Непосредствено след завършването си записах магистърска &nbsp;"+
            "степен, в същия университет, със специалност \"Софтуерни &nbsp;технологии\", която също завърших успешно.<br><br>&nbsp;От декември 2009г, четири месеца след"+
            " записването ми в &nbsp;университета, работя в магазин \"Метро Пловдив 2\", от &nbsp;начало като обикновен сътрудник и впоследствие " +
            "като &nbsp;продуктов консултант.<br><br>&nbsp;Работата ми в магазина ме научи да работя в екип, да работя с клиенти, да си планирам " +
            "работния ден и приоритизирам задачите си.<br><br>През останалото време решавам курсове от <a href=\"https://telerikacademy.com/\" target=\"_blank\">" +
            "<b><u>Софтуерна академия \"Телерик\"</b></u></a> и <a href=\"https://softuni.bg/\" target=\"_blank\">" +
            "<b><u>Софтуерен университет</b></u>\"</a>, както и мой лични проекти.Част от тях могат да се видят в моя Github акаунт. <a href=\"https://github.com/ivanpop\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><br><br>Като хоби имам YouTube канал, в който качвам кадри от игри и показвам дългите години придобит опит със снайпера и двуцевката. ;)" +
            "<a href=\"https://www.youtube.com/user/unfragablegaming/\" target=\"_blank\">" + "<b><u>Unfragable Gaming</u></b></a><br><br>Целта ми е да работя в IT-сферата " + 
            "и да продължавам да си развивам уменията на програмист.<br><br><hr><br><br><h1>Образование</h1><br><br>2014 г. ПУ \"Паисий Хилендарски\" " + 
            "- Пловдив, висше образование, степен магистър, специалност \"Софтуерни технологии\".<br><br>2013 г. ПУ \"Паисий Хилендарски\" - Пловдив, " + 
            " висше образование, степен бакалавър, специалност \"Информатика\".<br><br>1997 г. ОУ \"Райна Княгиня\" - Пловдив, основно образование.<br><br> " +
            "<hr><br><br><h1>Езици</h1><br><br>Български – майчин език.<br><br>Английски – четене - отлично, писане - много добро, разговор - много добро." +
            "<br><br>Френски – четене - основно, писане - основно, разговор - основно.<br><br><hr><br><br><h1>Трудов опит</h1><br><br>12/2009 - 07/2014 Сътрудник" +
            " впоследствие Продуктов консултант, в магазин \"Метро 2 Пловдив\".<br><br>11/2012 - 04/2013 Оператор въвеждане на данни в “Highstyle” Ltd." +
            "<br><br><hr><br><br><h1>Други</h1><br><br><b>Езици за програмиране:</b><br><br>C#, C++, Java, JavaScript...<br><br><b>Технологии и стандарти:</b>" +
            "<br><br>HTML/DHTML, CSS, ASP.NET, jQuery, MySQL...<br><br><b>Програми:</b><br><br>MS Visual Studio 2013 for Desktop, Eclipse IDE," +
            "MS Visual Studio 2013 for Web, Notepad++;<br>MS Office, Libre Office, Adobe Photoshop, Adobe Premiere Pro, Audacity";

        string converterText = "<br><br><h1>Converter</h1><br><em>Програма за преобразуване на мерни единици.</em><br><br>Програмата е написана на" +
            " C# и представлява прост конвертор или преобразувател на мерни единици.Възможните мерни единици могат да се видят на изображението.<br>" +
            "<img src=\"/Resources/convertor1.jpg\"><br><b>Source: </b><a href=\"https://github.com/ivanpop/Converter\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/convertor.exe\">converter.exe</a></td><td class=\"size\">49.0 KB</td> " + 
            " </tr></tbody></table>";

        string projectsBul = "Тук съм показал някои от проектите върху които работя.<br><br>";

        protected void Page_Load(object sender, EventArgs e)
        {
            mainContent.Text = aboutMeBul;
            visibilities();
        }

        protected void switchEngBtn_Click(object sender, EventArgs e)
        {
            mainContent.Text = aboutMeEng;
            lang.Text = "English";
            artTitle.Text = "About me";
            navigation.Text = "Navigation";
            visibilities();
        }

        protected void switchBulBtn_Click(object sender, EventArgs e)
        {
            mainContent.Text = aboutMeBul;
            lang.Text = "Български";
            artTitle.Text = "За мен";
            navigation.Text = "Навигация";
            visibilities();
        }

        protected void aboutMe_Click(object sender, EventArgs e)
        {
            mainContent.Text = aboutMeBul;
            lang.Text = "Български";
            artTitle.Text = "За мен";
            navigation.Text = "Навигация";
            visibilities();
        }

        protected void biography_Click(object sender, EventArgs e)
        {
            mainContent.Text = biographyBul;
            lang.Text = "Български";
            artTitle.Text = "Автобиография";
            navigation.Text = "Навигация";
            visibilities();
        }

        protected void projects_Click(object sender, EventArgs e)
        {
            mainContent.Text = projectsBul;
            lang.Text = "Български";
            artTitle.Text = "Проекти";
            navigation.Text = "Навигация";
            visibilities();
        }

        protected void contacts_Click(object sender, EventArgs e)
        {
            lang.Text = "Български";
            artTitle.Text = "Контакти";
            navigation.Text = "Навигация";
            visibilities();
        }

        protected void visibilities()
        {
            if (artTitle.Text == "Автобиография")
            {
                ivanpopov.Visible = true;
            }
            else
            {
                ivanpopov.Visible = false;
            }

            if (artTitle.Text == "Проекти")
            {
                converter.Visible = true;
                countdown.Visible = true;
                ryu.Visible = true;
                projectsContent.Visible = true;
            }
            else
            {
                converter.Visible = false;
                countdown.Visible = false;
                ryu.Visible = false;
                projectsContent.Visible = false;
                projectsContent.Text = "";
            }
        }

        protected void converter_Click(object sender, EventArgs e)
        {
            projectsContent.Text = converterText;
            mainContent.Text = projectsBul;
        }
        
    }
}
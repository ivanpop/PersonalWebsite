using System;
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
            "степен, в същия университет, със специалност \"Софтуерни &nbsp;технологии\".<br><br>&nbsp;От декември 2009г, четири месеца след"+
            " записването ми в &nbsp;университета, работя в магазин \"Метро Пловдив 2\", от начало &nbsp;като обикновен сътрудник и впоследствие "+
            "като продуктов &nbsp;консултант.<br><br>&nbsp;Работата ми в магазина ме научи да работя в екип, да работя с клиенти, да си планирам "+
            "работния ден и приоритизирам задачите си.<br><br>През останалото време решавам курсове от <a href=\"https://telerikacademy.com/\">"+
            "Софтуерна академия \"Телерик\"</a> и <a href=\"https://softuni.bg/\">" +
            "Софтуерен университет\"</a>, както и мой лични проекти.Част от тях могат да се видят в моя Github акаунт.<a href=\"https://github.com/ivanpop\">" +
            "Github</a>";

        protected void Page_Load(object sender, EventArgs e)
        {
            mainContent.Text = aboutMeBul;
        }

        protected void switchEngBtn_Click(object sender, EventArgs e)
        {
            mainContent.Text = aboutMeEng;
            lang.Text = "English";
            title.Text = "About me";
            navigation.Text = "Navigation";
            ivanpopov.Visible = false;
        }

        protected void switchBulBtn_Click(object sender, EventArgs e)
        {
            mainContent.Text = aboutMeBul;
            lang.Text = "Български";
            title.Text = "За мен";
            navigation.Text = "Навигация";
            ivanpopov.Visible = false;
        }

        protected void aboutMe_Click(object sender, EventArgs e)
        {
            mainContent.Text = aboutMeBul;
            lang.Text = "Български";
            title.Text = "За мен";
            navigation.Text = "Навигация";
            ivanpopov.Visible = false;
        }

        protected void biography_Click(object sender, EventArgs e)
        {
            mainContent.Text = biographyBul;
            lang.Text = "Български";
            title.Text = "Автобиография";
            navigation.Text = "Навигация";
            ivanpopov.Visible = true;            
        }

        protected void projects_Click(object sender, EventArgs e)
        {
            ivanpopov.Visible = false;
        }

        protected void contacts_Click(object sender, EventArgs e)
        {
            ivanpopov.Visible = false;
        }
        
    }
}
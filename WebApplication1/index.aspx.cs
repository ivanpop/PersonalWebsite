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
            "степен, в същия университет, със специалност \"Софтуерни &nbsp;технологии\", която също завърших успешно.<br><br>&nbsp;От декември 2009г, четири месеца след"+
            " записването ми в &nbsp;университета, работя в магазин \"Метро Пловдив 2\", от начало &nbsp;като обикновен сътрудник и впоследствие " +
            "като продуктов &nbsp;консултант.<br><br>&nbsp;Работата ми в магазина ме научи да работя в екип, да работя с клиенти, да си планирам " +
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

        string converterTextBul = "<br><br><h1>Converter</h1><br><em>Програма за преобразуване на мерни единици.</em><br><br>Програмата е написана на" +
            " C# и представлява прост конвертор или преобразувател на мерни единици.Възможните мерни единици могат да се видят на изображението.<br><br>" +
            "<img src=\"/Resources/convertor1.jpg\"><br><br><b>Source: </b><a href=\"https://github.com/ivanpop/Converter\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/convertor.exe\">Convertor</a></td><td class=\"size\">49.0 KB</td> " + 
            " </tr></tbody></table>";

        string stopwatchTextBul = "<br><br><h1>Countdown timer and stopwatch</h1><br><em>Обратно броене и секундомер.</em><br><br>Написана е на C# и представлява програма " + 
            " за обратно броене и секундомер. При изтичане на времето се чува бийпване. Прогресът може да се види и на таскбара, дори и програмата да е минимализирана. " + 
            "Перфектна програма, ако често варите яйца или готвите. ;) <br> Секундомера измерва с точност от милисекунда. Има възможност за отчитане на обиколка, пауза и " + 
            "записване на времената на обиколките като текстов файл.<br>Обратното броене и секундомера са напълно независими един от друг и могат да работят едновременно.<br><br>" +
            "<img src=\"/Resources/CT1.jpg\"><br><br><img src=\"/Resources/CT2.jpg\"><br><br><b>Source: </b><a href=\"https://github.com/ivanpop/Stopwatch\" target=\"_blank\">" + 
            "<b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/countdown timer.exe\">Countdown Timer</a></td><td class=\"size\">959.0 KB</td> " +
            " </tr></tbody></table>";

        string ryuTextBul1 = "<br><br><h1>Ryu: The Big Adventure!</h1><br><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br><br>" +
            "<h2>Описание</h2><br><span class=\"tab\"></span><b>Ryu: The Big Adventure</b> е подобие на аркадните игри <b>Cadillacs and Dinosaurs, Contra, Metal Slug, Streets of Rage, Golden Axe</b> и още много други." +
            "<br><br><h2>Функции</h2><br><span class=\"tab\"></span>Играта „Ryu: The Big Adventure” предоставя на потребителите възможността да играят на един типичен хоризонтален beat 'em up симулатор." + 
            " Beat 'em up е жанр в компютърните игри, който включва ръкопашен бой между главният герой и голям брой врагове. Игрите са най-често 2D, като героят се движи хоризонтално" +
            " по нивото, в посока надясно. Тези игри са познати с простия си и лесен за научаване геймплей, като първата подобна игра датира от 1984г.<br><span class=\"tab\"></span>При стартиране на играта, " +
            "потребителя влиза в ролята на героят Ryu, който има за цел да победи всички врагове в нивото.<br><span class=\"tab\"></span>Ryu е герой от видео игри, създаден от Capcom още през 1987 година, играещ " +
            " основна роля в Street Fighter серията. Той владее бойни изкуства смесени с изкуствата на убиец.Освен върховните си умения в ръкопашният бой, Ryu разполага и с някои уникални" +
            " умения към арсенала си.<br><br><li><b>Hadouken</b> - В превод „Юмрук от енергия“.Това е вълна от енергия, която Ryu изстрелва от ръцете си, за да покоси врагове, които се намират на" +
            " разстояние от него. За да изпълни това умение Ryu трябва да има достатъчно вътрешна енергия или MP (Magic Points).<br><img src=\"/Resources/ryu3.png\"><br>" +
            "</li><br><li><b>Shoryuken</b> - В превод „Издигащ се драконов юмрук“, е друго 	специално умение, предназначено за близък бой. Ryu 	използва юмрука си за да се изстреля нагоре " +
            "и така да нанесе убийствен ъперкът към противника, който се намира непосредствено до него. Както Hadouken и Shoryuken изисква 	вътрешна енергия.<br><img src=\"/Resources/ryu1.png\"><br></li>" +
            "<br><li><b>Tatsumaki</b> - В превод „Торнадо“. Ryu има умението да скочи и да изпълни торнадо от ритници докато е във въздуха. Това е най-силната атака на Ryu и изисква най-много" +
            " вътрешна 	енергия.<br><img src=\"/Resources/ryu2.jpg\">";

        string ryuTextBul2 = "<br><br><h1>Ryu: The Big Adventure!</h1><br><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br><br>" +
            "<span class=\"tab\"></span>Вътрешната енергия се изобразява в долният ляв ъгъл на екрана, под формата на 8 сини правоъгълника, обозначени с MP. Тя е нужна за изпълнението на специалните " +
            " умения на Ryu. След нейното използване, енергията се запълва по малко, с времето. Когато героят няма достатъчно енергия, той не може да изпълнява специалните си умения.<br>" +
            "<span class=\"tab\"></span>Над индикатора за енергията има и още един индикатор за здравето на Ryu, обозначен като HP. То също е изобразено чрез 8 правоъгълника, но в червено. За разлика от енергията," +
            " здравето не се възобновява с времето. За целта Ryu трябва да намери храна, която е пръсната из нивото. Здравето ни се отнема когато биваме ударени от някой противник или" +
            " когато преминем през някакво препядствие, като огън. Когато здравето ни се изчерпа нашият герой умира и играта приключва.<br><span class=\"tab\"></span>Освен тези два индикатора имаме и време." +
            "Времето се изписва в долната част на екрана, по средата. То показва, колко време имаме за да преминем нивото. Когато времето изтече, играта приключва с лош край. Времето" +
            "се възобновява след като преминем част от нивото, примерно средата на нивото.<br><span class=\"tab\"></span>Освен да използва основната игрова функционалност, потребителят може също да спира и пуска" +
            "звука на приложението, да променя силата на звука и на музиката и да променя преди игровата сесия трудността и да напусне играта по всяко време. Играта също може да бъде" +
            "минимизирана.<br><br><h2>Софтуерни ограничения</h2><br><span class=\"tab\"></span>За ползване на играта Ryu: The Big Adventure е необходима инсталацията на JRE " +
            "(Java Runtime Environment). JRE е достъпен от сайта на Oracle.&nbsp;<a href=\"http://www.oracle.com/technetwork/java/javase/downloads/index.html\" target=\"_blank\">" +
            "<b><u>Link</u></b></a><br><br><h2>Допускания и зависимости</h2><br><span class=\"tab\"></span>Достъпът до дистрибуцията на играта е зависим от GitHub, уеб хранилището" +
            "за разполагане на софтуерни проекти и техните съвместни разработки върху отдалечен интернет сървър.<br><span class=\"tab\"></span>Проектът прави допускането и разчита, че порталът GitHub, който се" +
            "поддържа от трета страна, е достъпен и в изправност.<br><span class=\"tab\"></span>Прави се също допускането, че крайните потребители разполагат със съвместим персонален компютър с инсталират Java Runtime" +
            "Environment. Към момента на създаването на дипломната работа, Java езикът е с голяма популярност и повечето компютри имат инсталиран нужният пакет, което спомага за лесното " +
            "разпространение на играта.<br><br><h2>Диаграма на състоянията</h2><br><span class=\"tab\"></span>Диаграмата на състоянията в този раздел показва как играта Ryu: The Big Adventure " +
            "трябва да обработва заявките на крайния потребител.<br><span class=\"tab\"></span>Диаграмата е изградена чрез Унифицираният език за моделиране (UML), който е графичен език за конструиране и документиране на " +
            "елементите на една софтуерна система.<br><br><img src=\"/Resources/ryu4.png\" width=\"592\" height=\"400\"><a href=\"/Resources/ryu4.png\"" +
            "target=\"_blank\"><b><u>Оригинален размер</u></b></a><br><br><span class=\"tab\"></span>В проекта се използват 4 различни състояния, едно за менюто, второто за настройките, третото е „За Автора“ и" +
            "последното е за самата игра. Описани са и начините, по които може да се премине от едно състояние към друго, чрез насочени стрелки. Черните точки илюстрират пускането на програмата и съответно изключването й.";

        string ryuTextBul3 = "<br><br><h1>Ryu: The Big Adventure!</h1><br><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br><br>" +
            "<h2>Реализация</h2><br><h3>Потребителско меню</h3><br><span class=\"tab\"></span>Първата цел при създаването на проекта е да се направи начално потребителско меню.<br><br><img src=\"/Resources/ryu5.jpg\" width=\"592\">" +
            "<span class=\"tab\"></span>Основните събития, за които контролерът е „абониран“ е началото на нова игра (при натискане на бутон „Start Game“), показването на екран с настройки, екран „За Автора“ и изход от приложението." +
            " В менюто е изобразен и главният ни герой, в която роля се очаква да влезем.<br><br><h3>Настройки</h3><br><span class=\"tab\"></span>Менюто с настройките съдържа две маркиращи квадратчета, за включване и изключване на музиката" + 
            " и звуците, два слайдера за контролиране силата на звука и опция за контролиране на трудността на играта, както и бутон за връщане обратно към основното меню.<br>" +
            "<span class=\"tab\"></span>В менюто с настройките са използвани глобални променливи, които са достъпни до всеки един клас. Те се обявяват в главното меню, променят се в менюто с настройките и се прочитат от всяко едно събитие." +
            " Така звукът и музиката работят еднакво, във всяко едно състояние.<br><br><img src=\"/Resources/ryu6.jpg\" width=\"592\"><span class=\"tab\"></span>Трудността оказва влияние на издръжливостта на противниците. Когато трудността" +
            " е настроена на Hard, противниците са по-корави и са нужни повече удари за да бъдат убити и обратното. За постигането на целта се използва глобалната променлива difficulty, която приема следните три" + 
            " стойности: 0 за Easy, 1 за Normal и 2 за Hard. При 0 издръжливостта на противниците се намаля до 50% от нормалното, при 1 издръжливостта не се променя и остава на стандартното 100%, а при 2 тя се" +
            " повишава до 150%.<br><span class=\"tab\"></span>Слайдера за музиката използва метода  music.setVolume(float volume); за промяна на силата на музиката и music.getVolume(float volume); за да прочита каква е силата в момента " +
            "и да променя собственото си състояние.<br><span class=\"tab\"></span>Слайдера за звуците използва своя собствена глобална променлива, вместо методите  setVolume и getVolumе поради това, че силата на звукът им се декларира," + 
            " когато те бъдат възпроизведени и може да е различен за всеки един звук. Глобалната променлива се декларира в менюто и се нарича soundVolume. Тя се използва с прозвучаването на всеки един звук по" +
            " следния начин: <br>punchedSnd.play(1, Menu.soundVolume);<br><span class=\"tab\"></span>В горната команда звукът punchedSnd бива прозвирен чрез метода play. 1 представлява стъпката на звукът а променливата  soundVolume се " +
            "извиква от класът Menu и контролира неговата му сила.<br><span class=\"tab\"></span>За маркиращите квадратчета са използвани булевите soundOn и musicOn.<br><br><h3>За автора</h3><br><span class=\"tab\"></span>Credits или „За автора“ е най-просто изграденото " + 
            " състояние. То показва информация за създателите на приложението, под формата на слайдващ се нагоре текст. Информацията всъщност представлява едно голямо изображение, което се движи нагоре по екрана" + 
            " през определен интервал от време.";

        string projectsBul = "Тук съм показал някои от проектите върху които работя.<br><br>";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            mainContent.Text = aboutMeBul;
            visibilities();
            pageLbl.Text = "<br><br>Страница: ";
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
            projectsContent.Text = "";
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

            ryuPages(0);
        }

        protected void converter_Click(object sender, EventArgs e)
        {
            projectsContent.Text = converterTextBul;
            mainContent.Text = "";
            visibilities();
        }

        protected void countdown_Click1(object sender, EventArgs e)
        {
            projectsContent.Text = stopwatchTextBul;
            mainContent.Text = "";
            visibilities();
        }

        protected void ryu_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul1;
            mainContent.Text = "";            
            ryuPages(1);
        }

        protected void ryuPages(int page)
        {            
            if (page == 1)
            {
                ryuPage1.Visible = true;
                ryuPage2.Visible = true;
                ryuPage3.Visible = true;
                pageLbl.Visible = true;
            }
            if (page == 0)
            {
                ryuPage1.Visible = false;
                ryuPage2.Visible = false;
                ryuPage3.Visible = false;
                ryuPage1.Enabled = false;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = true;
                pageLbl.Visible = false;
            }
            if (page == 2)
            {
                ryuPage1.Enabled = true;
                ryuPage2.Enabled = false;
                ryuPage3.Enabled = true;
                ryuPage1.Visible = true;
                ryuPage2.Visible = true;
                ryuPage3.Visible = true;
                pageLbl.Visible = true;
            }
            if (page == 3)
            {
                ryuPage1.Enabled = true;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = false;
                ryuPage1.Visible = true;
                ryuPage2.Visible = true;
                ryuPage3.Visible = true;                
                pageLbl.Visible = true;                
            }
        }

        protected void ryuPage2_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul2;
            mainContent.Text = ""; 
            ryuPages(2);
        }

        protected void ryuPage1_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul1;
            mainContent.Text = "";
            ryuPages(1);
            ryuPage1.Enabled = false;
            ryuPage2.Enabled = true;
            ryuPage3.Enabled = true;
        }

        protected void ryuPage3_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul3;
            mainContent.Text = "";
            ryuPages(3);
        }
    }
}
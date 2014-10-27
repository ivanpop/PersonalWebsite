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
        string aboutMeBul = "<p>Здравейте,<br/><br/><span class=\"tab\"></span>Казвам се Иван Попов и съм новозавършил във ФМИТ на Пловдивския Университет \"Паисий Хилендарски\"." +
            "<br/><br/><span class=\"tab\"></span>Това е моята лична интернет страница.Тук ще намерите информация за мен и актуалните проекти, по които работя активно.<br/><br/>" +
            "<span class=\"tab\"></span>Моите интереси са основно в областта на Информационните Технологии, Езиците за програмиране и Средите за програмиране.";

        string aboutMeEng = "<p>Hello,<br/><br/>My name is Ivan Popov and I am a graduate in FMIT in Plovdiv University \"Paisii Hilendasrki\".<br/><br/>"+
            "This is my personal web page. Here you will find information about me and project, I work on.<br/><br/>"+
            "My interests are mainly in the field of information technology, programming languages ​​and their programming environments.";

        string biographyBul = "<span class=\"tab\"></span>Роден съм на 19.01.1990г. в гр. Пловдив, България.<br/><br/>" +
            "<span class=\"tab\"></span>Завърших висшето си образование, степен бакалавър, в &nbsp;Пловдивски университет \"Паисий Хилендарски\" през 2013 г." +
            "със &nbsp;специалност \"Информатика\".<br/><br/><span class=\"tab\"></span>Непосредствено след завършването си записах магистърска &nbsp;" +
            "степен, в същия университет, със специалност \"Софтуерни &nbsp;технологии\", която също завърших успешно.<br/><br/><span class=\"tab\"></span>От декември 2009г, четири месеца след" +
            " записването ми в &nbsp;университета, работя в магазин \"Метро Пловдив 2\", от начало &nbsp;като обикновен сътрудник и впоследствие " +
            "като продуктов &nbsp;консултант.<br/><br/><span class=\"tab\"></span>Работата ми в магазина ме научи да работя в екип, да работя с клиенти, да си планирам " +
            "работния ден и приоритизирам задачите си.<br/><br/><span class=\"tab\"></span>През останалото време решавам курсове от <a href=\"https://telerikacademy.com/\" target=\"_blank\">" +
            "<b><u>Софтуерна академия \"Телерик\"</b></u></a> и <a href=\"https://softuni.bg/\" target=\"_blank\">" +
            "<b><u>Софтуерен университет</b></u>\"</a>, както и мой лични проекти.Част от тях могат да се видят в моя Github акаунт. <a href=\"https://github.com/ivanpop\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><br/><br/><span class=\"tab\"></span>Като хоби имам YouTube канал, в който качвам кадри от игри и показвам дългите години придобит опит със снайпера и двуцевката. ;)" +
            "<a href=\"https://www.youtube.com/user/unfragablegaming/\" target=\"_blank\">" + "<b><u>Unfragable Gaming</u></b></a><br/><br/><span class=\"tab\"></span>Целта ми е да работя в IT-сферата " + 
            "и да продължавам да си развивам уменията на програмист.<br/><br/><hr><br/><br/><h1>Образование</h1><br/><br/><span class=\"round-bar blue-bar\">2014 г.</span> ПУ \"Паисий Хилендарски\" " +
            "- Пловдив, висше образование, степен магистър, специалност \"Софтуерни технологии\".<br/><br/><span class=\"round-bar blue-bar\">2013 г.</span> ПУ \"Паисий Хилендарски\" - Пловдив, " +
            " висше образование, степен бакалавър, специалност \"Информатика\".<br/><br/><span class=\"round-bar blue-bar\">1997 г.</span> ОУ \"Райна Княгиня\" - Пловдив, основно образование.<br/><br/> " +
            "<hr><br/><br/><h1>Езици</h1><br/><br/>Български – майчин език.<br/><br/>Английски – четене - отлично, писане - много добро, разговор - много добро." +
            "<br/><br/>Френски – четене - основно, писане - основно, разговор - основно.<br/><br/><hr><br/><br/><h1>Трудов опит</h1><br/><br/><span class=\"round-bar blue-bar\">12/2009 - 07/2014</span> Сътрудник" +
            " впоследствие Продуктов консултант, в магазин \"Метро 2 Пловдив\".<br/><br/><span class=\"round-bar blue-bar\">11/2012 - 04/2013</span> Оператор въвеждане на данни в “Highstyle” Ltd." +
            "<br/><br/><hr><br/><br/><h1>Други</h1><br/><br/><b>Езици за програмиране:</b><br/><br/>C#, C++, Java, JavaScript...<br/><br/><b>Технологии и стандарти:</b>" +
            "<br/><br/>HTML/DHTML, CSS, ASP.NET, jQuery, MySQL...<br/><br/><b>Програми:</b><br/><br/>MS Visual Studio 2013 for Desktop, Eclipse IDE," +
            "MS Visual Studio 2013 for Web, Notepad++;<br/>MS Office, Libre Office, Adobe Photoshop, Adobe Premiere Pro, Audacity";

        string biographyEng = "<span class=\"tab\"></span>I'm born on 19.01.1990г. in Plovdiv, Bulgaria.<br/><br/>&nbsp;" +
            "<span class=\"tab\"></span>I graduated from Plovdiv University \"Paisii Hilendarski\" in &nbsp;2013, with a bachelor degree in Informatics." +
            "<br/><br/><span class=\"tab\"></span>Right after that I started studying masters degree, in the same &nbsp;university, in the field of \"Software Technologies\"," +
            "which I graduated &nbsp;in 2014.<br/><br/><span class=\"tab\"></span>From December 2009, four months after" +
            " becoming a student in &nbsp;the university, I started working in \"Metro Cash&Carry Plovdiv 2\", &nbsp;from the beginning as a regular associate and afterwards " +
            "as a &nbsp;product consultant.<br/><br/><span class=\"tab\"></span>My work in the magazine taught me to work in a team, to work with clients, to plan " +
            "my working day and to prioritize my tasks.<br/><br/><span class=\"tab\"></span>In my spare time I follow online courses in <a href=\"https://telerikacademy.com/\" target=\"_blank\">" +
            "<b><u>Software Academy \"Telerik\"</b></u></a> and <a href=\"https://softuni.bg/\" target=\"_blank\">" +
            "<b><u>The Software University</b></u>\"</a>, as well as my personal projects. Part of them can be seen in my Github account. <a href=\"https://github.com/ivanpop\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><br/><br/><span class=\"tab\"></span>As a hobby I have a YouTube channel, where I upload gameplay videos in which I show my years of experience with the sniper and the shotgun. ;)" +
            "<a href=\"https://www.youtube.com/user/unfragablegaming/\" target=\"_blank\">" + "<b><u>Unfragable Gaming</u></b></a><br/><br/><span class=\"tab\"></span>My goal is to work in the field of IT " +
            "and to continue to develop my skills as a programmer.<br/><br/><hr><br/><br/><h1>Education</h1><br/><br/><span class=\"round-bar blue-bar\">2014</span> PU \"Paisii Hilendarski\" " +
            "- Plovdiv, Masters degree, field of \"Software Technologies\".<br/><br/><span class=\"round-bar blue-bar\">2013</span> PU \"Paisii Hilendarski\" - Plovdiv, " +
            " Bachelors degree, field of \"Informatics\".<br/><br/><span class=\"round-bar blue-bar\">1997</span> Elementary school \"Rayna Knyaginya\" - Plovidv.<br/><br/> " +
            "<hr><br/><br/><h1>Languages</h1><br/><br/>Bulgarian – mother's language.<br/><br/>English – reading - great, writing - great, speaking - great." +
            "<br/><br/>French – reading - basic, writing - basic, speaking - basic.<br/><br/><hr><br/><br/><h1>Working experience</h1><br/><br/><span class=\"round-bar blue-bar\">12/2009 - 07/2014</span> Associate" +
            " and after that Product consultant in \"Metro Cash&Carry 2 Plovdiv\".<br/><br/><span class=\"round-bar blue-bar\">11/2012 - 04/2013</span> Data entry operator in “Highstyle” Ltd." +
            "<br/><br/><hr><br/><br/><h1>Other</h1><br/><br/><b>Programming languages:</b><br/><br/>C#, C++, Java, JavaScript...<br/><br/><b>Technologies and standarts:</b>" +
            "<br/><br/>HTML/DHTML, CSS, ASP.NET, jQuery, MySQL...<br/><br/><b>Programs:</b><br/><br/>MS Visual Studio 2013 for Desktop, Eclipse IDE," +
            "MS Visual Studio 2013 for Web, Notepad++;<br/>MS Office, Libre Office, Adobe Photoshop, Adobe Premiere Pro, Audacity";

        string converterTextBul = "<br/><br/><h1>Converter</h1><br/><em>Програма за преобразуване на мерни единици.</em><br/><br/><span class=\"tab\"></span>Програмата е написана на" +
            " C# и представлява прост конвертор или преобразувател на мерни единици.Възможните мерни единици могат да се видят на изображението.<br/><br/>" +
            "<img src=\"/Resources/convertor1.jpg\"><br/><br/><b>Source: </b><a href=\"https://github.com/ivanpop/Converter\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/convertor.exe\">Convertor</a></td><td class=\"size\">49.0 KB</td> " + 
            " </tr></tbody></table>";

        string converterTextEng = "<br/><br/><h1>Converter</h1><br/><em>Program for converting metric units.</em><br/><br/><span class=\"tab\"></span>The program is written in" +
            " C# and it's a simple converter of metric units. Different metric units can be seen in the screenshot.<br/><br/>" +
            "<img src=\"/Resources/convertor1.jpg\"><br/><br/><b>Source: </b><a href=\"https://github.com/ivanpop/Converter\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/convertor.exe\">Convertor</a></td><td class=\"size\">49.0 KB</td> " +
            " </tr></tbody></table>";

        string stopwatchTextBul = "<br/><br/><h1>Countdown timer and stopwatch</h1><br/><em>Обратно броене и секундомер.</em><br/><br/><span class=\"tab\"></span>Написана е на C# и представлява програма " + 
            " за обратно броене и секундомер. При изтичане на времето се чува бийпване. Прогресът може да се види и на таскбара, дори и програмата да е минимализирана. " +
            "Перфектна програма, ако често варите яйца или готвите. ;) <br/><span class=\"tab\"></span>Секундомера измерва с точност от милисекунда. Има възможност за отчитане на обиколка, пауза и " +
            "записване на времената на обиколките като текстов файл.<br/><span class=\"tab\"></span>Обратното броене и секундомера са напълно независими един от друг и могат да работят едновременно.<br/><br/>" +
            "<img src=\"/Resources/CT1.jpg\"><br/><br/><img src=\"/Resources/CT2.jpg\"><br/><br/><b>Source: </b><a href=\"https://github.com/ivanpop/Stopwatch\" target=\"_blank\">" + 
            "<b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/countdown timer.exe\">Countdown Timer</a></td><td class=\"size\">959.0 KB</td> " +
            " </tr></tbody></table>";

        string stopwatchTextEng = "<br/><br/><h1>Countdown timer and stopwatch</h1><br/><em>Countdown timer and a stopwatch.</em><br/><br/><span class=\"tab\"></span>Written in C#, this is a " +
            " countdown timer and a stopwatch. When the timer reaches 0, there is a beep. The progress can be seen in the taskbar, even if the program is minimized. " +
            "Perfect if you often boil eggs or cook. ;) <br/><span class=\"tab\"></span>The stopwatch has a precision of a millisecond. There is an option to count a lap, pause and " +
            "to save the lap times in a text file.<br/><span class=\"tab\"></span>The countdown timer and the stopwatch are completly independent on from the other and can work simultaneously.<br/><br/>" +
            "<img src=\"/Resources/CT1.jpg\"><br/><br/><img src=\"/Resources/CT2.jpg\"><br/><br/><b>Source: </b><a href=\"https://github.com/ivanpop/Stopwatch\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/countdown timer.exe\">Countdown Timer</a></td><td class=\"size\">959.0 KB</td> " +
            " </tr></tbody></table>";

        string ryuTextBul1 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/>" +
            "<h2>Описание</h2><br/><span class=\"tab\"></span><b>Ryu: The Big Adventure</b> е подобие на аркадните игри <b>Cadillacs and Dinosaurs, Contra, Metal Slug, Streets of Rage, Golden Axe</b> и още много други." +
            "<br/><br/><h2>Функции</h2><br/><span class=\"tab\"></span>Играта „Ryu: The Big Adventure” предоставя на потребителите възможността да играят на един типичен хоризонтален Beat 'em up симулатор." + 
            " Beat 'em up е жанр в компютърните игри, който включва ръкопашен бой между главният герой и голям брой врагове. Игрите са най-често 2D, като героят се движи хоризонтално" +
            " по нивото, в посока надясно. Тези игри са познати с простия си и лесен за научаване геймплей, като първата подобна игра датира от 1984г.<br/><span class=\"tab\"></span>При стартиране на играта, " +
            "потребителя влиза в ролята на героят Ryu, който има за цел да победи всички врагове в нивото.<br/><span class=\"tab\"></span>Ryu е герой от видео игри, създаден от Capcom още през 1987 година, играещ " +
            " основна роля в Street Fighter серията. Той владее бойни изкуства смесени с изкуствата на убиец.Освен върховните си умения в ръкопашният бой, Ryu разполага и с някои уникални" +
            " умения към арсенала си.<br/><br/><li><b>Hadouken</b> - В превод „Юмрук от енергия“.Това е вълна от енергия, която Ryu изстрелва от ръцете си, за да покоси врагове, които се намират на" +
            " разстояние от него. За да изпълни това умение Ryu трябва да има достатъчно вътрешна енергия или MP (Magic Points).<br/><img src=\"/Resources/ryu3.png\"><br/>" +
            "</li><br/><li><b>Shoryuken</b> - В превод „Издигащ се драконов юмрук“, е друго 	специално умение, предназначено за близък бой. Ryu 	използва юмрука си за да се изстреля нагоре " +
            "и така да нанесе убийствен ъперкът към противника, който се намира непосредствено до него. Както Hadouken и Shoryuken изисква 	вътрешна енергия.<br/><img src=\"/Resources/ryu1.png\"><br/></li>" +
            "<br/><li><b>Tatsumaki</b> - В превод „Торнадо“. Ryu има умението да скочи и да изпълни торнадо от ритници докато е във въздуха. Това е най-силната атака на Ryu и изисква най-много" +
            " вътрешна 	енергия.<br/><img src=\"/Resources/ryu2.jpg\">";

        string ryuTextEng1 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/>" +
            "<h2>Description</h2><br/><span class=\"tab\"></span><b>Ryu: The Big Adventure</b> is simmilar to arcade games like <b>Cadillacs and Dinosaurs, Contra, Metal Slug, Streets of Rage, Golden Axe</b> and many others." +
            "<br/><br/><h2>Functions</h2><br/><span class=\"tab\"></span>„Ryu: The Big Adventure” gives the user the chance to play a tipical horizontal Beat 'em up simulator." +
            " Beat 'em up is a computer game genre, which involves hand-to-hand combat between the main hero and numerous enemies. These type of games are mostly in 2D, where the player moves horizontaly" +
            " to the right. These games are famous for they're easy to learn gameplay, with the first of this type of games dating from 1984<br/><span class=\"tab\"></span>When starting the game, " +
            "the user goes in the role of Ryu, which have to beat all the enemies in the level.<br/><span class=\"tab\"></span>Ryu is a superhero from video games, created by Capcom in 1987, which plays " +
            " the main role in the Street Fighter series. He knows mixed martial arts and assassin skills. Also Ryu possesses some unique abilities in his arsenal." +
            " .<br/><br/><li><b>Hadouken</b> - Translated „Fist of energy“. This is a projectile of energy, which Ryu shoots from his hands, to hit enemies from distance." +
            " To do this ability Ryu must have enough energy or MP (Magic Points).<br/><img src=\"/Resources/ryu3.png\"><br/>" +
            "</li><br/><li><b>Shoryuken</b> - Translated „Rising dragon fist“, is another special ability, designet for close combat. Ryu uses his fist to shoots himself up " +
            "and in that way to deliver a deadly upercut to his oponent, which is directly in front of him. Just like Hadouken Shoryuken also requires spirit energy.<br/><img src=\"/Resources/ryu1.png\"><br/></li>" +
            "<br/><li><b>Tatsumaki</b> - Translated „Tornado“. Ryu haves the ability to jump and to perform a tornato from kicks while in mid air. This is the most powerful attack that Ryu possesses and it" +
            " requires most spirit energy.<br/><img src=\"/Resources/ryu2.jpg\">";

        string ryuTextBul2 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/>" +
            "<span class=\"tab\"></span>Вътрешната енергия се изобразява в долният ляв ъгъл на екрана, под формата на 8 сини правоъгълника, обозначени с MP. Тя е нужна за изпълнението на специалните " +
            " умения на Ryu. След нейното използване, енергията се запълва по малко, с времето. Когато героят няма достатъчно енергия, той не може да изпълнява специалните си умения.<br/>" +
            "<span class=\"tab\"></span>Над индикатора за енергията има и още един индикатор за здравето на Ryu, обозначен като HP. То също е изобразено чрез 8 правоъгълника, но в червено. За разлика от енергията," +
            " здравето не се възобновява с времето. За целта Ryu трябва да намери храна, която е пръсната из нивото. Здравето ни се отнема когато биваме ударени от някой противник или" +
            " когато преминем през някакво препядствие, като огън. Когато здравето ни се изчерпа нашият герой умира и играта приключва.<br/><span class=\"tab\"></span>Освен тези два индикатора имаме и време." +
            "Времето се изписва в долната част на екрана, по средата. То показва, колко време имаме за да преминем нивото. Когато времето изтече, играта приключва с лош край. Времето" +
            "се възобновява след като преминем част от нивото, примерно средата на нивото.<br/><span class=\"tab\"></span>Освен да използва основната игрова функционалност, потребителят може също да спира и пуска" +
            "звука на приложението, да променя силата на звука и на музиката и да променя преди игровата сесия трудността и да напусне играта по всяко време. Играта също може да бъде" +
            "минимизирана.<br/><br/><h2>Софтуерни ограничения</h2><br/><span class=\"tab\"></span>За ползване на играта Ryu: The Big Adventure е необходима инсталацията на JRE " +
            "(Java Runtime Environment). JRE е достъпен от сайта на Oracle.&nbsp;<a href=\"http://www.oracle.com/technetwork/java/javase/downloads/index.html\" target=\"_blank\">" +
            "<b><u>Link</u></b></a><br/><br/><h2>Допускания и зависимости</h2><br/><span class=\"tab\"></span>Достъпът до дистрибуцията на играта е зависим от GitHub, уеб хранилището" +
            "за разполагане на софтуерни проекти и техните съвместни разработки върху отдалечен интернет сървър.<br/><span class=\"tab\"></span>Проектът прави допускането и разчита, че порталът GitHub, който се" +
            "поддържа от трета страна, е достъпен и в изправност.<br/><span class=\"tab\"></span>Прави се също допускането, че крайните потребители разполагат със съвместим персонален компютър с инсталират Java Runtime" +
            "Environment. Към момента на създаването на проекта, Java езикът е с голяма популярност и повечето компютри имат инсталиран нужният пакет, което спомага за лесното " +
            "разпространение на играта.<br/><br/><h2>Диаграма на състоянията</h2><br/><span class=\"tab\"></span>Диаграмата на състоянията в този раздел показва как играта Ryu: The Big Adventure " +
            "трябва да обработва заявките на крайния потребител.<br/><span class=\"tab\"></span>Диаграмата е изградена чрез Унифицираният език за моделиране (UML), който е графичен език за конструиране и документиране на " +
            "елементите на една софтуерна система.<br/><br/><img src=\"/Resources/ryu4.png\" width=\"592\" height=\"400\"><a href=\"/Resources/ryu4.png\"" +
            "target=\"_blank\"><b><u>Оригинален размер</u></b></a><br/><br/><span class=\"tab\"></span>В проекта се използват 4 различни състояния, едно за менюто, второто за настройките, третото е „За Автора“ и" +
            "последното е за самата игра. Описани са и начините, по които може да се премине от едно състояние към друго, чрез насочени стрелки. Черните точки илюстрират пускането на програмата и съответно изключването й.";

        string ryuTextEng2 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/>" +
            "<span class=\"tab\"></span>Spirit energy is displayed in the lower left corner of the screen, in the form of 8 blue rectangles. It's used when performing special " +
            " moves. After being used, energy regenerates slowly over time. When the player doesn't have enough energy, he can't use special abilities.<br/>" +
            "<span class=\"tab\"></span>Over the energy indicator there is another one, for the health of Ryu, described as HP. It's displayed in the same way, but with red rectangles. Unlike energy," +
            " health doesn't regenerate over time. To restore health Ryu must find food which is dropped randomly on the map. Health is taken when the player gets hit or" +
            " when he goes through some obsticle like fire. When all of our health is depleted Ryu dies and the game ends.<br/><span class=\"tab\"></span>Other than those two indicators there is alos time." +
            "Time is displayer at the bottom of the screen in the middle. It shows how much time we have to complete the level. When the time ends the game ends. We get more time" +
            "by reaching certain part of the level.<br/><span class=\"tab\"></span>There are also in-game options. The user can stop and start" +
            " the sound of the game, to change the volume, to change the game difficulty and to quit at any time. The game can also be" +
            " minimized.<br/><br/><h2>Software limitations</h2><br/><span class=\"tab\"></span>To play Ryu: The Big Adventure we need JRE " +
            "(Java Runtime Environment). JRE is available from Oracle's website.&nbsp;<a href=\"http://www.oracle.com/technetwork/java/javase/downloads/index.html\" target=\"_blank\">" +
            "<b><u>Link</u></b></a><br/><br/><h2>Acceptances and dependencies</h2><br/><span class=\"tab\"></span>The source code can be found on GitHub, a web-based hosting service" +
            "for source code management (SCM) and distributed revision control.<br/><span class=\"tab\"></span>The project makes the assumption that GitHub, which is" +
            " managed by third-party administration is accessible.<br/><span class=\"tab\"></span>There is also the acceptance, that the users have compatible computer with Java Runtime" +
            "Environment installed on it. At the moment of creating the project, The Java programming language is very popular and most computers have the required package installed, which helps " +
            "the easy distribution of the game.<br/><br/><h2>State diagram</h2><br/><span class=\"tab\"></span>The state diagram shows how the game Ryu: The Big Adventure " +
            "handles user commands.<br/><span class=\"tab\"></span>The diagram is created using The Unified Modeling Language (UML), a general-purpose modeling language in the field of software engineering, which is designed to provide a standard way to visualize the design of a system. " +
            ".<br/><br/><img src=\"/Resources/ryu4.png\" width=\"592\" height=\"400\"><a href=\"/Resources/ryu4.png\"" +
            "target=\"_blank\"><b><u>Original size</u></b></a><br/><br/><span class=\"tab\"></span>There are 4 different states in the project - menu, options, credits and" +
            "the game itself. We can see the ways we can pass through different states.";

        string ryuTextBul3 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/>" +
            "<h2>Реализация</h2><br/><h3>Потребителско меню</h3><br/><span class=\"tab\"></span>Първата цел при създаването на проекта е да се направи начално потребителско меню.<br/><br/><img src=\"/Resources/ryu5.jpg\" width=\"592\">" +
            "<span class=\"tab\"></span>Основните събития, за които контролерът е „абониран“ е началото на нова игра (при натискане на бутон „Start Game“), показването на екран с настройки, екран „За Автора“ и изход от приложението." +
            " В менюто е изобразен и главният ни герой, в която роля се очаква да влезем.<br/><br/><h3>Настройки</h3><br/><span class=\"tab\"></span>Менюто с настройките съдържа две маркиращи квадратчета, за включване и изключване на музиката" + 
            " и звуците, два слайдера за контролиране силата на звука и опция за контролиране на трудността на играта, както и бутон за връщане обратно към основното меню.<br/>" +
            "<span class=\"tab\"></span>В менюто с настройките са използвани глобални променливи, които са достъпни до всеки един клас. Те се обявяват в главното меню, променят се в менюто с настройките и се прочитат от всяко едно събитие." +
            " Така звукът и музиката работят еднакво, във всяко едно състояние.<br/><br/><img src=\"/Resources/ryu6.jpg\" width=\"592\"><span class=\"tab\"></span>Трудността оказва влияние на издръжливостта на противниците. Когато трудността" +
            " е настроена на Hard, противниците са по-корави и са нужни повече удари за да бъдат убити и обратното. За постигането на целта се използва глобалната променлива difficulty, която приема следните три" + 
            " стойности: 0 за Easy, 1 за Normal и 2 за Hard. При 0 издръжливостта на противниците се намаля до 50% от нормалното, при 1 издръжливостта не се променя и остава на стандартното 100%, а при 2 тя се" +
            " повишава до 150%.<br/><span class=\"tab\"></span>Слайдера за музиката използва метода  music.setVolume(float volume); за промяна на силата на музиката и music.getVolume(float volume); за да прочита каква е силата в момента " +
            "и да променя собственото си състояние.<br/><span class=\"tab\"></span>Слайдера за звуците използва своя собствена глобална променлива, вместо методите  setVolume и getVolumе поради това, че силата на звукът им се декларира," + 
            " когато те бъдат възпроизведени и може да е различен за всеки един звук. Глобалната променлива се декларира в менюто и се нарича soundVolume. Тя се използва с прозвучаването на всеки един звук по" +
            " следния начин: <br/>punchedSnd.play(1, Menu.soundVolume);<br/><span class=\"tab\"></span>В горната команда звукът punchedSnd бива прозвирен чрез метода play. 1 представлява стъпката на звукът а променливата  soundVolume се " +
            "извиква от класът Menu и контролира неговата му сила.<br/><span class=\"tab\"></span>За маркиращите квадратчета са използвани булевите soundOn и musicOn.<br/><br/><h3>За автора</h3><br/><span class=\"tab\"></span>Credits или „За автора“ е най-просто изграденото " + 
            " състояние. То показва информация за създателите на приложението, под формата на слайдващ се нагоре текст. Информацията всъщност представлява едно голямо изображение, което се движи нагоре по екрана" + 
            " през определен интервал от време.";

        string ryuTextEng3 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/>" +
            "<h2>Realization</h2><br/><h3>User menu</h3><br/><span class=\"tab\"></span>The first part of the project is to create a main menu.<br/><br/><img src=\"/Resources/ryu5.jpg\" width=\"592\">" +
            "<span class=\"tab\"></span>The menu provides options to start a new game, to go to the settings screen, go ot the credits screen and exit the game." +
            " In the menu we can see the main character.<br/><br/><h3Options</h3><br/><span class=\"tab\"></span>The options menu contains to tickable squares, for turning music and sounds on and off" +
            " , two sliders for controling sound volume and an option to control game difficulty, also there is a back button.<br/>" +
            "<span class=\"tab\"></span>In the settings menu I've used global variables, which are available in every class. They are declared in the main menu, can be changed in the settings menu and can be red from all states." +
            " This way sound and music can work in the same way in every part of the game.<br/><br/><img src=\"/Resources/ryu6.jpg\" width=\"592\"><span class=\"tab\"></span>Difficulty changes enemies health by increasing or decreasing it." +
            " When the difficulty is set on Hard, enemies are much harder and require much more effort to kill. To make this I've used a global variable named Difficulty, which can take three different numbers" +
            " : 0 for Easy, 1 for Normal and 2 for Hard. At 0 health of enemies is decreased by 50% from normal, at 1 health isn't changed and at 2 " +
            ", it's increased by 50%.<br/><span class=\"tab\"></span>The music slider uses the method music.setVolume(float volume); for changing music volume and music.getVolume(float volume); to read the current volume " +
            "and to change it's state accordingly.<br/><span class=\"tab\"></span>The sound slider uses it's own global variable unlike setVolume and getVolumе because sound volume is declared," +
            " at the moment they are played and can be different for every each sound. The global variable is declared in the main manu and it's named soundVolume. It's used every time a sound is played" +
            " in the following way: <br/>punchedSnd.play(1, Menu.soundVolume);<br/><span class=\"tab\"></span>In this command punchedSnd is been played using the method play. 1 is the pitch and the variable soundVolume is " +
            "called from the menu class and sets the volume of the sound.<br/><span class=\"tab\"></span>For the thicking squares I've used the variables soundOn and musicOn.<br/><br/><h3>Credits</h3><br/><span class=\"tab\"></span>Credits is the most " +
            " simple made state. It shows information about the creator of the game by sliding text through the screen. The text is actually an image which is moved up the screen";

        string ryuTextBul4 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/>" +
            "<h2>Реализация</h2><br/><h3>Play</h3><br/><span class=\"tab\"></span>Класът Play е основното състояние на играта. В него са реализирани главният герой, " +
            "враговете му, структурата на нивото, обектите по картата и взаимоотношението между всички тях.<br/><h4>Начална анимация</h4><br/>Нивото ни приветства с начална " + 
            "анимация - „Round One“ и съпътстващ я звук. За целта се използва изображение (round1Image) и мащабиращ ефект, като така се добавя допълнителна динамика. За постигане " + 
            " на ефекта се използва командата round1Image.draw() заедно с променливата round1Scale, която отговаря за мащаба на изображението. Когато използваме командата round1Scale++;" + 
            " в update метода, променливата ще се увеличава с единица, с всеки един цикъл. По този начин и мащаба на началното изображение се увеличава и ефекта е постигнат. При стигане" +
            " до определен мащаб, началната анимация приключва, таймера се включва и потребителя получава контрол над героя.<table><tr><th>public void round1Animation()<br/>" +
            "{<br/><span class=\"tab\"></span><font color=\"green\">//round1 animation and sound</font><br/><span class=\"tab\"></span>if (round1Bool)<br/><span class=\"tab\">" + 
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>round1Scale += 4;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>if (round1Scale >= 100 && round1Scale <= 105 && Menu.soundOn)<br/><span class=\"tab\">" + 
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>round1Snd.play(1, Menu.soundVolume);<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span> " +
            "if (round1Scale >= 600 && round1Scale <= 610)<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>" +
            "round1Bool = false;<br/><span class=\"tab\"></span><span class=\"tab\"></span>enableInput = true;<br/><span class=\"tab\"></span><span class=\"tab\"></span>round1Scale = 1;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"> " + 
            "</span>Методът е round1Animation(). round1Bool се грижи за приключването на анимацията. При достигане на размер 100 се включва съпътстващият звук, а при достигане на размер 600 анимацията приключва. " + 
            " Освен за началната анимация и звук, при изпълнението на метода се променя и трудността на противниците, според въведената настройка за трудност в менюто за настройки. enableInput булевата се използва " + 
            "за позволяване и забраняване на управлението на героя. Освен при началото на играта, булевата се използва и на други места, като по време на менюто за пауза.<br/><br/><h3>Карта на нивото</h3><br/>" +
            "<span class=\"tab\"></span>Картата представлява едно голямо изображение със зелен фон наподобяващ трева. Първо, изображението е оразмерено до точната големина, за да се получи достатъчно продължително ниво. Освен тревата" + 
            " имаме и гора, от горната и долната част. Тази гора представлява обструкция, която има за цел да не позволява на героя да излиза извън границите на нивото. Гората е изградена от един единствен спрайт " +
            " на дърво. Спрайтът е взет от сайтът <a href=\"http://www.deviantart.com\" target=\"_blank\">" +
            "<b><u>www.deviantart.com</u></b></a>, сайт за публикуване на произведения на изкуството, на потребители от цял свят.<br/><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span><img src=\"/Resources/ryu7.png\" width=\"300\"><br/><span class=\"tab\"></span>След намиране на подходящият спрайт, с помощта на Photoshop, дървото" + 
            " се дублира многократно, за да се постигне ефект на гора. Процесът по изграждането на нивото е сравнително лесен, но изображението трябва да е в .png формат, поради лимитация на slick2D. Това означава," +
            " че крайният резултат от картата е файл с размер от 10MB или близо 3 пъти по-голям от еквивалента си в .jpg формат.<br/><span class=\"tab\"></span>При създаване на картата, създаваме и две променливи – " + 
            "shiftX и shiftY. Те се използват за да движат изображението в прозореца на програмата. Така когато движим героя, ние всъщност движим картата под него. Неговите координати си остават едни и същи, но получаваме ефект на движение на героя.";

        string ryuTextBul5 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/>" +
            "<h2>Реализация</h2><br/><h3>Създаване на Ryu</h3><br/><span class=\"tab\"></span>За анимиране на главният герой на играта са използвани общо 14 различни анимации. Всяка една анимация е изградена от спрайтшийтове.<br/><span class=\"tab\"></span>" +
            "Spritesheet представлява едно изображение, в което се намират няколко подизображения от анимацията наречени спрайтове.<br/><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span><img src=\"/Resources/ryu8.png\" width=\"400\"><br/>" +
            "<span class=\"tab\"></span>При декларацията използваме пътя към спрайт-изображението и x и y, които отговарят съответно за вертикалния и хоризонталния размер на кадъра в спрайта. И тук както при анимирането с отделни кадри, спрайта трябва да е в png формат и с прозрачен фон." +
            "<br/><img src=\"/Resources/ryu9.png\" width=\"594\"><br/><span class=\"tab\"></span>Кадрите в спрайта трябва да са на точно разстояние един от друг. x се сформира като се вземе хоризонталната резолюция и се раздели на броят кадри в спрайта." +
            " При несъответствие, се получават неточности, в изобразяването на анимацията.<br/><span class=\"tab\"></span>Анимацията се декларира, като за източник се използва спрайта, следван от х, отговарящ за времетраенето" +
            " на всеки един кадър в милисекунди. След изтичане на времето, кадъра се заменя автоматично от следващия в спрайта.<br/><br/><li><b>ryuStatic</b>. Това е статичната анимация. Използва се по всяко време, когато героят не" +
            " се движи или не извършва някакво действие. Освен по време на игра, спрайтът се използва и в началното меню.</li><br/><li><b>ryuReady</b>. Анимацията се използва в началното и при благополучно приключване на играта. Тя представлява " +
            " действието на Ryu, за завързване на лентата на главата си.<br/><li><b>ryuLeft</b>. Използва се при вървене назад и илюстрира отстъпване назад.</li><br/><li><b>ryuRight</b>. Използва се при движение напред/надясно, нагоре и надолу." +
            "</li><br/><li><b>ryuPunch</b>. Това е юмрукът на Ryu</li><br/><li><b>ryuLowKick</b>. Ритникът на Ryu.</li><br/><li><b>ryuHadouken</b><b>ryuShoryuken</b> и <b>ryuTatsaku</b>. Тези анимации илюстрират трите специални умения на героя.<b>ryuHadouken</b> се" +
            " използва в комбинация с <b>ryuHadoukenBall</b>, която е анимацията на изстреляната от Ryu топка от енергия.</li><br/><li><b>ryuHurt</b>. Тази анимация илюстрира как Ryu поема удър от противник.</li><br/><li><b>ryuWin1</b> и <b>ryuWin2</b>. Това" +
            " са две отделни анимации, които вървят в комбинация и се използват при благополучното приключване на играта. Те илюстрират Ryu като победител.<br/><br/><span class=\"tab\"></span>Освен за визуализацията, Ryu използва и редица звукови ефекти, взети " +
            "от различни източници от Интернет.<br/><span class=\"tab\"></span>За реализацията на героя, са използвани и множество от променливи и методи, които вдъхват живот в героя.<br/><span class=\"tab\"></span>Методът ryuPhysics() отговаря за движението," + 
            " привключването на различните анимации, ударите, специалните умения  и жизнените показатели на главният герой. Методът слуша за въвеждания от клавиатурата и движи и илюстрира героя според тях. Тук са записани продължителностите на анимацийте," + 
            " границите на нивото, които не могат да бъдат преминавани,  взаимоотношението на Ryu с препядствията и обектите за събиране по картата и следенето на неговите жизнени показатели. За да се избегне дублирането на анимацийте, всяка една от тях" + 
            " е групирана със собствена булева стойност. Когато Ryu е в статично положение, булевата ryuStatic е true и всички останали са false. Във всеки един момент, само една булева стойност може да е истина. В противен случай, на картата могат да" + 
            " се появят две различни анимации едновременно или два главни героя един върху друг. За справяне с този проблем идва още един метод, наречен removeDuplications(). Той се грижи за това да има само една булева, която да е истина и променя " +
            "останалите в неистина.<br/><span class=\"tab\"></span>Координатите на Ryu са описани от общо 4 променливи. Първите, shiftX и shiftY, определят местоположението му върху прозореца на играта. Тези координати са едни и същи и не се променят" + 
            " през цялата игра. Втората двойка променливи са ryuPositionX и ryuPositionY. Те определят местоположението му върху картата на нивото. Те описват движението на картата зад Ryu. Така получаваме ефекта, че Ryu се движи, но всъщност самата" + 
            " му фигура не се премества от горният ляв ъгъл на прозореца.";

        string ryuTextBul6 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/>" +
            "<h2>Реализация</h2><br/><h3>Създаване на противниците</h3><br/><span class=\"tab\"></span>Другата основна част от играта е създаването на противници, които да ни държат заети. Тяхната реализация е сходна с тази на главният герой – създадени" +
            " са със спрайтове, издават звуци, имат жизнени показатели и могат да удрят. Разликата тук е, че те трябва да се контролират от компютъра, чрез изкуствен интелект (A.I.), вместо от клавиатурата.<br/><span class=\"tab\"></span>" +
            "Всеки един противник е създаден от 5 различни спрайта: статично положение, ходене, удряне, бивайки ударен и спрайт за умиране.<br/><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\">" +
            "<span class=\"tab\"></span><span class=\"tab\"></span></span><img src=\"/Resources/ryu10.png\" width=\"250\"><br/><span class=\"tab\"></span>Противниците се намират на точно определени координати на нивото. За разлика от Ryu, противниците нямат" +
            " специални умения следователно нямат магически точки (MP) а единствено здраве (HP), което се определя от зададеното ниво на трудност.<br/><br/><h3>Създаване на изкуствен интелект</h3><span class=\"tab\"></span><li><b>Общи сведения</b></li><br/>" +
            "<span class=\"tab\"></span>Изкуственият интелект позволява на компютрите да правят неща, които за хората изглеждат разумни. Той има способност да анализира окръжаващата го среда и да предприема действия, които увеличават възможността за постигане " +
            "на определени цели.<br/><span class=\"tab\"></span>Създаването на изкуственият интелект е един от най-сложните етапи, при проектирането на компютърна игра. За него има обособен отделен дял в информатиката и се изучава като академична дисциплина." +
            "<br/><span class=\"tab\"></span>Пример за много добър A.I. е този в играта F.E.A.R.: First Encounter Assault Recon. Това е FPS шуутър, в който противниците имат широк набор от действия. Те могат да клякат и да минават под препядствия, да скачат" + 
            " през прозорци, да се подават през парапети, да изкачват стълби и да бутат обекти за да създадат прикритие от насрешната стрелба. Различни врагове могат да работят в екип, използвайки обиколни пътеки, за да изненадат играча в гръб, да използват" + 
            " потискаща стрелба и да скачат зад стени, когато биват обстрелвани. Често изкуственият интелект на F.E.A.R. е посочван като високо развит и неговата ефективност помага на играта да спечели наградите „2005 Best AI Award“ на GameSpot и „Most" +
            " Infuental AI Games“ на AIGameDev's.<br/><span class=\"tab\"></span>За целта на проекта е създаден по-просто устроен изкуствен интелект. Той е един и същ за всеки противник. Това което той прави е да следи за местоположението на главният герой," +
            " да се придвижва по посока към него и да изпълнява удари върху играча.<br/><span class=\"tab\"></span>При започването на играта, всеки един противник е предварително създаден на нивото, но е в пасивно положение и ние не го виждаме. Те имат " +
            "определен обхват на действие, в което Ryu трябва да влезне, за да могат да се активират. За да не се получи претрупване на врагове, на едно и също място, те се създадени със собствени уникални координати и обхвати на действие.<br/><span " +
            "class=\"tab\"></span>Обхватът е такъв, че когато противника се появи на екрана, той вече е в активно положение и вече се движи към нас. Веднъж задействан, противника ще е активен до края на жизненият си цикъл, който е до смъртта му, смъртта" +
            " на Ryu или изтичане на времето.<br/><img src=\"/Resources/ryu11.jpg\" width=\"592\">";

        string ryuTextBul7 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/>" +
            "<h2>Реализация</h2><br/><h3>Създаване на противниците</h3><span class=\"tab\"></span><span class=\"tab\"></span><li><b>Придвижване към Ryu</b></li><br/><span class=\"tab\"></span>Противника се движи когато Ryu навлезе в обхватът му, докато" + 
            " самият противник е жив и докато той не се намира до Ryu. Когато тези две условия са изпълнени, противникът започва да се придвижва към shiftX и shiftY координатите със скорост delta * .1f. По време на придвижването аналогично се променя" +
            " и анимацията на противника, към анимация на придвижване.<table><tr><th>if (ryuPositionX < -170 && thugHP > 0)<br/>{<br/><span class=\"tab\"></span>if (thugPosY < 117)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>moveY += delta * .1f;<br/><span class=\"tab\"></span><span class=\"tab\"></span>thugSprite = thugWalkAnimation;<br/><span class=\"tab\"></span>}<br/> " +
            "<span class=\"tab\"></span>if (thugPosY > 120)<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" + 
            "</span>moveY -= delta * .1f;<br/><span class=\"tab\"></span><spanthugSprite = thugWalkAnimation;<br/>}<br/><span class=\"tab\"></span>if (thugPosX > 170)<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span>" +
            "<span class=\"tab\"></span>moveX -= delta * .1f;<br/><span class=\"tab\"></span><span class=\"tab\"></span>thugSprite = thugWalkAnimation;<br/><span class=\"tab\"></span>}<br/>" +
            "}</th></tr></table><br/><span class=\"tab\"></span>Когато стигне до играча той спира, защото тогава едно от условията за движение не е изпълнено – това да не се намира до него.<br/><br/><li><b>Удряне</b></li><br/><span class=\"tab\"></span>" +
            "За да можем да ударим главният герой, първо трябва да сме изпълнили серия от условия. Противника трябва да се намира в непосредствена близост до Ryu, Ryu трябва да не изпълнява удари или умения и самият противник трябва да е жив.<br/><span class=\"tab\"></span>" +
            "Първо булевият метод thugAtRyu()следи дали противника се намира на точното място, за да изпълни удар и връща true.<br/><table><tr><th>public boolean thugAtRyu(float thugPosX, float thugPosY)<br/>" +
            "{<br/><span class=\"tab\"></span>if (thugPosX < 190 && thugPosX > 115 && thugPosY < 130 &&<br/><span class=\"tab\"></span><span class=\"tab\"></span>thugPosY > 70)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>else<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>Със следващият булев метод, наречен ryuAttack(), ние следим дали героят" +
            " не извършва някакъв удар или специално умение.<br/><table><tr><th>public boolean ryuAttack()<br/>" +
            "{<br/><span class=\"tab\"></span>if (ryuHadouken || ryuLowKick || ryuPunch || ryuShoryuken ||<br/><span class=\"tab\"></span><span class=\"tab\"></span>ryuShoryuken || ryuTatsaku)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>else<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>Както споменахме, за всяко едно действие на Ryu има съответна булева стойност. В този случай, чрез" +
            " тях можем да следим действията на главният герой и да ги използваме в нашия метод.<br/><span class=\"tab\"></span>Противникът трябва да удря през определено време, когато вече се намира срещу Ryu, за да се придобие реалност към действията му. За целта се " +
            "използва метода enemyAttackChance().<br/><span class=\"tab\"></span>enemyAttackChance()е шансът врагът да удари, когато се намира в непосредствена близост до Ryu.<br/><table><tr><th>public boolean enemyAttackChance()<br/>" +
            "{<br/><span class=\"tab\"></span>Random rand = new Random();<br/><br/><span class=\"tab\"></span>if (rand.nextInt(1000) > 900)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>else<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>Метода създава случайно число в интервала от 1 до 1000, с всеки един цикъл на играта. " +
            "Когато числото е по-голямо от 900, метода изпраща сигнал за изпълняване на удар.<br/><span class=\"tab\"></span>Когато всички тези условия са изпълнени преминаваме към изпълнението на удара.";

        string ryuTextBul8 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/>" +
            "<h2>Реализация</h2><br/><h3>Създаване на противниците</h3><br/><table><tr><th>if (thugAtRyu(thugPosX, thugPosY) && !ryuAttack() && enemyAttackChance() &&<br/><span class=\"tab\"></span>showThug && thugHitRyu)<br/>" +
            "{<br/><span class=\"tab\"></span>thugSprite = thugHitAnimation;<br/><span class=\"tab\"></span>getInitialTime = time;<br/><br/><span class=\"tab\"></span>if (!punchedSnd.playing() && Menu.soundOn)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>punchedSnd.play(1, Menu.soundVolume);<br/><span class=\"tab\"></span>}<br/><br/> " +
            "<span class=\"tab\"></span>ryuHurt = true;<br/><span class=\"tab\"></span>ryuHP--;<br/><span class=\"tab\"></span>thugHitRyu = false;<br/>" +
            "}</th></tr></table><br/><span class=\"tab\"></span>Първо, анимацията на врагът се променя към такава на удряне. След това създаваме таймер, който да връща противника към " + 
            "статичното си положение, след като вече е изпълнил удара. Проверяваме дали звуците са позволени в тази сесия на играта и изпълняваме звук на удряне. Също така проверяваме дали конкретният звук не" + 
            " се изпълнява в момента, чрез punchedSnd.playing(), който връща true когато това е вярно. Целта е да не се получава застъпване на звука, което може да доведе до какафония. Променяме анимацията на" +
            " Ryu със съответната, изобразяваща състояние на болка и отнемаме от неговите жизнени точки. Накрая същият таймер връща и Ryu към статичното му положение.<br/><span class=\"tab\"></span>За " +
            "създаването на таймера използваме метода delay().<br/><table><tr><th>public boolean delay(long startTime, int number)<br/>{<br/></span><span class=\"tab\"></span>if (startTime + number <= time)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>else<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>Този метод използва променливата time, която представлява системното времето под формата" +
            " на цифра. StartTime е времето когато е започнал таймера, а  number е интервала от време до неговото приключване. Когато интервалът изтече метода връща стойност  true и таймера приключва.<br/><span class=\"tab\">" + 
            "По сходен начин се изпълняват и ударите на Ryu.<br/><span class=\"tab\">За да нанесем удар първо проверяваме за противник в близост до Ryu и дали противника е жив. След това изсвирваме звука за удряне, по абсолютно" + 
            " същия начин, привключваме анимацийте на двата героя, създаваме таймер и отнемаме от жизнените точки на врага. След приключване на таймера, героите се връщат към началното си състояние и можем " +
            "да започнем от начало.<br/><br/><li><b>Анимация за край</b></li><br/><span class=\"tab\"></span>Анимацията за благополучен край е създадена по сходен модел с тази за начало. Тук обаче освен само " +
            "нея използваме и три спрайта на Ryu, чрез които го изобразяваме в доволно състояние – състояние на успех.<br><table><tr><th>public void youWinAnimation(StateBasedGame sbg)<br/>" +
            "{<br/><span class=\"tab\"></span>if (winState)<br/><span class=\"tab\"></span>{<br/><span " +
            "class=\"tab\"></span><span class=\"tab\"></span>youWinScale1 += 3;<br/><span class=\"tab\"></span><span class=\"tab\"></span>" +
            "youWinScale2 += 2;<br/><span class=\"tab\"></span><span class=\"tab\"></span>enableInput = false;<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span>ryuSprite = ryuReadyAnimation;<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span>ryuSprite.stopAt(6);<br/><br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span>if (ryuSprite.isStopped())<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span>{<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>ryuSprite = ryuWin1Animation;<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>ryuSprite.stopAt(3);<br/><br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>if (ryuSprite.isStopped())<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>{<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>ryuSprite = ryuWin2Animation;<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>}<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span>}<br/>" +
            "<span class=\"tab\"></span>}<br/><br/>" +
            "<span class=\"tab\"></span>if (youWinScale1 >= 100 && youWinScale1 <= 105 &&  Menu.soundOn)<br/>" +
            "<span class=\"tab\"></span>{<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span>youWinSnd.play(1, Menu.soundVolume);<br/>" +
            "<span class=\"tab\"></span>}<br/><br/>" +
            "<span class=\"tab\"></span>if (youWinScale1 >= 600 && youWinScale1 <= 610 <br/>" +            
            "<span class=\"tab\"></span>{<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span>youWinScale1 -= 3;<br/>" +
            "<span class=\"tab\"></span>}<br/><br/>" +
            "<span class=\"tab\"></span>if (youWinScale2 >= 1200)<br/>" +
            "<span class=\"tab\"></span>{<br/>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span>sbg.enterState(0);<br/>" +
            "<span class=\"tab\"></span>}<br/>" +
            "}</th></tr></table>";

        string ryuTextBul9 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/>" +
            "<h2>Реализация</h2><br/><span class=\"tab\"></span>Метода се нарича youWinAnimation. Той се обхожда с всеки един цикъл на играта," +
            " но се активира, когато булевата winState върне стойност на вярно.  winState връща вярна стойност, когато всички противници са убити. Проверката става като се" +
            " прочетат стойностите на жизнените точки на всички противници и те са равни на 0. Самата проверка се намира в update(), следователно тя се проверява с всеки" +
            " цикъл на играта.<br/><img src=\"/Resources/ryu12.png\" width=\"592\"><br/><span class=\"tab\"></span>При вярност youWinImage изображението се изрисува на" + 
            " екрана, като  youWinScale1 и  youWinScale2 са неговите вертикални и хоризонтални размери. Тези стойности постепенно се увеличават, за да се създаде " + 
            "необходимата анимация. Когато стойността на  youWinScale1 премине 100, се възпроизвежда и звук, за успешно завършване на играта. Когато стойността на  " + 
            "youWinScale1 премине 600, изображението вече е в пълния си размер и скалирането приключва и малко след това играча бива прехвърлен към началното меню," +
            " чрез sbg.enterState(0);.<br/><span class=\"tab\"></span>Споменахме и че Ryu също извършва анимация. Първо движението на героя се забранява с enableInput" + 
            " = false;.  След това преминаваме към първият спрайт ryuReadyAnimation, който е изграден от 6 кадъра. Спираме анимацията на последния 6-ти кадър с " + 
            "ryuSprite.stopAt(6);, правим проверка дали тя е спряла с ryuSprite.isStopped() и  ако това е вярно преминаваме към втория спрайт - ryuWin1Animation." + 
            " Отново спираме спрайта на последният кадър, в случая кадър 3, проверяваме за спиране на анимацията и привключваме към последната анимация " +
            "ryuWin2Animation.<br/><span class=\"tab\"></span>Всички тези анимации и спрайтове придават усещане са успешно приключила игра.<br/><br/><h2>" +
            "Заключение</h2><br/><span class=\"tab\"></span>В проекта бяха описани основните компоненти, за изграждането на нашата игра. Бяха споменати, " + 
            "без да бъдат детайлно изследвани – LWJGL и Slick2D библиотеките, които макар и изградени от трети страни, са необходими компоненти на средата." + 
            " Разгледана беше в основи логиката на анимирането чрез спрайтове и бяха изложени някои идеи за реализация, използвани при създаването на логиката" +
            " на играта Ryu: The Big Adventure.<br/><span class=\"tab\"></span>Оттук нататък възможностите за развитие и подобрение на средата са много:<br/><span " +
            "class=\"tab\"></span>От функционална гледна точка може да бъде подобрен изкуственият интелект на опонентите. Всеки един от опонентите е създаден отделно," + 
            " което означава че и характерите им могат да се направят различни. В игрите се използват различни класове герои като танк, лечител, стрелец и войн, всеки един" +
            " специализиран в определени умения и с различни предимства и недостатъци.<br/><span class=\"tab\"></span>Танкът e герой който има за цел да поема ударите и да предпазва" +
            " останалите от щети. Той върши малко щети, но за сметка на това е много здрав и труден за убиване.<br/><span class=\"tab\"></span>Лечителят използва магически сили за да" + 
            " лекува събратята си и да увеличава тяхната сила. Той е лесен за убиване и не извършва никакви щети и затова мястото му е в най-задните части на боя, от където използва" +
            " магията си за лекуване.<br/><span class=\"tab\"></span>Стрелецът и войнът са класовете които извършват най-много щети. Докато танкът задържа вниманието на враговете, лечителят " +
            "поддържа всички живи, стрелецът и войнът трябва да вършат щети, които да доведат до победа за екипа.<br/><span class=\"tab\"></span>Всеки един клас опонент ще изисква свой собствен" + 
            " изкуствен интелект, коренно различен от на останалите. Комбинацията от тези класове могат да създадат много проблеми за главният герой, принуждавайки го да използва " +
            "различни стратегии за всеки един от тях.<br/><span class=\"tab\"></span>Може да бъде добавена и база данни, която да съхранява резултати. Резултатите ще се бъзират на това, за колко" +
            " време е преминато нивото, на каква трудност е преминато нивото, колко здраве е останало на героя в края на нивото и др.<br/><span class=\"tab\"></span>Могат да се търсят" +
            " други платформи за представяне, например да се създадат портове на играта за уеб браузър и за мобилни устройства, като iOS, Windows Mobile, Android и Blackberry." + 
            "<br/><br/><b>Source: </b><a href=\"https://github.com/ivanpop/Ryu\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/ryu.zip\">Ryu: The Big Adventure!</a></td><td class=\"size\">24.8 MB</td> " +
            " </tr></tbody></table>";

        string projectsBul = "Тук съм показал някои от проектите върху които работя.<br/><br/>";

        string projectsEng = "Here I've shown some of the projects I'm working on.<br/><br/>";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            mainContent.Text = aboutMeBul;
            visibilities();
            pageLbl.Text = "<br/><br/>Страница: ";            
        }

        protected void langSwitch()
        {
            visibilities();

            if (!aboutMe.Enabled)
            {
                aboutMe_Click(aboutMe, null);
            }
            if (!biography.Enabled)
            {
                biography_Click(biography, null);
            }
            if (!projects.Enabled)
            {
                projects_Click(projects, null);
            }
            if (!converter.Enabled)
            {
                converter_Click(converter, null);
            }
            if (!countdown.Enabled)
            {
                countdown_Click1(countdown, null);
            }
            if (!ryu.Enabled)
            {
                if (!ryuPage1.Enabled)
                {
                    ryuPage1_Click(ryuPage1, null);
                }
                if (!ryuPage2.Enabled)
                {
                    ryuPage2_Click(ryuPage2, null);
                }
                if (!ryuPage3.Enabled)
                {
                    ryuPage3_Click(ryuPage3, null);
                }
            }
            
        }

        protected void switchEngBtn_Click(object sender, EventArgs e)
        {
            switchBulBtn.Enabled = true;
            switchEngBtn.Enabled = false;            
            lang.Text = "English";
            artTitle.Text = "About me";
            navigation.Text = "Navigation";                       
            aboutMe.Text = "About me";
            biography.Text = "Biography";
            projects.Text = "Projects";
            contacts.Text = "Contacts";
            header1.Text = "Ivan Popov";
            header2.Text = "Personal website";
            goTop.Text = "Top";

            langSwitch();
        }

        protected void switchBulBtn_Click(object sender, EventArgs e)
        {
            switchBulBtn.Enabled = false;
            switchEngBtn.Enabled = true;
            mainContent.Text = aboutMeBul;
            lang.Text = "Български";
            artTitle.Text = "За мен";
            navigation.Text = "Навигация";                     
            aboutMe.Text = "За мен";
            biography.Text = "Автобиография";
            projects.Text = "Проекти";
            contacts.Text = "Контакти";
            header1.Text = "Иван Попов";
            header2.Text = "Лична Интернет Страница";
            goTop.Text = "Горе";

            langSwitch();
        }

        protected void aboutMe_Click(object sender, EventArgs e)
        {
            aboutMe.Enabled = false;
            biography.Enabled = true;
            contacts.Enabled = true;
            projects.Enabled = true;

            ryu.Enabled = true;
            converter.Enabled = true;
            countdown.Enabled = true;

            if (!switchBulBtn.Enabled)
            {
                artTitle.Text = "За мен";
                mainContent.Text = aboutMeBul;                
                visibilities();
            }
            else
            {
                artTitle.Text = "About me";
                mainContent.Text = aboutMeEng;                
                visibilities();
            }            
        }

        protected void biography_Click(object sender, EventArgs e)
        {
            biography.Enabled = false;
            aboutMe.Enabled = true;            
            contacts.Enabled = true;
            projects.Enabled = true;

            ryu.Enabled = true;
            converter.Enabled = true;
            countdown.Enabled = true;

            if (!switchBulBtn.Enabled)
            {
                mainContent.Text = biographyBul;
                lang.Text = "Български";
                artTitle.Text = "Автобиография";
                navigation.Text = "Навигация";
                visibilities();
            }
            else
            {
                mainContent.Text = biographyEng;
                lang.Text = "Bulgarian";
                artTitle.Text = "Biography";
                navigation.Text = "Navigation";
                visibilities();
            }
        }

        protected void projects_Click(object sender, EventArgs e)
        {
            projects.Enabled = false;
            aboutMe.Enabled = true;
            biography.Enabled = true;
            contacts.Enabled = true;

            if (!switchBulBtn.Enabled)
            {
                mainContent.Text = projectsBul;                
                artTitle.Text = "Проекти";                
            }
            else
            {
                mainContent.Text = projectsEng;                
                artTitle.Text = "Projects";                
            }

            visibilities();
            projectsContent.Text = "";
        }

        protected void contacts_Click(object sender, EventArgs e)
        {
            contacts.Enabled = false;
            aboutMe.Enabled = true;
            biography.Enabled = true;            
            projects.Enabled = true;

            ryu.Enabled = true;
            converter.Enabled = true;
            countdown.Enabled = true;

            lang.Text = "Български";
            artTitle.Text = "Контакти";
            navigation.Text = "Навигация";
            visibilities();
        }

        protected void visibilities()
        {
            if (artTitle.Text == "Автобиография" || artTitle.Text == "Biography")
            {
                ivanpopov.Visible = true;
            }
            else
            {
                ivanpopov.Visible = false;
            }

            if (artTitle.Text == "Проекти" || artTitle.Text == "Projects")
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
            converter.Enabled = false;
            ryu.Enabled = true;
            countdown.Enabled = true;
            
            mainContent.Text = "";
            visibilities();

            if (!switchBulBtn.Enabled)
            {
                projectsContent.Text = converterTextBul;
            }
            else
            {
                projectsContent.Text = converterTextEng;
            }
        }

        protected void countdown_Click1(object sender, EventArgs e)
        {
            converter.Enabled = true;
            ryu.Enabled = true;
            countdown.Enabled = false;

            mainContent.Text = "";
            visibilities();

            if (!switchBulBtn.Enabled)
            {
                projectsContent.Text = stopwatchTextBul;
            }
            else
            {
                projectsContent.Text = stopwatchTextEng;
            }
        }

        protected void ryu_Click(object sender, EventArgs e)
        {
            converter.Enabled = true;
            ryu.Enabled = false;
            countdown.Enabled = true;

            if (!switchBulBtn.Enabled)
            {
                projectsContent.Text = ryuTextBul1;
            }
            else
            {
                projectsContent.Text = ryuTextEng1;
            }
            
            mainContent.Text = "";            
            ryuPages(1);
        }

        protected void visiblePages()
        {
            pageLbl.Visible = true;
            ryuPage1.Visible = true;
            ryuPage2.Visible = true;
            ryuPage3.Visible = true;
            ryuPage4.Visible = true;
            ryuPage5.Visible = true;
            ryuPage6.Visible = true;
            ryuPage7.Visible = true;
            ryuPage8.Visible = true;
            ryuPage9.Visible = true;
        }

        protected void ryuPages(int page)
        {            
            if (page == 1)
            {
                ryuPage1.Enabled = false;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = true;
                ryuPage4.Enabled = true;
                ryuPage5.Enabled = true;
                ryuPage6.Enabled = true;
                ryuPage7.Enabled = true;
                ryuPage8.Enabled = true;
                ryuPage9.Enabled = true;
                pageLbl.Visible = false;
                visiblePages();
            }
            if (page == 0)
            {
                ryuPage1.Visible = false;
                ryuPage2.Visible = false;
                ryuPage3.Visible = false;
                ryuPage4.Visible = false;
                ryuPage5.Visible = false;
                ryuPage6.Visible = false;
                ryuPage7.Visible = false;
                ryuPage8.Visible = false;
                ryuPage9.Visible = false;                
            }
            if (page == 2)
            {
                ryuPage1.Enabled = true;
                ryuPage2.Enabled = false;
                ryuPage3.Enabled = true;
                ryuPage4.Enabled = true;
                ryuPage5.Enabled = true;
                ryuPage6.Enabled = true;
                ryuPage7.Enabled = true;
                ryuPage8.Enabled = true;
                ryuPage9.Enabled = true;
                visiblePages();
            }
            if (page == 3)
            {
                ryuPage1.Enabled = true;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = false;
                ryuPage4.Enabled = true;
                ryuPage5.Enabled = true;
                ryuPage6.Enabled = true;
                ryuPage7.Enabled = true;
                ryuPage8.Enabled = true;
                ryuPage9.Enabled = true;
                visiblePages();
            }
            if (page == 4)
            {
                ryuPage1.Enabled = true;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = true;
                ryuPage4.Enabled = false;
                ryuPage5.Enabled = true;
                ryuPage6.Enabled = true;
                ryuPage7.Enabled = true;
                ryuPage8.Enabled = true;
                ryuPage9.Enabled = true;
                visiblePages();
            }
            if (page == 5)
            {
                ryuPage1.Enabled = true;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = true;
                ryuPage4.Enabled = true;
                ryuPage5.Enabled = false;
                ryuPage6.Enabled = true;
                ryuPage7.Enabled = true;
                ryuPage8.Enabled = true;
                ryuPage9.Enabled = true;
                visiblePages();
            }
            if (page == 6)
            {
                ryuPage1.Enabled = true;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = true;
                ryuPage4.Enabled = true;
                ryuPage5.Enabled = true;
                ryuPage6.Enabled = false;
                ryuPage7.Enabled = true;
                ryuPage8.Enabled = true;
                ryuPage9.Enabled = true;
                visiblePages();
            }
            if (page == 7)
            {
                ryuPage1.Enabled = true;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = true;
                ryuPage4.Enabled = true;
                ryuPage5.Enabled = true;
                ryuPage6.Enabled = true;
                ryuPage7.Enabled = false;
                ryuPage8.Enabled = true;
                ryuPage9.Enabled = true;
                visiblePages();
            }
            if (page == 8)
            {
                ryuPage1.Enabled = true;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = true;
                ryuPage4.Enabled = true;
                ryuPage5.Enabled = true;
                ryuPage6.Enabled = true;
                ryuPage7.Enabled = true;
                ryuPage8.Enabled = false;
                ryuPage9.Enabled = true;
                visiblePages();
            }
            if (page == 9)
            {
                ryuPage1.Enabled = true;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = true;
                ryuPage4.Enabled = true;
                ryuPage5.Enabled = true;
                ryuPage6.Enabled = true;
                ryuPage7.Enabled = true;
                ryuPage8.Enabled = true;
                ryuPage9.Enabled = false;
                visiblePages();
            }
        }

        protected void ryuPage2_Click(object sender, EventArgs e)
        {
            if (!switchBulBtn.Enabled)
            {
                projectsContent.Text = ryuTextBul2;
            }
            else
            {
                projectsContent.Text = ryuTextEng2;
            }

            mainContent.Text = ""; 
            ryuPages(2);
        }

        protected void ryuPage1_Click(object sender, EventArgs e)
        {
            if (!switchBulBtn.Enabled)
            {
                projectsContent.Text = ryuTextBul1;
            }
            else
            {
                projectsContent.Text = ryuTextEng1;
            }
            
            mainContent.Text = "";
            ryuPages(1);            
        }

        protected void ryuPage3_Click(object sender, EventArgs e)
        {
            if (!switchBulBtn.Enabled)
            {
                projectsContent.Text = ryuTextBul3;
            }
            else
            {
                projectsContent.Text = ryuTextEng3;
            }

            mainContent.Text = "";
            ryuPages(3);
        }

        protected void ryuPage4_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul4;
            mainContent.Text = "";
            ryuPages(4);
        }

        protected void ryuPage5_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul5;
            mainContent.Text = "";
            ryuPages(5);
        }

        protected void ryuPage6_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul6;
            mainContent.Text = "";
            ryuPages(6);
        }

        protected void ryuPage7_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul7;
            mainContent.Text = "";
            ryuPages(7);
        }

        protected void ryuPage8_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul8;
            mainContent.Text = "";
            ryuPages(8);
        }

        protected void ryuPage9_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul9;
            mainContent.Text = "";
            ryuPages(9);
        }        
    }
}
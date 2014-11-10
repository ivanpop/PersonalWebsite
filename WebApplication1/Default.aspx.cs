﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string aboutMeBul = "<p>Здравейте,<br/><br/><span class=\"tab\"></span>Казвам се Иван Попов и съм програмист.<br/><br/><span class=\"tab\"></span> " + 
            "Това е моята лична интернет страница.Тук ще намерите информация за мен и актуалните проекти, по които работя активно.<br/><br/><span class=\"tab\"></span>Моите интереси са основно в областта на " + 
            "Информационните Технологии, Езиците за програмиране и Средите за програмиране.";

        string aboutMeEng = "<p>Hello,<br/><br/>My name is Ivan Popov and I'm a programmer<br/><br/>This is my personal web page. Here you will find information" + 
            " about me and project, I work on.<br/><br/>My interests are mainly in the field of information technology, programming languages ​​and their programming environments.";

        string contactsBul = "<span class=\"round-bar blue-bar\">E-mail:</span> ivanpop@abv.bg<br><br><span class=\"round-bar blue-bar\">Skype:</span> ivan9019<br><br>Също така можете да ми изпратите съобщение като използвате формата за контакти.<br><br>";

        string contactsEng = "<span class=\"round-bar blue-bar\">E-mail:</span> ivanpop@abv.bg<br><br><span class=\"round-bar blue-bar\">Skype:</span> ivan9019<br><br>Also you can send me a message using the contacts form below.<br><br>";

        string biographyBul = "<span class=\"tab\"></span>Роден съм на 19.01.1990г. в гр. Пловдив, България.<br/><br/><span class=\"tab\"></span>Завърших висшето си образование, степен бакалавър, в &nbsp;Пловдивски " +
            "университет \"Паисий Хилендарски\" през 2013 г. &nbsp;със &nbsp;специалност \"Информатика\".<br/><br/><span class=\"tab\"></span>Непосредствено след завършването си записах &nbsp;магистърска &nbsp;степен, в същия" +
            " университет, със специалност &nbsp;\"Софтуерни &nbsp;технологии\", която също завърших успешно.<br/><br/><span class=\"tab\"></span>От декември 2009г, четири месеца след записването ми в &nbsp;университета," + 
            " работя в магазин \"Метро Пловдив 2\", от начало &nbsp;като обикновен сътрудник и впоследствие като продуктов &nbsp;консултант.<br/><br/><span class=\"tab\"></span>Работата ми в магазина ме научи да " + 
            "работя в екип, да работя с клиенти, да си планирам работния ден и приоритизирам задачите си.<br/><br/><span class=\"tab\"></span>През останалото време решавам курсове от <a href=\"https://telerikacademy.com/\"" + 
            " target=\"_blank\"><b><u>Софтуерна академия \"Телерик\"</b></u></a> и <a href=\"https://softuni.bg/\" target=\"_blank\"><b><u>Софтуерен университет</b></u>\"</a>, както и мой лични проекти.Част от тях могат" + 
            "да се видят в моя Github акаунт. <a href=\"https://github.com/ivanpop\" target=\"_blank\"><b><u>Github</u></b></a><br/><br/><span class=\"tab\"></span>Като хоби имам YouTube канал, в който качвам кадри от " + 
            "игри и показвам дългите години придобит опит със снайпера и двуцевката. ;)<a href=\"https://www.youtube.com/user/unfragablegaming/\" target=\"_blank\">" + "<b><u>Unfragable Gaming</u></b></a><br/><br/>" + 
            "<span class=\"tab\"></span>Целта ми е да работя в IT-сферата и да продължавам да си развивам уменията на програмист.<br/><br/><hr><br/><br/><h1>Образование</h1><br/><br/><span class=\"round-bar blue-bar" +
            "\">2014 г.</span> <a href=\"https://uni-plovdiv.bg/\" target=\"_blank\"><b><u> ПУ \"Паисий Хилендарски\"</u></b></a> - Магистър, специалност \"Софтуерни технологии\".<br/><br/>" +
            "<span class=\"round-bar blue-bar\">2013 г.</span> <a href=\"https://uni-plovdiv.bg/\" target=\"_blank\"><b><u> ПУ \"Паисий Хилендарски\"</u></b></a>  - Бакалавър, специалност \"Информатика\".<br/><br/>" +
            "<span class=\"round-bar blue-bar\">2009 г.</span> <a href=\"http://www.pghtt.net/\" target=\"_blank\"><b><u> ПГХТТ</u></b></a> - средно образование.<br/><br/>" +
            "<span class=\"round-bar blue-bar\">1997 г.</span> <a href=\"http://rainakniaginia.com/\" target=\"_blank\"><b><u> ОУ \"Райна Княгиня\"</u></b></a> - основно образование.<br/><br/><hr><br/><br/><h1>" +
            "Трудов опит</h1><br/><br/><span class=\"round-bar blue-bar\">12/2009 - 07/2014</span> Сътрудник и Продуктов консултант в магазин <a href=\"http://www.metro.bg/\" target=\"_blank\"><b><u>\"Метро 2 Пловдив\"" +
            "</u></b></a>.<br/><br/><span class=\"round-bar blue-bar\">11/2012 - 04/2013</span> Оператор въвеждане на данни в <a href=\"http://stildecor.bg/\" target=\"_blank\"><b><u>“Highstyle” Ltd</u></b></a>.<br/><br/>" +
            "<hr><br/><br/><h1>Компютърни умения</h1><br/><br/><b>Езици за програмиране:</b><br/><br/>C#, C++, Java, JavaScript;<br/><br/><b>Технологии и стандарти:</b><br/><br/>ASP.NET Web Forms, SQL Server;<br/>HTML5, " +
            "CSS3, jQuery;<br/><br/><b>Операционни системи:</b><br/><br/>Административни умения с Windows XP, Vista, 7, 8/8.1;<br/>Linux: Ubuntu дистрибуции, Arch Linux, OpenSUSE;<br/><br/><b>Програми за " +
            "разработка:</b><br/><br/>.NET - MS Visual Studio 2013 for Desktop, MS Visual Studio 2013 for Web, MonoDevelop;<br/>C++ - CodeBlocks, Microsoft Visual Studio 6.0;<br/>Java - Eclipse, NetBeans;<br/>Database - " +
            "SQL Server Management Studio, phpMyAdmin;<br/>Notepad++;<br/><br/><b>Други компютърни умения:</b><br/><br/> Отлични умения с MS Word, Excel, PowerPoint, Libre Office, OpenOffice;<br/><br/>Обработка на видео, " + 
            "аудио и изображения - Adobe Photoshop, GIMP, Adobe Premiere Pro,<br/> Sony Vegas PRO, Audacity;";

        string biographyEng = "<span class=\"tab\"></span>I'm born on 19.01.1990г. in Plovdiv, Bulgaria.<br/><br/>&nbsp;<span class=\"tab\"></span>I graduated from Plovdiv University \"Paisii Hilendarski\" in &nbsp;2013," + 
            " with a bachelor degree in Informatics.<br/><br/><span class=\"tab\"></span>Right after that I started studying masters degree, in the same &nbsp;university, in the field of \"Software Technologies\"," +
            "which I graduated &nbsp;in 2014.<br/><br/><span class=\"tab\"></span>From December 2009, four months after becoming a student in &nbsp;the university, I started working in \"Metro Cash&Carry Plovdiv 2\"," +
            " &nbsp;from the beginning as a regular associate and afterwards as a &nbsp;product consultant.<br/><br/><span class=\"tab\"></span>My work in the magazine taught me to work in a team, to work with clients," +
            " to plan my working day and to prioritize my tasks.<br/><br/><span class=\"tab\"></span>In my spare time I follow online courses in <a href=\"https://telerikacademy.com/\" target=\"_blank\"><b><u>Software " +
            "Academy \"Telerik\"</b></u></a> and <a href=\"https://softuni.bg/\" target=\"_blank\"><b><u>The Software University</b></u>\"</a>, as well as my personal projects. Part of them can be seen in my Github " +
            "account. <a href=\"https://github.com/ivanpop\" target=\"_blank\"><b><u>Github</u></b></a><br/><br/><span class=\"tab\"></span>As a hobby I have a YouTube channel, where I upload gameplay videos in which " +
            "I show my years of experience with the sniper and the shotgun. ;)<a href=\"https://www.youtube.com/user/unfragablegaming/\" target=\"_blank\">" + "<b><u>Unfragable Gaming</u></b></a><br/><br/><span " +
            "class=\"tab\"></span>My goal is to work in the field of IT and to continue to develop my skills as a programmer.<br/><br/><hr><br/><br/><h1>Education</h1><br/><br/><span class=\"round-bar blue-bar" +
            "\">2014 г.</span> <a href=\"https://uni-plovdiv.bg/\" target=\"_blank\"><b><u>PU “Paisii Hilendarski” </u></b></a> - Master's degree, field of \"Software technologies\".<br/><br/>" +
            "<span class=\"round-bar blue-bar\">2013 г.</span> <a href=\"https://uni-plovdiv.bg/\" target=\"_blank\"><b><u>PU “Paisii Hilendarski”</u></b></a>  - Bachelor's degree, field of \"Informatics\".<br/><br/>" +
            "<span class=\"round-bar blue-bar\">2009 г.</span> <a href=\"http://www.pghtt.net/\" target=\"_blank\"><b><u> PGHTT</u></b></a> - secondary.<br/><br/>" +
            "<span class=\"round-bar blue-bar\">1997 г.</span> <a href=\"http://rainakniaginia.com/\" target=\"_blank\"><b><u> OU “Rayna Knyaginya” </u></b></a> -primary.<br/><br/><hr><br/><br/><h1>" +
            "Work experience</h1><br/><br/><span class=\"round-bar blue-bar\">12/2009 - 07/2014</span> Associate and Product consultant in <a href=\"http://www.metro.bg/\" target=\"_blank\"><b><u>\"Metro 2 Plovdiv\"" +
            "</u></b></a>.<br/><br/><span class=\"round-bar blue-bar\">11/2012 - 04/2013</span> Data entry operator in <a href=\"http://stildecor.bg/\" target=\"_blank\"><b><u>“Highstyle” Ltd</u></b></a>.<br/><br/>" +
            "<hr><br/><br/><h1>Computer skills</h1><br/><br/><b>Programming languages:</b><br/><br/>C#, C++, Java, JavaScript;<br/><br/><b>Technologies and standards:</b><br/><br/>ASP.NET Web Forms, SQL Server;<br/>HTML5, " +
            "CSS3, jQuery;<br/><br/><b>Operating systems:</b><br/><br/>Administrative skills with Windows XP, Vista, 7, 8/8.1;<br/>Linux: Ubuntu distributions, Arch Linux, OpenSUSE;<br/><br/><b>Development " +
            "tools:</b><br/><br/>.NET - MS Visual Studio 2013 for Desktop, MS Visual Studio 2013 for Web, MonoDevelop;<br/>C++ - CodeBlocks, Microsoft Visual Studio 6.0;<br/>Java - Eclipse, NetBeans;<br/>Database - " +
            "SQL Server Management Studio, phpMyAdmin;<br/>Notepad++;<br/><br/><b>Other computer skills:</b><br/><br/> Excellent skills with MS Word, Excel, PowerPoint, Libre Office, OpenOffice;<br/><br/>Video, audio " +
            "and image editing skills - Adobe Photoshop, GIMP, Adobe Premiere Pro,<br/> Sony Vegas PRO, Audacity;";

        string converterTextBul = "<br/><br/><h1>Converter</h1><br/><em>Програма за преобразуване на мерни единици.</em><br/><br/><span class=\"tab\"></span>Програмата е написана на C# и представлява прост конвертор" +
            " или преобразувател на мерни единици.Възможните мерни единици могат да се видят на изображението.<br/><br/><img src=\"/Resources/convertor1.jpg\"><br/><br/><b>Source: </b><a " + 
            "href=\"https://github.com/ivanpop/Converter\" target=\"_blank\"><b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/convertor.exe\">Convertor</a></td><td class=\"size\">49.0 KB</td></tr></tbody></table>";

        string converterTextEng = "<br/><br/><h1>Converter</h1><br/><em>Program for converting metric units.</em><br/><br/><span class=\"tab\"></span>The program is written in C# and it's a simple converter of metric " + 
            "units. Different metric units can be seen in the screenshot.<br/><br/><img src=\"/Resources/convertor1.jpg\"><br/><br/><b>Source: </b><a href=\"https://github.com/ivanpop/Converter\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class=\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a " + 
            "href=\"../Resources/convertor.exe\">Convertor</a></td><td class=\"size\">49.0 KB</td></tr></tbody></table>";

        string stopwatchTextBul1 = "<br/><br/><h1>Countdown timer and stopwatch</h1><br/><em>Обратно броене и секундомер.</em><br/><br/><span class=\"tab\"></span>Написана е на C# и представлява програма за обратно броене" +
            " и секундомер. При изтичане на времето се чува бийпване. Прогресът може да се види и на таскбара, дори и програмата да е минимализирана. Перфектна програма, ако често варите яйца или готвите. ;) <br/><span " +
            "class=\"tab\"></span>Секундомера измерва с точност от милисекунда. Има възможност за отчитане на обиколка, пауза и записване на времената на обиколките като текстов файл.<br/><span class=\"tab\"></span>" +
            "Обратното броене и секундомера са напълно независими един от друг и могат да работят едновременно.<br/><br/><img src=\"/Resources/CT1.jpg\"><br/><br/><img src=\"/Resources/CT2.jpg\"><br/><br/><b>Source: " +
            "</b><a href=\"https://github.com/ivanpop/Stopwatch\" target=\"_blank\"><b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr " + 
            "class =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/countdown timer.exe\">Countdown Timer</a></td><td class=\"size\">959.0 KB</td></tr></tbody></table>";

        string stopwatchTextBul2 = "Страницата е в процес на разработка";

        string stopwatchTextEng2 = "Page is under construction";

        string stopwatchTextEng1 = "<br/><br/><h1>Countdown timer and stopwatch</h1><br/><em>Countdown timer and a stopwatch.</em><br/><br/><span class=\"tab\"></span>Written in C#, this is a countdown timer and a stopwatch" +
            ". When the timer reaches 0, there is a beep. The progress can be seen in the taskbar, even if the program is minimized. Perfect if you often boil eggs or cook. ;) <br/><span class=\"tab\"></span>The stopwatch" +
            " has a precision of a millisecond. There is an option to count a lap, pause and to save the lap times in a text file.<br/><span class=\"tab\"></span>The countdown timer and the stopwatch are completly " +
            "independent on from the other and can work simultaneously.<br/><br/><img src=\"/Resources/CT1.jpg\"><br/><br/><img src=\"/Resources/CT2.jpg\"><br/><br/><b>Source: </b><a href=" + 
            "\"https://github.com/ivanpop/Stopwatch\" target=\"_blank\"><b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/countdown timer.exe\">Countdown Timer</a></td><td class=\"size\">959.0 KB</td></tr></tbody></table>";

        string ryuTextBul1 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/><h2>Описание</h2><br/><span class=\"tab\"></span>" +
            "<b>Ryu: The Big Adventure</b> е подобие на аркадните игри <b>Cadillacs and Dinosaurs, Contra, Metal Slug, Streets of Rage, Golden Axe</b> и още много други.<br/><br/><h2>Функции</h2><br/><span class=\"tab\">" +
            "</span>Играта „Ryu: The Big Adventure” предоставя на потребителите възможността да играят на един типичен хоризонтален Beat 'em up симулатор. Beat 'em up е жанр в компютърните игри, който включва ръкопашен бой" +
            " между главният герой и голям брой врагове. Игрите са най-често 2D, като героят се движи хоризонтално по нивото в посока надясно. Тези игри са познати с простия си и лесен за научаване геймплей, като първата" +
            " подобна игра датира от 1984г.<br/><span class=\"tab\"></span>При стартиране на играта, потребителя влиза в ролята на героят Ryu, който има за цел да победи всички врагове в нивото.<br/><span class=\"tab\">" +
            "</span>Ryu е герой от видео игри, създаден от Capcom още през 1987 година, играещ основна роля в Street Fighter серията. Той владее бойни изкуства смесени с изкуствата на убиец.Освен върховните си умения в " +
            "ръкопашният бой, Ryu разполага и с някои уникални умения към арсенала си.<br/><br/><li><b>Hadouken</b> - В превод „Юмрук от енергия“.Това е вълна от енергия, която Ryu изстрелва от ръцете си, за да покоси " +
            "врагове, които се намират на разстояние от него. За да изпълни това умение Ryu трябва да има достатъчно вътрешна енергия или MP (Magic Points).<br/><img src=\"/Resources/ryu3.png\"><br/></li><br/><li><b>" +
            "Shoryuken</b> - В превод „Издигащ се драконов юмрук“, е друго 	специално умение, предназначено за близък бой. Ryu 	използва юмрука си за да се изстреля нагоре и така да нанесе убийствен ъперкът към противника," +
            " който се намира непосредствено до него. Както Hadouken и Shoryuken изисква 	вътрешна енергия.<br/><img src=\"/Resources/ryu1.png\"><br/></li><br/><li><b>Tatsumaki</b> - В превод „Торнадо“. Ryu има умението " + 
            "да скочи и да изпълни торнадо от ритници докато е във въздуха. Това е най-силната атака на Ryu и изисква най-много вътрешна енергия.<br/><img src=\"/Resources/ryu2.jpg\">";

        string ryuTextEng1 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/><h2>Description</h2><br/><span class=\"tab\"></span>" +
            "<b>Ryu: The Big Adventure</b> is simmilar to arcade games like <b>Cadillacs and Dinosaurs, Contra, Metal Slug, Streets of Rage, Golden Axe</b> and many others.<br/><br/><h2>Functions</h2><br/><span " +
            "class=\"tab\"></span>„Ryu: The Big Adventure” gives the user the chance to play a tipical horizontal Beat 'em up simulator. Beat 'em up is a computer game genre, which involves hand-to-hand combat between the" +
            " main hero and numerous enemies. These type of games are mostly in 2D, where the player moves horizontaly to the right. These games are famous for they're easy to learn gameplay, with the first of this type of" +
            " games dating from 1984<br/><span class=\"tab\"></span>When starting the game, the user goes in the role of Ryu, which have to beat all the enemies in the level.<br/><span class=\"tab\"></span>Ryu is a " +
            "superhero from video games, created by Capcom in 1987, which plays the main role in the Street Fighter series. He knows mixed martial arts and assassin skills. Also Ryu possesses some unique abilities in his" +
            " arsenal.<br/><br/><li><b>Hadouken</b> - Translated „Fist of energy“. This is a projectile of energy, which Ryu shoots from his hands, to hit enemies from distance. To do this ability Ryu must have enough" +
            " energy or MP (Magic Points).<br/><img src=\"/Resources/ryu3.png\"><br/></li><br/><li><b>Shoryuken</b> - Translated „Rising dragon fist“, is another special ability, designet for close combat. Ryu uses his" +
            " fist to shoots himself up and in that way to deliver a deadly upercut to his oponent, which is directly in front of him. Just like Hadouken Shoryuken also requires spirit energy.<br/><img " +
            "src=\"/Resources/ryu1.png\"><br/></li><br/><li><b>Tatsumaki</b> - Translated „Tornado“. Ryu haves the ability to jump and to perform a tornato from kicks while in midair. This is the most powerful attack" + 
            " that Ryu possesses and it requires most spirit energy.<br/><img src=\"/Resources/ryu2.jpg\">";

        string ryuTextBul2 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/><span class=\"tab\"></span>Вътрешната енергия се" +
            " изобразява в долният ляв ъгъл на екрана, под формата на 8 сини правоъгълника, обозначени с MP. Тя е нужна за изпълнението на специалните умения на Ryu. След нейното използване, енергията се запълва по малко," +
            " с времето. Когато героят няма достатъчно енергия, той не може да изпълнява специалните си умения.<br/><span class=\"tab\"></span>Над индикатора за енергията има и още един индикатор за здравето на Ryu, " +
            "обозначен като HP. То също е изобразено чрез 8 правоъгълника, но в червено. За разлика от енергията, здравето не се възобновява с времето. За целта Ryu трябва да намери храна, която е пръсната из нивото." +
            " Здравето ни се отнема когато биваме ударени от някой противник или когато преминем през някакво препядствие, като огън. Когато здравето ни се изчерпа нашият герой умира и играта приключва.<br/><span " +
            "class=\"tab\"></span>Освен тези два индикатора имаме и време. Времето се изписва в долната част на екрана, по средата. То показва, колко време имаме за да преминем нивото. Когато времето изтече, играта" +
            " приключва с лош край. Времето се възобновява след като преминем част от нивото, примерно средата на нивото.<br/><span class=\"tab\"></span>Освен да използва основната игрова функционалност, потребителят може" +
            " също да спира и пуска звука на приложението, да променя силата на звука и на музиката и да променя преди игровата сесия трудността и да напусне играта по всяко време. Играта също може да бъде минимизирана." +
            "<br/><br/><h2>Софтуерни ограничения</h2><br/><span class=\"tab\"></span>За ползване на играта Ryu: The Big Adventure е необходима инсталацията на JRE (Java Runtime Environment). JRE е достъпен от сайта на " +
            "Oracle.&nbsp;<a href=\"http://www.oracle.com/technetwork/java/javase/downloads/index.html\" target=\"_blank\"><b><u>Link</u></b></a><br/><br/><h2>Допускания и зависимости</h2><br/><span class=\"tab\"></span>" +
            "Достъпът до дистрибуцията на играта е зависим от GitHub, уеб хранилището за разполагане на софтуерни проекти и техните съвместни разработки върху отдалечен интернет сървър.<br/><span class=\"tab\"></span>" +
            "Проектът прави допускането и разчита, че порталът GitHub, който се поддържа от трета страна, е достъпен и в изправност.<br/><span class=\"tab\"></span>Прави се също допускането, че крайните потребители " +
            "разполагат със съвместим персонален компютър с инсталират Java Runtime Environment. Към момента на създаването на проекта, Java езикът е с голяма популярност и повечето компютри имат инсталиран нужният пакет," + 
            " което спомага за лесното разпространение на играта.<br/><br/><h2>Диаграма на състоянията</h2><br/><span class=\"tab\"></span>Диаграмата на състоянията в този раздел показва как играта Ryu: The Big Adventure " +
            "трябва да обработва заявките на крайния потребител.<br/><span class=\"tab\"></span>Диаграмата е изградена чрез Унифицираният език за моделиране (UML), който е графичен език за конструиране и документиране на " +
            "елементите на една софтуерна система.<br/><br/><img src=\"/Resources/ryu4.png\" width=\"592\" height=\"400\"><a href=\"/Resources/ryu4.png\"target=\"_blank\"><b><u>Оригинален размер</u></b></a><br/><br/><span" +
            " class=\"tab\"></span>В проекта се използват 4 различни състояния, едно за менюто, второто за настройките, третото е „За Автора“ и последното е за самата игра. Описани са и начините, по които може да се премине" + 
            " от едно състояние към друго, чрез насочени стрелки. Черните точки илюстрират пускането на програмата и съответно изключването й.";

        string ryuTextEng2 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/><span class=\"tab\"></span>Spirit energy is displayed" +
            " in the lower left corner of the screen, in the form of 8 blue rectangles. It's used when performing special moves. After being used, energy regenerates slowly over time. When the player doesn't have enough" +
            " energy, he can't use special abilities.<br/><span class=\"tab\"></span>Over the energy indicator there is another one, for the health of Ryu, described as HP. It's displayed in the same way, but with red" +
            " rectangles. Unlike energy, health doesn't regenerate over time. To restore health Ryu must find food which is dropped randomly on the map. Health is taken when the player gets hit or when he goes through some" +
            " obsticle like fire. When all of our health is depleted Ryu dies and the game ends.<br/><span class=\"tab\"></span>Other than those two indicators there is alos time. Time is displayer at the bottom of the" +
            " screen in the middle. It shows how much time we have to complete the level. When the time ends the game ends. We get more time by reaching certain part of the level.<br/><span class=\"tab\"></span>There are" +
            " also in-game options. The user can stop and start the sound of the game, to change the volume, to change the game difficulty and to quit at any time. The game can also be minimized.<br/><br/><h2>Software " +
            "limitations</h2><br/><span class=\"tab\"></span>To play Ryu: The Big Adventure we need JRE (Java Runtime Environment). JRE is available from Oracle's website.&nbsp;<a href" +
            "=\"http://www.oracle.com/technetwork/java/javase/downloads/index.html\" target=\"_blank\"><b><u>Link</u></b></a><br/><br/><h2>Acceptances and dependencies</h2><br/><span class=\"tab\"></span>The source code " + 
            "can be found on GitHub, a web-based hosting service for source code management (SCM) and distributed revision control.<br/><span class=\"tab\"></span>The project makes the assumption that GitHub, which is" +
            " managed by third-party administration is accessible.<br/><span class=\"tab\"></span>There is also the acceptance, that the users have compatible computer with Java Runtime Environment installed on it. At the" +
            " moment of creating the project, The Java programming language is very popular and most computers have the required package installed, which helps the easy distribution of the game.<br/><br/><h2>State diagram" +
            "</h2><br/><span class=\"tab\"></span>The state diagram shows how the game Ryu: The Big Adventure handles user commands.<br/><span class=\"tab\"></span>The diagram is created using The Unified Modeling Language" +
            " (UML), a general-purpose modeling language in the field of software engineering, which is designed to provide a standard way to visualize the design of a system<br/><br/><img src=\"/Resources/ryu4.png\" " +
            "width=\"592\" height=\"400\"><a href=\"/Resources/ryu4.png\"target=\"_blank\"><b><u>Original size</u></b></a><br/><br/><span class=\"tab\"></span>There are 4 different states in the project - menu, options," + 
            " credits and the game itself. We can see the ways we can pass through different states.";

        string ryuTextBul3 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/><h2>Реализация</h2><br/><h3>Потребителско меню</h3>" +
            "<br/><span class=\"tab\"></span>Първата цел при създаването на проекта е да се направи начално потребителско меню.<br/><br/><img src=\"/Resources/ryu5.jpg\" width=\"592\"><span class=\"tab\"></span>Основните" +
            " събития, за които контролерът е „абониран“ е началото на нова игра (при натискане на бутон „Start Game“), показването на екран с настройки, екран „За Автора“ и изход от приложението. В менюто е изобразен и " + 
            "главният ни герой, в която роля се очаква да влезем.<br/><br/><h3>Настройки</h3><br/><span class=\"tab\"></span>Менюто с настройките съдържа две маркиращи квадратчета, за включване и изключване на музиката" +
            " и звуците, два слайдера за контролиране силата на звука и опция за контролиране на трудността на играта, както и бутон за връщане обратно към основното меню.<br/><span class=\"tab\"></span>В менюто с " +
            "настройките са използвани глобални променливи, които са достъпни до всеки един клас. Те се обявяват в главното меню, променят се в менюто с настройките и се прочитат от всяко едно събитие. Така звукът и " +
            "музиката работят еднакво, във всяко едно състояние.<br/><br/><img src=\"/Resources/ryu6.jpg\" width=\"592\"><span class=\"tab\"></span>Трудността оказва влияние на издръжливостта на противниците. Когато " + 
            "трудността е настроена на Hard, противниците са по-корави и са нужни повече удари за да бъдат убити и обратното. За постигането на целта се използва глобалната променлива difficulty, която приема следните три" +
            " стойности: 0 за Easy, 1 за Normal и 2 за Hard. При 0 издръжливостта на противниците се намаля до 50% от нормалното, при 1 издръжливостта не се променя и остава на стандартното 100%, а при 2 тя се повишава до" + 
            " 150%.<br/><span class=\"tab\"></span>Слайдера за музиката използва метода  music.setVolume(float volume); за промяна на силата на музиката и music.getVolume(float volume); за да прочита каква е силата в момента " +
            "и да променя собственото си състояние.<br/><span class=\"tab\"></span>Слайдера за звуците използва своя собствена глобална променлива, вместо методите  setVolume и getVolumе поради това, че силата на звукът им" + 
            " се декларира, когато те бъдат възпроизведени и може да е различен за всеки един звук. Глобалната променлива се декларира в менюто и се нарича soundVolume. Тя се използва с прозвучаването на всеки един звук по" +
            " следния начин: <br/>punchedSnd.play(1, Menu.soundVolume);<br/><span class=\"tab\"></span>В горната команда звукът punchedSnd бива прозвирен чрез метода play. 1 представлява стъпката на звукът а променливата" +
            " soundVolume се извиква от класът Menu и контролира неговата му сила.<br/><span class=\"tab\"></span>За маркиращите квадратчета са използвани булевите soundOn и musicOn.<br/><br/><h3>За автора</h3><br/>" +
            "<span class=\"tab\"></span>Credits или „За автора“ е най-просто изграденото състояние. То показва информация за създателите на приложението, под формата на слайдващ се нагоре текст. Информацията всъщност " + 
            "представлява едно голямо изображение, което се движи нагоре по екрана през определен интервал от време.";

        string ryuTextEng3 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/><h2>Realization</h2><br/><h3>User menu</h3><br/>" +
            "<span class=\"tab\"></span>The first part of the project is to create a main menu.<br/><br/><img src=\"/Resources/ryu5.jpg\" width=\"592\"><span class=\"tab\"></span>The menu provides options to start a new" +
            " game, to go to the settings screen, go ot the credits screen and exit the game. In the menu we can see the main character.<br/><br/><h3Options</h3><br/><span class=\"tab\"></span>The options menu contains to" +
            " tickable squares, for turning music and sounds on and off, two sliders for controling sound volume and an option to control game difficulty, also there is a back button.<br/><span class=\"tab\"></span>In the" +
            " settings menu I've used global variables, which are available in every class. They are declared in the main menu, can be changed in the settings menu and can be red from all states. This way sound and music " + 
            "can work in the same way in every part of the game.<br/><br/><img src=\"/Resources/ryu6.jpg\" width=\"592\"><span class=\"tab\"></span>Difficulty changes enemies health by increasing or decreasing it." +
            " When the difficulty is set on Hard, enemies are much harder and require much more effort to kill. To make this I've used a global variable named Difficulty, which can take three different numbers: 0 for Easy," +
            " 1 for Normal and 2 for Hard. At 0 health of enemies is decreased by 50% from normal, at 1 health isn't changed and at 2, it's increased by 50%.<br/><span class=\"tab\"></span>The music slider uses the method" +
            " music.setVolume(float volume); for changing music volume and music.getVolume(float volume); to read the current volume and to change it's state accordingly.<br/><span class=\"tab\"></span>The sound slider " +
            "uses it's own global variable unlike setVolume and getVolumе because sound volume is declared, at the moment they are played and can be different for every each sound. The global variable is declared in the " +
            "main manu and it's named soundVolume. It's used every time a sound is played in the following way: <br/>punchedSnd.play(1, Menu.soundVolume);<br/><span class=\"tab\"></span>In this command punchedSnd is been" +
            " played using the method play. 1 is the pitch and the variable soundVolume is called from the menu class and sets the volume of the sound.<br/><span class=\"tab\"></span>For the thicking squares I've used the" +
            " variables soundOn and musicOn.<br/><br/><h3>Credits</h3><br/><span class=\"tab\"></span>Credits is the most simple made state. It shows information about the creator of the game by sliding text through the" + 
            " screen. The text is actually an image which is moved up the screen";

        string ryuTextBul4 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/><h2>Реализация</h2><br/><h3>Play</h3><br/>" +
            "<span class=\"tab\"></span>Класът Play е основното състояние на играта. В него са реализирани главният герой, враговете му, структурата на нивото, обектите по картата и взаимоотношението между всички тях.<br/>" +
            "<h4>Начална анимация</h4><br/>Нивото ни приветства с начална анимация - „Round One“ и съпътстващ я звук. За целта се използва изображение (round1Image) и мащабиращ ефект, като така се добавя допълнителна " +
            "динамика. За постигане на ефекта се използва командата round1Image.draw() заедно с променливата round1Scale, която отговаря за мащаба на изображението. Когато използваме командата round1Scale++; в update " +
            "метода, променливата ще се увеличава с единица, с всеки един цикъл. По този начин и мащаба на началното изображение се увеличава и ефекта е постигнат. При стигане до определен мащаб, началната анимация " +
            "приключва, таймера се включва и потребителя получава контрол над героя.<table><tr><th>public void round1Animation()<br/>{<br/><span class=\"tab\"></span><font color=\"green\">//round1 animation and sound" +
            "</font><br/><span class=\"tab\"></span>if (round1Bool)<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>round1Scale += 4;<br/><span class=\"tab\"></span>}<br/>" +
            "<span class=\"tab\"></span>if (round1Scale >= 100 && round1Scale <= 105 && Menu.soundOn)<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>" +
            "round1Snd.play(1, Menu.soundVolume);<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span> if (round1Scale >= 600 && round1Scale <= 610)<br/><span class=\"tab\"></span>{<br/><span class=\"tab\">" +
            "</span><span class=\"tab\"></span>round1Bool = false;<br/><span class=\"tab\"></span><span class=\"tab\"></span>enableInput = true;<br/><span class=\"tab\"></span><span class=\"tab\"></span>round1Scale = 1;" +
            "<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>Методът е round1Animation(). round1Bool се грижи за приключването на анимацията. При достигане на размер 100 се включва" +
            " съпътстващият звук, а при достигане на размер 600 анимацията приключва. Освен за началната анимация и звук, при изпълнението на метода се променя и трудността на противниците, според въведената настройка за " +
            "трудност в менюто за настройки. enableInput булевата се използва за позволяване и забраняване на управлението на героя. Освен при началото на играта, булевата се използва и на други места, като по време на " +
            "менюто за пауза.<br/><br/><h3>Карта на нивото</h3><br/><span class=\"tab\"></span>Картата представлява едно голямо изображение със зелен фон наподобяващ трева. Първо, изображението е оразмерено до точната " +
            "големина, за да се получи достатъчно продължително ниво. Освен тревата имаме и гора, от горната и долната част. Тази гора представлява обструкция, която има за цел да не позволява на героя да излиза извън " +
            "границите на нивото. Гората е изградена от един единствен спрайт на дърво. Спрайтът е взет от сайтът <a href=\"http://www.deviantart.com\" target=\"_blank\"><b><u>www.deviantart.com</u></b></a>, сайт за " +
            "публикуване на произведения на изкуството, на потребители от цял свят.<br/><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\">" +
            "</span><img src=\"/Resources/ryu7.png\" width=\"300\"><br/><span class=\"tab\"></span>След намиране на подходящият спрайт, с помощта на Photoshop, дървото се дублира многократно, за да се постигне ефект на " +
            "гора. Процесът по изграждането на нивото е сравнително лесен, но изображението трябва да е в .png формат, поради лимитация на slick2D. Това означава, че крайният резултат от картата е файл с размер от 10MB или" +
            " близо 3 пъти по-голям от еквивалента си в .jpg формат.<br/><span class=\"tab\"></span>При създаване на картата, създаваме и две променливи – shiftX и shiftY. Те се използват за да движат изображението в " + 
            "прозореца на програмата. Така когато движим героя, ние всъщност движим картата под него. Неговите координати си остават едни и същи, но получаваме ефект на движение на героя.";

        string ryuTextEng4 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/><h2>Realization</h2><br/><h3>Play</h3><br/>" +
            "<span class=\"tab\"></span>The Play class is the main state of the game. In it the main character, his enemies, the structure of the level and the objects on the map have been initialized.<br/><h4>Start " + 
            "animation</h4><br/>Starting a new game present us with an animation - „Round One“ and a corresponding sound. For this purpose we use an image (round1Image) and a scaling effect. To create the effect " +
            " we use the command round1Image.draw() and the variable round1Scale, which scales the image. When we use the command round1Scale++; in the update method, the variable gets increased with every cicle of the " +
            "game. This way the scale is increased and the animation is complete. When reaching a certain scale, the starting animation stops, the timer starts and the user takes control over the main character.<table><tr>" + 
            "<th>public void round1Animation()<br/>{<br/><span class=\"tab\"></span><font color=\"green\">//round1 animation and sound</font><br/><span class=\"tab\"></span>if (round1Bool)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>round1Scale += 4;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>if (round1Scale >= 100 && round1Scale <= 105 && Menu.soundOn)" +
            "<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>round1Snd.play(1, Menu.soundVolume);<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>" +
            "if (round1Scale >= 600 && round1Scale <= 610)<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>round1Bool = false;<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>enableInput = true;<br/><span class=\"tab\"></span><span class=\"tab\"></span>round1Scale = 1;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>The method is " +
            "round1Animation(). round1Bool takes care of the completion of the animation. When reaching scale of 100 a sound starts to play, and when reaching scale of 600 the animation ends. Beside the animation, this " +
            "method is also responsible for changing the enemies health according to the difficulty, set in the options menu. The boolean enableInput is used to give or inhibit control over the main character. Beside at " +
            "the beginning of the game, the boolean is used in other places, like when the pause menu is open.<br/><br/><h3>Map of the level</h3><br/><span class=\"tab\"></span>The map is one huge image, with greenish " +
            "background imitating grass. First the image is scaled to an exact size so the level can be long enough. Other than the grass there is also a forest from the top and bottom. This forest is an obstruction, which" +
            " haves the purpose to not allow the main character to go outside the boundries of the map. The forest is made of only one sprite, that of a tree. The sprite is downloaded from " +
            "<a href=\"http://www.deviantart.com\" target=\"_blank\"><b><u>www.deviantart.com</u></b></a>, a website for publication of user-made artwork.<br/><span class=\"tab\"></span><span class=\"tab\"></span>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span><img src=\"/Resources/ryu7.png\" width=\"300\"><br/><span class=\"tab\"></span>After finding the correct sprite, using Photoshop," + 
            " the tree is duplicated multiple times so the effect of a forest can be made. The process of building the map is fairly simple, the image must be in .png format because of a limitation in Slick2D. This means," +
            " that the resulting file is 10MB in size or nearly 3 larger than the equivalent in .jpg.<br/><span class=\"tab\"></span>When creating the map we also create two variables – shiftX and shiftY. They are used to" + 
            " move the image in the window ot the program. This way when moving Ryu we actually move the image below him. His coordinates remain the same but we get the effect of moving the character.";

        string ryuTextBul5 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/><h2>Реализация</h2><br/><h3>Създаване на Ryu</h3>" +
            "<br/><span class=\"tab\"></span>За анимиране на главният герой на играта са използвани общо 14 различни анимации. Всяка една анимация е изградена от спрайтшийтове.<br/><span class=\"tab\"></span>Spritesheet" +
            " представлява едно изображение, в което се намират няколко подизображения от анимацията наречени спрайтове.<br/><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>" +
            "<img src=\"/Resources/ryu8.png\" width=\"400\"><br/><span class=\"tab\"></span>При декларацията използваме пътя към спрайт-изображението и x и y, които отговарят съответно за вертикалния и хоризонталния размер" +
            " на кадъра в спрайта. И тук както при анимирането с отделни кадри, спрайта трябва да е в png формат и с прозрачен фон.<br/><img src=\"/Resources/ryu9.png\" width=\"594\"><br/><span class=\"tab\"></span>Кадрите" +
            " в спрайта трябва да са на точно разстояние един от друг. x се сформира като се вземе хоризонталната резолюция и се раздели на броят кадри в спрайта. При несъответствие, се получават неточности, в " +
            "изобразяването на анимацията.<br/><span class=\"tab\"></span>Анимацията се декларира, като за източник се използва спрайта, следван от х, отговарящ за времетраенето на всеки един кадър в милисекунди. След " +
            "изтичане на времето, кадъра се заменя автоматично от следващия в спрайта.<br/><br/><li><b>ryuStatic</b>. Това е статичната анимация. Използва се по всяко време, когато героят не се движи или не извършва някакво" + 
            " действие. Освен по време на игра, спрайтът се използва и в началното меню.</li><br/><li><b>ryuReady</b>. Анимацията се използва в началното и при благополучно приключване на играта. Тя представлява " +
            " действието на Ryu, за завързване на лентата на главата си.<br/><li><b>ryuLeft</b>. Използва се при вървене назад и илюстрира отстъпване назад.</li><br/><li><b>ryuRight</b>. Използва се при движение " +
            "напред/надясно, нагоре и надолу.</li><br/><li><b>ryuPunch</b>. Това е юмрукът на Ryu</li><br/><li><b>ryuLowKick</b>. Ритникът на Ryu.</li><br/><li><b>ryuHadouken</b><b>ryuShoryuken</b> и <b>ryuTatsaku</b>. " +
            "Тези анимации илюстрират трите специални умения на героя.<b>ryuHadouken</b> се използва в комбинация с <b>ryuHadoukenBall</b>, която е анимацията на изстреляната от Ryu топка от енергия.</li><br/><li><b>" +
            "ryuHurt</b>. Тази анимация илюстрира как Ryu поема удър от противник.</li><br/><li><b>ryuWin1</b> и <b>ryuWin2</b>. Това са две отделни анимации, които вървят в комбинация и се използват при благополучното " +
            "приключване на играта. Те илюстрират Ryu като победител.<br/><br/><span class=\"tab\"></span>Освен за визуализацията, Ryu използва и редица звукови ефекти, взети от различни източници от Интернет.<br/>" + 
            "<span class=\"tab\"></span>За реализацията на героя, са използвани и множество от променливи и методи, които вдъхват живот в героя.<br/><span class=\"tab\"></span>Методът ryuPhysics() отговаря за движението," +
            " привключването на различните анимации, ударите, специалните умения  и жизнените показатели на главният герой. Методът слуша за въвеждания от клавиатурата и движи и илюстрира героя според тях. Тук са записани " +
            "продължителностите на анимацийте, границите на нивото, които не могат да бъдат преминавани,  взаимоотношението на Ryu с препядствията и обектите за събиране по картата и следенето на неговите жизнени " +
            "показатели. За да се избегне дублирането на анимацийте, всяка една от тях е групирана със собствена булева стойност. Когато Ryu е в статично положение, булевата ryuStatic е true и всички останали са false. Във" +
            " всеки един момент, само една булева стойност може да е истина. В противен случай, на картата могат да се появят две различни анимации едновременно или два главни героя един върху друг. За справяне с този " +
            "проблем идва още един метод, наречен removeDuplications(). Той се грижи за това да има само една булева, която да е истина и променя останалите в неистина.<br/><span class=\"tab\"></span>Координатите на Ryu са" +
            " описани от общо 4 променливи. Първите, shiftX и shiftY, определят местоположението му върху прозореца на играта. Тези координати са едни и същи и не се променят през цялата игра. Втората двойка променливи са" +
            " ryuPositionX и ryuPositionY. Те определят местоположението му върху картата на нивото. Те описват движението на картата зад Ryu. Така получаваме ефекта, че Ryu се движи, но всъщност самата му фигура не се " + 
            "премества от горният ляв ъгъл на прозореца.";

        string ryuTextEng5 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/><h2>Realization</h2><br/><h3>Creating Ryu</h3><br/>" +
            "<span class=\"tab\"></span>To animate the main character in the game I've used a total of 14 different animations. Each animation is made of spritesheets.<br/><span class=\"tab\"></span>A spritesheet is an " +
            "image in which there are a couple of sub-images or frames of the animation called sprites.<br/><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\">" +
            "</span><img src=\"/Resources/ryu8.png\" width=\"400\"><br/><span class=\"tab\"></span>When declaring the spritesheet we give the path to the image, x and y, which correspond to the vertical and horizontal size" +
            " of the sprite frame. The spritesheet must be in .png format and with transparent background.<br/><img src=\"/Resources/ryu9.png\" width=\"594\"><br/><span class=\"tab\"></span>The frames of the sprite have to" +
            " be in an exact distance between each other. x is formed when we take the horizontal size of the spritesheet and we divide it by the count of frames inside it. If the distance isn't messured corectly, there " +
            "will be inadequacyies when drawing the animation.<br/><span class=\"tab\"></span>The animation is declared with the spritesheet as source file followed by х which stands for the duration of each frame messured" +
            " in milliseconds. After this duration has passed the framed is followed by the next in the spritesheet.<br/><br/><li><b>ryuStatic</b>. This is the static animation. It's used each time Ryu isn't moving or " +
            "doing some action. Other than inside the game, this sprite is also used in the main menu.</li><br/><li><b>ryuReady</b>. This animation is used when starting and finishing the game. It represents the action of " +
            "Ryu when tying his headband.<br/><li><b>ryuLeft</b>. Used when walking back.</li><br/><li><b>ryuRight</b>. Used when walking forward/right, up and down.</li><br/><li><b>ryuPunch</b>. This is Ryu hitting with " +
            "fist</li><br/><li><b>ryuLowKick</b>. Ryu hitting with kick.</li><br/><li><b>ryuHadouken</b><b>ryuShoryuken</b> and <b>ryuTatsaku</b>. These animations represent the three special abilities that Ryu posses.<b>" +
            "ryuHadouken</b> is used in combination with <b>ryuHadoukenBall</b>, which is the animation of the fired ball of energy.</li><br/><li><b>ryuHurt</b>. This is the animation of Ryu when he gets hurt.</li><br/><li>" +
            "<b>ryuWin1</b> and <b>ryuWin2</b>. These are two different animations which work in combination and are used when finishing the game. They illustrate Ryu as a winner.<br/><br/><span class=\"tab\"></span>Other " +
            "the visual Ryu also uses a variety of sound effects, taken from different sources from the web.<br/><span class=\"tab\"></span>For the realization of Ryu there are also a variety of variables and methods, which" +
            " are created for his needs.<br/><span class=\"tab\"></span>ryuPhysics() takes care of moving, Ryu, switching between basic animations, hits, special abilities, his health and energy. This method listens to " +
            "input from the keyboard and does the corresponding animation. Here there are the durations of the animations, the boundries of the level which cannot be passed, the relationship between Ryu and the traps and " +
            "objects on the map and the monitoring of his HP and MP. To avoid duplications of animations each on of them is grouped with it's own boolean. When Ryu is in static position, the boolean ryuStatic is true and " +
            "all other are false. In every moment only one boolean can be true. Otherwise we can see two different animations at the same time. To avoid this problem there is another method called removeDuplications(). It " +
            "takes care of this, that only one boolean can be true and it switches all the others to false.<br/><span class=\"tab\"></span>The coordinates of Ryu are described with 4 variables. First two, shiftX and shiftY" +
            " determine his location on the window of the application. These coordinates are always the same and don't change. The other two are ryuPositionX and ryuPositionY. They determine his location on the map. They " + 
            "describe the movement of the background image behind Ryu. This way we get the effect that Ryu is moving, but actually his figure doesn't move from the left corner of the window.";

        string ryuTextBul6 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br/><br/><h2>Реализация</h2><br/><h3>Създаване на " +
            "противниците</h3><br/><span class=\"tab\"></span>Другата основна част от играта е създаването на противници, които да ни държат заети. Тяхната реализация е сходна с тази на главният герой – създадени са със " +
            "спрайтове, издават звуци, имат жизнени показатели и могат да удрят. Разликата тук е, че те трябва да се контролират от компютъра, чрез изкуствен интелект (A.I.), вместо от клавиатурата.<br/>" +
            "<span class=\"tab\"></span>Всеки един противник е създаден от 5 различни спрайта: статично положение, ходене, удряне, бивайки ударен и спрайт за умиране.<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span><span class=\"tab\"></span><span class=\"tab\"><span class=\"tab\"></span><span class=\"tab\"></span></span><img src=\"/Resources/ryu10.png\" width=\"250\"><br/><span class=\"tab\"></span>Противниците " +
            "се намират на точно определени координати на нивото. За разлика от Ryu, противниците нямат специални умения следователно нямат магически точки (MP) а единствено здраве (HP), което се определя от зададеното " +
            "ниво на трудност.<br/><br/><h3>Създаване на изкуствен интелект</h3><span class=\"tab\"></span><li><b>Общи сведения</b></li><br/><span class=\"tab\"></span>Изкуственият интелект позволява на компютрите да " +
            "правят неща, които за хората изглеждат разумни. Той има способност да анализира обкръжаващата го среда и да предприема действия, които увеличават възможността за постигане на определени цели.<br/>" +
            "<span class=\"tab\"></span>Създаването на изкуственият интелект е един от най-сложните етапи, при проектирането на компютърна игра. За него има обособен отделен дял в информатиката и се изучава като академична" +
            " дисциплина.<br/><span class=\"tab\"></span>Пример за много добър A.I. е този в играта F.E.A.R.: First Encounter Assault Recon. Това е FPS шуутър, в който противниците имат широк набор от действия. Те могат да" +
            " клякат и да минават под препядствия, да скачат през прозорци, да се подават през парапети, да изкачват стълби и да бутат обекти за да създадат прикритие от насрешната стрелба. Различни врагове могат да " +
            "работят в екип, използвайки обиколни пътеки, за да изненадат играча в гръб, да използват потискаща стрелба и да скачат зад стени, когато биват обстрелвани. Често изкуственият интелект на F.E.A.R. е посочван " +
            "като високо развит и неговата ефективност помага на играта да спечели наградите „2005 Best AI Award“ на GameSpot и „Most Infuental AI Games“ на AIGameDev's.<br/><span class=\"tab\"></span>За целта на проекта е" +
            " създаден по-просто устроен изкуствен интелект. Той е един и същ за всеки противник. Това което той прави е да следи за местоположението на главният герой, да се придвижва по посока към него и да изпълнява " +
            "удари върху играча.<br/><span class=\"tab\"></span>При започването на играта, всеки един противник е предварително създаден на нивото, но е в пасивно положение и ние не го виждаме. Те имат определен обхват на " +
            "действие, в което Ryu трябва да влезне, за да могат да се активират. За да не се получи претрупване на врагове, на едно и също място, те се създадени със собствени уникални координати и обхвати на действие." +
            "<br/><span class=\"tab\"></span>Обхватът е такъв, че когато противника се появи на екрана, той вече е в активно положение и вече се движи към нас. Веднъж задействан, противника ще е активен до края на жизненият" + 
            " си цикъл, който е до смъртта му, смъртта на Ryu или изтичане на времето.<br/><img src=\"/Resources/ryu11.jpg\" width=\"592\">";

        string ryuTextEng6 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/><h2>Realization</h2><br/><h3>Creating enemies</h3>" +
            "<br/><span class=\"tab\"></span>The other important part of the game is creating the enemies, which will keep us busy throughout the level. They are created similarly to the main character – they are created " + 
            "using spritesheets, they make sounds, they have health and they can hit. The difference here is that they are controlled by the computer using artificial intelligence (A.I.).<br/><span class=\"tab\"></span>" +
            "Each enemy is created using 5 different spritesheets: static animation, walking, hitting, being hit and a sprite for dying.<br/><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>" +
            "<span class=\"tab\"><span class=\"tab\"></span><span class=\"tab\"></span></span><img src=\"/Resources/ryu10.png\" width=\"250\"><br/><span class=\"tab\"></span>The enemies are initialized in exact coordinates" +
            " on the level. Unlike Ryu, the enemies don't have special abilities which means that they don't have energy (MP) either. Only health (HP), which is defined by the level of difficulty.<br/><br/><h3>Creating " +
            "artificial intelligence</h3><span class=\"tab\"></span><li><b>Overview</b></li><br/><span class=\"tab\"></span>Artificial intelligence alows computers to do things, which people can find reasonable. A.I. can " +
            "analyze the surrounding environment and to make decisions, which increase the posibility to acomplish given tasks.<br/><span class=\"tab\"></span>Creating of A.I. is one of the most complex stages when " +
            "creating a computer game. It haves a ceparate segment in IT and it's an academic field of study.<br/><span class=\"tab\"></span>An example of great A.I. is that in the game F.E.A.R.: First Encounter Assault " +
            "Recon. This is a FPS (First person shooter), in which computer entities have a variety of different actions. Enemies can duck to travel under crawlspaces, jump through windows, vault over railings, climb " +
            "ladders, and push over large objects to create cover. Various opponents may act as a team, taking back routes to surprise the player, using suppressive fire or taking cover if under fire. The game's artificial" +
            " intelligence is often cited as being highly advanced,and its efficiency helped the game win GameSpot's \"2005 Best AI Award,\" and earn the #2 ranking on AIGameDev's \"Most Influential AI Games.\"<br/>" +
            "<span class=\"tab\"></span>For the purpose of this project, I've used a much simpler A.I.. It's the same for every enemy. What it does is to check the coordinates of Ryu, to move towards him and to perform " +
            "hits.<br/><span class=\"tab\"></span>When starting the game, each enemy is created ot the map, but at a passive state and we don't see him. They have a field of action which Ryu must enter in order for them to" +
            " activate. To prevent clutter of enemies in a same spot, they are created with their own separate coordinates and fields of action.<br/><span class=\"tab\"></span>The field is made in the way that when the " +
            "enemy is on the screen, he is already active and is moving towards us. One active, he remains like so until the end of his lifespan, which is until his death, the death of Ryu or when the timer reaches zero." + 
            "<br/><img src=\"/Resources/ryu11.jpg\" width=\"592\">";

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
            "използва метода enemyAttackChance().<br/><span class=\"tab\"></span>enemyAttackChance() е шансът врагът да удари, когато се намира в непосредствена близост до Ryu.<br/><table><tr><th>public boolean enemyAttackChance()<br/>" +
            "{<br/><span class=\"tab\"></span>Random rand = new Random();<br/><br/><span class=\"tab\"></span>if (rand.nextInt(1000) > 900)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>else<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>Метода създава случайно число в интервала от 1 до 1000, с всеки един цикъл на играта. " +
            "Когато числото е по-голямо от 900, метода изпраща сигнал за изпълняване на удар.<br/><span class=\"tab\"></span>Когато всички тези условия са изпълнени преминаваме към изпълнението на удара.";

        string ryuTextEng7 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/>" +
            "<h2>Realization</h2><br/><h3>Creating enemies</h3><span class=\"tab\"></span><span class=\"tab\"></span><li><b>Moving towards Ryu</b></li><br/><span class=\"tab\"></span>Each enemy is moving when Ryu gets inside his range, while" +
            " he is alive and while he isn't next to Ryu. When these two conditions have been met, the enemy starts to move to the coordinates of shiftX and shiftY with the speed of delta * .1f. While moving his animation" +
            " changes to a walking animation.<table><tr><th>if (ryuPositionX < -170 && thugHP > 0)<br/>{<br/><span class=\"tab\"></span>if (thugPosY < 117)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>moveY += delta * .1f;<br/><span class=\"tab\"></span><span class=\"tab\"></span>thugSprite = thugWalkAnimation;<br/><span class=\"tab\"></span>}<br/> " +
            "<span class=\"tab\"></span>if (thugPosY > 120)<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>moveY -= delta * .1f;<br/><span class=\"tab\"></span><spanthugSprite = thugWalkAnimation;<br/>}<br/><span class=\"tab\"></span>if (thugPosX > 170)<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span>" +
            "<span class=\"tab\"></span>moveX -= delta * .1f;<br/><span class=\"tab\"></span><span class=\"tab\"></span>thugSprite = thugWalkAnimation;<br/><span class=\"tab\"></span>}<br/>" +
            "}</th></tr></table><br/><span class=\"tab\"></span>When he reaches the main character he stops, because one of the condition isn't met – that of not being next to him.<br/><br/><li><b>Hitting</b></li><br/><span class=\"tab\"></span>" +
            "To be able to hit Ryu, first we need to meet a series of conditions. The enemy must be right in front of Ryu, Ryu mustn't do any hits or skills at the moment and he must be alive.<br/><span class=\"tab\"></span>" +
            "First the boolean method thugAtRyu() looks if the enemy is at the right place to perform a hit and returns true.<br/><table><tr><th>public boolean thugAtRyu(float thugPosX, float thugPosY)<br/>" +
            "{<br/><span class=\"tab\"></span>if (thugPosX < 190 && thugPosX > 115 && thugPosY < 130 &&<br/><span class=\"tab\"></span><span class=\"tab\"></span>thugPosY > 70)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>else<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>With the next boolean method called ryuAttack(), we look if the main character" +
            " isn't doing any hits or special skills.<br/><table><tr><th>public boolean ryuAttack()<br/>" +
            "{<br/><span class=\"tab\"></span>if (ryuHadouken || ryuLowKick || ryuPunch || ryuShoryuken ||<br/><span class=\"tab\"></span><span class=\"tab\"></span>ryuShoryuken || ryuTatsaku)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>else<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>As I mentioned before, for each action of Ryu there is a boolean. In this case," +
            " using them, we can check for these actions and use them in this method.<br/><span class=\"tab\"></span>The enemy must hit in an interval of time when he is at Ryu. For this purpose " +
            "we use the method enemyAttackChance().<br/><span class=\"tab\"></span>enemyAttackChance() is the chance the enemy hits.<br/><table><tr><th>public boolean enemyAttackChance()<br/>" +
            "{<br/><span class=\"tab\"></span>Random rand = new Random();<br/><br/><span class=\"tab\"></span>if (rand.nextInt(1000) > 900)<br/><span class=\"tab\">" +
            "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>else<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>This method creates a random nombe in the range from 1 to 1000 with each cicle of the game. " +
            "When this number is greater than 900, the method sends a signal to perform a hit.<br/><span class=\"tab\"></span>When all these conditions have been met we can finally execute a punch.";

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

        string ryuTextEng8 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/>" +
           "<h2>Realization</h2><br/><h3>Creating enemies</h3><br/><table><tr><th>if (thugAtRyu(thugPosX, thugPosY) && !ryuAttack() && enemyAttackChance() &&<br/><span class=\"tab\"></span>showThug && thugHitRyu)<br/>" +
           "{<br/><span class=\"tab\"></span>thugSprite = thugHitAnimation;<br/><span class=\"tab\"></span>getInitialTime = time;<br/><br/><span class=\"tab\"></span>if (!punchedSnd.playing() && Menu.soundOn)<br/><span class=\"tab\">" +
           "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>punchedSnd.play(1, Menu.soundVolume);<br/><span class=\"tab\"></span>}<br/><br/> " +
           "<span class=\"tab\"></span>ryuHurt = true;<br/><span class=\"tab\"></span>ryuHP--;<br/><span class=\"tab\"></span>thugHitRyu = false;<br/>" +
           "}</th></tr></table><br/><span class=\"tab\"></span>First, the animation of the enemy changes to a hitting one. After that we create a timer, which returns him " +
           "to static position after an interval of time. We check to see if sounds have been enabled and we execute a hitting sound. Also we check that this certain sound" +
           " isn't been used at the moment using punchedSnd.playing(), which returns true if it's used. The reason of doing this is to prevent overlap of the sound. We change the animation to" +
           " Ryu with the one which represents him in pain and we decrease his hit points. Finally, the timer returns Ryu to his static position.<br/><span class=\"tab\"></span>To " +
           "create the timer we use the method delay().<br/><table><tr><th>public boolean delay(long startTime, int number)<br/>{<br/></span><span class=\"tab\"></span>if (startTime + number <= time)<br/><span class=\"tab\">" +
           "</span>{<br/><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br/><span class=\"tab\"></span>}<br/><span class=\"tab\"></span>else<br/><span class=\"tab\"></span>{<br/><span class=\"tab\"></span><span class=\"tab\">" +
           "</span>return false;<br/><span class=\"tab\"></span>}<br/>}</th></tr></table><br/><span class=\"tab\"></span>This method uses the variable time, which represents system time." +
           " StartTime is the time at which the timer has started, and number is the interval of time until his end. When the interval is over the method returns true and the timer stops.<br/><span class=\"tab\">" +
           "Ryu's punches are done in the same way.<br/><span class=\"tab\">To do a hit we first have to check if there is an enemy close to Ryu and if he is alive. After that we play a punching sound " +
           "in the exact same way, we change the animations of the two characters, create a timer and we decrease the enemy's hit points. After the timer has completed, they return to they're starting position and we can " +
           "start all over again.<br/><br/><li><b>Animation for ending</b></li><br/><span class=\"tab\"></span>This animation is used when the user completes the level and it's made in the same way as the starting animation." +
           " In here we also use three sprites of Ryu, with which we show him as a winner.<br><table><tr><th>public void youWinAnimation(StateBasedGame sbg)<br/>" +
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

        string ryuTextEng9 = "<br/><br/><h1>Ryu: The Big Adventure!</h1><br/><em>2D Action game. Written in Java it represents a 2D Beat 'em up simulator.</em><br/><br/>" +
            "<h2>Realization</h2><br/><span class=\"tab\"></span>The method is called youWinAnimation. It's executed with every cicle of the game," +
            " but it's activated when the boolean winState returns true. winState returns true when all enemies have been killed. It checks" +
            " the hit points of each entity and executes when they all are at 0. The check itself is inside update(), which means that it's executed" +
            " with every cicle of the game.<br/><img src=\"/Resources/ryu12.png\" width=\"592\"><br/><span class=\"tab\"></span>When true youWinImage is drawn" +
            " on the screen, with  youWinScale1 and youWinScale2 as it's vertical and horizontal size. These variables increase so that " +
            "the animation can be done. When youWinScale1 reaches 100 a sound is played. When  " +
            "youWinScale1 reaches 600, the image is at it's full size, the scaling stops and a short time after that the user gets moved to the main menu," +
            " using sbg.enterState(0);.<br/><span class=\"tab\"></span>I mentioned that Ryu also has an animation for the ending. First, user movement is disabled using enableInput" +
            " = false;. After that we move to the first sprite ryuReadyAnimation, which is made out of 6 sprites. We stop the animation at the 6th frame using " +
            "ryuSprite.stopAt(6);, we do a check to see if it's stopped with ryuSprite.isStopped() and if that's true we move to the next sprite - ryuWin1Animation." +
            " Again we stop the sprite at the last frame, in this case frame 3, we check for the stopping of the animation and we go to the last animation " +
            "ryuWin2Animation.<br/><span class=\"tab\"></span><br/><br/><h2>" +
            "Conclusion</h2><br/><span class=\"tab\"></span>In this project I've shown some of the most important components for building this game. I've mentioned " +
            "LWJGL and Slick2D, which are needed for this purpose." +
            " I've shown the logic of the animation using spritesheets and I've shown some methods of realization, which I've used to create the logic" +
            " of the game Ryu: The Big Adventure.<br/><span class=\"tab\"></span>From here there are many posibilities for further developing the game:<br/><span " +
            "class=\"tab\"></span>The artificial intelligence can be drastically improved. Each of the enemies is create independently," +
            " which meants that they can have a different A.I. and can do their own things which can differ them from the others. There are different types of character classes in each game, like a tank, healer, archer and warrior," +
            " each of them specialized in a certain set of skills, with different advantages and disadvantages.<br/><span class=\"tab\"></span>The tank is a class which has the purpose to take hits and to protect" +
            " the rest from damage. He does small amounts of damage, but has a lot of HP and is very hard to kill.<br/><span class=\"tab\"></span>The healer uses magical skills to" +
            " heal his allies and to buff them, increasing they're power. He's easy to kill and doesn't do any kind of damage and so he has to be protected and in the back of every formation, where" +
            " he uses his healings.<br/><span class=\"tab\"></span>The archer and the warrior are the classes which do the most damage. The tank takes the enemies attention, the healer " +
            "keeps everyone alive and the archer and warrior do the damage.<br/><span class=\"tab\"></span>Each class will need its own type of A.I." +
            " ,which has to be a lot different from the others. This combination of classes can cause a lot of problems for the player, forcing him to " +
            "use different type of strategies for each one of them.<br/><span class=\"tab\"></span>A database can be added, which can keep high scores. The score can be based on" +
            " how long it took to complete the level, on what difficulty, how much HP remaining does the player haves at the end and others.<br/><span class=\"tab\"></span>" +
            "The game can be ported to other platforms like iOS, Windows Mobile, Android and Blackberry or it can be played online using an internet browser." +
            "<br/><br/><b>Source: </b><a href=\"https://github.com/ivanpop/Ryu\" target=\"_blank\">" +
            "<b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class " +
            " =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/ryu.zip\">Ryu: The Big Adventure!</a></td><td class=\"size\">24.8 MB</td> " +
            " </tr></tbody></table>";

        string projectsBul = "Тук съм показал някои от проектите върху които работя.<br/><br/>";
        string projectsEng = "Here I've shown some of the projects I'm working on.<br/><br/>";
        byte id = 0, code;
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
                mainContent.Text = projectsBul;
                artTitle.Text = "Проекти";
                if (id == 1)
                {
                    mainContent.Text = projectsEng;
                    artTitle.Text = "Projects";
                }
            }
            if (Request.QueryString["a"] == null)
            {
                aboutMe.Enabled = false;
                  
                mainContent.Text = aboutMeBul;

                if (id == 1)
                {
                    artTitle.Text = "About me";
                    mainContent.Text = aboutMeEng;
                }
            }
            if (Request.QueryString["a"] == "bio")
            {
                biography.Enabled = false;
                ivanpopov.Visible = true;
                artTitle.Text = "Автобиография";
                mainContent.Text = biographyBul;
                if (id == 1)
                {
                    artTitle.Text = "Biography";
                    mainContent.Text = biographyEng;
                }
            }
            if (Request.QueryString["a"] == "con")
            {
                contacts.Enabled = false;
                contactsPanel.Visible = true;
                artTitle.Text = "Контакти";
                mainContent.Text = contactsBul;
                if (id == 1)
                {
                    artTitle.Text = "Contacts";
                    mainContent.Text = contactsEng;
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
                projects.Enabled = false;
                converter.Enabled = false;
                projectsPanel.Visible = true;
                mainContent.Text = "";
                artTitle.Text = "Проекти";
                projectsContent.Text = converterTextBul;
                if (id == 1)
                {
                    artTitle.Text = "Projects";
                    projectsContent.Text = converterTextEng;
                }
            }
            if (Request.QueryString["a"] == "countdown")
            {
                projects.Enabled = false;
                countdown.Enabled = false;
                projectsPanel.Visible = true;
                mainContent.Text = "";
                artTitle.Text = "Проекти";
                projectsContent.Text = stopwatchTextBul1;
                pagePanel.Visible = true;
                pageBtn3.Visible = false;
                pageBtn4.Visible = false;
                pageBtn5.Visible = false;
                pageBtn6.Visible = false;
                pageBtn7.Visible = false;
                pageBtn8.Visible = false;
                pageBtn9.Visible = false;
                byte page;
                byte.TryParse(Request.QueryString["p"], out page);
                switch (page)
                {
                    case 2: pageBtn2.Enabled = false;
                        break;
                    default: pageBtn1.Enabled = false;
                        break;
                }
                if (id == 0)
                {
                    switch (Request.QueryString["p"])
                    {
                        case "2": projectsContent.Text = stopwatchTextBul2;
                            break;
                        default: projectsContent.Text = stopwatchTextBul1;
                            break;
                    }
                }
                else
                {
                    artTitle.Text = "Projects";
                    switch (Request.QueryString["p"])
                    {
                        case "2": projectsContent.Text = stopwatchTextEng2;
                            break;
                        default: projectsContent.Text = stopwatchTextEng1;
                            break;
                    }
                }
            }
            if (Request.QueryString["a"] == "ryu")
            {
                projects.Enabled = false;
                ryu.Enabled = false;
                projectsPanel.Visible = true;
                pagePanel.Visible = true;
                mainContent.Text = "";                                
                byte page;
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
                artTitle.Text = "Проекти";
                if (id == 0)
                {
                    switch (Request.QueryString["p"])
                    {
                        case "2": projectsContent.Text = ryuTextBul2;
                            break;
                        case "3": projectsContent.Text = ryuTextBul3;
                            break;
                        case "4": projectsContent.Text = ryuTextBul4;
                            break;
                        case "5": projectsContent.Text = ryuTextBul5;
                            break;
                        case "6": projectsContent.Text = ryuTextBul6;
                            break;
                        case "7": projectsContent.Text = ryuTextBul7;
                            break;
                        case "8": projectsContent.Text = ryuTextBul8;
                            break;
                        case "9": projectsContent.Text = ryuTextBul9;
                            break;
                        default: projectsContent.Text = ryuTextBul1;
                            break;
                    }
                }
                else
                {
                    artTitle.Text = "Projects";
                    switch (Request.QueryString["p"])
                    {
                        case "2": projectsContent.Text = ryuTextEng2;
                            break;
                        case "3": projectsContent.Text = ryuTextEng3;
                            break;
                        case "4": projectsContent.Text = ryuTextEng4;
                            break;
                        case "5": projectsContent.Text = ryuTextEng5;
                            break;
                        case "6": projectsContent.Text = ryuTextEng6;
                            break;
                        case "7": projectsContent.Text = ryuTextEng7;
                            break;
                        case "8": projectsContent.Text = ryuTextEng8;
                            break;
                        case "9": projectsContent.Text = ryuTextEng9;
                            break;
                        default: projectsContent.Text = ryuTextEng1;
                            break;
                    }                    
                }
            }            
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
                        if (status == SmtpStatusCode.MailboxBusy ||
                            status == SmtpStatusCode.MailboxUnavailable)
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
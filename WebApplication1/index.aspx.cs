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
        string aboutMeBul = "<p>Здравейте,<br><br><span class=\"tab\"></span>Казвам се Иван Попов и съм новозавършил във ФМИТ на Пловдивския Университет \"Паисий Хилендарски\"." +
            "<br><br><span class=\"tab\"></span>Това е моята лична интернет страница.Тук ще намерите информация за мен и актуалните проекти, по които работя активно.<br><br>" +
            "<span class=\"tab\"></span>Моите интереси са основно в областта на Информационните Технологии, Езиците за програмиране и Средите за програмиране.";

        string aboutMeEng = "<p>Hello,<br><br>My name is Ivan Popov and I am a graduate in FMIT in Plovdiv University \"Paisii Hilendasrki\".<br><br>"+
            "This is my personal web page. Here you will find information about me and project, I work on.<br><br>"+
            "My interests are mainly in the field of information technology, programming languages ​​and their programming environments.";

        string biographyBul = "&nbsp;Роден съм на 19.01.1990г. в гр. Пловдив, България.<br><br>&nbsp;"+
            "Завърших висшето си образование, степен бакалавър, в &nbsp;Пловдивски университет \"Паисий Хилендарски\" през 2013 г."+
            "със &nbsp;специалност \"Информатика\".<br><br>&nbsp;Непосредствено след завършването си записах магистърска &nbsp;" +
            "степен, в същия университет, със специалност \"Софтуерни &nbsp;технологии\", която също завърших успешно.<br><br>&nbsp;От декември 2009г, четири месеца след"+
            " записването ми в &nbsp;университета, работя в магазин \"Метро Пловдив 2\", от начало &nbsp;като обикновен сътрудник и впоследствие " +
            "като продуктов &nbsp;консултант.<br><br>Работата ми в магазина ме научи да работя в екип, да работя с клиенти, да си планирам " +
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

        string ryuTextBul4 = "<br><br><h1>Ryu: The Big Adventure!</h1><br><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br><br>" +
            "<h2>Реализация</h2><br><h3>Play</h3><br><span class=\"tab\"></span>Класът Play е основното състояние на играта. В него са реализирани главният герой, " +
            "враговете му, структурата на нивото, обектите по картата и взаимоотношението между всички тях.<br><h4>Начална анимация</h4><br>Нивото ни приветства с начална " + 
            "анимация - „Round One“ и съпътстващ я звук. За целта се използва изображение (round1Image) и мащабиращ ефект, като така се добавя допълнителна динамика. За постигане " + 
            " на ефекта се използва командата round1Image.draw() заедно с променливата round1Scale, която отговаря за мащаба на изображението. Когато използваме командата round1Scale++;" + 
            " в update метода, променливата ще се увеличава с единица, с всеки един цикъл. По този начин и мащаба на началното изображение се увеличава и ефекта е постигнат. При стигане" +
            " до определен мащаб, началната анимация приключва, таймера се включва и потребителя получава контрол над героя.<table><tr><th>public void round1Animation()<br><span class=\"tab\"></span>" +
            "{<br><span class=\"tab\"></span><span class=\"tab\"></span>//round1 animation and sound<br><span class=\"tab\"></span><span class=\"tab\"></span>if (round1Bool)<br><span class=\"tab\">" + 
            "</span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>round1Scale += 4;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br> " +
            "<span class=\"tab\"></span><span class=\"tab\"></span>if (round1Scale >= 100 && round1Scale <= 105 && Menu.soundOn)<br><span class=\"tab\"></span><span class=\"tab\">" + 
            "</span>{<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>round1Snd.play(1, Menu.soundVolume);<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br><span class=\"tab\"></span> " +
            "<span class=\"tab\"></span>if (round1Scale >= 600 && round1Scale <= 610)<br><span class=\"tab\"></span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span>" +
            "<span class=\"tab\"></span>round1Bool = false;<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>enableInput = true;<br><span class=\"tab\"></span><span class " +
            "=\"tab\"></span><span class=\"tab\"></span>round1Scale = 1;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br><span class=\"tab\"></span>}</th></tr></table><br><span class=\"tab\"> " + 
            "</span>Методът е round1Animation(). round1Bool се грижи за приключването на анимацията. При достигане на размер 100 се включва съпътстващият звук, а при достигане на размер 600 анимацията приключва. " + 
            " Освен за началната анимация и звук, при изпълнението на метода се променя и трудността на противниците, според въведената настройка за трудност в менюто за настройки. enableInput булевата се използва " + 
            "за позволяване и забраняване на управлението на героя. Освен при началото на играта, булевата се използва и на други места, като по време на менюто за пауза.<br><br><h3>Карта на нивото</h3><br>" +
            "<span class=\"tab\"></span>Картата представлява едно голямо изображение със зелен фон наподобяващ трева. Първо, изображението е оразмерено до точната големина, за да се получи достатъчно продължително ниво. Освен тревата" + 
            " имаме и гора, от горната и долната част. Тази гора представлява обструкция, която има за цел да не позволява на героя да излиза извън границите на нивото. Гората е изградена от един единствен спрайт " +
            " на дърво. Спрайтът е взет от сайтът <a href=\"http://www.deviantart.com\" target=\"_blank\">" +
            "<b><u>www.deviantart.com</u></b></a>, сайт за публикуване на произведения на изкуството, на потребители от цял свят.<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>" +
            "<span class=\"tab\"></span><span class=\"tab\"></span><img src=\"/Resources/ryu7.png\" width=\"300\"><br><span class=\"tab\"></span>След намиране на подходящият спрайт, с помощта на Photoshop, дървото" + 
            " се дублира многократно, за да се постигне ефект на гора. Процесът по изграждането на нивото е сравнително лесен, но изображението трябва да е в .png формат, поради лимитация на slick2D. Това означава," +
            " че крайният резултат от картата е файл с размер от 10MB или близо 3 пъти по-голям от еквивалента си в .jpg формат.<br><span class=\"tab\"></span>При създаване на картата, създаваме и две променливи – " + 
            "shiftX и shiftY. Те се използват за да движат изображението в прозореца на програмата. Така когато движим героя, ние всъщност движим картата под него. Неговите координати си остават едни и същи, но получаваме ефект на движение на героя.";

        string ryuTextBul5 = "<br><br><h1>Ryu: The Big Adventure!</h1><br><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br><br>" +
            "<h2>Реализация</h2><br><h3>Създаване на Ryu</h3><br><span class=\"tab\"></span>За анимиране на главният герой на играта са използвани общо 14 различни анимации. Всяка една анимация е изградена от спрайтшийтове.<br><span class=\"tab\"></span>" +
            "Spritesheet представлява едно изображение, в което се намират няколко подизображения от анимацията наречени спрайтове.<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span><img src=\"/Resources/ryu8.png\" width=\"400\"><br>" +
            "<span class=\"tab\"></span>При декларацията използваме пътя към спрайт-изображението и x и y, които отговарят съответно за вертикалния и хоризонталния размер на кадъра в спрайта. И тук както при анимирането с отделни кадри, спрайта трябва да е в png формат и с прозрачен фон." +
            "<br><img src=\"/Resources/ryu9.png\" width=\"594\"><br><span class=\"tab\"></span>Кадрите в спрайта трябва да са на точно разстояние един от друг. x се сформира като се вземе хоризонталната резолюция и се раздели на броят кадри в спрайта." +
            " При несъответствие, се получават неточности, в изобразяването на анимацията.<br><span class=\"tab\"></span>Анимацията се декларира, като за източник се използва спрайта, следван от х, отговарящ за времетраенето" +
            " на всеки един кадър в милисекунди. След изтичане на времето, кадъра се заменя автоматично от следващия в спрайта.<br><br><li><b>ryuStatic</b>. Това е статичната анимация. Използва се по всяко време, когато героят не" +
            " се движи или не извършва някакво действие. Освен по време на игра, спрайтът се използва и в началното меню.</li><br><li><b>ryuReady</b>. Анимацията се използва в началното и при благополучно приключване на играта. Тя представлява " +
            " действието на Ryu, за завързване на лентата на главата си.<br><li><b>ryuLeft</b>. Използва се при вървене назад и илюстрира отстъпване назад.</li><br><li><b>ryuRight</b>. Използва се при движение напред/надясно, нагоре и надолу." +
            "</li><br><li><b>ryuPunch</b>. Това е юмрукът на Ryu</li><br><li><b>ryuLowKick</b>. Ритникът на Ryu.</li><br><li><b>ryuHadouken</b><b>ryuShoryuken</b> и <b>ryuTatsaku</b>. Тези анимации илюстрират трите специални умения на героя.<b>ryuHadouken</b> се" +
            " използва в комбинация с <b>ryuHadoukenBall</b>, която е анимацията на изстреляната от Ryu топка от енергия.</li><br><li><b>ryuHurt</b>. Тази анимация илюстрира как Ryu поема удър от противник.</li><br><li><b>ryuWin1</b> и <b>ryuWin2</b>. Това" +
            " са две отделни анимации, които вървят в комбинация и се използват при благополучното приключване на играта. Те илюстрират Ryu като победител.<br><br><span class=\"tab\"></span>Освен за визуализацията, Ryu използва и редица звукови ефекти, взети " +
            "от различни източници от Интернет.<br><span class=\"tab\"></span>За реализацията на героя, са използвани и множество от променливи и методи, които вдъхват живот в героя.<br><span class=\"tab\"></span>Методът ryuPhysics() отговаря за движението," + 
            " привключването на различните анимации, ударите, специалните умения  и жизнените показатели на главният герой. Методът слуша за въвеждания от клавиатурата и движи и илюстрира героя според тях. Тук са записани продължителностите на анимацийте," + 
            " границите на нивото, които не могат да бъдат преминавани,  взаимоотношението на Ryu с препядствията и обектите за събиране по картата и следенето на неговите жизнени показатели. За да се избегне дублирането на анимацийте, всяка една от тях" + 
            " е групирана със собствена булева стойност. Когато Ryu е в статично положение, булевата ryuStatic е true и всички останали са false. Във всеки един момент, само една булева стойност може да е истина. В противен случай, на картата могат да" + 
            " се появят две различни анимации едновременно или два главни героя един върху друг. За справяне с този проблем идва още един метод, наречен removeDuplications(). Той се грижи за това да има само една булева, която да е истина и променя " +
            "останалите в неистина.<br><span class=\"tab\"></span>Координатите на Ryu са описани от общо 4 променливи. Първите, shiftX и shiftY, определят местоположението му върху прозореца на играта. Тези координати са едни и същи и не се променят" + 
            " през цялата игра. Втората двойка променливи са ryuPositionX и ryuPositionY. Те определят местоположението му върху картата на нивото. Те описват движението на картата зад Ryu. Така получаваме ефекта, че Ryu се движи, но всъщност самата" + 
            " му фигура не се премества от горният ляв ъгъл на прозореца.";

        string ryuTextBul6 = "<br><br><h1>Ryu: The Big Adventure!</h1><br><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br><br>" +
            "<h2>Реализация</h2><br><h3>Създаване на противниците</h3><br><span class=\"tab\"></span>Другата основна част от играта е създаването на противници, които да ни държат заети. Тяхната реализация е сходна с тази на главният герой – създадени" +
            " са със спрайтове, издават звуци, имат жизнени показатели и могат да удрят. Разликата тук е, че те трябва да се контролират от компютъра, чрез изкуствен интелект (A.I.), вместо от клавиатурата.<br><span class=\"tab\"></span>" +
            "Всеки един противник е създаден от 5 различни спрайта: статично положение, ходене, удряне, бивайки ударен и спрайт за умиране.<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\">" +
            "<span class=\"tab\"></span><span class=\"tab\"></span></span><img src=\"/Resources/ryu10.png\" width=\"250\"><br><span class=\"tab\"></span>Противниците се намират на точно определени координати на нивото. За разлика от Ryu, противниците нямат" +
            " специални умения следователно нямат магически точки (MP) а единствено здраве (HP), което се определя от зададеното ниво на трудност.<br><br><h3>Създаване на изкуствен интелект</h3><span class=\"tab\"></span><li><b>Общи сведения</b></li><br>" +
            "<span class=\"tab\"></span>Изкуственият интелект позволява на компютрите да правят неща, които за хората изглеждат разумни. Той има способност да анализира окръжаващата го среда и да предприема действия, които увеличават възможността за постигане " +
            "на определени цели.<br><span class=\"tab\"></span>Създаването на изкуственият интелект е един от най-сложните етапи, при проектирането на компютърна игра. За него има обособен отделен дял в информатиката и се изучава като академична дисциплина." +
            "<br><span class=\"tab\"></span>Пример за много добър A.I. е този в играта F.E.A.R.: First Encounter Assault Recon. Това е FPS шуутър, в който противниците имат широк набор от действия. Те могат да клякат и да минават под препядствия, да скачат" + 
            " през прозорци, да се подават през парапети, да изкачват стълби и да бутат обекти за да създадат прикритие от насрешната стрелба. Различни врагове могат да работят в екип, използвайки обиколни пътеки, за да изненадат играча в гръб, да използват" + 
            " потискаща стрелба и да скачат зад стени, когато биват обстрелвани. Често изкуственият интелект на F.E.A.R. е посочван като високо развит и неговата ефективност помага на играта да спечели наградите „2005 Best AI Award“ на GameSpot и „Most" +
            " Infuental AI Games“ на AIGameDev's.<br><span class=\"tab\"></span>За целта на проекта е създаден по-просто устроен изкуствен интелект. Той е един и същ за всеки противник. Това което той прави е да следи за местоположението на главният герой," +
            " да се придвижва по посока към него и да изпълнява удари върху играча.<br><span class=\"tab\"></span>При започването на играта, всеки един противник е предварително създаден на нивото, но е в пасивно положение и ние не го виждаме. Те имат " +
            "определен обхват на действие, в което Ryu трябва да влезне, за да могат да се активират. За да не се получи претрупване на врагове, на едно и също място, те се създадени със собствени уникални координати и обхвати на действие.<br><span " +
            "class=\"tab\"></span>Обхватът е такъв, че когато противника се появи на екрана, той вече е в активно положение и вече се движи към нас. Веднъж задействан, противника ще е активен до края на жизненият си цикъл, който е до смъртта му, смъртта" +
            " на Ryu или изтичане на времето.<br><img src=\"/Resources/ryu11.jpg\" width=\"592\">";

        string ryuTextBul7 = "<br><br><h1>Ryu: The Big Adventure!</h1><br><em>2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.</em><br><br>" +
            "<h2>Реализация</h2><br><h3>Създаване на противниците</h3><span class=\"tab\"></span><span class=\"tab\"></span><li><b>Придвижване към Ryu</b></li><br><span class=\"tab\"></span>Противника се движи когато Ryu навлезе в обхватът му, докато" + 
            " самият противник е жив и докато той не се намира до Ryu. Когато тези две условия са изпълнени, противникът започва да се придвижва към shiftX и shiftY координатите със скорост delta * .1f. По време на придвижването аналогично се променя" +
            " и анимацията на противника, към анимация на придвижване.<table><tr><th>if (ryuPositionX < -170 && thugHP > 0)<br><span class=\"tab\"> " +
            "</span>{<br><span class=\"tab\"></span><span class=\"tab\"></span>if (thugPosY < 117)<br><span class=\"tab\">" +
            "</span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>moveY += delta * .1f;<br><span class=\"tab\"></span><span " + 
            "class=\"tab\"></span><span class=\"tab\"></span>thugSprite = thugWalkAnimation;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br> " +
            "<span class=\"tab\"></span><span class=\"tab\"></span>if (thugPosY > 120)<br><span class=\"tab\"></span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\">" + 
            "</span>moveY -= delta * .1f;<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span><span" + 
            "thugSprite = thugWalkAnimation;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br><span class=\"tab\"></span> " +
            "<span class=\"tab\"></span>if (thugPosX > 170)<br><span class=\"tab\"></span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span>" +
            "<span class=\"tab\"></span>moveX -= delta * .1f;<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>thugSprite = thugWalkAnimation;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br><span " +
            "class=\"tab\"></span>}</th></tr></table><br><span class=\"tab\"></span>Когато стигне до играча той спира, защото тогава едно от условията за движение не е изпълнено – това да не се намира до него.<br><br><li><b>Удряне</b></li><br><span class=\"tab\"></span>" +
            "За да можем да ударим главният герой, първо трябва да сме изпълнили серия от условия. Противника трябва да се намира в непосредствена близост до Ryu, Ryu трябва да не изпълнява удари или умения и самият противник трябва да е жив.<br><span class=\"tab\"></span>" +
            "Първо булевият метод thugAtRyu()следи дали противника се намира на точното място, за да изпълни удар и връща true.<br><table><tr><th>public boolean thugAtRyu(float thugPosX, float thugPosY)<br><span class=\"tab\"> " +
            "</span>{<br><span class=\"tab\"></span><span class=\"tab\"></span>if (thugPosX < 190 && thugPosX > 115 && thugPosY < 130 &&<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>thugPosY > 70)<br><span class=\"tab\">" +
            "</span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br> " +
            "<span class=\"tab\"></span><span class=\"tab\"></span>else<br><span class=\"tab\"></span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br><span class=\"tab\"></span>}</th></tr></table><br><span class=\"tab\"></span>Със следващият булев метод, наречен ryuAttack(), ние следим дали героят" +
            " не извършва някакъв удар или специално умение.<br><table><tr><th>public boolean ryuAttack()<br><span class=\"tab\"> " +
            "</span>{<br><span class=\"tab\"></span><span class=\"tab\"></span>if (ryuHadouken || ryuLowKick || ryuPunch || ryuShoryuken ||<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>ryuShoryuken || ryuTatsaku)<br><span class=\"tab\">" +
            "</span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br> " +
            "<span class=\"tab\"></span><span class=\"tab\"></span>else<br><span class=\"tab\"></span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br><span class=\"tab\"></span>}</th></tr></table><br><span class=\"tab\"></span>Както споменахме, за всяко едно действие на Ryu има съответна булева стойност. В този случай, чрез" +
            " тях можем да следим действията на главният герой и да ги използваме в нашия метод.<br><span class=\"tab\"></span>Противникът трябва да удря през определено време, когато вече се намира срещу Ryu, за да се придобие реалност към действията му. За целта се " +
            "използва метода enemyAttackChance().<br><span class=\"tab\"></span>enemyAttackChance()е шансът врагът да удари, когато се намира в непосредствена близост до Ryu.<br><table><tr><th>public boolean enemyAttackChance()<br><span class=\"tab\"> " +
            "</span>{<br><span class=\"tab\"></span><span class=\"tab\"></span>Random rand = new Random();<br><br><span class=\"tab\"></span><span class=\"tab\"></span>if (rand.nextInt(1000) > 900)<br><span class=\"tab\">" +
            "</span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\"></span>return true;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br> " +
            "<span class=\"tab\"></span><span class=\"tab\"></span>else<br><span class=\"tab\"></span><span class=\"tab\"></span>{<br><span class=\"tab\"></span><span class=\"tab\"></span><span class=\"tab\">" +
            "</span>return false;<br><span class=\"tab\"></span><span class=\"tab\"></span>}<br><span class=\"tab\"></span>}</th></tr></table><br><span class=\"tab\"></span>Метода създава случайно число в интервала от 1 до 1000, с всеки един цикъл на играта. " +
            "Когато числото е по-голямо от 900, метода изпраща сигнал за изпълняване на удар.<br><span class=\"tab\"></span>Когато всички тези условия са изпълнени преминаваме към изпълнението на удара.";

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
        }

        protected void ryuPages(int page)
        {            
            if (page == 1)
            {
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

                ryuPage1.Enabled = false;
                ryuPage2.Enabled = true;
                ryuPage3.Enabled = true;
                ryuPage4.Enabled = true;
                ryuPage5.Enabled = true;
                ryuPage6.Enabled = true;
                ryuPage7.Enabled = true;
                pageLbl.Visible = false;
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
                visiblePages();
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
        }

        protected void ryuPage3_Click(object sender, EventArgs e)
        {
            projectsContent.Text = ryuTextBul3;
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
    }
}
﻿public class Stopwatch
{
    public static string stopwBul1 = "Написана е на C# и представлява програма за обратно броене и секундомер. При изтичане на времето се чува бийпване. Прогресът може да се види и на таскбара, дори и програмата да е минимализирана. Перфектна програма, ако често варите яйца или готвите. ;) <br/><span class=\"tab\"></span>Секундомера измерва с точност от милисекунда. Има възможност за отчитане на обиколка, пауза и записване на времената на обиколките като текстов файл.<br/><span class=\"tab\"></span>Обратното броене и секундомера са напълно независими един от друг и могат да работят едновременно.<br/><br/><img src=/Resources/CT1.jpg><br/><br/><img src=/Resources/CT2.jpg>";
    public static string stopwBul2 = "<h2>Реализация</h2><br/><span class=\"tab\"></span>Времето е изразено чрез масива timeArr, който е с размер от 3 реда и 2 колони. Колоните олицетворяват двете цифри от числата за време, а трите реда са за секунди, минути и часове.<br/><span class=\"tab\"></span>При натискане на цифра, тя се въвежда на мястото на единиците на секундите. С всяко следващо въвеждане въведените стойности се изместват една позиция наляво. Числото намиращо се на мястото на единиците на секундите, се измества към десетиците, а нововъведеното число застава на мястото на единиците. По същия начин, с въвеждане на следващо число, се запълват минутите и часовете.<br/><span class=\"tab\"></span>При натискане на Start, първото нещо което се случва е преобразуването на числата във време. За пример, ако е въведено числото 89 като секунди, то се преобразува на 29 секунди и се добавя една единица към минутите. Също така се декларира променливата time, която представлява цялото време в секунди. За пример, ако програмата показва 30 минути и 25 секунди, time ще бъде равно на 1825. Time се използва за прогрес-бара, намиращ се в долната част от прозореца на програмата и също така за прогрес-бара в таскбара. Тяхната минимална стойност е 0, максималната е time, а стъпката е 1.<br/><br/><img src=\"/Resources/CT3.jpg\"><br/><br/><span class=\"tab\"></span>Накрая се стартира и метода startCountdown(), който е основният метод на програмата и в него се извършва цялата дейност на обратното броене. <br/><br/><img src=\"/Resources/CT4.jpg\"><br/><br/><span class=\"tab\"></span>Методът е асинхронен и се изпълнява веднъж на всяка секунда. Първото нещо което прави е да премахне една секунда. След това извършва една стъпка на прогрес-бара. updateTime() служи за изобразяване на новото време в програмата, като конвертира числата на секундите, минутите и часовете в стрингове и ги поставя в съответните лейбъли. addZero() метода добавя “0” към стринговете за изписване на времето, когато числото е съставено от една цифра. За пример, когато секундите са 5 на екрана се изобразява “05”. timeToSeconds() метода следи времето и връща true, когато има още оставащо време. Когато секундите станат 0 метода променя стойността им на 60 и в същото време премахва една единица от минутите. Когато секундите са 0 и минутите са 0, секундите се променят на 60, минутите на 59, а от часовете се взима една единица. Когато часовете са 0 и не може да се вземе единица от тях,  програмата изсвирва аларма за приключване и връща стойност false, която приключва и асинхронния метод startCountdown() и обратното време спира. taskbar.SetProgressValue(progressBar1.Value, time); използва стойностите на прогрес-бара вътре в програмата, за да обнови прогрес-бара в таскбара. checkMinutes() метода се използва заедно с бутоните за добавяне и отнемане на време, като ги отключва за използване и съответно ги заключва. Когато времето е 15:25 можем да използваме бутоните “-1”, ”-5” и ”-10” за да отнемем време, но не можем да използваме “-30”, защото нямаме достатъчно налично време.";
    public static string stopwBul3 = "<h2>Други функции на обратното броене</h2><br/><h3>Добавяне и отнемане на време</h3><br/><span class=\"tab\"></span>Това са бутони които се използват за добавяне на допълнително време или за отнемане на време, докато таймера работи. Когато таймера работи и се натисне бутона “+5”, се добавят още 5 минути към времето. Бутоните за добавяне на време могат да се използват и преди стартирането на обратното броене, като въведат първоначално време. За отнемане на време се използва Plus-minus бутона. Той превключва функционалността на бутоните с минутите, като ги променя в добавяне или отнемане. При всяко променяне на времето се променят и стойностите на двата прогрес-бара.<br/><br/><img src=/Resources/CT5.gif><br/><br/><h3>Beep</h3><br/><span class=\"tab\"></span> Когато времето изтече се чува силно бийпване. Бийпването може да се изключва чрез радио-бутона Beep, намиращ се в долната част на прозореца на програмата.";
    public static string stopwBul4 = "<h2>Секундомер</h2><br/><span class=\"tab\"></span>Секундомера се намира в таба Stopwatch. Той е напълно независим от обратното броене и двете могат да работят успоредно едновременно. Секундомера разполага с опциите да засичаме време с точност до милисекунда, да засичаме отделни обиколки, да спрем отчитането за момент чрез пауза и да запишем времената на обиколките в текстов файл. <br/><br/><h3>Реализация</h3><br/><span class=\"tab\"></span>Основният метод тук се нарича startMS() който е асинхронен. <br/><br/><img src=/Resources/CT6.png><br/><br/>Той се задейства след натискането на Start бутона и се изпълнява веднъж на всеки 33 милисекунди, което означава и че опресняването на времето на екрана ще се осъществява за същия интервал.";
    public static string stopwBul5 = "<h2>Секундомер</h2><br/><h3>Реализация</h3><br/><span class=\"tab\"></span>За реализирането на програмата е нужно да се използва системното време. То се използва на мястото на високо-прецизен таймер, който би изисквал доста хардуерни ресурси. Първо, секундите от системното време се взимат и се записват в променливата tempSeconds1. tempSeconds1 и tempSeconds2 се използват за да отчитат интервала от една секунда. tempSeconds2 се декларира като tempSeconds1 + 1 секунда. Когато измине 1 секунда tempSeconds1 се изравнява с tempSeconds2 и това индикира преминаването на една секнуда. Когато това се случи tempSeconds2 се увеличава с 1 и процеса започва отначало. За да се избегне положението когато tempSeconds1 е 59 tempSeconds2 да стане 60, се използва булевата “sixty”. По тови начин когато tempSeconds2 е 60, променливата веднага се променя на 0 и минутите се увеличават с 1. <br/><span class=\"tab\"></span>Секундите, минутите и часовете се променят по сходен начин както при обратното броене. Милисекундите обаче не са свързани с този процес. Те се взимат от системното време, като така се спестява нуждата от прецизен таймер. Следи се и за правилното изписване на числата. Когато милисекундите са съставени от една цифра, се добавят “00” пред нея за да се изобрази трицифрено число. Когато милисекундите са двуцифрено число, тогава се добавя само “0”. По същият начин се проверяват секундите, минутите и часовете. Целият метод се изпълнява когато stopwatchRunning булевата е true. <br/><span class=\"tab\"></span>За засичането на обиколки се използва бутона “Lap”. Той използва listBox контейнер, за изобразяването на обиколките. Данните които се съхраняват са: номер на обиколката, общото време от започването на секундомера, с точност до милисекунди и времето на самата обиколка, с точност до секунда. <br/><span class=\"tab\"></span>За пауза се използва бутона Pause. Неговата функция е да променя булевата stopwatchRunning към false, за да спре времето или към true, за да възобнови спряното време.<br/><span class=\"tab\"></span>Save се използва за записването на времето в текстов файл. Запазването е възможно само когато секундомера е приключил и има поне една отчетена обиколка. <br/><br/><b>Source: </b><a href=" + "https://github.com/ivanpop/Stopwatch" + " target=\"_blank\"><b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/countdown timer.exe\">Countdown Timer</a></td><td class=\"size\">963.0 KB</td></tr></tbody></table>";
    public static string stopwEng1 = "Written in C#, this is a countdown timer and a stopwatch. When the timer reaches 0, there is a beep. The progress can be seen in the taskbar, even if the program is minimized. Perfect if you often boil eggs or cook. ;) <br/><span class=\"tab\"></span>The stopwatch has a precision of a millisecond. There is an option to count a lap, pause and to save the lap times in a text file.<br/><span class=\"tab\"></span>The countdown timer and the stopwatch are completly independent on from the other and can work simultaneously.<br/><br/><img src=/Resources/CT1.jpg><br/><br/><img src=/Resources/CT2.jpg>";
    public static string stopwEng2 = "<h2>Realization</h2><br/><span class=\"tab\"></span>Time is stored in the timeArr array, which has 3 lines and 2 columns. The columns represent the two digits of the number for time and the three lines are for seconds, minutes and hours.<br/><span class=\"tab\"></span>When entering a digit, it’s inserted in the place of the units of the seconds. Whit every other input, the inserted digits move one position to the left. The number which is in the units in the seconds gets moved to the tenths and the new digit goes to the place of the units. In the same way, with entering another digit, minutes and hours get populated.<br/><span class=\"tab\"></span>Pressing Start, the first thing that happens is converting the digits into time. For example, when 89 is inserted as seconds, it’s converted to 29 seconds and minutes gets increased by 1. Also a variable is declared with the name “time”, which represents the total time in seconds. For example, when the program is showing 30 minutes and 25 seconds, time will be equal to 1825. Time is used for the progress bar, positioned at the bottom of the program’s window and also for the progress bar in the taskbar. They’re minimum value is 0, maximum is time and the step is 1.<br/><br/><img src=\"/Resources/CT3.jpg\"><br/><br/><span class=\"tab\"></span>Last the method startCountdown() is started, which is the main method of the program and inside him is the whole job of the countdown. <br/><br/><img src=\"/Resources/CT4.jpg\"><br/><br/><span class=\"tab\"></span>This method is asynchronous and is executed once in every second. The first thing it does is to remove a second. After that it does one step of the progress bar. <br/><span class=\"tab\"></span>updateTime() is used for showing the updated time on the window by converting the numbers of the seconds, minutes and hours into strings and puts them in the correct labels. <br/><span class=\"tab\"></span>The addZero() method adds “0” to the strings for time, when the number is made only from one digit. For example, when the seconds are 5 we see “05” on the screen. <br/><span class=\"tab\"></span>timeToSeconds() checks the time and returns true when there is remaining time. When the seconds are 0 the method changes they’re value to 60 and in the same time it removes 1 minute from the minutes. When the seconds are 0 and the minutes are also 0, seconds gets changed to 60, minutes to 59 and 1 hour is removed. When the hours are also 0 and we can’t get an hour from them, the method plays a beeping sound and returns false, which stops the asynchronous method startCountdown() and the countdown ends. <br/><span class=\"tab\"></span>taskbar.SetProgressValue(progressBar1.Value, time); uses the properties of the progress bar inside the program window to update the progress bar in the taskbar. <br/><span class=\"tab\"></span>The checkMinutes() method is used along with the buttons for adding and taking time to enable and disable them for usage. When the time is 15:25 we can use the buttons “-1”, ”-5” и ”-10” to take time, but we can’t use “-30” because we don’t have enough time left.";
    public static string stopwEng3 = "<h2>Other functions of the countdown timer</h2><br/><h3>Adding and removing time</h3><br/><span class=\"tab\"></span>There are buttons which are used to add additional or remove time while the timer is working. When the timer is working and the button “+5” is pressed, an additional 5 minutes are added to the time. The buttons for adding time can be used before the countdown has begun, to input a starting time. The Plus-minus button is used for removing time. It changes the functionality of the buttons, changing them from adding time to removing time. With every changing of time the status of the two progress-bars is also updated.<br/><br/><img src=/Resources/CT5.gif><br/><br/><h3>Beep</h3><br/><span class=\"tab\"></span> When the countdown ends a beeping sound is played. This beep can be turned on or off using the “Beep” radio button, which is located at the bottom of the program window.";
    public static string stopwEng4 = "<h2>Stopwatch</h2><br/><span class=\"tab\"></span>The stopwatch is in its own tab called Stopwatch. It’s completely independent from the countdown timer and the two can work together independently. The stopwatch has the options to count time with a millisecond of precision, to count laps, to pause and to save the lap times in a text file. <br/><br/><h3>Realization</h3><br/><span class=\"tab\"></span>The main method in here is called startMS() which is asynchronous. <br/><br/><img src=/Resources/CT6.png><br/><br/>It starts after the Start button has been pressed and it’s executed once in every 33 milliseconds, which means that the refresh interval of the time is also 33ms.";
    public static string stopwEng5 = "<h2>Stopwatch</h2><br/><h3>Realization</h3><br/><span class=\"tab\"></span>For the stopwatch I’ve used the system time. It’s used to replace a high-precision timer, which would take lots of system resources. First, seconds from the system time are  saved into the variable tempSeconds1. tempSeconds1 and tempSeconds2 are used to indicate the interval of a second. tempSeconds2 is declared as tempSeconds1 + 1 second. When 1 passes tempSeconds1 becomes equal to tempSeconds2 and this indicates the passing of a second. When this happens tempSeconds2 gets increased by 1 and the process begins again. To avoid the situation when tempSeconds1 is 59 and tempSeconds2 to become 60, I’ve used a boolean called “sixty”. In this way when tempSeconds2 becomes 60, it immediately changes to 0 and the minutes get increased by 1. <br/><span class=\"tab\"></span>Seconds, minutes and hours are changed in a similar way as the countdown timer. Milliseconds however are not connected with this process. They are taken from the system time to avoid using a high-precision timer. Values are also checked for their correct representation. When the milliseconds are composed of one digit “00” is added in front of it so that a three-digit number is shown on the screen. When the milliseconds are composed of a two-digit number only “0” is added. In the same way seconds, minutes and hours are also checked. This method is executed when the boolean stopwatchRunning is true. <br/><span class=\"tab\"></span>The “Lap” button is used for counting laps. It uses a listBox container to show the laps. Data that is saved is composed of: lap number, total time from the beginning, with precision of milliseconds and the time of the lap itself. <br/><span class=\"tab\"></span>The “Pause” button is used for pausing. It’s function is to change the boolean stopwatchRunning to false in order to stop the time or to true to resume paused time.<br/><span class=\"tab\"></span>”Save” is used for saving time results in a text file. Saving is possible only when the stopwatch has stopped and there is at least one lap in the list box. <br/><br/><b>Source: </b><a href=" + "https://github.com/ivanpop/Stopwatch" + " target=\"_blank\"><b><u>Github</u></b></a><table class=\"itu-attachment-list withoutstats sticky-enabled sticky-table\" id=\"attachments\"><tbody><tr class =\"odd\"><td class=\"mime mime-zip\"></td><td class=\"file\"><a href=\"../Resources/countdown timer.exe\">Countdown Timer</a></td><td class=\"size\">963.0 KB</td></tr></tbody></table>";
}
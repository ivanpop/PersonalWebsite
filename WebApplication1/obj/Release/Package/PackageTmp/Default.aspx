<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html;charset=utf-8" />
	<title>Иван Попов</title>
	<link rel="shortcut icon" href="Resources\favicon.ico" type="image/x-icon" />
	<link rel="schema.dc" href="http://purl.org/dc/elements/1.1/" />	
	<meta name="description" content="Това е моята лична Интернет страница. Тук ще намерите информация за мен и актуалните проекти, по които работя." />
	<meta name="dcterms.description" content="Това е моята лична Интернет страница. Тук ще намерите информация за мен и актуалните проекти, по които работя." />
	<meta name="keywords" content="Ivan Popov ,Иван Попов" />
	<meta name="geo.region" content="BG-16" />
	<meta name="geo.placename" content="Plovdiv" />
	<meta name="geo.position" content="42.135408;24.74529" />
	<meta name="ICBM" content="42.135408, 24.74529" />
	<link rel="canonical" href="http://ivanpop.azurewebsites.net//" />
	<meta name="revisit-after" content="1 day" />
	<meta name="dcterms.publisher" content="Ivan Popov" />
	<link type="text/css" rel="stylesheet" media="all" href="Resources/css_styles.css" />
	<script type="text/javascript" src="resources/jquery-2.1.1.js"></script>
</head>

<body><form runat="server">	
	<div id="wrap">
		<div id="container">
			<div id="header">
				<div id="headertext">
					<div id="title">
						<h1><a href="/" title="Начало"><asp:Label ID="header1" runat="server" Text="Иван Попов"></asp:Label></a></h1>
					</div>
					<div id="tagline">
                        <asp:Label ID="header2" runat="server" Text="Лична Интернет Страница"></asp:Label>
                    </div>
				</div>									
			</div>						
			<div id="content">
                <div id="topbar">
					<div id="navbar" class="block navbar">					
						<h2><asp:Label ID="navigation" runat="server" Text="Навигация"></asp:Label></h2>
						<div class="menu">
							<asp:Button ID="aboutMe" runat="server" Text="За мен" OnClick="aboutMe_Click" Width="116px"/>
							<asp:Button ID="biography" runat="server" Text="Автобиография" OnClick="biography_Click" Width="116px"/>
                            <asp:Button ID="projects" runat="server" Text="Проекти" OnClick="projects_Click" Width="116px"/>
                            <asp:Button ID="contacts" runat="server" Text="Контакти" OnClick="contacts_Click" Width="116px"/>
						</div>
					</div>
					<div id="langbar" class="block langbar">
						<h2><asp:Label ID="lang" runat="server" Text="Езици"></asp:Label></h2>
						<div class="menu">
							<asp:Button ID="switchBulBtn" runat="server" Text="Български" OnClick="switchBulBtn_Click" Width="100px" Enabled="False" />
							<asp:Button ID="switchEngBtn" runat="server" Text="English" OnClick="switchEngBtn_Click" Width="100px"/>
						</div>
					</div>                                        
				</div>
				<div id="main">
					<h1><asp:Label ID="artTitle" runat="server" Text="За мен"></asp:Label><br/><br/></h1>
					<div class="node">
						<div class="post">
							<div class="content">                                							
							    <asp:Image ID="ivanpopov" runat="server" ImageUrl="~/Resources/ivanpopov.jpg" Visible="False" BorderStyle="Ridge" BorderWidth="1px" ImageAlign="Left"  />                                							
							    <asp:Label ID="mainContent" runat="server" CssClass="StatusLabel" Text="Label"></asp:Label>
							    <asp:Panel ID="contactsPanel" runat="server" Visible="False" BorderStyle="Solid" BorderWidth="2px">
                                    &nbsp;<br/>
                                    <asp:Label ID="emailLabel" runat="server" Text="*Вашият E-Mail:"></asp:Label>
                                    <br/>
                                    &nbsp;<asp:TextBox ID="emailTextBox" runat="server" Width="248px"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ControlToValidate="emailTextBox" ErrorMessage="E-mail адресът е неправилен!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="required"></asp:RegularExpressionValidator>
                                    <br />
                                    &nbsp;<asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Моля въведете вашият E-mail адрес!" ForeColor="Red" ValidationGroup="required"></asp:RequiredFieldValidator>
                                    <br />
                                    &nbsp;<asp:Label ID="subjectLabel" runat="server" Text="Тема:"></asp:Label>
                                    <br />
                                    &nbsp;<asp:TextBox ID="subjectBox" runat="server" Width="248px"></asp:TextBox>
                                    <br />
                                    <br />
                                    &nbsp;<asp:Label ID="messageLabel" runat="server" Text="*Съобщение:"></asp:Label>
                                    <br />
                                    &nbsp;<asp:TextBox ID="messageBox" runat="server" Height="99px" TextMode="MultiLine" Width="403px"></asp:TextBox>
                                    <br />
                                    &nbsp;<asp:RequiredFieldValidator ID="messageRequiredFieldValidator" runat="server" ControlToValidate="messageBox" ErrorMessage="Моля въведете съобщение!" ForeColor="Red" ValidationGroup="required"></asp:RequiredFieldValidator>
                                    <br />
                                    &nbsp;<asp:Label ID="codeLabel" runat="server" Text="*Защитен код:"></asp:Label>
                                    <br />
                                    &nbsp;<asp:Label ID="codeImg" runat="server" Text="Label"></asp:Label>
                                    <br />
                                    &nbsp;<asp:TextBox ID="codeBox" runat="server" Width="113px"></asp:TextBox>
                                    <asp:CompareValidator ID="codeCompareValidator" runat="server" ControlToValidate="codeBox" ErrorMessage="Кодът е грешен!" ForeColor="Red" ValidationGroup="required"></asp:CompareValidator>
                                    <br />
                                    &nbsp;<asp:RequiredFieldValidator ID="codeRequiredFieldValidator" runat="server" ControlToValidate="codeBox" ErrorMessage="Моля въведете защитният код!" ForeColor="Red" ValidationGroup="required"></asp:RequiredFieldValidator>
                                    <br />
                                    <br />
                                    &nbsp;*
                                    <asp:Label ID="requiredFieldLabel" runat="server" Text="Обозначава задължителните полета"></asp:Label>
                                    <br />
                                    &nbsp;<asp:Button ID="submitEmailBtn" runat="server" Text="Изпрати" Width="75px" OnClick="submitEmailBtn_Click" ValidationGroup="required" />
                                    &nbsp;<br />
                                    <br />
                                </asp:Panel>
							    <asp:Panel ID="projectsPanel" runat="server" Visible="False">
                                    <ul>
                                        <li><asp:Button ID="converter" runat="server" Height="25px" Text="Converter" Width="190px" OnClick="converter_Click" /></li>
                                        <span class="tab"></span><span class="tab"></span><asp:Label ID="ConverterDescr" runat="server" Text="&lt;em&gt;Програма за преобразуване на мерни единици.&lt;/em&gt;"></asp:Label>
                                    </ul>
                                    <ul>
                                        <li><asp:Button ID="countdown" runat="server" Height="25px" OnClick="countdown_Click1" Text="Countdown timer &amp; Stopwatch" Width="190px" /></li>
                                        <span class="tab"></span><span class="tab"></span><asp:Label ID="StopwDescr" runat="server" Text="&lt;em&gt;Обратно броене и секундомер.&lt;/em&gt;"></asp:Label>
                                    </ul>
                                    <ul>
                                        <li><asp:Button ID="ryu" runat="server" Height="25px" OnClick="ryu_Click" Text="Ryu: The Big Adventure!" Width="190px" /></li>
                                        <span class="tab"></span><span class="tab"></span><asp:Label ID="RyuDescr" runat="server" Text="&lt;em&gt;2D Екшън игра. Написана е на Java и представлява 2D Beat 'em up симулатор.&lt;/em&gt;"></asp:Label>
                                    </ul>
                                    <ul>
                                        <li><asp:Button ID="csDummies" runat="server" Height="25px" OnClick="csDummies_Click" Text="C# for Dummies" Width="190px" /></li>                                        
                                        <span class="tab"></span><span class="tab"></span><asp:Label ID="CSDescr" runat="server" Text="Задачи от книгата за C# на Телерик"></asp:Label>
                                    </ul>
                                </asp:Panel>
							    <asp:Panel ID="chaptersPanel" runat="server" Visible="False">
                                    <ul><li><asp:Button ID="chapter1Btn" runat="server" Height="25px" Text="Глава 1. Въведение в програмирането" Width="380px" OnClick="CSBul1_Click" /></li></ul>
                                    <ul><li><asp:Button ID="chapter2Btn" runat="server" Height="25px" OnClick="CSBul2_Click" Text="Глава 2. Примитивни типове и променливи" Width="380px" /></li></ul>
                                    <ul><li><asp:Button ID="chapter3Btn" runat="server" Height="25px" OnClick="CSBul3_Click" Text="Глава 3. Оператори и изрази" Width="380px" /></li></ul>
                                    <ul><li><asp:Button ID="chapter4Btn" runat="server" Height="25px" OnClick="CSBul4_Click" Text="Глава 4. Вход и изход от конзолата" Width="380px" /></li></ul>
                                    <ul><li><asp:Button ID="chapter5Btn" runat="server" Height="25px" Text="Глава 5. Условни конструкции" Width="380px" OnClick="CSBul5_Click" /></li></ul>
                                    <ul><li><asp:Button ID="chapter6Btn" runat="server" Height="25px" OnClick="CSBul6_Click" Text="Глава 6. Цикли" Width="380px" /></li></ul>
                                    <ul><li><asp:Button ID="chapter7Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 7. Масиви" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter8Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 8. Бройни системи" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter9Btn" runat="server" Height="25px" Text="Глава 9. Методи" Width="380px" OnClick="csDummies_Click" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter10Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 10. Рекурсия" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter11Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 11. Създаване и използване на обекти" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter12Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 12. Обработка на изключения" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter13Btn" runat="server" Height="25px" Text="Глава 13. Символни низове" Width="380px" OnClick="csDummies_Click" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter14Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 14. Дефиниране на класове" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter15Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 15. Текстови файлове" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter16Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 16. Линейни структури от данни" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter17Btn" runat="server" Height="25px" Text="Глава 17. Дървета и графи" Width="380px" OnClick="csDummies_Click" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter18Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 18. Речници, хеш-таблици и множества" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter19Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 19. Структури от данни - съпоставка и препоръки" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter20Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 20. Принципи на ООП" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter21Btn" runat="server" Height="25px" Text="Глава 21. Качествен програмен код" Width="380px" OnClick="csDummies_Click" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter22Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 22. Ламбда изрази и LINQ заявки" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter23Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 23. Как да решаваме задачи по програмиране?" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter24Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 24. Практически задачи за изпит - тема 1" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter25Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 25. Практически задачи за изпит - тема 1" Width="380px" Enabled="False" /></li></ul>
                                    <ul><li><asp:Button ID="chapter26Btn" runat="server" Height="25px" OnClick="csDummies_Click" Text="Глава 26. Практически задачи за изпит - тема 1" Width="380px" Enabled="False" /></li></ul>
                                </asp:Panel>
                                &nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;
                                <asp:Label ID="projectsContent" runat="server"></asp:Label>
							    <br />
                                <asp:Button ID="backBtn" runat="server" OnClick="backBtn_Click" Text="Обратно" Visible="False" Width="80px" />
							    <asp:Panel ID="pagePanel" runat="server" Visible="False" Width="412px">
                                    <asp:Label ID="pageLbl" runat="server" Text="&lt;br/&gt;&lt;br/&gt;Страница: "></asp:Label>
                                    <asp:Button ID="pageBtn1" runat="server" OnClick="ryuPage1_Click" Text="1" Width="20px" />
                                    <asp:Button ID="pageBtn2" runat="server" OnClick="ryuPage2_Click" Text="2" Width="20px" />
                                    <asp:Button ID="pageBtn3" runat="server" OnClick="ryuPage3_Click" Text="3" Width="20px" />
                                    <asp:Button ID="pageBtn4" runat="server" OnClick="ryuPage4_Click" Text="4" Width="20px" />
                                    <asp:Button ID="pageBtn5" runat="server" OnClick="ryuPage5_Click" Text="5" Width="20px" />
                                    <asp:Button ID="pageBtn6" runat="server" OnClick="ryuPage6_Click" Text="6" Width="20px" />
                                    <asp:Button ID="pageBtn7" runat="server" OnClick="ryuPage7_Click" Text="7" Width="20px" />
                                    <asp:Button ID="pageBtn8" runat="server" OnClick="ryuPage8_Click" Text="8" Width="20px" />
                                    <asp:Button ID="pageBtn9" runat="server" OnClick="ryuPage9_Click" Text="9" Width="20px" />
                                </asp:Panel>
							</div>
						</div>                        
					</div>
				</div>				
				<div id="footer">
					<a id="gotop" href="#"><asp:Label ID="goTop" runat="server" Text="Горе"></asp:Label></a>
					<p>© 2014 Иван Попов	</p></div>	
                </div>
            </div>
        </div>    	
</form>
  <script type='text/javascript'>
    $(function () {
        $('#main, #topbar').hide();
        $('#main, #topbar').fadeIn(1000);
    });
  </script>
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-51152907-1', 'auto');
        ga('send', 'pageview');
</script>
</body>
</html>
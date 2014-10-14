﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html;charset=utf-8" />
	<title>Иван Попов</title>
	<link rel="shortcut icon" href="resources\favicon.ico" type="image/x-icon" />
	<link rel="schema.dc" href="http://purl.org/dc/elements/1.1/" />	
	<meta name="description" content="Това е моята лична Интернет страница. Тук ще намерите информация за мен и актуалните проекти, по които работя." />
	<meta name="dcterms.description" content="Това е моята лична Интернет страница. Тук ще намерите информация за мен и актуалните проекти, по които работя." />
	<meta name="keywords" content="Ivan Popov ,Иван Попов" />
	<meta name="geo.region" content="BG-16" />
	<meta name="geo.placename" content="Plovdiv" />
	<meta name="geo.position" content="42.135408;24.74529" />
	<meta name="ICBM" content="42.135408, 24.74529" />
	<link rel="canonical" href="http://ivanpop.altervista.org/bg" />
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
						<h1>
							<a href="/" title="Начало">Иван Попов</a>
						</h1>
					</div>
					<div id="tagline">Лична Интернет Страница</div>
					</div>									
			</div>						
			<div id="content">
				<div id="main">
					<h1 class="title">
                        <asp:Label ID="artTitle" runat="server" Text="За мен"></asp:Label><br><br>
					</h1>
					<div class="node">
						<div class="post">
							<div class="content">                                							
							    <asp:Image ID="ivanpopov" runat="server" ImageUrl="~/Resources/ivanpopov.jpg" Visible="False" BorderStyle="Ridge" BorderWidth="7px" ImageAlign="Left"  />                                							
							    <asp:Label ID="mainContent" runat="server" Text="Label"></asp:Label>
							    <asp:Button ID="converter" runat="server" Height="41px" Text="Converter" Width="150px" OnClick="converter_Click" />&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="countdown" runat="server" Height="41px" Text="Countdown timer &amp; Stopwatch" Width="190px" />&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="ryu" runat="server" Height="41px" Text="Ryu: The Big Adventure!" Width="170px" />
							    <asp:Label ID="projectsContent" runat="server" Text="Label"></asp:Label>
							</div>
						</div>
					</div>
				</div>
				<div id="sidebar">
					<div id="block-user-1" class="block block-user">					
						<h2><asp:Label ID="navigation" runat="server" Text="Навигация"></asp:Label></h2>
						<div class="menu">
							<ul>
								<li><asp:Button ID="aboutMe" runat="server" Text="За мен" OnClick="aboutMe_Click" Width="102px"/></li>
								<li><asp:Button ID="biography" runat="server" Text="Автобиография" OnClick="biography_Click" Width="102px"/></li>
                                <li><asp:Button ID="projects" runat="server" Text="Проекти" OnClick="projects_Click" Width="102px"/></li>
                                <li><asp:Button ID="contacts" runat="server" Text="Контакти" OnClick="contacts_Click" Width="102px"/></li>
							</ul>
						</div>
					</div>
					<div id="block-locale-0" class="block block-locale">
						<h2>
                            <asp:Label ID="lang" runat="server" Text="Езици"></asp:Label>
                        </h2>
						<div class="content">
							<ul>
								<li><asp:Button ID="switchBulBtn" runat="server" Text="Български" OnClick="switchBulBtn_Click" Width="85px" /></li>
								<li><asp:Button ID="switchEngBtn" runat="server" Text="English" OnClick="switchEngBtn_Click" Width="85px"/></li>
							</ul>
						</div>
					</div>
				</div>
				<div class="clear">
				</div>
				<div id="footer">
					<a id="gotop" href="#">Горе</a>
					<p>"© 2014" <a href="bg/contact.html">Иван Попов</a>". Всички права са запазени."</p>
					<br>
				</div>
			</div>
		</div>
	</div>	
	<script type="text/javascript">
		<!--//--><![CDATA[//><!--
		window.___gcfg = {lang:"bg"};(function() {var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;po.src = 'https://apis.google.com/js/plusone.js';var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);})();
		//--><!]]>
	</script>
	<script type="text/javascript">	
		<!--//--><![CDATA[//><!--
		var _gaq = _gaq || [];_gaq.push(["_setAccount", "UA-7841815-2"]);_gaq.push(["_trackPageview"]);(function() {var ga = document.createElement("script");ga.type = "text/javascript";ga.async = true;ga.src = ("https:" == document.location.protocol ? "https://ssl" : "http://www") + ".google-analytics.com/ga.js";var s = document.getElementsByTagName("script")[0];s.parentNode.insertBefore(ga, s);})();
		//--><!]]>
	</script>	
	<script>
		(function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
		(i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
		m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
		})(window,document,'script','http://www.google-analytics.com/analytics.js','ga');

		ga('create', 'UA-51152907-1', 'altervista.org');
		ga('send', 'pageview');
</script>		
</form></body>
</html>
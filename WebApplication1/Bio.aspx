<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bio.aspx.cs" Inherits="WebApplication1.Bio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html;charset=utf-8" />
	<title>Иван Попов - Автобиография</title>
	<link rel="shortcut icon" href="Resources\favicon.ico" type="image/x-icon" />
	<link rel="schema.dc" href="http://purl.org/dc/elements/1.1/" />	
	<meta name="description" content="Роден съм на 19.01.1990г. в гр. Пловдив, България. Завърших висшето си образование, степен бакалавър, в Пловдивски университет Паисий Хилендарски през 2013 г. със специалност Информатика." />
	<meta name="dcterms.description" content="Това е моята лична Интернет страница. Тук ще намерите информация за мен и актуалните проекти, по които работя." />
	<meta name="keywords" content="Ivan, Popov, Иван, Попов, лична, страница, personal, it, programmer, програмист" />
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
<body>
    <form id="form1" runat="server">
        <div id="wrap">
		    <div id="container">
			    <div id="header">
				    <div id="headertext">
					    <div id="title"><h1><a href="/" title="Начало">Иван Попов</a></h1></div>
					    <div id="tagline">Лична Интернет Страница</div>
				    </div>									
			    </div>
                <div id="content">
                    <div id="topbar">
					    <div id="navbar" class="block navbar">					
						    <h2>Навигация</h2>
						    <div class="menu">
                                <asp:Button ID="aboutMe" runat="server" Text="За мен" Width="116px"/>
							    <asp:Button ID="biography" runat="server" Text="Автобиография" Width="116px" Enabled="False"/>
                                <asp:Button ID="projects" runat="server" Text="Проекти" Width="116px"/>
                                <asp:Button ID="contacts" runat="server" Text="Контакти" Width="116px"/>
						    </div>
					    </div>
					    <div id="langbar" class="block langbar">
						    <h2><asp:Label ID="lang" runat="server" Text="Езици"></asp:Label></h2>
						    <div class="menu">
							    <asp:Button ID="switchBulBtn" runat="server" Text="Български" Width="100px" Enabled="False" />
							    <asp:Button ID="switchEngBtn" runat="server" Text="English" Width="100px"/>
						    </div>
					    </div>                                      
				    </div>
                    <div id="main">
					    <h1>Автобиография</h1><br/><br/>
					    <div class="node">
						    <div class="post">
							    <div class="content">                                							
                                    <asp:Image ID="ivanpopov" runat="server" ImageUrl="~/Resources/ivanpopov.jpg" BorderStyle="Ridge" BorderWidth="1px" ImageAlign="Left" CssClass="bioimg"/>
                                    <asp:Label ID="MainContent" runat="server" Text="Label"></asp:Label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                <div id="footer">
					<a id="gotop" href="#"><asp:Label ID="goTop" runat="server" Text="Горе"></asp:Label></a>
					<p>© 2015 Иван Попов</p>
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

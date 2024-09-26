<%@ Page Title="Home Page" Language="VB" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="RCBasketball.WEB._Default" %>
<!DOCTYPE html>

<html>

    <head>
    <meta charset="utf-8">
    <title>Royal City Basketball</title>
        
    <meta name="author" content="Omega Fullard">
    <meta name="description" content="Royal City Basketball League">
    <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="icon" href="Images/favicon/favicon.ico" type="image/x-icon"/>      
        <link href="Styles/Site.css" rel="stylesheet" />
        <link href="App_Themes/MasterSite/Page.css" rel="stylesheet" />
            <!-- Add icon library -->
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>


</head>
    
<body>
    <form runat="server" class="topnav menu" style="height:50px;">
            <asp:Menu ID="NavigationMenu" runat="server" CssClass="topnav" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal" EnableScreenBoundaryDetection="true">
               <Items>
              
                    <asp:MenuItem NavigateUrl="Default.aspx" Text="Home" />

                   <asp:MenuItem Text="Players">
                
               <asp:MenuItem Text="Find Player" NavigateUrl="Players_Find.aspx"></asp:MenuItem>
              <asp:MenuItem Text= "Add Player" NavigateUrl="Players_Add.aspx"></asp:MenuItem>
             <asp:MenuItem Text="Update Player" NavigateUrl="Players_Update.aspx"></asp:MenuItem>
			 
             </asp:MenuItem>
   
            </Items>
            </asp:Menu>
</form>

    <br />
    <div><img src="Images/RCLogo.png" /></div>
    <br />
    <br />
    <div style="width:1000px;margin-left: auto;margin-right: auto;">
        <aside id="leftmenu">
          <center><img src="images/RCBaller.png" alt="rcballer" style="width:250px;height:250px;" /></center>
            
            <header>
                <h4 style="text-align: left;">Browse Team Roster</h4>
            </header>
            

            <form action="search.html" enctype="application/x-www-form-urlencoded"
            method="GET">
                <input name="q">
                <input type="submit">
            </form>
        </aside>
        <main id="main">
            <article>
                <header>
                    <center><h2><b>Welcome to Royal City Basketball</b></h2></center>
                </header>
               
                <h4><b>Our History</b></h4>
                <p><b>Formation and Early Years:</b> <br />The Royal City Basketball League was established in 2023 to provide a structured environment for basketball enthusiasts of all ages and skill levels. 
				The league was founded with the vision of promoting the sport within the community and fostering a sense of camaraderie among players.
                    <br></p>
                <p>
					<b>Community Focus:<br />
                        </b>
                    From its inception, the league has emphasized inclusivity and community engagement. It offers programs for various age groups, from young children just starting to learn the game to adults looking to compete at a higher level. 
						The league’s philosophy is that basketball is more than just a sport; it’s a way to build friendships, develop leadership skills, and promote physical fitness.
                </p>
				<p>
				<b>Programs and Growth:<br>
				</b>
				The league offers a variety of programs, including skills and drills sessions, team play, and specialized training. It also hosts competitive leagues for those looking to take their game to the next level. 
				Over the years, the league has grown significantly, attracting players from all over the region and becoming a central hub for basketball in Royal City.
                </p>
				
				<p>
				<b>Community Impact:<br>
				</b>
				One of the league’s core values is creating a sense of belonging for every participant. Coaches and staff are dedicated to teaching the values of teamwork, dedication, and personal growth. 
				The league’s success is measured not just by the number of games won, but by the positive impact it has on the lives of its players and the broader community.
				The Royal City Basketball League continues to thrive, thanks to the hard work and dedication of its coaches, volunteers, and participants. 
				It remains a beacon of community spirit and a testament to the power of sports to bring people together.
				</p>
				<br/>
				<br/>
<h4 class="card-title">Join Our Basketball League</h4>
                

                <p>Download our full leagues list:  <a href="downloads/FakeFeesList.zip">Spring/Summer/Fall Leagues</a></p>
            </article>

<H4>Tournaments</H4>
                <img src="images/dunk1.png" style="width:250px;height:250px;" alt="man dunking" />
           <p>Download our full fees list:  <a href="downloads/FakeFeesList.zip">Registration Fees</a></p>
			<br />
			<p>Sign up for volunteering at local <a href="#" class="btn btn-primary">Events</a></p>
            <br />
             <center>  <p><strong>Please be sure to follow us on Social Media!</strong></p>
            <br /> 
            <div style="height: 66px">

            <!-- Add font awesome icons -->
<a href="#" class="fa fa-facebook"></a>
<a href="#" class="fa fa-twitter"></a>
<a href="#" class="fa fa-linkedin"></a>
<a href="#" class="fa fa-youtube"></a>
<a href="#" class="fa fa-instagram"></a>

        </div>
<br />
        <a href="#" class="btn btn-primary">Follow Us!</a>  

    <h4 class="card-title"><strong>Directions to Our Main Location</strong></h4>                       

            <iframe src="https://www.google.com/maps/embed?pb=!1m16!1m12!1m3!1d12234.543958929013!2d-75.16621169999999!3d39.94953124999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!2m1!1s39.57.09%2C75.10.14.8!5e0!3m2!1sen!2sus!4v1723056453703!5m2!1sen!2sus" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
     <br />
            <a href="#" class="btn btn-primary">Directions</a>
            <a href="https://google.com/maps?q=39.57.09,75.10.14.8"></a>
        </main>

        
    </div>
</body>

</html>
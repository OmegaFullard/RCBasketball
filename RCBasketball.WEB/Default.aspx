<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="RCBasketball.WEB._Default" %>


<asp:Content ID="Content0" ContentPlaceHolderID="head" Runat="Server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
  
                           
<div class="card card-transparent">
   
     <div aria-dropeffect="move" style="padding-left:10px;padding-top:10px; padding-bottom:10px; height:500px;">
                                <asp:Panel ID="Panel1" runat="server" BackColor="#000090" BorderColor="#884dff" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="485px" HorizontalAlign="Center" Width="280px">
                                    Created By: Omega Fullard<br />
                                    <br />
                                    Royal City Basketball<br />
                                    <asp:Image ID="rcbball" runat="server" ImageUrl="images/rcbasketball1.png" BorderColor="#f2c2f2" BorderStyle="Solid" BorderWidth="1px" Height="132px" style="margin-top: 50px" Width="144px" />
                
                                    <br />
                                    Version 1.0<br /> Date: June 28, 2024</asp:Panel>
                                
                </div>
    <div>
        <center><h4 class="card-title">Join Our Basketball League</h4>
         <center><asp:Image ID="rcballer" runat="server" ImageUrl="images/RCBaller.png" Height="150px" Width="150px"/></center>
            <p><strong>Please be sure to follow us on Social Media!, links to social media websites</strong></p>
        <a href="#" class="btn btn-primary">Follow Us!</a>
            
		<div class="card-footer text-muted">
   <p>Sign up for volunteering at local events. </p>
  <a href="#" class="btn btn-primary">Events</a>

    <h4 class="card-title"><strong>Directions to Our Main Location</strong></h4>                       
    <a href="#" class="btn btn-primary">Directions</a>
            <a href="https://google.com/maps?q=39.57.09,75.10.14.8"></a>
  </div></center>
 
         </div>
  <div class="card-footer text-muted">
      <img src="Images/dunk1.png" /> <p>Tournaments throughout the city!!</p>
  </div>
    
    </div>
    
 
</asp:Content>
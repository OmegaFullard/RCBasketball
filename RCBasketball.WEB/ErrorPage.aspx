<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ErrorPage.aspx.vb"  MasterPageFile="~/Site.Master" Inherits="RCBasketball.WEB.ErrorPage" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceHolder1" >
              <div aria-dropeffect="move" style="padding-left:30px; padding-right:10px; height:500px;overflow: auto; background:rgba(236, 236, 236, 1);">    
                     <h2>Royal City Basketball</h2><br />
                   
                 <p>A fatal error has occurred. We cannot process your 
                                  request at this time.</p>

                       <ul class="error">
                                <li class="error">Click the “Go Home” button to try again.</li>
                        </ul>

                     <asp:Button ID="btnBack" runat="server" Text="Go Home"  CssClass="btnAction"  BorderStyle="None" />

                
               </div>
                  
             
    </asp:Content>


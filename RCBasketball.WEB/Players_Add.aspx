﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Players_Add.aspx.vb"  MasterPageFile="~/Site.Master" Inherits="RCBasketball.WEB.Players_Add" %>
<%@ Register Src="~/Controls_Search/ctrSearch_Players.ascx" TagPrefix="uc1" TagName="ctrSearch_Players" %>
<%@ Register Src="~/Controls_Add/ctrPlayers_Add.ascx" TagPrefix="uc1" TagName="ctrPlayers_Add" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceHolder1" >

               <script type="text/javascript">

                   function OnClientLoad1(sender, args) {
                       $telerik.$(".k-input")[1].setAttribute("readonly", "true");
                   }

               </script>
             

              <div aria-dropeffect="move" style="padding-left:5px; padding-right:10px; height:500px;overflow: auto; background:#e6ecff">    
                       <div class="HeadingB" >Add Players</div>
                 
                            <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="baller2" runat="server" ImageUrl="~/Images/baller2.png"  BorderColor="#f0f0f5" BorderStyle="Solid" BorderWidth="1px" Height="80px" style="margin-top: 5px" Width="80px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                    
										<asp:TableCell VerticalAlign="Top"><uc1:ctrsearch_players runat="server" id="ctrSearch_Players" Visible="false" /></asp:TableCell>
                                    </asp:TableRow>
                              
                              </asp:Table>
                                <div class="clear hideSkiplink">
                                         <asp:Menu ID="NavigationMenu" runat="server" CssClass="sub_menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                                             <Items>
                                                 <asp:MenuItem Text="Find" NavigateUrl="Players_Find.aspx"></asp:MenuItem> 
                                                  <asp:MenuItem  Text="Add"  NavigateUrl="Players_Add.aspx"></asp:MenuItem>
                                                 <asp:MenuItem Text="Update" NavigateUrl="Players_Update.aspx"></asp:MenuItem> 
                                                
                                             </Items>
                                          </asp:Menu>
                                </div>
                                <uc1:ctrPlayers_Add runat="server" id="ctrPlayers_Add" />
               </div>
              
                  
             
    </asp:Content>
<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Players_Update.aspx.vb"  MasterPageFile="~/Site.Master" Inherits="RCBasketball.WEB.Players_Update" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="~/Controls_Search/ctrSearch_Players_Update.ascx" TagPrefix="uc1" TagName="ctrSearch_Players_Update" %>
<%@ Register Src="~/Controls_Update/ctrPlayers_Update.ascx" TagPrefix="uc1" TagName="ctrPlayers_Update" %>
<%@ Register Src="~/Controls_Search/ctrSearch_Players.ascx" TagPrefix="uc1" TagName="ctrSearch_Players" %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceHolder1" >

     
               <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
               
              <div aria-dropeffect="move" style="padding-left:5px; padding-right:10px; height:500px;overflow: auto; background:#e6ecff">    
                       <div class="HeadingB" >Update Players</div>
                 
                            <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="baller2" runat="server" ImageUrl="~/Images/baller2.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="80px" style="margin-top: 5px" Width="80px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                      <asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_Players_Update runat="server" ID="ctrSearch_Players_Update" /></asp:TableCell>
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

                               <uc1:ctrPlayers_Update runat="server" id="ctrPlayers_Update" />
               </div>
              
                  
             
    </asp:Content>

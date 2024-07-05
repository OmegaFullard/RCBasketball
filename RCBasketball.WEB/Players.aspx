<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Players.aspx.vb" MasterPageFile="~/Site.Master" Inherits="RCBasketball.WEB.Players" %>

<%@ Register Src="~/ctrPlayers.ascx" TagPrefix="uc1" TagName="ctrPlayers" %>
<%@ Register Src="~/Controls_Search/ctrSearch_Players.ascx" TagPrefix="uc1" TagName="ctrSearch_Players" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceHolder1" >
              <div aria-dropeffect="move" style="padding-left:5px; padding-right:10px; height:500px;overflow: auto; background:#b6b7bc">    
                       <div class="HeadingB" >Departments</div>
                            <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="baller" runat="server" ImageUrl="~/Images/baller.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="80px" style="margin-top: 5px" Width="80px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_Players runat="server" ID="ctrSearch_Players" /></asp:TableCell>
                                    </asp:TableRow>
                             
                         </asp:Table>
                  <br />
<uc1:ctrPlayers runat="server" id="ctrPlayers" />


</div>
               </asp:Content>
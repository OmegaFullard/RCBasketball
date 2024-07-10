<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ctrSearch_Players_Find.ascx.vb" Inherits="RCBasketball.WEB.ctrSearch_Players_Find" %>
<asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
                        You can use a partial Player ID in your search
                       <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                             <asp:TableRow>
                                          <asp:TableCell>Agent:&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>
                                               <asp:TextBox ID="txtPlayerID" runat="server" Width="180"></asp:TextBox>
                                           </asp:TableCell>
                              </asp:TableRow>
                             <asp:TableRow>
                                          <asp:TableCell>&nbsp;</asp:TableCell>
                                         <asp:TableCell VerticalAlign="Top">
                                               <asp:Button ID="btnSearch" runat="server" Text="Search" Width="180" />
                                        </asp:TableCell>
                              </asp:TableRow>
                         </asp:Table>

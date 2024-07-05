<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ctrPlayers.ascx.vb" Inherits="RCBasketball.WEB.ctrPlayers" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>


<div style="width: 1200px; height:500px;  overflow: auto; padding-left:5px" >
           <div class="Heading" >Players List</div>
           <div><asp:HiddenField ID="ctrHiddebField" runat="server" /></div><br />
    
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
           <asp:GridView ID="grdPlayers" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="1200px" AllowPaging="True" AllowSorting="True" PageSize="15">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>
                                     
                                     <asp:BoundField DataField="PlayerID" HeaderText="Player ID" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="FirstN" HeaderText="First Name" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
									       <asp:BoundField DataField="LastN" HeaderText="Last Name" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="Address" HeaderText="Address" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />                                      
                                      <asp:BoundField DataField="ct_city" HeaderText="City" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="ct_state" HeaderText="State" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="ct_zip" HeaderText="Zip" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
									<asp:BoundField DataField="Phone" HeaderText="Phone" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" DataFormatString="(###)-#######" />
                                    <asp:BoundField DataField="Email" HeaderText="Email" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" DataFormatString='\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*' />
                                 
                                     
                                 </Columns>


                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
               
        </div>
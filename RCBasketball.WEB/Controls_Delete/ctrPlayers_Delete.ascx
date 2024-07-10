<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ctrPlayers_Delete.ascx.vb" Inherits="RCBasketball.WEB.ctrPlayers_Delete" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

    <div style="padding-left:5px; padding-top:5px; padding-bottom:5px">
                          <div class="Heading" >Delete Player</div>
                            <span class="required"><asp:Label ID="lblResult" runat="server" Text=""></asp:Label></span>
                            <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Width="1100px"  >
                             
							 <asp:TableRow>
                                         <asp:TableCell>Player ID:</asp:TableCell>

                                          <asp:TableCell > 
                                               <asp:TextBox ID="txtPlayerID" runat="server" Width="150px" Height="25px"></asp:TextBox>                                                                                             
                                          </asp:TableCell>
                                     <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> 
                                    <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                             </asp:TableRow>
                              <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              </asp:TableRow>
                              <asp:TableRow>
                                          <asp:TableCell>First Name<span class="required">*</span>:</asp:TableCell>
                                          <asp:TableCell>
                                                   <asp:TextBox ID="txtFirstN" runat="server" Width="200px" Height="25px" Enabled="True"></asp:TextBox>
                                          </asp:TableCell>
                                          <asp:TableCell>Last Name<span class="required">*</span>:</asp:TableCell>
                                           <asp:TableCell>
                                                  <asp:TextBox ID="txtLastN" runat="server" Width="200px" Height="25px" Enabled="True"></asp:TextBox>
                                          </asp:TableCell>
                                  
                                           <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                         
                              </asp:TableRow>
                              <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              </asp:TableRow>
                                <asp:TableRow>
                                           <asp:TableCell>Address:</asp:TableCell>
                                          <asp:TableCell>
                                                 <asp:TextBox ID="txtAddress" runat="server" Width="200px" Height="25px"></asp:TextBox>
                                          </asp:TableCell>
                                          
                              </asp:TableRow>
                                             
                              <asp:TableRow>
                                           <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                             <asp:TableRow>                                              
                                                    <asp:TableCell HorizontalAlign="Left" Font-Bold="False">City:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;
                                                        <asp:TextBox ID="txtCity" runat="server" Height="20px" Width="200px" MaxLength="50" Enabled="True"></asp:TextBox>
                                                       
                                                        </asp:TableCell>
                                                        <asp:TableCell HorizontalAlign="Left" Font-Bold="False">State:</asp:TableCell>
                                          <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;
                                              <asp:TextBox ID="txtState" runat="server" Height="20px" Width="200px" MaxLength="50" Enabled="True"></asp:TextBox>
                                           </asp:TableCell>
                                 </asp:TableRow>
                                 <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              </asp:TableRow>
                                <asp:TableRow>
                                                        <asp:TableCell HorizontalAlign="Left" Font-Bold="False">Zip:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp; 
                                                        <asp:TextBox ID="txtZip" runat="server" Height="20px" MaxLength="20" Width="100px" Enabled="True"></asp:TextBox>
                                                        

                                                    </asp:TableCell>
                                                </asp:TableRow>
                                <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                               <asp:TableRow>
                                           <asp:TableCell>Phone<span class="required">*</span>:</asp:TableCell>
                                           <asp:TableCell>
                                               <asp:TextBox ID="txtPhone" style="padding-left:10px;  color:GrayText" RenderMode="Lightweight" Runat="server" Width="200px" Height="25px" ValidationGroup="Submit">
                                               </asp:TextBox>

                                                <asp:RequiredFieldValidator  ID="valRequiredFieldPhone" runat="server" ControlToValidate="txtPhone" ValidationGroup="Submit"
                                                      ErrorMessage  ="Please enter Phone!"><span class="required">!</span></asp:RequiredFieldValidator>

                                                      <ajaxtoolkit:ValidatorCalloutExtender ID="Require_Phone"  TargetControlID="valRequiredFieldPhone"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>
                                           </asp:TableCell>
                                          
                              </asp:TableRow>
                                          <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                                <asp:TableRow>
                                          <asp:TableCell>Email1:</asp:TableCell>
                                          <asp:TableCell>
                                                 <asp:TextBox ID="txtEmail" runat="server" Width="200px" Height="25px"></asp:TextBox>
                                                
                                          </asp:TableCell>
                               </asp:TableRow>
                                <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                               
                          </asp:Table>
                  </div>

               <div style="padding-left:700px;padding-bottom:10px;"  ><asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="150" Height="25px"  />&nbsp;&nbsp;
                <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="150" Height="25px" ValidationGroup="Submit" /></div>

                   
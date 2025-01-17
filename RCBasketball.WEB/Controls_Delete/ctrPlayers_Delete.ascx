﻿<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ctrPlayers_Delete.ascx.vb" Inherits="RCBasketball.WEB.ctrPlayers_Delete" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

    <div style="padding-left:5px; padding-top:5px; padding-bottom:5px">
                          <div class="Heading" >Delete Player</div>
                            <span class="required"><asp:Label ID="lblResult" runat="server" Text=""></asp:Label></span>
                            <div> <asp:Label ID="lblPlayerID" runat="server" Text=""></asp:Label></div>
                            <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Width="1100px"  >
                             <asp:TableRow>
                                         <asp:TableCell>Player ID<span class="required">*</span>:</asp:TableCell>
                                          <asp:TableCell> 
                                                  <telerik:RadTextBox ID="txtID" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                   <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> 
                                    <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                             </asp:TableRow>
                              <asp:TableRow >
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              </asp:TableRow>
                             <asp:TableRow>
                                          <asp:TableCell>First Name<span class="required">*</span>:</asp:TableCell>
                                          <asp:TableCell>
                                                   <telerik:RadTextBox ID="txtFN" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                          <asp:TableCell>Last Name<span class="required">*</span>:</asp:TableCell>
                                           <asp:TableCell>
                                                  <telerik:RadTextBox ID="txtLN" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                  
                                           <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                         
                              </asp:TableRow>
                              <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              </asp:TableRow>
                              <asp:TableRow>
                                         <asp:TableCell>Address<span class="required">*</span>:</asp:TableCell>
                                          <asp:TableCell> 
                                                 <telerik:RadTextBox ID="txtAdd" runat="server" Width="200px" Height="25px"></telerik:RadTextBox>
                                                  
                                          </asp:TableCell>
                                       </asp:TableRow>   
                                         
                                          
                              <asp:TableRow>
                                           <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                               <asp:TableRow>
                                        <asp:TableCell>City<span class="required">*</span>:</asp:TableCell>
                                         <asp:TableCell> 
                                              <telerik:RadTextBox ID="txtc" runat="server" Width="200px" Height="25px"></telerik:RadTextBox>

                                                <asp:RequiredFieldValidator  ID="valRequiredFieldCity" runat="server" ControlToValidate="txtc" ValidationGroup="Submit"
                                                      ErrorMessage  ="Please enter City!"><span class="required">!</span></asp:RequiredFieldValidator>

                                                      <ajaxtoolkit:ValidatorCalloutExtender ID="Requere_City"  TargetControlID="valRequiredFieldCity"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>
                                          </asp:TableCell>
                                          <asp:TableCell>State<span class="required">*</span>:</asp:TableCell>
                                          <asp:TableCell>
                                              <telerik:RadMultiColumnComboBox runat="server"  ClientEvents-OnLoad="OnClientLoad1" ID="cmbStates" DropDownWidth="100px" Height="200px"  Width="150px" AutoPostBack="true"
                                                            Placeholder="--Select" >
                                                            <ColumnsCollection>
                                                                <telerik:MultiColumnComboBoxColumn Field="State" Title="States" Width="100px" />
                                                            </ColumnsCollection>
                                                </telerik:RadMultiColumnComboBox>
                                              
                                           </asp:TableCell>
                                   </asp:TableRow>
                                  <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              </asp:TableRow>
                                   <asp:TableRow>
                                           <asp:TableCell>Zip<span class="required">*</span>:</asp:TableCell>
                                           <asp:TableCell>
                                                <telerik:RadNumericTextBox ID="txtZ"   NumberFormat-DecimalDigits="0" NumberFormat-GroupSeparator="" MaxLength="5" runat="server" Width="100" Height="25px"></telerik:RadNumericTextBox>

                                               <asp:RequiredFieldValidator  ID="valRequiredFieldZip" runat="server" ControlToValidate="txtZ" ValidationGroup="Submit"
                                                      ErrorMessage  ="Please select Zip!"><span class="required">!</span></asp:RequiredFieldValidator>

                                                      <ajaxtoolkit:ValidatorCalloutExtender  ID ="Require_Zip"  TargetControlID="valRequiredFieldZip"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>
                                          </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                               <asp:TableRow>
                                           <asp:TableCell>Phone<span class="required">*</span>:</asp:TableCell>
                                           <asp:TableCell>
                                               <telerik:RadMaskedTextBox ID="txtPh" style="padding-left:10px;  color:GrayText" RenderMode="Lightweight" Runat="server" Mask="(###)###-####" Width="200px" Height="25px" ValidationGroup="Submit">
                                               </telerik:RadMaskedTextBox>

                                                <asp:RequiredFieldValidator  ID="valRequiredFieldPhone" runat="server" ControlToValidate="txtPh" ValidationGroup="Submit"
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
                                 
                                          <asp:TableCell>Email:</asp:TableCell>
                                          <asp:TableCell>
                                                 <telerik:RadTextBox ID="txtE" runat="server" Width="200px" Height="25px"></telerik:RadTextBox>
                                                  <asp:RegularExpressionValidator ID="valRegularExprEmailAddr" runat="server" ControlToValidate="txtE"
                                                     ErrorMessage="Email Address is in the wrong format" 
                                                     ValidationExpression="^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
                                                     ValidationGroup="Submit">!</asp:RegularExpressionValidator>

                                                  <ajaxtoolkit:ValidatorCalloutExtender ID="CalloutEmailAddress"  TargetControlID="valRegularExprEmailAddr"  Width="250px"  
                                                          HighlightCssClass="highlight" runat="server">
                                                  </ajaxtoolkit:ValidatorCalloutExtender>
               
                                          </asp:TableCell>
                               </asp:TableRow>
                                <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                               
                             
                         </asp:Table>
                  </div><br />


               <div style="padding-left:700px;padding-bottom:10px;"  ><asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="150" Height="25px"  />&nbsp;&nbsp;
                <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="150" Height="25px" ValidationGroup="Submit" /></div>

                   
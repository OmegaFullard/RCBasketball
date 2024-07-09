<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ctrPlayers_Add.ascx.vb" Inherits="RCBasketball.WEB.ctrPlayers_Add" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
     
<div style="padding-left:5px; padding-top:5px; padding-bottom:5px">
                          <div class="Heading" >Add Player</div>
                           <span class="required"><asp:Label ID="lblResult" runat="server" Text=""></asp:Label></span>
                              <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Width="1100px" >
                             <asp:TableRow>
                                         <asp:TableCell>Player ID<class="required">*</>:</asp:TableCell>
                                          <asp:TableCell > 
                                               <asp:TextBox ID="txtPlayerID" runat="server" Width="150px" Height="25px"></asp:TextBox>
                                                  
                                            
                                                   <asp:RequiredFieldValidator  ID="valRequiredFieldID" runat="server" ControlToValidate="txtPlayerID" ValidationGroup="Submit"
                                                      ErrorMessage  ="Please enter ID!"><class="required">!</></asp:RequiredFieldValidator>

                                                      <ajaxtoolkit:ValidatorCalloutExtender ID="Required_ID"  TargetControlID="valRequiredFieldID"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>
                                          </asp:TableCell>
                                     <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> 
                                    <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                             </asp:TableRow>
                              <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              </asp:TableRow>
                             <asp:TableRow>
                                          <asp:TableCell>First Name<class="required">*</>:</asp:TableCell>
                                          <asp:TableCell>
                                                   <asp:TextBox ID="txtFirstN" runat="server" Width="200px" Height="25px" ></asp:TextBox>

                                                   <asp:RequiredFieldValidator  ID="valRequiredFieldFirstN" runat="server" ControlToValidate="txtFirstN" ValidationGroup="Submit"
                                                      ErrorMessage  ="Please enter First Name!"><class="required">!</></asp:RequiredFieldValidator>

                                                      <ajaxtoolkit:ValidatorCalloutExtender ID="Required_FirstN"  TargetControlID="valRequiredFieldFirstN"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>
                                             
                                          </asp:TableCell>
                                          
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              
                          
							      <asp:TableCell>Last Name:</asp:TableCell>
                                 </asp:TableRow>
                                  <asp:TableRow>
                                 <asp:TableCell>
                                                 <asp:TextBox ID="txtLastN" runat="server" Width="200px" Height="25px"></asp:TextBox>
                                          </asp:TableCell>
                                          
                                           <asp:TableCell>Address:</asp:TableCell>
                                          <asp:TableCell>
                                                 <asp:TextBox ID="txtAddress" runat="server" Width="200px" Height="25px"></asp:TextBox>
                                          </asp:TableCell>
                                          
                              </asp:TableRow>
                             <asp:TableRow>
                                           <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><TableCell>&nbsp;&nbsp;</TableCell><TableCell>&nbsp;&nbsp;</TableCell><TableCell>&nbsp;&nbsp;</TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <TableCell>&nbsp;&nbsp;</TableCell>
                               </asp:TableRow>
                               <asp:TableRow>
                                        <asp:TableCell>City<class="required">*</>:</asp:TableCell>
                                         <asp:TableCell> 
                                              <asp:TextBox ID="txtCity" runat="server" Width="200px" Height="25px"></asp:TextBox>

                                                <asp:RequiredFieldValidator  ID="valRequiredFieldCity" runat="server" ControlToValidate="txtCity" ValidationGroup="Submit"
                                                      ErrorMessage  ="Please enter City!"><class="required">!</></asp:RequiredFieldValidator>

                                                      <ajaxtoolkit:ValidatorCalloutExtender ID="Require_City"  TargetControlID="valRequiredFieldCity"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>
                                          </asp:TableCell>
                                          <asp:TableCell>State<class="required">*</>:</asp:TableCell>
                                          <asp:TableCell>
                                              <telerik:RadMultiColumnComboBox runat="server" ClientEvents-OnLoad="OnClientLoad1" ID="cmbStates" DropDownWidth="100px" Height="200px"  Width="150px" Filter="Contains" FilterFields="State"
                                                   DataTextField="States" DataValueField="State" MarkFirstMatch="true" ChangeTextOnKeyBoardNavigation="false" AutoPostBack="true"
                                                     
                                                  Placeholder="--Select" >
                                                            <ColumnsCollection>
                                                                <telerik:MultiColumnComboBoxColumn Field="State" Title="States" Width="100px" />
                                                            </ColumnsCollection>
                                                </telerik:RadMultiColumnComboBox>

                                          </asp:TableCell>
                                           <asp:TableCell>Zip<class="required">*</>:</asp:TableCell>
                                           <asp:TableCell>
                                                <asp:TextBox ID="txtZip"   NumberFormat-DecimalDigits="0" NumberFormat-GroupSeparator="" MaxLength="5" runat="server" Width="100" Height="25px"></asp:TextBox>

                                               <asp:RequiredFieldValidator  ID="valRequiredFieldZip" runat="server" ControlToValidate="txtZip" ValidationGroup="Submit"
                                                      ErrorMessage  ="Please select Zip!"><class="required">!</></asp:RequiredFieldValidator>

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
                                           <asp:TableCell>Phone<class="required">*</>:</asp:TableCell>
                                           <asp:TableCell>
                                               <asp:TextBox ID="txtPhone" style="padding-left:10px;  color:GrayText" RenderMode="Lightweight" Runat="server" Mask="(###)###-####" Width="200px" Height="25px" ValidationGroup="Submit">
                                               </asp:TextBox>

                                                <asp:RequiredFieldValidator  ID="valRequiredFieldPhone" runat="server" ControlToValidate="txtPhone" ValidationGroup="Submit"
                                                      ErrorMessage ="Please enter Phone!"><class="required">!</></asp:RequiredFieldValidator>

                                                      <ajaxtoolkit:ValidatorCalloutExtender ID="Require_Phone"  TargetControlID="valRequiredFieldPhone"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>
                                           </asp:TableCell>
                                       
                                          <asp:TableCell>Email1:</asp:TableCell>
                                          <asp:TableCell>
                                                 <asp:TextBox ID="txtEmail" runat="server" Width="200px" Height="25px"></asp:TextBox>
                                                  <asp:RegularExpressionValidator ID="valRegularExprEmailAddr1" runat="server" ControlToValidate="txtEmail"
                                                     ErrorMessage="Email Address is in the wrong format" 
                                                     ValidationExpression="^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
                                                     ValidationGroup="Submit">!</asp:RegularExpressionValidator>

                                                  <ajaxtoolkit:ValidatorCalloutExtender ID="CalloutEmailAddress1"  TargetControlID="valRegularExprEmailAddr1"  Width="250px"  
                                                          HighlightCssClass="highlight" runat="server">
                                                  </ajaxtoolkit:ValidatorCalloutExtender>
               
                                          </asp:TableCell>
                               </asp:TableRow>
                                <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                               
                          </asp:Table>
                
    </div>
               <div style="padding-left:700px;padding-bottom:10px;"  ><asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="150" Height="25px"  />&nbsp;&nbsp;
                <asp:Button ID="btnAdd" runat="server" Text="Add" Width="150" Height="25px" ValidationGroup="Submit" /></div>

                   

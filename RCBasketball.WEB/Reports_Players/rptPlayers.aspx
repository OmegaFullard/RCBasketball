<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="rptPlayers.aspx.vb" MasterPageFile="~/Site.Master" Inherits="RCBasketball.WEB.rptPlayers" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<%@ Register Src="~/Controls_Search/ctrSearch_Players.ascx" TagPrefix="uc1" TagName="ctrSearch_Players" %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceHolder1" >
             
              <div aria-dropeffect="move" style="padding-left:10px; height:500px;overflow:auto;background:rgba(236, 236, 236, 1);">  
			  
                     <h2>Reports:Players Report</h2><br />
                         <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                                   
                                     <asp:TableRow>
                                         <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="report" runat="server" ImageUrl="~/Images/Report1.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="80px" style="margin-top: 5px" Width="80px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_Players runat="server" id="ctrSearch_Players" /></asp:TableCell>
                                    </asp:TableRow>
                         </asp:Table>
             
                  
                          <rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor=""  ClientIDMode="AutoID" HighlightBackgroundColor="" 
                                InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor=""
                                LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor=""
                                PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor=""
                                SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor=""
                                ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px"
                                ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px"
                                ToolBarItemPressedHoverBackColor="153, 187, 226" Width="100%" BorderStyle="None" Height="322px">
                              <LocalReport ReportPath="">
                                   <DataSources>
                                        <rsweb:ReportDataSource DataSourceId="" Name="" />
                                    </DataSources>
                                </LocalReport>
                        </rsweb:ReportViewer>

   </div>
          
 </asp:Content>
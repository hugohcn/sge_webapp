<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmReportVenda.aspx.cs" Inherits="Presentation.reports.frmReportVenda" Title="S.G.E :: Relatório de Vendas" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.XtraReports.v8.3.Web, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073" namespace="DevExpress.XtraReports.Web" tagprefix="dxxr" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxCallbackPanel" tagprefix="dxcp" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlacerLateral" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" style="width: 100%">
        <tr>
            <td align="center" valign="top" rowspan="2" style="padding: 4px;">
                <dxxr:ReportToolbar ID="ReportToolbar1" runat="server" 
                    ReportViewer="<%# rpViewerVendas %>" ShowDefaultButtons="False">
                    <Items>
                        <dxxr:ReportToolbarButton ItemKind="Search" 
                            ToolTip="Display the search window" />
                        <dxxr:ReportToolbarSeparator />
                        <dxxr:ReportToolbarButton ItemKind="PrintReport" ToolTip="Print the report" />
                        <dxxr:ReportToolbarButton ItemKind="PrintPage" 
                            ToolTip="Print the current page" />
                        <dxxr:ReportToolbarSeparator />
                        <dxxr:ReportToolbarButton Enabled="False" ItemKind="FirstPage" 
                            ToolTip="First Page" />
                        <dxxr:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" 
                            ToolTip="Previous Page" />
                        <dxxr:ReportToolbarLabel Text="Page" />
                        <dxxr:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                        </dxxr:ReportToolbarComboBox>
                        <dxxr:ReportToolbarLabel Text="of" />
                        <dxxr:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
                        <dxxr:ReportToolbarButton ItemKind="NextPage" ToolTip="Next Page" />
                        <dxxr:ReportToolbarButton ItemKind="LastPage" ToolTip="Last Page" />
                        <dxxr:ReportToolbarSeparator />
                        <dxxr:ReportToolbarButton ItemKind="SaveToDisk" 
                            ToolTip="Export a report and save it to the disk" />
                        <dxxr:ReportToolbarButton ItemKind="SaveToWindow" 
                            ToolTip="Export a report and show it in a new window" />
                        <dxxr:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                            <Elements>
                                <dxxr:ListElement Text="Pdf" Value="pdf" />
                                <dxxr:ListElement Text="Xls" Value="xls" />
                                <dxxr:ListElement Text="Rtf" Value="rtf" />
                                <dxxr:ListElement Text="Mht" Value="mht" />
                                <dxxr:ListElement Text="Text" Value="txt" />
                                <dxxr:ListElement Text="Csv" Value="csv" />
                                <dxxr:ListElement Text="Image" Value="png" />
                            </Elements>
                        </dxxr:ReportToolbarComboBox>
                    </Items>
                    <Styles>
                        <LabelStyle>
                        <Margins MarginLeft="3px" MarginRight="3px" />
                        </LabelStyle>
                    </Styles>
                </dxxr:ReportToolbar>
                <br />
                <dxcp:ASPxCallbackPanel ID="cbpPanelReport" runat="server" 
                    ClientInstanceName="cbpPanelReport" LoadingPanelText="Carregando..." 
                    oncallback="cbpPanelReport_Callback" Width="100%">
                    <PanelCollection>
<dxp:PanelContent runat="server">
    <dxxr:ReportViewer ID="rpViewerVendas" runat="server" BorderColor="Gray" 
        BorderStyle="Solid" BorderWidth="1px"
        ReportName="Presentation.reports.rptVenda" 
        Report="<%# new Presentation.reports.rptVenda() %>">
        <Border BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" />
    </dxxr:ReportViewer>
                        </dxp:PanelContent>
</PanelCollection>
                </dxcp:ASPxCallbackPanel>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmReportEstoque.aspx.cs"
    Inherits="Presentation.reports.frmReportEstoque" Title="S.G.E. - Relatório de Estoque" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.3" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register assembly="DevExpress.XtraReports.v8.3.Web, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073" namespace="DevExpress.XtraReports.Web" tagprefix="dxxr" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dxcp" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>
<%@ Register assembly="DevExpress.Web.v8.3, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlacerLateral" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" style="width: 100%">
        <tr>
            <td style="width: 1%" valign="top">
                <table style="width: 1%">
                    <tr>
                        <td style="font-family: Tahoma; font-size: 10pt; color: Gray;">
                            Código:</td>
                    </tr>
                    <tr>
                        <td>
                            <dxe:ASPxTextBox ID="txtCodigo" runat="server" Width="170px">
                            </dxe:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <div style="text-align: center;">
                                <img alt="Buscar" style="cursor: pointer;" onclick="cbpPanelReport.PerformCallback();"
                                    src="../imgs/btnBuscar.gif" />
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
            <td align="center" valign="top" rowspan="2">
                <br />
                <dxcp:ASPxCallbackPanel ID="cbpPanelReport" runat="server" ClientInstanceName="cbpPanelReport"
                    LoadingPanelText="Carregando..." OnCallback="cbpPanelReport_Callback" Width="100%">
                    <PanelCollection>
                        <dxp:PanelContent runat="server">
                            <dxxr:ReportToolbar ID="ReportToolbar1" runat="server" 
                                ReportViewer="<%# ReportViewer1 %>" ShowDefaultButtons="False">
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
                            <dxxr:ReportViewer ID="ReportViewer1" runat="server"
                             BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px"
                             ReportName="Presentation.reports.rptEstoque" 
                             Report="<%# new Presentation.reports.rptEstoque() %>">
                                <Border BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" />
                            </dxxr:ReportViewer>
                        </dxp:PanelContent>
                    </PanelCollection>
                </dxcp:ASPxCallbackPanel>
            </td>
        </tr>
    </table>
</asp:Content>

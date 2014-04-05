<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmReportCaixa.aspx.cs" Inherits="Presentation.reports.frmReportCaixa" Title="S.G.E :: Relatório de Caixa" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.XtraReports.v8.3.Web, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073" namespace="DevExpress.XtraReports.Web" tagprefix="dxxr" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxCallbackPanel" tagprefix="dxcp" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlacerLateral" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" style="width: 100%">
        <tr>
            <td style="width: 1%" valign="top">
                <table style="width: 1%">
                    <tr>
                        <td style="font-family: Tahoma; font-size: 10pt; color: Gray;">
                            Data Inicial:</td>
                    </tr>
                    <tr>
                        <td>
                            <dxe:ASPxDateEdit ID="dtInicial" runat="server">
                            </dxe:ASPxDateEdit>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="font-family: Tahoma; font-size: 10pt; color: Gray;">
                            Data Final:</td>
                    </tr>
                    <tr>
                        <td>
                            <dxe:ASPxDateEdit ID="dtFinal" runat="server">
                            </dxe:ASPxDateEdit>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center">
                           <div style="text-align:center;">
                    <img  alt="Buscar" style="cursor: pointer" onclick="cbpPanelReportCaixa.PerformCallback();" src="../imgs/btnBuscar.gif"/>
                </div> 
                        </td>
                    </tr>
                </table>
            </td>
            <td align="center" valign="top" rowspan="2">
                <dxcp:ASPxCallbackPanel ID="cbpPanelReportCaixa" runat="server" 
                    ClientInstanceName="cbpPanelReportCaixa" LoadingPanelText="Carregando..." 
                    Width="100%" oncallback="cbpPanelReportCaixa_Callback">
                    <PanelCollection>
<dxp:PanelContent runat="server">
    <br />
    <dxxr:ReportToolbar ID="ReportToolbar1" runat="server" 
        ReportViewer="<%# rpViewerCaixa %>" ShowDefaultButtons="False">
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
    <dxxr:ReportViewer ID="rpViewerCaixa" runat="server" BorderColor="Gray" 
        BorderStyle="Solid" BorderWidth="1px" 
        Report="<%# new Presentation.reports.rptCaixa() %>" 
        ReportName="Presentation.reports.rptCaixa" 
        LoadingPanelText="Carregando...">
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

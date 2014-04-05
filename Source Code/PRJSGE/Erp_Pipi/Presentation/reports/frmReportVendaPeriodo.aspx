<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmReportVendaPeriodo.aspx.cs" Inherits="Presentation.reports.frmReportVendaPeriodo" Title="S.G.E :: Relatório de Vendas por Período" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.XtraReports.v8.3.Web, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073" namespace="DevExpress.XtraReports.Web" tagprefix="dxxr" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxCallbackPanel" tagprefix="dxcp" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
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
                            Data Inicial:</td>
                    </tr>
                    <tr>
                        <td>
                            <dxe:ASPxDateEdit ID="dtInicial"  runat="server" ClientInstanceName="dtInicial">
                                <ValidationSettings ErrorText="">
                                    <ErrorFrameStyle>
                                        <ErrorTextPaddings PaddingLeft="3px" PaddingRight="4px" />
                                        <Paddings PaddingLeft="4px" PaddingRight="3px" />
                                    </ErrorFrameStyle>
                                    <RequiredField ErrorText="" IsRequired="True" />
                                </ValidationSettings>
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
                            <dxe:ASPxDateEdit ID="dtFinal" runat="server" ClientInstanceName="dtFinal">
                            </dxe:ASPxDateEdit>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center">
                            <div style="text-align:center;">
                            <img id="btnBuscar" onclick="cbpVendasPeriodo.PerformCallback();" src="../imgs/btnBuscar.gif"/>
                               
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
            <td align="center" valign="top" rowspan="2" style="padding: 4px;">
                <dxcp:ASPxCallbackPanel ID="cbpVendasPeriodo" runat="server" 
                    ClientInstanceName="cbpVendasPeriodo" EnableCallbackCompression="True" 
                    LoadingPanelText="Carregando..." oncallback="cbpVendasPeriodo_Callback" 
                    Width="100%">
                    <PanelCollection>
<dxp:PanelContent runat="server">
    <dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" 
        HeaderText="Relatório de vendas por período" Height="150px" 
        HorizontalAlign="Left" Width="400px">
        <HeaderStyle HorizontalAlign="Left" />
        <panelcollection>
            <dxp:PanelContent runat="server">
            <div style="text-align: left;"><b>Total de vendas de <%= dtInicial.Date.ToString("dd/MM/yyyy")%> a <%= dtFinal.Date.ToString("dd/MM/yyyy")%>:</b>&nbsp;&nbsp;&nbsp;<dxe:ASPxLabel 
                    ID="lblNVendas" runat="server">
                </dxe:ASPxLabel>
                </div>
            <br />
            <br />
            <div style="text-align: left;"><b>Valor total de vendas no período:</b>&nbsp;&nbsp;&nbsp;R$
                <dxe:ASPxLabel ID="lblTotalVendas" runat="server">
                </dxe:ASPxLabel>
                </div>
            <br />
            <br />
            <div style="text-align: left;"><b>Valor total de descontos no período:</b>&nbsp;&nbsp;&nbsp;R$
                <dxe:ASPxLabel ID="lblTotalDescontos" runat="server">
                </dxe:ASPxLabel>
                </div>
                <br />
                <br />
                <div style="text-align: left;"><b>Valor total:</b>&nbsp;&nbsp;&nbsp;R$
                <dxe:ASPxLabel ID="lblTotal" runat="server">
                </dxe:ASPxLabel>
                </div>
            </dxp:PanelContent>
        </panelcollection>
    </dxrp:ASPxRoundPanel>
    <br />
                        </dxp:PanelContent>
</PanelCollection>
                </dxcp:ASPxCallbackPanel>

                <br />
            </td>
        </tr>
    </table>
</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmProdutoVendaDiaByProduto.aspx.cs"
    Inherits="Presentation.reports.frmProdutoVendaDiaByProduto" Title="S.G.E :: Relatório de Produto Específico Vendido por Período" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.3" Namespace="DevExpress.Web.ASPxEditors"
    TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.XtraReports.v8.3.Web, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxCallbackPanel"
    TagPrefix="dxcp" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxPanel"
    TagPrefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v8.3, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v8.3.Export, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073"
    Namespace="DevExpress.Web.ASPxGridView.Export" TagPrefix="dxwgv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlacerLateral" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" style="width: 100%">
        <tr>
            <td style="width: 1%" valign="top">
                <table style="width: 1%">
                    <tr>
                        <td style="font-family: Tahoma; font-size: 10pt; color: Gray;">
                            &nbsp;Código do Produto:                             
                            <dxe:ASPxTextBox ID="txtCodigoProduto" runat="server" Width="100%" 
                                ClientInstanceName="txtCodigoProduto">
                            </dxe:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="font-family: Tahoma; font-size: 10pt; color: Gray;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="font-family: Tahoma; font-size: 10pt; color: Gray;">
                            Data Inicial:
                        </td>
                    </tr>
                    <tr>
                        <td style="font-family: Tahoma; font-size: 10pt; color: Gray;">
                            <dxe:ASPxDateEdit ID="dtInicial" runat="server">
                            </dxe:ASPxDateEdit>
                        </td>
                    </tr>
                    <tr>
                        <td style="font-family: Tahoma; font-size: 10pt; color: Gray;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="font-family: Tahoma; font-size: 10pt; color: Gray;">
                            Data Final:
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dxe:ASPxDateEdit ID="dtFinal" runat="server">
                            </dxe:ASPxDateEdit>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <div style="text-align: center;">
                                <img alt="Buscar" style="cursor: pointer" onclick="gdvProdutosByIdVendaDia.PerformCallback();"
                                    src="../imgs/btnBuscar.gif" />
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top" align="center">
                <dxwgv:ASPxGridView ID="gdvProdutosByIdVendaDia" runat="server" 
                    ClientInstanceName="gdvProdutosByIdVendaDia" 
                    oncustomcallback="gdvProdutosByIdVendaDia_CustomCallback" Width="90%" 
                    AutoGenerateColumns="False">
                    <SettingsText EmptyDataRow="Selecione a data inicial, final e o código do produto." />
                    <TotalSummary>
                        <dxwgv:ASPxSummaryItem DisplayFormat="Total: {0:n2}" FieldName="total" 
                            ShowInGroupFooterColumn="Subtotal" SummaryType="Sum" />
                        <dxwgv:ASPxSummaryItem DisplayFormat="Quantidade total vendida: {0:n2}" 
                            FieldName="quantidade" ShowInGroupFooterColumn="Quantidade" SummaryType="Sum" />
                    </TotalSummary>
                    <Columns>
                        <dxwgv:GridViewDataTextColumn Caption="Produto" FieldName="produto" 
                            VisibleIndex="0">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn Caption="Quantidade" FieldName="quantidade" 
                            VisibleIndex="1">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn Caption="Subtotal" FieldName="total" 
                            VisibleIndex="2">
                        </dxwgv:GridViewDataTextColumn>
                    </Columns>
                    <SettingsLoadingPanel Text="Carregando..." />
                    <SettingsPager>
                        <Summary AllPagesText="Páginas: {0} - {1} ({2} itens)" 
                            Text="Página {0} de {1} ({2} itens)" />
                    </SettingsPager>
                    <Settings ShowFooter="True" />
                </dxwgv:ASPxGridView>
            </td>
        </tr>
    </table>
</asp:Content>

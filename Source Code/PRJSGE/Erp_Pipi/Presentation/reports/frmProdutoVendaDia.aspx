<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmProdutoVendaDia.aspx.cs"
    Inherits="Presentation.reports.frmProdutoVendaDia" Title="S.G.E :: Relatório de Venda de Produtos" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.3" Namespace="DevExpress.Web.ASPxEditors"
    TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.XtraReports.v8.3.Web, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxCallbackPanel"
    TagPrefix="dxcp" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxPanel"
    TagPrefix="dxp" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3.Export, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dxwgv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlacerLateral" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" style="width: 100%">
        <tr>
            <td style="width: 1%" valign="top">
                <table style="width: 1%">
                    <tr>
                        <td style="font-family: Tahoma; font-size: 10pt; color: Gray;">
                            Data Inicial:
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dxe:ASPxDateEdit ID="dtInicial" runat="server">
                            </dxe:ASPxDateEdit>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
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
                                <img alt="Buscar" style="cursor: pointer" onclick="gdvProdutos.PerformCallback();"
                                    src="../imgs/btnBuscar.gif" />
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top" align="center">
                
                <dxcp:ASPxCallbackPanel ID="cbpRelatorioVendaDetalhadaDia" ClientInstanceName="cbpRelatorioVendaDetalhadaDia" runat="server" 
                    LoadingPanelText="Carregando..." 
                    oncallback="cbpRelatorioVendaDetalhadaDia_Callback" Width="100%">
                    <PanelCollection>
<dxp:PanelContent runat="server">
    <table cellpadding="0" style="width: 90%">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" style="width: 1%">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <dxwgv:ASPxGridView ID="gdvProdutos" runat="server" AutoGenerateColumns="False" 
        ClientInstanceName="gdvProdutos" OnCustomCallback="gdvProdutos_CustomCallback" 
        Width="90%" SummaryText="Total:">
        <TotalSummary>
            <dxwgv:ASPxSummaryItem DisplayFormat="{0:n2}" FieldName="total" 
                ShowInGroupFooterColumn="Subtotal" SummaryType="Sum" />
        </TotalSummary>
        <Columns>
            <dxwgv:GridViewDataTextColumn Caption="Produto" FieldName="produto" 
                VisibleIndex="0">
                <PropertiesTextEdit>
                    <Style HorizontalAlign="Left">
                    </Style>
                </PropertiesTextEdit>
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn Caption="Quantidade" FieldName="quantidade" 
                ToolTip="Quantidade de produtos vendidos" VisibleIndex="1">
                <PropertiesTextEdit>
                    <Style HorizontalAlign="Center">
                    </Style>
                </PropertiesTextEdit>
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn Caption="Subtotal" FieldName="total" 
                VisibleIndex="2">
                <PropertiesTextEdit DisplayFormatString="{0:n2}">
                    <Style HorizontalAlign="Center">
                    </Style>
                </PropertiesTextEdit>
            </dxwgv:GridViewDataTextColumn>
        </Columns>
        <SettingsPager Mode="ShowAllRecords" PageSize="100">
            <Summary AllPagesText="Páginas: {0} - {1} ({2} itens)" 
                Text="Página {0} de {1} ({2} itens)" />
        </SettingsPager>
        <Settings ShowFooter="True" ShowGroupFooter="VisibleAlways" />
        <SettingsText EmptyDataRow="Informe uma data inicial e final para buscar." />
        <SettingsLoadingPanel Text="Carregando..." />
        <Styles>
            <Header HorizontalAlign="Center">
            </Header>
        </Styles>
    </dxwgv:ASPxGridView>
    <dxwgv:ASPxGridViewExporter ID="gdvExporter" runat="server" 
        FileName="RelatorioProdutoVendidosPorPeriodo" GridViewID="gdvProdutos" 
        MaxColumnWidth="600" PreserveGroupRowStates="True">
    </dxwgv:ASPxGridViewExporter>
                        </dxp:PanelContent>
</PanelCollection>
                </dxcp:ASPxCallbackPanel>
                
            </td>
        </tr>
    </table>
</asp:Content>

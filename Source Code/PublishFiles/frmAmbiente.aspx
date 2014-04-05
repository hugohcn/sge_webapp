<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmAmbiente.aspx.cs"
    Inherits="Presentation.forms.frmAmbiente" Title="" EnableTheming="true" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dxtc" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dxw" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxDataView" tagprefix="dxdv" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td valign="top">
                <table cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td align="center">
                            
                            <dxtc:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" 
                                CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                                ImageFolder="~/App_Themes/Soft Orange/{0}/" LoadingPanelText="" 
                                TabSpacing="2px" Width="90%">
                                <ContentStyle>
                                    <Border BorderColor="LightGray" BorderStyle="Solid" BorderWidth="3px" />
                                </ContentStyle>
                                <TabPages>
                                    <dxtc:TabPage Text="Produtos Mais Vendidos">
                                        <ContentCollection>
                                            <dxw:ContentControl runat="server">
                                            </dxw:ContentControl>
                                        </ContentCollection>
                                    </dxtc:TabPage>
                                    <dxtc:TabPage Text="Estoque">
                                        <ContentCollection>
                                            <dxw:ContentControl runat="server">
                                            </dxw:ContentControl>
                                        </ContentCollection>
                                    </dxtc:TabPage>
                                    <dxtc:TabPage Text="Clientes">
                                        <ContentCollection>
                                            <dxw:ContentControl runat="server">
                                            </dxw:ContentControl>
                                        </ContentCollection>
                                    </dxtc:TabPage>
                                </TabPages>
                                <Paddings Padding="4px" />
                            </dxtc:ASPxPageControl>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

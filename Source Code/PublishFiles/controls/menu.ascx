<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="menu.ascx.cs" Inherits="Presentation.controls.menu" %>
<%@ Register Assembly="DevExpress.Web.v8.3, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dxcp" %>
<%@ Register Assembly="DevExpress.Web.v8.3, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073"
    Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dxm" %>
<%@ Register Assembly="DevExpress.Web.v8.3, Version=8.3.4.0, Culture=neutral, PublicKeyToken=5377c8e3b72b4073"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<table cellpadding="0" cellspacing="0" width="100%" border="0">
    <tr>
        <td align="left" valign="top" style="background-repeat: repeat-x; background-image: url('App_Themes/Soft Orange/Web/nbHeaderBack.png')">
            <dxm:ASPxMenu ID="menuSistema" runat="server" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                CssPostfix="Soft_Orange" ImageFolder="~/App_Themes/Soft Orange/{0}/" ItemSpacing="0px"
                SeparatorHeight="0px" SeparatorWidth="0px" ShowPopOutImages="True" ClientInstanceName="menuSistema"
                AutoSeparators="RootOnly" BorderBetweenItemAndSubMenu="HideRootOnly" Font-Size="9pt"
                GutterWidth="0px" LoadingPanelText="Carregando...">
                <Items>
                    <dxm:MenuItem Text="Início" NavigateUrl="~/frmAmbiente.aspx"
                        Target="_self">
                    </dxm:MenuItem>
                    <dxm:MenuItem Text="Produtos">
                        <Items>
                            <dxm:MenuItem NavigateUrl="~/frmManterProdutos.aspx" Text="Gerenciar Produtos">
                            </dxm:MenuItem>
                            <dxm:MenuItem Text="Gerenciar Tipos de Produtos" NavigateUrl="~/frmManterTipoProduto.aspx">
                            </dxm:MenuItem>
                            <dxm:MenuItem NavigateUrl="~/frmManterEstoque.aspx" Text="Gerenciar Estoque">
                            </dxm:MenuItem>
                        </Items>
                    </dxm:MenuItem>
                    <dxm:MenuItem Text="Clientes">
                        <Items>
                            <dxm:MenuItem NavigateUrl="~/frmManterClientes.aspx" Text="Gerenciar Clientes">
                            </dxm:MenuItem>
                            <dxm:MenuItem Text="Gerenciar Carteiras" NavigateUrl="~/frmManterCarteiraCliente.aspx"
                                Visible="False">
                            </dxm:MenuItem>
                            <dxm:MenuItem Text="Mala Direta" Visible="False">
                            </dxm:MenuItem>
                        </Items>
                    </dxm:MenuItem>
                    <dxm:MenuItem Text="Fornecedores">
                        <Items>
                            <dxm:MenuItem NavigateUrl="~/frmManterRevendedor.aspx" Text="Gerenciar Fornecedores">
                            </dxm:MenuItem>
                        </Items>
                    </dxm:MenuItem>
                    <dxm:MenuItem Text="Relatórios">
                        <Items>
                            <dxm:MenuItem Text="Vendas">
                                <Items>
                                    <dxm:MenuItem Text="Relatório Geral de Vendas" 
                                        NavigateUrl="~/reports/frmReportVenda.aspx" Target="_blank">
                                    </dxm:MenuItem>
                                    <dxm:MenuItem Text="Relatório de Vendas por Período" 
                                        NavigateUrl="~/reports/frmReportVendaPeriodo.aspx" Target="_blank">
                                    </dxm:MenuItem>
                                    <dxm:MenuItem Text="Relatório Geral de Produtos Vendidos por Período" 
                                        NavigateUrl="~/reports/frmProdutoVendaDia.aspx" Target="_blank">
                                    </dxm:MenuItem>
                                    <dxm:MenuItem NavigateUrl="~/reports/frmProdutoVendaDiaByProduto.aspx" 
                                        Target="_blank" Text="Relatório de Produto Específico Vendido por Período">
                                    </dxm:MenuItem>
                                </Items>
                            </dxm:MenuItem>
                            <dxm:MenuItem Text="Caixa">
                                <Items>
                                    <dxm:MenuItem Text="Relatório Geral de Caixa" 
                                        NavigateUrl="~/reports/frmReportCaixa.aspx" Target="_blank">
                                    </dxm:MenuItem>
                                </Items>
                            </dxm:MenuItem>
                            <dxm:MenuItem Text="Estoque">
                                <Items>
                                    <dxm:MenuItem Text="Relatório Geral de Estoque" 
                                        NavigateUrl="~/reports/frmReportEstoque.aspx" Target="_blank">
                                    </dxm:MenuItem>
                                </Items>
                            </dxm:MenuItem>
                        </Items>
                    </dxm:MenuItem>
                    <dxm:MenuItem Text="Custos">
                        <Items>
                            <dxm:MenuItem NavigateUrl="~/frmManterTipoCusto.aspx" Text="Gerenciar Tipos de Custos">
                            </dxm:MenuItem>
                            <dxm:MenuItem Text="Gerenciar Custos" NavigateUrl="~/frmManterCusto.aspx">
                            </dxm:MenuItem>
                        </Items>
                    </dxm:MenuItem>
                    <dxm:MenuItem Text="Vendas">
                        <Items>
                            <dxm:MenuItem NavigateUrl="~/frmManterVenda.aspx" Text="Gerenciar Vendas">
                            </dxm:MenuItem>
                            <dxm:MenuItem NavigateUrl="~/frmManterTipoPagamento.aspx" Text="Gerenciar Tipos de Pagamento">
                            </dxm:MenuItem>
                            <dxm:MenuItem NavigateUrl="~/frmVendas.aspx" Text="Módulo de Vendas" Visible="False">
                            </dxm:MenuItem>
                        </Items>
                    </dxm:MenuItem>
                    <dxm:MenuItem Text="Sobre" NavigateUrl="javascript:popSobre.Show();">
                    </dxm:MenuItem>
                </Items>
                <VerticalPopOutImage Height="8px" Url="~/App_Themes/Soft Orange/Web/mVerticalPopOut.png" />
                <ItemStyle ImageSpacing="6px" PopOutImageSpacing="10px" />
                <SubMenuStyle GutterWidth="0px" />
                <SubMenuItemImage UrlChecked="~/App_Themes/Soft Orange/Web/mSubMenuItemChecked.gif" />
                <SeparatorPaddings Padding="0px" />
                <Border BorderWidth="0px" BorderStyle="None" />
                <ItemImage UrlChecked="~/App_Themes/Soft Orange/Web/mItemChecked.gif" />
                <HorizontalPopOutImage Height="4px" Url="~/App_Themes/Soft Orange/Web/mHorizontalPopOut.png"
                    UrlSelected="~/App_Themes/Soft Orange/Web/mHorizontalPopOutH.png" />
            </dxm:ASPxMenu>
        </td>
        <td align="right" style="background-repeat: repeat-x; background-image: url('App_Themes/Soft Orange/Web/nbHeaderBack.png')">
            <dxm:ASPxMenu ID="menuAdmin" runat="server" AppearAfter="200" AutoSeparators="RootOnly"
                ClientInstanceName="menuAdmin" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                CssPostfix="Soft_Orange" DisappearAfter="700" ImageFolder="~/App_Themes/Soft Orange/{0}/"
                ItemSpacing="0px" SeparatorHeight="0px" SeparatorWidth="0px" ShowPopOutImages="True"
                Width="140px" Visible="False" OnItemClick="menuAdmin_ItemClick" AutoPostBack="True"
                BorderBetweenItemAndSubMenu="HideRootOnly" GutterWidth="0px" LoadingPanelText="Carregando">
                <Items>
                    <dxm:MenuItem Name="Administrador" Text="Administrador">
                        <Items>
                            <dxm:MenuItem NavigateUrl="~/frmManterPerfil.aspx" Text="Perfil">
                            </dxm:MenuItem>
                            <dxm:MenuItem Text="Banco de Dados"
                                NavigateUrl="javascript:popConfigDb.Show()" Visible="False">
                            </dxm:MenuItem>
                            <dxm:MenuItem Name="LogOff" Text="Fazer Logoff">
                            </dxm:MenuItem>
                        </Items>
                    </dxm:MenuItem>
                </Items>
                <VerticalPopOutImage Height="8px" Url="~/App_Themes/Soft Orange/Web/mVerticalPopOut.png" />
                <ItemStyle ImageSpacing="6px" PopOutImageSpacing="10px" />
                <SubMenuStyle GutterWidth="0px" />
                <SubMenuItemImage UrlChecked="~/App_Themes/Soft Orange/Web/mSubMenuItemChecked.gif" />
                <SeparatorPaddings Padding="0px" />
                <Border BorderWidth="0px" />
                <ItemImage UrlChecked="~/App_Themes/Soft Orange/Web/mItemChecked.gif" />
                <HorizontalPopOutImage Height="4px" Url="~/App_Themes/Soft Orange/Web/mHorizontalPopOut.png"
                    UrlSelected="~/App_Themes/Soft Orange/Web/mHorizontalPopOutH.png" />
            </dxm:ASPxMenu>
        </td>
    </tr>
</table>
<dxpc:ASPxPopupControl ID="popSobre" runat="server" AllowDragging="True" 
    ClientInstanceName="popSobre" Height="350px" Modal="True" PopupHorizontalAlign="WindowCenter"
    PopupVerticalAlign="WindowCenter" ShowHeader="False" Width="400px" 
    BackColor="Transparent" FooterText="" HeaderText="" ShowShadow="False">
    <ModalBackgroundStyle Opacity="70" BackColor="White">
    </ModalBackgroundStyle>
    <ContentCollection>
        <dxpc:PopupControlContentControl runat="server">
            <div style="text-align: center; width: 100%;">
                <img alt="S.G.E." src="imgs/sobre.jpg" />
            </div>
        </dxpc:PopupControlContentControl>
    </ContentCollection>
    <Border BorderWidth="0px" />
</dxpc:ASPxPopupControl>

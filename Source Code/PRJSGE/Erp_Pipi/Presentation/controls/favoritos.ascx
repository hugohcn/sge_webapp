<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="favoritos.ascx.cs" Inherits="Presentation.controls.favoritos" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxNavBar" tagprefix="dxnb" %>
<table cellpadding="0" cellspacing="2" width="100%">
    <tr>
        <td align="center">
            <dxnb:ASPxNavBar ID="navFavoritos" runat="server" 
                ClientInstanceName="navFavoritos" 
                CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                GroupSpacing="0px" ImageFolder="~/App_Themes/Soft Orange/{0}/" 
                Width="190px" AllowSelectItem="True" 
                EnableAnimation="True" LoadingPanelText="">
                <Groups>
                    <dxnb:NavBarGroup AllowDragging="False" ExpandButtonPosition="Right" 
                        Text="Favoritos">
                        <Items>
                            <dxnb:NavBarItem Text="Favoritos">
                            </dxnb:NavBarItem>
                        </Items>
                        <ContentStyle>
                            <Paddings Padding="4px" />
                        </ContentStyle>
                        <ItemStyle HorizontalAlign="Left" />
                        <ItemTemplate>
                            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="odsFavoritos">
                                <ItemTemplate>
                                    <div style="padding-bottom: 5px; padding-top: 5px;"><a href="<%# Eval("UrlFavorito")%>" target="_blank"><%# Eval("NomeFavorito")%></a></div>
                                </ItemTemplate>
                            </asp:Repeater>
                            <asp:ObjectDataSource ID="odsFavoritos" runat="server" 
                                SelectMethod="GetFavoritoByFuncionarioId" TypeName="Business.BUFavorito">
                                <SelectParameters>
                                    <asp:SessionParameter Name="idFuncionario" SessionField="idUser" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </ItemTemplate>
                    </dxnb:NavBarGroup>
                </Groups>
                <CollapseImage Height="18px" 
                    Width="18px" />
                <ExpandImage Height="18px" 
                    Width="18px" />
            </dxnb:ASPxNavBar>
        </td>
    </tr>
</table>

<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmManterVenda.aspx.cs" Inherits="Presentation.frmManterVenda" Title="SGE - Gerenciar Vendas" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3.Export" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxTabControl" tagprefix="dxtc" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxClasses" tagprefix="dxw" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxNavBar" tagprefix="dxnb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%">

    <table cellpadding="0" border="0" cellspacing="2" width="100%">
        <tr>
            <td style="width: 25%">
                &nbsp;</td>
            <td style="width: 25%">
                &nbsp;</td>
            <td align="right" style="width: 25%; padding-right: 10px;">
                <dxe:ASPxButton ID="btnExportarXLS" runat="server" 
                    ClientInstanceName="btnExportarXLS" 
                    CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                    onclick="btnExportarXLS_Click" Text="Exportar para XLS" 
                    UseSubmitBehavior="False" Width="150px">
                </dxe:ASPxButton>
            </td>
            <td align="right" style="width: 10%">
                <dxe:ASPxButton ID="btnExportarPdf" runat="server" 
                    ClientInstanceName="btnExportarPdf" 
                    CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                    onclick="btnExportarPdf_Click" Text="Exportar para PDF" 
                    UseSubmitBehavior="False" Width="150px">
                </dxe:ASPxButton>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="4" style="width: ">
                <dxwgv:ASPxGridView ID="gdvVendas" runat="server" AutoGenerateColumns="False" 
                    ClientInstanceName="gdvVendas" 
                    CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                    DataSourceID="odsVendas" KeyFieldName="IdVenda" Width="100%" 
                    oncustomerrortext="gdvVendas_CustomErrorText">
                    <Templates>
                        <DetailRow>
                            <dxwgv:ASPxGridView ID="gdvItemCarrinho" runat="server" 
                                AutoGenerateColumns="False" DataSourceID="odsItemCarrinhoById" 
                                onbeforeperformdataselect="gdvItemCarrinho_BeforePerformDataSelect" 
                                Width="100%" KeyFieldName="IdItemCarrinho">
                                <SettingsText EmptyDataRow="Não há produtos para esta venda." />
                                <Columns>
                                    <dxwgv:GridViewDataTextColumn FieldName="IdItemCarrinho" 
                                        VisibleIndex="0" Visible="False">
                                    </dxwgv:GridViewDataTextColumn>
                                    <dxwgv:GridViewDataComboBoxColumn Caption="Produto" FieldName="IdProduto" 
                                        VisibleIndex="0">
                                        <PropertiesComboBox DataSourceID="odsProdutos" TextField="StrNome" 
                                            ValueField="IdProduto" ValueType="System.String">
                                        </PropertiesComboBox>
                                    </dxwgv:GridViewDataComboBoxColumn>
                                    <dxwgv:GridViewDataTextColumn Caption="Quantidade Vendida" 
                                        FieldName="IntQuatidade" VisibleIndex="1">
                                    </dxwgv:GridViewDataTextColumn>
                                    <dxwgv:GridViewDataTextColumn FieldName="IdVenda" Visible="False" 
                                        VisibleIndex="3">
                                    </dxwgv:GridViewDataTextColumn>
                                    <dxwgv:GridViewCommandColumn VisibleIndex="2">
                                        <DeleteButton Text="Excluir" Visible="True">
                                        </DeleteButton>
                                    </dxwgv:GridViewCommandColumn>
                                </Columns>
                                <SettingsDetail IsDetailGrid="True" />
                            </dxwgv:ASPxGridView>
                        </DetailRow>
                    </Templates>
                    <Styles CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                        CssPostfix="Soft_Orange" GroupButtonWidth="28">
                        <Header ImageSpacing="5px" SortingImageSpacing="5px">
                        </Header>
                        <LoadingPanel ImageSpacing="10px">
                        </LoadingPanel>
                    </Styles>
                    <SettingsText EmptyDataRow="Não há registros de vendas cadastrados no sistema." 
                        ConfirmDelete="Deseja realmente deletar esta venda do sistema?" />
                    <Columns>
                        <dxwgv:GridViewDataTextColumn Caption="Data da Venda" 
                            FieldName="DteVenda" VisibleIndex="0">
                            <PropertiesTextEdit DisplayFormatString="{0:dd/MM/yyyy}">
                            </PropertiesTextEdit>
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn Caption="Produtos" 
                            FieldName="IdItemCarrinho" VisibleIndex="1" Visible="False">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataComboBoxColumn FieldName="TipoPagamento" VisibleIndex="1">
                            <PropertiesComboBox DataSourceID="odsTipoPagamento" DropDownStyle="DropDown" 
                                EnableIncrementalFiltering="True" TextField="StrNome" 
                                ValueField="IdTipoPagamento" ValueType="System.String">
                            </PropertiesComboBox>
                        </dxwgv:GridViewDataComboBoxColumn>
                        <dxwgv:GridViewDataTextColumn FieldName="FltValorDesconto" VisibleIndex="2" 
                            Caption="Desconto">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn FieldName="FltValorTotal" VisibleIndex="3" 
                            Caption="Total da venda">
                            <PropertiesTextEdit DisplayFormatString="{0:n2}">
                            </PropertiesTextEdit>
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataCheckColumn 
                            FieldName="BitStatusVenda" VisibleIndex="4" Caption="Venda Ideal">
                        </dxwgv:GridViewDataCheckColumn>
                        <dxwgv:GridViewCommandColumn VisibleIndex="5">
                            <DeleteButton Text="Excluir" Visible="True">
                            </DeleteButton>
                        </dxwgv:GridViewCommandColumn>
                    </Columns>
                    <SettingsLoadingPanel Text="" />
                    <Images ImageFolder="~/App_Themes/Soft Orange/{0}/">
                        <CollapsedButton Height="14px" 
                            Url="~/App_Themes/Soft Orange/GridView/gvCollapsedButton.png" Width="13px" />
                        <ExpandedButton Height="13px" 
                            Url="~/App_Themes/Soft Orange/GridView/gvExpandedButton.png" Width="13px" />
                        <DetailCollapsedButton Height="14px" 
                            Url="~/App_Themes/Soft Orange/GridView/gvCollapsedButton.png" Width="13px" />
                        <DetailExpandedButton Height="13px" 
                            Url="~/App_Themes/Soft Orange/GridView/gvExpandedButton.png" Width="13px" />
                        <HeaderFilter Height="19px" 
                            Url="~/App_Themes/Soft Orange/GridView/gvHeaderFilter.png" Width="19px" />
                        <HeaderActiveFilter Height="19px" 
                            Url="~/App_Themes/Soft Orange/GridView/gvHeaderFilterActive.png" Width="19px" />
                        <HeaderSortDown Height="3px" 
                            Url="~/App_Themes/Soft Orange/GridView/gvHeaderSortDown.png" Width="6px" />
                        <HeaderSortUp Height="3px" 
                            Url="~/App_Themes/Soft Orange/GridView/gvHeaderSortUp.png" Width="6px" />
                        <FilterRowButton Height="13px" Width="13px" />
                        <CustomizationWindowClose Height="18px" Width="18px" />
                        <PopupEditFormWindowClose Height="18px" Width="18px" />
                        <WindowResizer Height="12px" 
                            Url="~/App_Themes/Soft Orange/GridView/WindowResizer.png" Width="12px" />
                        <FilterBuilderClose Height="18px" Width="18px" />
                    </Images>
                    <SettingsPager>
                        <AllButton>
                            <Image Height="19px" Width="28px" />
                        </AllButton>
                        <FirstPageButton>
                            <Image Height="19px" Width="23px" />
                        </FirstPageButton>
                        <LastPageButton>
                            <Image Height="19px" Width="23px" />
                        </LastPageButton>
                        <NextPageButton>
                            <Image Height="19px" Width="19px" />
                        </NextPageButton>
                        <PrevPageButton>
                            <Image Height="19px" Width="19px" />
                        </PrevPageButton>
                        <Summary AllPagesText="Páginas: {0} - {1} ({2} itens)" 
                            Text="Página {0} de {1} ({2} itens)" />
                    </SettingsPager>
                    <SettingsDetail ShowDetailRow="True" />
                    <Paddings Padding="1px" />
                    <Settings ShowFilterRow="True" />
                    <ImagesEditors>
                        <CalendarPrevYear Height="19px" 
                            Url="~/App_Themes/Soft Orange/Editors/edtCalendarPrevYear.png" Width="23px" />
                        <CalendarPrevMonth Height="19px" 
                            Url="~/App_Themes/Soft Orange/Editors/edtCalendarPrevMonth.png" Width="19px" />
                        <CalendarNextMonth Height="19px" 
                            Url="~/App_Themes/Soft Orange/Editors/edtCalendarNextMonth.png" Width="19px" />
                        <CalendarNextYear Height="19px" 
                            Url="~/App_Themes/Soft Orange/Editors/edtCalendarNextYear.png" Width="23px" />
                    </ImagesEditors>
                </dxwgv:ASPxGridView>
                <asp:ObjectDataSource ID="odsVendas" runat="server" 
                    DataObjectTypeName="Entity.ENVenda" DeleteMethod="DeleteVenda" SelectMethod="GetAllVendas" 
                    TypeName="Business.BUVenda" OldValuesParameterFormatString="original_{0}">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="odsItemCarrinho" runat="server" 
                    SelectMethod="GetAllItensCarrinho" TypeName="Business.BUItemCarrinho" 
                    DataObjectTypeName="Entity.ENItemCarrinho" DeleteMethod="DeleteCarrinho" 
                    OldValuesParameterFormatString="original_{0}">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="odsProdutos" runat="server" 
                    SelectMethod="GetAllProdutos" TypeName="Business.BUProduto" 
                    OldValuesParameterFormatString="original_{0}">
                </asp:ObjectDataSource>
                <dxwgv:ASPxGridViewExporter ID="gvExporter" runat="server" FileName="Vendas" 
                    GridViewID="gdvVendas">
                </dxwgv:ASPxGridViewExporter>
                <asp:ObjectDataSource ID="odsTipoPagamento" runat="server" 
                    SelectMethod="GetAllTipoPagamento" TypeName="Business.BUTipoPagamento">
                </asp:ObjectDataSource>
                            <asp:ObjectDataSource ID="odsItemCarrinhoById" runat="server" 
                                SelectMethod="GetCarrinhoByIdVenda" 
                    TypeName="Business.BUItemCarrinho" DataObjectTypeName="Entity.ENItemCarrinho" 
                    DeleteMethod="DeleteCarrinho" 
                    OldValuesParameterFormatString="original_{0}">
                                <SelectParameters>
                                    <asp:SessionParameter Name="idVenda" SessionField="idVenda" 
                                        Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
            </td>
        </tr>
        </table>

</div>
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="contentPlacerLateral">
                            <dxnb:ASPxNavBar ID="navDetalhesEstoque" runat="server" ClientInstanceName="navDetalhesEstoque"
        CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange"
        GroupSpacing="0px" ImageFolder="~/App_Themes/Soft Orange/{0}/" LoadingPanelText=""
        Width="100%">
                                <Groups>
                                    <dxnb:NavBarGroup Text="Detalhes">
                                        <Items>
                                            <dxnb:NavBarItem Text="Relatório do vendas">
                                                <Template>
                                                    <table cellpadding="0" style="width: 100%">
                                                        <tr>
                                                            <td>
                                        &nbsp;
                                                            </td>
                                                            <td>
                                        &nbsp;
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left" colspan="2">
                                                                <dxe:ASPxHyperLink ID="hlkRelatorioEstoque" runat="server" ClientInstanceName="hlkRelatorioEstoque"
                                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange"
                                            Cursor="pointer" ForeColor="Gray" Text="[Relatório de Vendas]">
                                                                    <ClientSideEvents Click="function(s, e) {
	var Pop = null;
    Pop = window.open(&quot;/reports/frmReportVendas.aspx&quot;,&quot;&quot;,&quot;height=600px ,width=800px, status=no, scrollbars=yes, toolbar=no, menubar=no, resizable=yes, left=300px&quot;);
    Pop.focus();
}" />
                                                                </dxe:ASPxHyperLink>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </Template>
                                            </dxnb:NavBarItem>
                                        </Items>
                                    </dxnb:NavBarGroup>
                                </Groups>
                                <CollapseImage Height="18px" Width="18px" />
                                <ExpandImage Height="18px" Width="18px" />
    </dxnb:ASPxNavBar>

</asp:Content>


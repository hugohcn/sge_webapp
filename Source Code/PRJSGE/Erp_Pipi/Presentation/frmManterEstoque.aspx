<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmManterEstoque.aspx.cs"
    Inherits="Presentation.frmManterEstoque" Title="SGE - Gerenciar Estoque" %>

<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dxcp" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxNavBar" TagPrefix="dxnb" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3.Export" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dxwgv" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript">
    function OnSpinValidation(s, e) {
    var name = e.value;
    if (name == 0)
        e.isValid = false;
}
function OnRetirarClick(element, keyValue) {
        popUpRetirarProdutoEstoque.ShowAtElement(element);
        lblCodigoProduto.SetValue(keyValue);
    }
    </script>

    <div style="width: 100%;">
        <table cellpadding="0" style="border-collapse: collapse; width: 100%">
            <tr>
                <td style="width: 25%">
                    <dxe:ASPxButton ID="btnInserir" runat="server" AutoPostBack="False" ClientInstanceName="btnInserir"
                        CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange"
                        Text="Inserir" Width="150px">
                        <ClientSideEvents Click="function(s, e) {
	gdvEstoque.AddNewRow();
}" />
                    </dxe:ASPxButton>
                </td>
                <td style="width: 25%">
                </td>
                <td align="right" style="width: 25%; padding-right: 10px;">
                    <dxe:ASPxButton ID="btnEsportarXls" runat="server" ClientInstanceName="btnEsportarXls"
                        CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange"
                        OnClick="btnEsportarXls_Click" Text="Exportar para XLS" Width="150px">
                    </dxe:ASPxButton>
                </td>
                <td align="right" style="width: 10%">
                    <dxe:ASPxButton ID="btnExportarPdf" runat="server" ClientInstanceName="btnExportarPdf"
                        CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange"
                        OnClick="btnExportarPdf_Click" Text="Exportar para PDF" Width="150px">
                    </dxe:ASPxButton>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="center" colspan="4">
                    <dxwgv:ASPxGridView ID="gdvEstoque" runat="server" AutoGenerateColumns="False" ClientInstanceName="gdvEstoque"
                        CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange"
                        DataSourceID="odsEstoque" Width="100%" KeyFieldName="IdProduto" OnCellEditorInitialize="gdvEstoque_CellEditorInitialize"
                        OnCustomErrorText="gdvEstoque_CustomErrorText" OnHtmlRowPrepared="gdvEstoque_HtmlRowPrepared"
                        OnCustomCallback="gdvEstoque_CustomCallback" OnInitNewRow="gdvEstoque_InitNewRow"
                        OnRowInserting="gdvEstoque_RowInserting" 
                        onrowupdating="gdvEstoque_RowUpdating">
                        <Styles CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange"
                            GroupButtonWidth="28">
                            <Header ImageSpacing="5px" SortingImageSpacing="5px">
                            </Header>
                            <LoadingPanel ImageSpacing="10px">
                            </LoadingPanel>
                        </Styles>
                        <SettingsText EmptyDataRow="Não há produtos cadastrados no estoque." 
                            ConfirmDelete="Deseja realmente deletar este produto do estoque?" />
                        <Columns>
                            <dxwgv:GridViewDataTextColumn FieldName="IdProduto" VisibleIndex="0" 
                                Caption="Código">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataComboBoxColumn Caption="Produto" FieldName="IdProduto" 
                                VisibleIndex="1">
                                <PropertiesComboBox DataSourceID="odsProdutos" TextField="StrNome" 
                                    ValueField="IdProduto" ValueType="System.String">
                                    <ValidationSettings Display="Dynamic" ErrorText="">
                                        <ErrorFrameStyle>
                                            <ErrorTextPaddings PaddingRight="4px" />
                                            <Paddings Padding="3px" PaddingLeft="4px" />
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesComboBox>
                                <EditFormSettings Visible="False" />
                            </dxwgv:GridViewDataComboBoxColumn>
                            <dxwgv:GridViewDataDateColumn FieldName="Entrada" VisibleIndex="2" 
                                Caption="Data de Entrada">
                            </dxwgv:GridViewDataDateColumn>
                            <dxwgv:GridViewDataSpinEditColumn Caption="Quantidade Atual" 
                                FieldName="QuantidadeEntrada" VisibleIndex="3">
                                <PropertiesSpinEdit DisplayFormatString="g" LargeIncrement="1" MaxLength="5" 
                                    MaxValue="99999" NumberType="Integer">
                                    <ValidationSettings Display="Dynamic" ErrorText="">
                                        <ErrorFrameStyle>
                                            <ErrorTextPaddings PaddingRight="4px" />
                                            <Paddings Padding="3px" PaddingLeft="4px" />
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesSpinEdit>
                            </dxwgv:GridViewDataSpinEditColumn>
                            <dxwgv:GridViewDataSpinEditColumn FieldName="QuantidadeVendida" Visible="False" 
                                VisibleIndex="3">
                                <PropertiesSpinEdit DisplayFormatString="g" LargeIncrement="1" MaxLength="5" 
                                    MaxValue="99999" NumberType="Integer">
                                    <ValidationSettings Display="Dynamic" ErrorText="">
                                        <ErrorFrameStyle>
                                            <ErrorTextPaddings PaddingRight="4px" />
                                            <Paddings Padding="3px" PaddingLeft="4px" />
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesSpinEdit>
                            </dxwgv:GridViewDataSpinEditColumn>
                            <dxwgv:GridViewDataTextColumn VisibleIndex="5" FieldName="ValorVendaUnitario">
                                <PropertiesTextEdit DisplayFormatString="{0:n2}">
                                    <ValidationSettings Display="Dynamic" ErrorText="">
                                        <ErrorFrameStyle>
                                            <ErrorTextPaddings PaddingRight="4px" />
                                            <Paddings Padding="3px" PaddingLeft="4px" />
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesTextEdit>
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn FieldName="ValorCustoUnitario" VisibleIndex="4">
                                <PropertiesTextEdit DisplayFormatString="{0:n2}">
                                    <ValidationSettings Display="Dynamic" ErrorText="">
                                        <ErrorFrameStyle>
                                            <ErrorTextPaddings PaddingRight="4px" />
                                            <Paddings Padding="3px" PaddingLeft="4px" />
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesTextEdit>
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn FieldName="ValorTotalCusto" VisibleIndex="6" 
                                Caption="Valor Total de Custo">
                                <PropertiesTextEdit DisplayFormatString="{0:n2}">
                                </PropertiesTextEdit>
                                <EditFormSettings Visible="False" />
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Valor Total de Venda" FieldName="ValorTotalVenda"
                                VisibleIndex="7">
                                <PropertiesTextEdit DisplayFormatString="{0:n2}">
                                </PropertiesTextEdit>
                                <EditFormSettings Visible="False" />
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Retirada" ToolTip="Retirar produto do estoque"
                                VisibleIndex="8">
                                <PropertiesTextEdit DisplayFormatString="{0}">
                                    <Style Font-Names="Tahoma" Font-Size="9pt" Font-Underline="False" ForeColor="#FF9933"
                                        HorizontalAlign="Center">
                                        </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Visible="False" />
                                <DataItemTemplate>
                                    <a href="javascript:void(0);" onclick="OnRetirarClick(this, '<%# Container.KeyValue %>')">
                                        Efetuar Retirada</a>
                                </DataItemTemplate>
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewCommandColumn VisibleIndex="9">
                                <EditButton Visible="True" Text="Editar">
                                </EditButton>
                                <NewButton Text="Inserir">
                                </NewButton>
                                <DeleteButton Text="Excluir">
                                </DeleteButton>
                                <SelectButton Text="Selecionar">
                                </SelectButton>
                                <CancelButton Text="Cancelar">
                                </CancelButton>
                                <UpdateButton Text="Inserir">
                                </UpdateButton>
                                <ClearFilterButton Text="Apagar">
                                </ClearFilterButton>
                            </dxwgv:GridViewCommandColumn>
                        </Columns>
                        <SettingsLoadingPanel Text="" />
                        <Images ImageFolder="~/App_Themes/Soft Orange/{0}/">
                            <CollapsedButton Height="14px" Url="~/App_Themes/Soft Orange/GridView/gvCollapsedButton.png"
                                Width="13px" />
                            <ExpandedButton Height="13px" Url="~/App_Themes/Soft Orange/GridView/gvExpandedButton.png"
                                Width="13px" />
                            <DetailCollapsedButton Height="14px" Url="~/App_Themes/Soft Orange/GridView/gvCollapsedButton.png"
                                Width="13px" />
                            <DetailExpandedButton Height="13px" Url="~/App_Themes/Soft Orange/GridView/gvExpandedButton.png"
                                Width="13px" />
                            <HeaderFilter Height="19px" Url="~/App_Themes/Soft Orange/GridView/gvHeaderFilter.png"
                                Width="19px" />
                            <HeaderActiveFilter Height="19px" Url="~/App_Themes/Soft Orange/GridView/gvHeaderFilterActive.png"
                                Width="19px" />
                            <HeaderSortDown Height="3px" Url="~/App_Themes/Soft Orange/GridView/gvHeaderSortDown.png"
                                Width="6px" />
                            <HeaderSortUp Height="3px" Url="~/App_Themes/Soft Orange/GridView/gvHeaderSortUp.png"
                                Width="6px" />
                            <FilterRowButton Height="13px" Width="13px" />
                            <CustomizationWindowClose Height="18px" Width="18px" />
                            <PopupEditFormWindowClose Height="18px" Width="18px" />
                            <WindowResizer Height="12px" Url="~/App_Themes/Soft Orange/GridView/WindowResizer.png"
                                Width="12px" />
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
                        <SettingsDetail ShowDetailButtons="False" />
                        <Paddings Padding="1px" />
                        <Settings ShowFilterRow="True" />
                        <ImagesEditors>
                            <CalendarPrevYear Height="19px" Url="~/App_Themes/Soft Orange/Editors/edtCalendarPrevYear.png"
                                Width="23px" />
                            <CalendarPrevMonth Height="19px" Url="~/App_Themes/Soft Orange/Editors/edtCalendarPrevMonth.png"
                                Width="19px" />
                            <CalendarNextMonth Height="19px" Url="~/App_Themes/Soft Orange/Editors/edtCalendarNextMonth.png"
                                Width="19px" />
                            <CalendarNextYear Height="19px" Url="~/App_Themes/Soft Orange/Editors/edtCalendarNextYear.png"
                                Width="23px" />
                        </ImagesEditors>
                    </dxwgv:ASPxGridView>
                    <asp:ObjectDataSource ID="odsCalculosEstoque" runat="server" OldValuesParameterFormatString="original_{0}"
                        SelectMethod="GetData" TypeName="Presentation.reports.dsEstoqueTableAdapters.tblConsultaEstoqueTestTableAdapter">
                    </asp:ObjectDataSource>
                    <dxpc:ASPxPopupControl ID="popUpRetirarProdutoEstoque" runat="server" ClientInstanceName="popUpRetirarProdutoEstoque"
                        CloseAction="CloseButton" FooterText="" HeaderText="Informe valor a ser retirado"
                        Height="140px" Width="250px" ShowCloseButton="true">
                        <ContentCollection>
                            <dxpc:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                                <table cellpadding="2" cellspacing="3" style="width: 100%">
                                    <tr>
                                        <td align="left" style="width: 1%">
                                            Produto:
                                        </td>
                                        <td colspan="3" align="left">
                                            &nbsp;
                                            <dxe:ASPxLabel ID="lblCodigoProduto" runat="server" ClientInstanceName="lblCodigoProduto">
                                            </dxe:ASPxLabel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" align="left">
                                            Quantidade a ser retirada: &nbsp; &nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left" colspan="4">
                                            <dxe:ASPxSpinEdit ID="spQuantidadeRetirada" runat="server" ClientInstanceName="spQuantidadeRetirada"
                                                Height="21px" LargeIncrement="1" MaxLength="9" MaxValue="99999999" Number="0"
                                                NumberType="Integer">
                                                <ClientSideEvents Validation="function(s, e) {
	OnSpinValidation
}" />
                                                <ValidationSettings ErrorText="">
                                                    <ErrorFrameStyle>
                                                        <ErrorTextPaddings PaddingRight="4px" />
                                                        <Paddings Padding="3px" PaddingLeft="4px" />
                                                    </ErrorFrameStyle>
                                                    <RequiredField ErrorText="" IsRequired="True" />
                                                </ValidationSettings>
                                            </dxe:ASPxSpinEdit>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;
                                        </td>
                                        <td colspan="2">
                                            &nbsp;
                                            <dxcp:ASPxCallbackPanel ID="cbpProcessoRetirada" runat="server" ClientInstanceName="cbpProcessoRetirada"
                                                OnCallback="cbpProcessoRetirada_Callback" Width="200px">
                                                <ClientSideEvents EndCallback="function(s, e) {
	gdvEstoque.PerformCallback();
}" />
                                                <PanelCollection>
                                                    <dxp:PanelContent ID="PanelContent1" runat="server">
                                                    </dxp:PanelContent>
                                                </PanelCollection>
                                            </dxcp:ASPxCallbackPanel>
                                        </td>
                                        <td>
                                            &nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" colspan="2">
                                            <dxe:ASPxButton ID="btnRetirar" runat="server" AutoPostBack="False" Text="Retirar"
                                                Width="100px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                                                CssPostfix="Soft_Orange">
                                                <ClientSideEvents Click="function(s, e) {
	
	cbpProcessoRetirada.PerformCallback(spQuantidadeRetirada.GetText()+&quot;#&quot;+lblCodigoProduto.GetValue());
	spQuantidadeRetirada.SetValue(0);
	popUpRetirarProdutoEstoque.Hide();
}" />
                                            </dxe:ASPxButton>
                                        </td>
                                        <td align="right" colspan="2">
                                            <dxe:ASPxButton ID="btnCancelar" runat="server" AutoPostBack="False" ClientInstanceName="btnCancelar"
                                                Text="Cancelar" Width="100px" 
                                                CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange">
                                                <ClientSideEvents Click="function(s, e) {
	
	popUpRetirarProdutoEstoque.Hide();
	spQuantidadeRetirada.SetValue(0);
}" />
                                            </dxe:ASPxButton>
                                        </td>
                                    </tr>
                                </table>
                            </dxpc:PopupControlContentControl>
                        </ContentCollection>
                        <HeaderStyle Font-Bold="False" HorizontalAlign="Left" />
                    </dxpc:ASPxPopupControl>
                    <asp:ObjectDataSource ID="odsEstoque" runat="server" DataObjectTypeName="Entity.ENEstoque"
                        DeleteMethod="DeleteProdutoFromEstoque" InsertMethod="AddProdutoOnEstoque" SelectMethod="GetAllProdutosFromEstoque"
                        TypeName="Business.BUEstoque" UpdateMethod="UpdateProdutoFromEstoque" 
                        OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
                    <dxwgv:ASPxGridViewExporter ID="gvExporter" runat="server" FileName="Estoque" GridViewID="gdvEstoque">
                    </dxwgv:ASPxGridViewExporter>
                    <asp:ObjectDataSource ID="odsProdutos" runat="server" SelectMethod="GetAllProdutos"
                        TypeName="Business.BUProduto"></asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="odsProdutosById" runat="server" SelectMethod="GetProdutoById"
                        TypeName="Business.BUProduto">
                        <SelectParameters>
                            <asp:SessionParameter Name="idProduto" SessionField="idProduto" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="odsTipoProduto" runat="server" SelectMethod="GetAllTipoProduto"
                        TypeName="Business.BUTipoProduto"></asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="odsRevendedores" runat="server" SelectMethod="GetAllRevendedores"
                        TypeName="Business.BURevendedor"></asp:ObjectDataSource>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
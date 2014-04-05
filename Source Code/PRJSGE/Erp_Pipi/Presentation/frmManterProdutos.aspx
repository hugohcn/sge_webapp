<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmManterProdutos.aspx.cs"
    Inherits="Presentation.frmManterProdutos" Title="SGE - Gerenciar Produtos" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v8.3.Export" Namespace="DevExpress.Web.ASPxGridView.Export" TagPrefix="dxwgv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%;">
            <table cellpadding="0" style="border-collapse: collapse; width: 100%">
                <tr>
                    <td style="width: 25%">
                        <dxe:ASPxButton ID="btnInserirProduto" runat="server" 
                            ClientInstanceName="btnInserirProduto" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            Text="Inserir" Width="150px" AutoPostBack="False" AllowFocus="False">
                            <ClientSideEvents Click="function(s, e) {
	gdvProdutos.AddNewRow();
	txtCodigo.Focus();
}" />
                        </dxe:ASPxButton>
                    </td>
                    <td>
                    </td>
                    <td align="right" style="width: 25%; padding-right: 10px;">
                        <dxe:ASPxButton ID="btnExportarXls" runat="server" CausesValidation="False" ClientInstanceName="btnExportarXls"
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                            CssPostfix="Soft_Orange" OnClick="btnExportarXls_Click"
                            Text="Exportar para XLS" UseSubmitBehavior="False" Width="150px" 
                            AllowFocus="False">
                        </dxe:ASPxButton>
                    </td>
                    <td align="right" style="width: 10%">
                        <dxe:ASPxButton ID="btnExportarPdf" runat="server" CausesValidation="False" ClientInstanceName="btnExportarPdf"
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                            CssPostfix="Soft_Orange" OnClick="btnExportarPdf_Click"
                            Text="Exportar para PDF" UseSubmitBehavior="False" Width="150px" 
                            AllowFocus="False">
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
                        <dxwgv:ASPxGridView ID="gdvProdutos" runat="server" AutoGenerateColumns="False" 
                            ClientInstanceName="gdvProdutos" DataSourceID="odsProdutos" 
                            KeyFieldName="IdProduto" Width="100%" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                            CssPostfix="Soft_Orange" 
                            oncelleditorinitialize="gdvProdutos_CellEditorInitialize" 
                            oncustomerrortext="gdvProdutos_CustomErrorText">
                            <SettingsBehavior ConfirmDelete="True" />
                            <Styles CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                                CssPostfix="Soft_Orange" GroupButtonWidth="28">
                                <Header ImageSpacing="5px" SortingImageSpacing="5px">
                                </Header>
                                <LoadingPanel ImageSpacing="10px">
                                </LoadingPanel>
                            </Styles>
                            <SettingsText ConfirmDelete="Deseja realmente deletar este produto do sistema?" 
                                EmptyDataRow="Não há produtos cadastrados no sistema." />
                            <TotalSummary>
                                <dxwgv:ASPxSummaryItem DisplayFormat="Total de Produtos:" FieldName="IdProduto" 
                                    ShowInColumn="Id Produto" ShowInGroupFooterColumn="Id Produto" 
                                    SummaryType="Count" />
                            </TotalSummary>
                            <Columns>
                                <dxwgv:GridViewDataTextColumn Caption="Código" FieldName="IdProduto" 
                                    Name="txtCodigo" VisibleIndex="0">
                                    <PropertiesTextEdit ClientInstanceName="txtCodigo">
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Produto" FieldName="StrNome" 
                                    VisibleIndex="1">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataComboBoxColumn Caption="Tipo de Produto" 
                                    FieldName="IdTipoProduto" VisibleIndex="2">
                                    <PropertiesComboBox DataSourceID="odsTipoProduto" TextField="StrNome" 
                                        ValueField="IdTipoProduto" ValueType="System.String">
                                    </PropertiesComboBox>
                                </dxwgv:GridViewDataComboBoxColumn>
                                <dxwgv:GridViewDataComboBoxColumn Caption="Revendedor" FieldName="IdRevendedor" 
                                    VisibleIndex="3">
                                    <PropertiesComboBox DataSourceID="odsRevendedor" TextField="StrNome" 
                                        ValueField="IdRevendedor" ValueType="System.String">
                                    </PropertiesComboBox>
                                </dxwgv:GridViewDataComboBoxColumn>
                                <dxwgv:GridViewDataDateColumn FieldName="DteDataCadastro" VisibleIndex="4" 
                                    Caption="Data de Cadastro">
                                </dxwgv:GridViewDataDateColumn>
                                <dxwgv:GridViewCommandColumn VisibleIndex="5">
                                    <EditButton Text="Editar" Visible="True">
                                    </EditButton>
                                    <NewButton Text="Inserir">
                                    </NewButton>
                                    <DeleteButton Text="Excluir" Visible="True">
                                    </DeleteButton>
                                    <SelectButton Text="Selecionar">
                                    </SelectButton>
                                    <CancelButton Text="Cancelar">
                                    </CancelButton>
                                    <UpdateButton Text="Inserir">
                                    </UpdateButton>
                                    <ClearFilterButton Visible="True" text="Apagar">
                                    </ClearFilterButton>
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
                            <Paddings Padding="1px" />
                            <Settings ShowFooter="True" ShowFilterRow="True" />
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
                        <asp:ObjectDataSource ID="odsProdutos" runat="server" 
                            DataObjectTypeName="Entity.ENProduto" DeleteMethod="DeleteProduto" 
                            InsertMethod="CreateProduto" SelectMethod="GetAllProdutos" 
                            TypeName="Business.BUProduto" UpdateMethod="UpdateProduto">
                        </asp:ObjectDataSource>
                        <dxwgv:ASPxGridViewExporter ID="gdvExporter" runat="server" 
                            GridViewID="gdvProdutos" ReportHeader="{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Courier New;}{\f1\fnil\fcharset0 Times New Roman;}}
\viewkind4\uc1\pard\b\f0\fs28 Produtos\fs24\par
\b0\f1\fs20\par
}
" FileName="Produtos">
                        </dxwgv:ASPxGridViewExporter>
                        <asp:ObjectDataSource ID="odsTipoProduto" runat="server" SelectMethod="GetAllTipoProduto"
                            TypeName="Business.BUTipoProduto"></asp:ObjectDataSource>
                        <asp:ObjectDataSource ID="odsRevendedor" runat="server" SelectMethod="GetAllRevendedores"
                            TypeName="Business.BURevendedor"></asp:ObjectDataSource>
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
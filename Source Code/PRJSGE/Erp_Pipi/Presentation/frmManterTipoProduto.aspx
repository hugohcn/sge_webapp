<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmManterTipoProduto.aspx.cs"
    Inherits="Presentation.frmManterTipoProduto" Title="SGE - Gerenciar Tipos de Produtos" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v8.3.Export" namespace="DevExpress.XtraPivotGrid.Web" tagprefix="dxpgw" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3.Export" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dxwgv" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%;">
            <table cellpadding="0" style="border-collapse: collapse; width: 100%" 
                align="center">
                <tr>
                    <td style="width: 25%" align="left" valign="top">
                        <dxe:ASPxButton 
                            ID="btnInserirNovo" runat="server" 
                            ClientInstanceName="btnInserirNovo" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                            CssPostfix="Soft_Orange" Text="Inserir" Width="150px" AutoPostBack="False">
                            <ClientSideEvents Click="function(s, e) {
	gdvTipoProduto.AddNewRow();
}" />
                        </dxe:ASPxButton>
                    </td>
                    <td>&nbsp;
                    </td>
                    <td align="right" style="width: 25%; padding-right: 10px;">
                        <dxe:ASPxButton ID="btnExportarXLS" runat="server" 
                            ClientInstanceName="btnExportarXLS" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                            CssPostfix="Soft_Orange" onclick="btnExportarXLS_Click" 
                            Text="Exportar para XLS" Width="150px">
                        </dxe:ASPxButton>
                    </td>
                    <td align="right" style="width: 10%">
                        <dxe:ASPxButton ID="btnExportarPDF" runat="server" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                            CssPostfix="Soft_Orange" Text="Exportar para PDF" Width="150px" 
                            onclick="btnExportarPDF_Click">
                        </dxe:ASPxButton>
                    </td>
                </tr>
                <tr>
                    <td style="width: 25%">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td align="right" style="width: 25%">
                        &nbsp;</td>
                    <td align="right" style="width: 10%">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4" align="center">
                        <dxwgv:ASPxGridView ID="gdvTipoProduto" runat="server" 
                            AutoGenerateColumns="False" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                            CssPostfix="Soft_Orange" DataSourceID="odsTipoProduto" Width="100%" 
                            ClientInstanceName="gdvTipoProduto" KeyFieldName="IdTipoProduto" 
                            oncustomcallback="gdvTipoProduto_CustomCallback" 
                            oncustomerrortext="gdvTipoProduto_CustomErrorText"><SettingsBehavior ConfirmDelete="True" 
                                ColumnResizeMode="NextColumn" />
                            <SettingsEditing PopupEditFormHeight="200px" PopupEditFormHorizontalAlign="WindowCenter"
                                PopupEditFormModal="True" PopupEditFormVerticalAlign="WindowCenter" 
                                PopupEditFormWidth="800px" />
                            <Styles CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                                CssPostfix="Soft_Orange" groupbuttonwidth="28">
                                <Header ImageSpacing="5px" SortingImageSpacing="5px">
                                </Header>
                                <LoadingPanel ImageSpacing="10px">
                                </LoadingPanel>
                                <CommandColumnItem Font-Underline="False" ForeColor="#FF6600">
                                </CommandColumnItem>
                            </Styles>
                            <SettingsText ConfirmDelete="Deseja realmente deletar este tipo de produto do sistema?" 
                                EmptyDataRow="Não há tipos de produto cadastrados no sistema." />
                            <TotalSummary>
                                <dxwgv:ASPxSummaryItem FieldName="IdProduto" ShowInColumn="Produto" SummaryType="Sum" />
                            </TotalSummary>
                            <Columns>
                                <dxwgv:GridViewDataTextColumn Caption="Tipo de Produto" FieldName="StrNome" 
                                    VisibleIndex="0">
                                    <CellStyle HorizontalAlign="Left">
                                    </CellStyle>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewCommandColumn VisibleIndex="1">
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
                                    <ClearFilterButton Text="Apagar">
                                    </ClearFilterButton>
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dxwgv:GridViewCommandColumn>
                            </Columns>
                            <SettingsLoadingPanel Text="" />
                            <Images ImageFolder="~/App_Themes/Soft Orange/{0}/">
                                <CollapsedButton Height="14px" 
                                    Url="~/App_Themes/Soft Orange/GridView/gvCollapsedButton.png" 
                                    Width="11px" />
                                <ExpandedButton Height="13px" 
                                    Url="~/App_Themes/Soft Orange/GridView/gvExpandedButton.png" 
                                    Width="11px" />
                                <DetailCollapsedButton Height="14px" 
                                    Url="~/App_Themes/Soft Orange/GridView/gvCollapsedButton.png" 
                                    Width="11px" />
                                <DetailExpandedButton Height="13px" 
                                    Url="~/App_Themes/Soft Orange/GridView/gvExpandedButton.png" 
                                    Width="11px" />
                                <HeaderFilter Height="19px" 
                                    Url="~/App_Themes/Soft Orange/GridView/gvHeaderFilter.png" />
                                <HeaderActiveFilter Height="19px" 
                                    Url="~/App_Themes/Soft Orange/GridView/gvHeaderFilterActive.png" />
                                <HeaderSortDown Height="3px" 
                                    Url="~/App_Themes/Soft Orange/GridView/gvHeaderSortDown.png" />
                                <HeaderSortUp Height="3px" 
                                    Url="~/App_Themes/Soft Orange/GridView/gvHeaderSortUp.png" />
                                <FilterRowButton Height="13px" Width="13px" />
                                <CustomizationWindowClose Height="18px" />
                                <PopupEditFormWindowClose Height="18px" />
                                <WindowResizer Height="12px" 
                                    Url="~/App_Themes/Soft Orange/GridView/WindowResizer.png" />
                                <FilterBuilderClose Height="18px" />
                            </Images>
                            <SettingsPager>
                                <AllButton>
                                    <Image Height="19px" />
                                </AllButton>
                                <FirstPageButton>
                                    <Image Height="19px" />
                                </FirstPageButton>
                                <LastPageButton>
                                    <Image Height="19px" />
                                </LastPageButton>
                                <NextPageButton>
                                    <Image Height="19px" />
                                </NextPageButton>
                                <PrevPageButton>
                                    <Image Height="19px" />
                                </PrevPageButton>
                                <Summary AllPagesText="Páginas: {0} - {1} ({2} itens)" 
                                    Text="Página {0} de {1} ({2} itens)" />
                            </SettingsPager>
                            <Paddings Padding="1px" />
                            <ImagesEditors>
                                <CalendarPrevYear Height="19px" 
                                    Url="~/App_Themes/Soft Orange/Editors/edtCalendarPrevYear.png" />
                                <CalendarPrevMonth Height="19px" 
                                    Url="~/App_Themes/Soft Orange/Editors/edtCalendarPrevMonth.png" />
                                <CalendarNextMonth Height="19px" 
                                    Url="~/App_Themes/Soft Orange/Editors/edtCalendarNextMonth.png" />
                                <CalendarNextYear Height="19px" 
                                    Url="~/App_Themes/Soft Orange/Editors/edtCalendarNextYear.png" />
                            </ImagesEditors>
                        </dxwgv:ASPxGridView>
                        <asp:ObjectDataSource ID="odsTipoProduto" runat="server" 
                            DataObjectTypeName="Entity.ENTipoProduto" DeleteMethod="DeleteTipoProduto" 
                            InsertMethod="CreateTipoProduto" SelectMethod="GetAllTipoProduto" 
                            TypeName="Business.BUTipoProduto" UpdateMethod="UpdateTipoProduto">
                        </asp:ObjectDataSource>
                        <dxwgv:ASPxGridViewExporter ID="gvExporter" runat="server" 
                            GridViewID="gdvTipoProduto" FileName="Tipos de Produtos">
                        </dxwgv:ASPxGridViewExporter>
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmManterTipoCusto.aspx.cs"
    Inherits="Presentation.frmManterTipoCusto" Title="SGE - Gerenciar Tipos de Custos" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3.Export" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dxwgv" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%;">
            <table cellpadding="0" style="border-collapse: collapse; width: 100%">
                <tr>
                    <td style="width: 25%">
                        
                        <dxe:ASPxButton ID="btnInserir" runat="server" AutoPostBack="False" 
                            ClientInstanceName="btnInserir" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            Text="Inserir" UseSubmitBehavior="False" Width="150px">
                            <clientsideevents click="function(s, e) {
	gdvTipoProdutos.AddNewRow();
}" />
                        </dxe:ASPxButton>
                        
                    </td>
                    <td style="width: 25%">
                        
                    </td>
                    <td align="right" style="width:10%;">
                        
                        <dxe:ASPxButton ID="btnExportarXls" runat="server" 
                            ClientInstanceName="btnExportarXls" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            onclick="btnExportarXls_Click" Text="Exportar para XLS" Width="150px">
                        </dxe:ASPxButton>
                        
                    </td>
                    <td align="right" style="width: 10%">
                        
                        <dxe:ASPxButton ID="btnExportarPdf" runat="server" 
                            ClientInstanceName="btnExportarPdf" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            onclick="btnExportarPdf_Click" Text="Exportar para PDF" Width="150px">
                        </dxe:ASPxButton>
                        
                    </td>
                </tr>
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
                    <td align="center" colspan="4">
                        
                        <dxwgv:ASPxGridView ID="gdvTipoProdutos" runat="server" 
                            AutoGenerateColumns="False" ClientInstanceName="gdvTipoProdutos" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            DataSourceID="odsTipoCusto" Width="100%" KeyFieldName="IdTipoCusto" 
                            oncustomerrortext="gdvTipoProdutos_CustomErrorText">
                            <styles cssfilepath="~/App_Themes/Soft Orange/{0}/styles.css" 
                                csspostfix="Soft_Orange" groupbuttonwidth="28">
                                <Header ImageSpacing="5px" SortingImageSpacing="5px">
                                </Header>
                                <LoadingPanel ImageSpacing="10px">
                                </LoadingPanel>
                                <commandcolumnitem font-underline="False" forecolor="#FF6600">
                                </commandcolumnitem>
                            </styles>
                            <SettingsText ConfirmDelete="Deseja realmente deletar este tipo de custo do sistema?" 
                                EmptyDataRow="Não há tipos de custos cadastrados no sistema." />
                            <Columns>
                                <dxwgv:GridViewDataTextColumn Caption="Tipo de Custo" FieldName="StrNome" 
                                    VisibleIndex="0">
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
                                    <ClearFilterButton Visible="True" Text="Apagar">
                                    </ClearFilterButton>
                                </dxwgv:GridViewCommandColumn>
                            </Columns>
                            <settingsloadingpanel text="" />
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
                            <settingspager>
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
                            </settingspager>
                            <Paddings Padding="1px" />
                            <settings showfilterrow="True" />
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
                        <asp:ObjectDataSource ID="odsTipoCusto" runat="server" 
                            DataObjectTypeName="Entity.ENTipoCusto" DeleteMethod="Delete" 
                            InsertMethod="CreateTipoCusto" SelectMethod="GetAllTipoCusto" 
                            TypeName="Business.BUTipoCusto" UpdateMethod="UpdateTipoCusto"></asp:ObjectDataSource>
                        <dxwgv:ASPxGridViewExporter ID="gvExporter" runat="server" 
                            FileName="Tipos de Custos" GridViewID="gdvTipoProdutos">
                        </dxwgv:ASPxGridViewExporter>
                        
                    </td>
                </tr>
            </table>
    </div>
</asp:Content>


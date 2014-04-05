<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmManterRevendedor.aspx.cs"
    Inherits="Presentation.frmManterRevendedor" Title="SGE - Gerenciar Fornecedores" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3.Export" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxPopupControl" tagprefix="dxpc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%;">
    
        <table cellpadding="0" style="border-collapse: collapse; width: 100%">
            <tr>
                <td style="width: 25%">
                    <dxe:ASPxButton ID="btnInserir" runat="server" AutoPostBack="False" 
                        ClientInstanceName="btnInserir" 
                        CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                        Text="Inserir" Width="150px">
                        <ClientSideEvents Click="function(s, e) {
	gdvRevendedores.AddNewRow();
}" />
                    </dxe:ASPxButton>
                </td>
                <td style="width: 25%">
                </td>
                <td align="right" style="width: 25%; padding-right: 10px;">
                    <dxe:ASPxButton ID="btnExportarXls" runat="server" 
                        ClientInstanceName="btnExportarXls" 
                        CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                        onclick="btnExportarXls_Click" Text="Exportar para XLS" Width="150px">
                    </dxe:ASPxButton>
                </td>
                <td style="width: 10%">
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
                    <dxwgv:ASPxGridView ID="gdvRevendedores" runat="server" 
                        AutoGenerateColumns="False" ClientInstanceName="gdvRevendedores" 
                        CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                        DataSourceID="odsRevendedores" KeyFieldName="IdRevendedor" 
                        oncustomerrortext="gdvRevendedores_CustomErrorText" 
                        Width="100%">
                        <Styles CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                            CssPostfix="Soft_Orange" GroupButtonWidth="28">
                            <Header ImageSpacing="5px" SortingImageSpacing="5px">
                            </Header>
                            <LoadingPanel ImageSpacing="10px">
                            </LoadingPanel>
                            <CommandColumnItem Font-Underline="False" ForeColor="#FF6600">
                            </CommandColumnItem>
                        </Styles>
                        <SettingsText ConfirmDelete="Deseja realmente deletar este fornecedor do sistema?" 
                            EmptyDataRow="Não há fornecedores cadastrados no sistema." />
                        <Columns>
                            <dxwgv:GridViewDataTextColumn Caption="Nome" FieldName="StrNome" 
                                VisibleIndex="0">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Endereço" FieldName="StrEndereco" 
                                VisibleIndex="1">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Número" FieldName="IntNumero" 
                                VisibleIndex="2">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Bairro" FieldName="StrBairro" 
                                VisibleIndex="3">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Cidade" FieldName="StrCidade" 
                                VisibleIndex="4">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Estado" FieldName="StrEstado" 
                                VisibleIndex="5">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Cep" FieldName="StrCep" VisibleIndex="6">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Telefone" FieldName="StrTelefone" 
                                VisibleIndex="7">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Celular" FieldName="StrCelular" 
                                VisibleIndex="8">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn Caption="Fax" FieldName="StrFax" VisibleIndex="9">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataButtonEditColumn Caption="E-mail" FieldName="StrEmail" 
                                VisibleIndex="10">
                                <PropertiesButtonEdit ClientInstanceName="btnEmail" DisplayFormatString="{0}">
                                    
<ClientSideEvents ButtonClick="function(s, e) {
	popContatoRevendedor.Show();
}" />
                                    

<ButtonStyle>
                                        <BackgroundImage HorizontalPosition="center" ImageUrl="~/imgs/mail.jpg" 
                                            Repeat="NoRepeat" VerticalPosition="center" />
                                    </ButtonStyle>
                                    

<Style Font-Underline="False" ForeColor="#FF6600">
                                    </Style>
                                
</PropertiesButtonEdit>
                            </dxwgv:GridViewDataButtonEditColumn>
                            <dxwgv:GridViewCommandColumn VisibleIndex="11">
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
                            <summary text="Página {0} de {1} ({2} itens)" 
                                AllPagesText="Páginas: {0} - {1} ({2} itens)">
                            </summary>
                        </SettingsPager>
                        <Paddings Padding="1px" />
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
                    <asp:ObjectDataSource ID="odsRevendedores" runat="server" 
                        DataObjectTypeName="Entity.ENRevendedor" DeleteMethod="DeleteRevendedor" 
                        InsertMethod="CreateRevendedor" SelectMethod="GetAllRevendedores" 
                        TypeName="Business.BURevendedor" UpdateMethod="UpdateRevendedor">
                    </asp:ObjectDataSource>
                    <dxwgv:ASPxGridViewExporter ID="gvExporter" runat="server" 
                        FileName="Revendedores" GridViewID="gdvRevendedores">
                    </dxwgv:ASPxGridViewExporter>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
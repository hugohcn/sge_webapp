<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmManterClientes.aspx.cs"
    Inherits="Presentation.frmManterClientes" Title="SGE - Gerenciar Clientes" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3.Export" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dxwgv" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%;">
            <table cellpadding="0" style="border-collapse: collapse; width: 100%">
                <tr>
                    <td style="width: 25%">
                        <dxe:ASPxButton ID="btnInserirCliente" runat="server" AutoPostBack="False" 
                            ClientInstanceName="btnInserirCliente" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            Text="Inserir" UseSubmitBehavior="False" Width="150px">
                            <ClientSideEvents Click="function(s, e) {
	gdvClientes.AddNewRow();
}" />
                        </dxe:ASPxButton>
                    </td>
                    <td>
                    </td>
                    <td align="right" style="width: 25%; padding-right: 10px;">
                        <dxe:ASPxButton ID="btnExportarXls" runat="server" 
                            ClientInstanceName="btnExportarXls" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            onclick="btnExportarXls_Click" Text="Exportar para XLS" 
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
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="4">
                        <dxwgv:ASPxGridView ID="gdvClientes" runat="server" AutoGenerateColumns="False" 
                            ClientInstanceName="gdvClientes" DataSourceID="odsClientes" 
                            KeyFieldName="IdCliente" Width="100%" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                            CssPostfix="Soft_Orange" oncustomerrortext="gdvClientes_CustomErrorText">
                            <Templates>
                                <DetailRow>
                                    <dxwgv:ASPxGridView ID="gdvCarteiraCliente" runat="server" 
                                        AutoGenerateColumns="False" ClientInstanceName="gdvCarteiraCliente" 
                                        CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                                        DataSourceID="odsCarteiraCliente" 
                                        onbeforeperformdataselect="gdvCarteiraCliente_BeforePerformDataSelect" 
                                        Width="100%">
                                        <Styles CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                                            CssPostfix="Soft_Orange" GroupButtonWidth="28">
                                            <Header ImageSpacing="5px" SortingImageSpacing="5px">
                                            </Header>
                                            <LoadingPanel ImageSpacing="10px">
                                            </LoadingPanel>
                                        </Styles>
                                        <Columns>
                                            <dxwgv:GridViewDataTextColumn Caption="Valor Devido" FieldName="FltValorTotal" 
                                                VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataDateColumn Caption="Data de Pagamento" 
                                                FieldName="DteDataPagamento" VisibleIndex="1">
                                            </dxwgv:GridViewDataDateColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Valor de Crédito" FieldName="FltValorCredito" 
                                                VisibleIndex="2">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataCheckColumn Caption="Status da Carteira" 
                                                FieldName="BitStatusCarteira" VisibleIndex="3">
                                            </dxwgv:GridViewDataCheckColumn>
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
                                        </SettingsPager>
                                        <SettingsDetail IsDetailGrid="True" ShowDetailButtons="False" />
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
                                </DetailRow>
                            </Templates>
                            <Styles CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                                CssPostfix="Soft_Orange" GroupButtonWidth="28">
                                <Header ImageSpacing="5px" SortingImageSpacing="5px">
                                </Header>
                                <LoadingPanel ImageSpacing="10px">
                                </LoadingPanel>
                                <CommandColumnItem Font-Underline="False" ForeColor="#FF6600">
                                </CommandColumnItem>
                            </Styles>
                            <SettingsText EmptyDataRow="Não há clientes cadastrados no momento." 
                                ConfirmDelete="Deseja realmente deletar este cliente?" />
                            <Columns>
                                <dxwgv:GridViewDataTextColumn FieldName="IdCliente" Visible="False" 
                                    VisibleIndex="0">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Nome" FieldName="StrNome" 
                                    VisibleIndex="0">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Endereço" FieldName="StrEndereco" 
                                    VisibleIndex="1">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Número" FieldName="IntNumero" 
                                    VisibleIndex="2">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Bairro" FieldName="StrBairro" 
                                    VisibleIndex="3">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Cidade" FieldName="StrCidade" 
                                    VisibleIndex="4">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Estado" FieldName="StrEstado" 
                                    VisibleIndex="5">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Cep" FieldName="StrCep" VisibleIndex="6">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="E-mail" FieldName="StrEmail" 
                                    VisibleIndex="7">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                            <RequiredField ErrorText="" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Telefone" FieldName="StrTelefone" 
                                    VisibleIndex="8">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Celular" FieldName="StrCelular" 
                                    VisibleIndex="9">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Fax" FieldName="StrFax" 
                                    VisibleIndex="10">
                                    <PropertiesTextEdit>
                                        <ValidationSettings ErrorText="">
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewCommandColumn VisibleIndex="11">
                                    <EditButton Visible="True" Text="Editar">
                                    </EditButton>
                                    <NewButton Text="Inserir">
                                    </NewButton>
                                    <DeleteButton Visible="True" Text="Excluir">
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
                                <Summary AllPagesText="Páginas: {0} - {1} ({2} itens)" 
                                    Text="Página {0} de {1} ({2} itens)" />
                            </SettingsPager>
                            <SettingsDetail ShowDetailRow="True" />
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
                        <asp:ObjectDataSource ID="odsClientes" runat="server" 
                            DataObjectTypeName="Entity.ENCliente" DeleteMethod="Delete" 
                            InsertMethod="CreateUsuario" SelectMethod="GetAllClientes" 
                            TypeName="Business.BUCliente" UpdateMethod="UpdateCliente">
                        </asp:ObjectDataSource>
                        <asp:ObjectDataSource ID="odsCarteiraCliente" runat="server" 
                            SelectMethod="GetCarteiraByIdCliente" TypeName="Business.BUCarteira">
                            <SelectParameters>
                                <asp:SessionParameter Name="idCliente" SessionField="idCliente" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                        <dxwgv:ASPxGridViewExporter ID="gvExporter" runat="server" FileName="Clientes" 
                            GridViewID="gdvClientes">
                        </dxwgv:ASPxGridViewExporter>
                    <br />
                    </td>
                </tr>
            </table>
    </div>
</asp:Content>

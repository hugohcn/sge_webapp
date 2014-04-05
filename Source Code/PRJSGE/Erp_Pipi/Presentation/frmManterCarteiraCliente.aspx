<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmManterCarteiraCliente.aspx.cs"
    Inherits="Presentation.frmManterCarteiraCliente" Title="SGE - Gerenciar Carteiras" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxPopupControl" tagprefix="dxpc" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxCallbackPanel" tagprefix="dxcp" %>
<%@ Register assembly="DevExpress.Web.v8.3" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v8.3.Export" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dxwgv" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript">
function OnMoreInfoClick(element, keyValue) 
    {
        var eKey = keyValue;
        popValorPago.ShowAtElement(element);
        cpPopValorPago.PerformCallback(eKey);
    }
</script>
    <div style="width: 100%;">
            <table cellpadding="0" style="border-collapse: collapse; width: 100%">
                <tr>
                    <td style="width: 25%">
                        
                        <dxe:ASPxButton ID="btnInserir" runat="server" AutoPostBack="False" 
                            ClientInstanceName="btnInserir" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            Text="Inserir" UseSubmitBehavior="False" Width="150px">
                            <ClientSideEvents Click="function(s, e) {
	gdvCarteiras.AddNewRow();
}" />
                        </dxe:ASPxButton>
                        
                    </td>
                    <td style="width: 25%">
                    </td>
                    <td style="width: 25%; padding-right: 10px;" align="right">
                        <dxe:ASPxButton ID="btnExportarXls" runat="server" 
                            ClientInstanceName="btnExportarXls" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            Text="Exportar para XLS" Width="150px" onclick="btnExportarXls_Click">
                        </dxe:ASPxButton>
                    </td>
                    <td style="width: 10%" align="right">
                        <dxe:ASPxButton ID="btnExportarPdf" runat="server" 
                            ClientInstanceName="btnExportarPdf" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            Text="Exportar para PDF" Width="150px" onclick="btnExportarPdf_Click">
                        </dxe:ASPxButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" colspan="4">
                        
                        <dxwgv:ASPxGridView ID="gdvCarteiras" runat="server" 
                            AutoGenerateColumns="False" ClientInstanceName="gdvCarteiras" 
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            DataSourceID="odsCarteiras" KeyFieldName="IdCarteira" 
                            onhtmlrowprepared="gdvCarteiras_HtmlRowPrepared" 
                            PreviewFieldName="DteDataPagamento" Width="100%" 
                            oncustomcallback="gdvCarteiras_CustomCallback" 
                            oncustomerrortext="gdvCarteiras_CustomErrorText">
                            <SettingsBehavior ColumnResizeMode="NextColumn" />
                            <Styles CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                                CssPostfix="Soft_Orange" GroupButtonWidth="28">
                                <Header ImageSpacing="5px" SortingImageSpacing="5px">
                                </Header>
                                <LoadingPanel ImageSpacing="10px">
                                </LoadingPanel>
                                <CommandColumnItem Font-Underline="False" ForeColor="#FF6600">
                                </CommandColumnItem>
                            </Styles>
                            <SettingsText CustomizationWindowCaption="Valor pago" 
                                emptydatarow="Não há carteiras registradas no sistema." 
                                ConfirmDelete="Deseja realmente deletar esta carteira do sistema?" />
                            <Columns>
                                <dxwgv:GridViewDataComboBoxColumn Caption="Cliente" FieldName="IdCliente" 
                                    VisibleIndex="0">
                                    <PropertiesComboBox DataSourceID="odsClientes" TextField="StrNome" 
                                        ValueField="IdCliente" ValueType="System.String">
                                    </PropertiesComboBox>
                                </dxwgv:GridViewDataComboBoxColumn>
                                <dxwgv:GridViewDataTextColumn FieldName="FltValorTotal" VisibleIndex="1" 
                                    Caption="Valor Devido">
                                    <PropertiesTextEdit DisplayFormatString="{0:n2}">
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataDateColumn FieldName="DteDataPagamento" VisibleIndex="2" 
                                    Caption="Data de Pagamento">
                                </dxwgv:GridViewDataDateColumn>
                                <dxwgv:GridViewDataTextColumn FieldName="FltValorCredito" VisibleIndex="3" 
                                    Caption="Valor de Crédito">
                                    <PropertiesTextEdit DisplayFormatString="{0:n2}">
                                    </PropertiesTextEdit>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataCheckColumn FieldName="BitStatusCarteira" VisibleIndex="4" 
                                    Caption="Em Débito?">
                                </dxwgv:GridViewDataCheckColumn>
                                <dxwgv:GridViewCommandColumn VisibleIndex="5">
                                    <EditButton Visible="True" Text="Editar">
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
                                    <ClearFilterButton Visible="True">
                                    </ClearFilterButton>
                                </dxwgv:GridViewCommandColumn>
                                <dxwgv:GridViewDataTextColumn VisibleIndex="6" Caption="Transação" 
                                    ShowInCustomizationForm="False">
                                    <EditFormSettings Visible="False" />
                                    <DataItemTemplate>
                                        <a class="lnkGrid" href="javascript:void(0)" 
                                            onclick="OnMoreInfoClick(this,'<%# Container.KeyValue %>')">Efetuar Baixa</a></DataItemTemplate>
                                </dxwgv:GridViewDataTextColumn>
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
                                    Text="Páginas {0} de {1} ({2} itens)" />
                            </SettingsPager>
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
                            <SettingsCustomizationWindow Enabled="True" PopupHorizontalAlign="WindowCenter" 
                                PopupVerticalAlign="WindowCenter" />
                        </dxwgv:ASPxGridView>
                        <asp:ObjectDataSource ID="odsClientes" runat="server" 
                            SelectMethod="GetAllClientes" TypeName="Business.BUCliente">
                        </asp:ObjectDataSource>
                        <asp:ObjectDataSource ID="odsCarteiras" runat="server" 
                            SelectMethod="GetAllCarteiraClientes" TypeName="Business.BUCarteira" 
                            DataObjectTypeName="Entity.ENCarteira" DeleteMethod="DeleteCarteira" 
                            InsertMethod="CreateCarteira" UpdateMethod="UpdateCarteira">
                        </asp:ObjectDataSource>
                        
                        <dxwgv:ASPxGridViewExporter ID="gvExporter" runat="server" 
                            FileName="Carteira de Clientes" GridViewID="gdvCarteiras">
                        </dxwgv:ASPxGridViewExporter>
                        
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="4">
                        
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="left" colspan="4">
                        
                        <dxpc:ASPxPopupControl ID="popValorPago" runat="server" 
                            ClientInstanceName="popValorPago" CloseAction="CloseButton" FooterText="" 
                            HeaderText="Valor Pago" Height="180px" Width="280px">
                            <ContentCollection>
<dxpc:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
    <dxcp:ASPxCallbackPanel ID="cpPopValorPago" runat="server" 
        ClientInstanceName="cpPopValorPago" Height="100%" LoadingPanelText="" 
        Width="100%" OnCallback="cpPopValorPago_Callback">
        <panelcollection>
            <dxp:PanelContent ID="PanelContent1" runat="server">
                <table align="center" cellpadding="0" width="100%">
                    <tr>
                        <td align="center">
                            <dxe:ASPxTextBox ID="txtValorPago" ClientInstanceName="txtValorPago" 
                                runat="server" Width="170px" MaxLength="10">
                                <ClientSideEvents Validation="function(s, e) {
    var name = e.value;
    if (name == null)
        e.isValid = false;
	if (name &lt; 0)
		e.isValid = false;
}" />
                                <ValidationSettings CausesValidation="True" Display="Dynamic" ErrorText="" 
                                    SetFocusOnError="True">
                                    <ErrorFrameStyle>
                                        <ErrorTextPaddings PaddingRight="4px" />
                                        <Paddings Padding="3px" PaddingLeft="4px" />
                                    </ErrorFrameStyle>
                                    <RegularExpression ErrorText="" />
                                    <RequiredField ErrorText="" IsRequired="True" />
                                </ValidationSettings>
                            </dxe:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center">
                            <dxe:ASPxButton ID="btnBaixa" runat="server" 
                                ClientInstanceName="btnBaixa" 
                                CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                                Text="Gerar baixa" Width="150px" AutoPostBack="False">
                                <ClientSideEvents Click="function(s, e) {
	gdvCarteiras.PerformCallback(txtValorPago.GetValue());
	popValorPago.Hide();
}" />
                            </dxe:ASPxButton>
                        </td>
                    </tr>
                </table>
            </dxp:PanelContent>
        </panelcollection>
    </dxcp:ASPxCallbackPanel>
                                </dxpc:PopupControlContentControl>
</ContentCollection>
                        </dxpc:ASPxPopupControl>
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmManterPerfil.aspx.cs"
    Inherits="Presentation.frmManterPerfil" Title="SGE - Perfil" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.3" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div style="text-align: center">
    <table cellpadding="0" border="0" cellspacing="2" width="80%" style="margin-left: 10px;
        color: #ef643c; font-family: Arial; font-size: 9pt; text-align: left;">
        <tr>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblNome" runat="server" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" Text="Nome">
                </dxe:ASPxLabel>
            </td>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblEndereco" runat="server" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" Text="Endereço">
                </dxe:ASPxLabel>
            </td>
        </tr>
        <tr>
            <td>
                <dxe:ASPxTextBox ID="txtNome" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="70" ClientInstanceName="txtNome">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RegularExpression ErrorText="" />
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                    <ClientSideEvents Validation="function(s, e) {
	var name = e.value;
    if (name == null)
        e.isValid = false;
}" />
                </dxe:ASPxTextBox>
            </td>
            <td>
                <dxe:ASPxTextBox ID="txtEndereco" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="70">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RegularExpression ErrorText="" />
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                    <ClientSideEvents Validation="function(s, e) {
	var name = e.value;
    if (name == null)
        e.isValid = false;
}" />
                </dxe:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblNumero" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                    CssPostfix="Aqua" Text="Número">
                </dxe:ASPxLabel>
            </td>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblBairro" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                    CssPostfix="Aqua" Text="Bairro">
                </dxe:ASPxLabel>
            </td>
        </tr>
        <tr>
            <td>
                <dxe:ASPxTextBox ID="txtNumero" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="5">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RegularExpression ErrorText="" />
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                    <ClientSideEvents Validation="function(s, e) {
	var name = e.value;
    if (name == null)
        e.isValid = false;
}" />
                </dxe:ASPxTextBox>
            </td>
            <td>
                <dxe:ASPxTextBox ID="txtBairro" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="40">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                    <ClientSideEvents Validation="function(s, e) {
	var name = e.value;
    if (name == null)
        e.isValid = false;
}" />
                </dxe:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblCidade" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                    CssPostfix="Aqua" Text="Cidade">
                </dxe:ASPxLabel>
            </td>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblEstado" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                    CssPostfix="Aqua" Text="Estado">
                </dxe:ASPxLabel>
            </td>
        </tr>
        <tr>
            <td>
                <dxe:ASPxTextBox ID="txtCidade" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="40">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RegularExpression ErrorText="" />
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                    <ClientSideEvents Validation="function(s, e) {
	var name = e.value;
    if (name == null)
        e.isValid = false;
}" />
                </dxe:ASPxTextBox>
            </td>
            <td>
                <dxe:ASPxTextBox ID="txtEstado" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="40">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RegularExpression ErrorText="" />
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                    <ClientSideEvents Validation="function(s, e) {
	var name = e.value;
    if (name == null)
        e.isValid = false;
}" />
                </dxe:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblCep" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                    CssPostfix="Aqua" Text="Código Postal">
                </dxe:ASPxLabel>
            </td>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblTelefone" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                    CssPostfix="Aqua" Text="Telefone">
                </dxe:ASPxLabel>
            </td>
        </tr>
        <tr>
            <td>
                <dxe:ASPxTextBox ID="txtCep" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="10">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RegularExpression ErrorText="" />
                        <RequiredField ErrorText="" />
                    </ValidationSettings>
                </dxe:ASPxTextBox>
            </td>
            <td>
                <dxe:ASPxTextBox ID="txtTelefone" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="14">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RegularExpression ErrorText="" />
                        <RequiredField ErrorText="" />
                    </ValidationSettings>
                </dxe:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblCelular" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                    CssPostfix="Aqua" Text="Celular">
                </dxe:ASPxLabel>
            </td>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblFax" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                    CssPostfix="Aqua" Text="Fax">
                </dxe:ASPxLabel>
            </td>
        </tr>
        <tr>
            <td>
                <dxe:ASPxTextBox ID="txtCelular" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="14">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RegularExpression ErrorText="" />
                        <RequiredField ErrorText="" />
                    </ValidationSettings>
                </dxe:ASPxTextBox>
            </td>
            <td>
                <dxe:ASPxTextBox ID="txtFax" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="14">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RegularExpression ErrorText="" />
                        <RequiredField ErrorText="" />
                    </ValidationSettings>
                </dxe:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-left: 4px;">
                <dxe:ASPxLabel ID="lblEmail" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                    CssPostfix="Aqua" Text="E-mail">
                </dxe:ASPxLabel>
            </td>
            <td style="padding-left: 4px;">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <dxe:ASPxTextBox ID="txtEmail" runat="server" Width="280px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" MaxLength="90">
                    <ValidationSettings>
                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                        <RegularExpression ErrorText="" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                    <ClientSideEvents Validation="function(s, e) {
	var name = e.value;
    if (name == null)
        e.isValid = false;
}" />
                </dxe:ASPxTextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td align="right">
                <dxe:ASPxButton ID="btnAtualizar" runat="server" 
                    ClientInstanceName="btnAtualizar" 
                    CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                    onclick="btnAtualizar_Click" Text="Atualizar" UseSubmitBehavior="False" 
                    Width="150px">
                </dxe:ASPxButton>
            </td>
            <td>
                <dxe:ASPxButton ID="btnCancelar" runat="server" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                    CssPostfix="Soft_Orange" Text="Cancelar" Width="150px" 
                    ClientInstanceName="btnCancelar" UseSubmitBehavior="False" 
                    PostBackUrl="~/frmAmbiente.aspx">
                </dxe:ASPxButton>
            </td>
        </tr>
    </table>
    </div>
</asp:Content>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="Presentation.controls.login" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.3" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v8.3" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<%@ Register src="rodape.ascx" tagname="rodape" tagprefix="uc1" %>
<%@ Register src="cabecalho.ascx" tagname="cabecalho" tagprefix="uc2" %>

<style type="text/css">
    .style1
    {
        border-collapse: collapse;
        width: 100%;
    }
</style>

<script language="javascript" type="text/javascript">
function OnLoginValidation(s, e) {
    var name = e.value;
    if (name == null)
        e.isValid = false;
}

function OnPassValidation(s, e) {
    var name = e.value;
    if (name == null)
        e.isValid = false;
}

function OnEmailValidation(s, e) {
    var name = e.value;
    if (name == null)
        e.isValid = false;
}

function OnCpfValidation(s, e) {
    var name = e.value;
    if (name == null)
        e.isValid = false;
}
</script>
<table cellpadding="0" width="100%">
    <tr>
        <td align="center" height="400px" valign="middle">
            <table align="center" cellspacing="2" cellpadding="0" width="100%">
                <tr>
                    <td valign="top">
                        <uc2:cabecalho ID="cabecalho1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        &nbsp;
                        <dxrp:ASPxRoundPanel ID="panelLogin" runat="server" ClientInstanceName="panelLogin"
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                            CssPostfix="Soft_Orange" HeaderText="Login - Módulo Administrativo"
                            Width="400px">
                            <TopEdge BackColor="White">
                                <BackgroundImage ImageUrl="~/App_Themes/Soft Orange/Web/rpTopEdge.gif" />
                            </TopEdge>
                            <LeftEdge BackColor="White">
                                <BackgroundImage HorizontalPosition="left" 
                                    ImageUrl="~/App_Themes/Soft Orange/Web/rpLeftEdge.gif" Repeat="RepeatY" />
                            </LeftEdge>
                            <BottomRightCorner Height="9px" 
                                Url="~/App_Themes/Soft Orange/Web/rpBottomRightCorner.png" />
                            <ContentPaddings PaddingBottom="10px" PaddingLeft="12px" PaddingTop="10px" />
                            <NoHeaderTopRightCorner Height="9px" 
                                Url="~/App_Themes/Soft Orange/Web/rpNoHeaderTopRightCorner.png" />
                            <RightEdge BackColor="White">
                                <BackgroundImage HorizontalPosition="right" 
                                    ImageUrl="~/App_Themes/Soft Orange/Web/rpRightEdge.gif" Repeat="RepeatY" />
                            </RightEdge>
                            <HeaderRightEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Soft Orange/Web/rpHeaderRightEdge.gif" 
                                    Repeat="NoRepeat" VerticalPosition="bottom" />
                            </HeaderRightEdge>
                            <Border BorderStyle="None" />
                            <Content BackColor="White">
                            </Content>
                            <HeaderLeftEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Soft Orange/Web/rpHeaderLeftEdge.gif" 
                                    Repeat="NoRepeat" VerticalPosition="bottom" />
                            </HeaderLeftEdge>
                            <HeaderStyle BackColor="#F9F9F9" Height="24px">
                            <Paddings PaddingBottom="1px" PaddingLeft="12px" PaddingTop="1px" />
                            <BackgroundImage ImageUrl="~/App_Themes/Soft Orange/Web/rpHeaderBack.gif" 
                                Repeat="RepeatX" VerticalPosition="bottom" />
                            <Border BorderStyle="None" />
                            </HeaderStyle>
                            <BottomEdge BackColor="White">
                                <BackgroundImage ImageUrl="~/App_Themes/Soft Orange/Web/rpBottomEdge.gif" 
                                    Repeat="RepeatX" VerticalPosition="bottom" />
                            </BottomEdge>
                            <TopRightCorner Height="9px" 
                                Url="~/App_Themes/Soft Orange/Web/rpTopRightCorner.png" />
                            <HeaderContent>
                                <BackgroundImage ImageUrl="~/App_Themes/Soft Orange/Web/rpHeaderBack.gif" 
                                    Repeat="RepeatX" VerticalPosition="bottom" />
                            </HeaderContent>
                            <NoHeaderTopEdge BackColor="White">
                                <BackgroundImage ImageUrl="~/App_Themes/Soft Orange/Web/rpNoHeaderTopEdge.gif" />
                            </NoHeaderTopEdge>
                            <NoHeaderTopLeftCorner Height="9px" 
                                Url="~/App_Themes/Soft Orange/Web/rpNoHeaderTopLeftCorner.png" />
                            <PanelCollection>
                                <dxp:PanelContent runat="server">
                                    <table cellpadding="0" width="100%" cellspacing="2">
                                        <tr>
                                            <td align="left">
                                                <dxe:ASPxLabel ID="lblLogin" runat="server" Text="Login:" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                                                    CssPostfix="Aqua">
                                                </dxe:ASPxLabel>
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td align="left">
                                                <dxe:ASPxTextBox ID="txtLogin" runat="server" Width="150px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                                                    CssPostfix="Soft_Orange">
                                                    <ClientSideEvents Validation="function(s, e) {
	OnLoginValidation
}" />
                                                    <ValidationSettings SetFocusOnError="True" ErrorText="">
                                                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                                                        <ErrorFrameStyle ImageSpacing="4px">
                                                            <ErrorTextPaddings PaddingLeft="4px" />
                                                        </ErrorFrameStyle>
                                                        <RequiredField ErrorText="" IsRequired="True" />
                                                    </ValidationSettings>
                                                </dxe:ASPxTextBox>
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left">
                                                <dxe:ASPxLabel ID="lblSenha" runat="server" Text="Senha:" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                                                    CssPostfix="Aqua">
                                                </dxe:ASPxLabel>
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td align="left">
                                                <dxe:ASPxTextBox ID="txtSenha" runat="server" Width="150px" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                                                    CssPostfix="Soft_Orange" ClientInstanceName="txtSenha" MaxLength="8" 
                                                    Password="True">
                                                    <ClientSideEvents Validation="function(s, e) {
	OnPassValidation
}" />
                                                    <ValidationSettings ErrorText="">
                                                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                                                        <ErrorFrameStyle ImageSpacing="4px">
                                                            <ErrorTextPaddings PaddingLeft="4px" />
                                                        </ErrorFrameStyle>
                                                        <RequiredField ErrorText="" IsRequired="True" />
                                                    </ValidationSettings>
                                                </dxe:ASPxTextBox>
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
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left">
                                                <dxe:ASPxHyperLink ID="lnkRecuperarSenha" runat="server" ClientInstanceName="lnkRecuperarSenha"
                                                    CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" 
                                                    CssPostfix="Soft_Orange" Font-Underline="False"
                                                    Text="Recuperar Senha" NavigateUrl="javascript:void(0)">
                                                    <ClientSideEvents Click="function(s, e) {
	alert('Link temporáriamente sem funcionalidade.');
//	popRecuperarSenha.Show();
}" />
                                                </dxe:ASPxHyperLink>
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td align="center">
                                                <dxe:ASPxButton ID="btnLogin" runat="server" ClientInstanceName="btnLogin" CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css"
                                                    CssPostfix="Soft_Orange" Text="Login" OnClick="btnLogin_Click">
                                                </dxe:ASPxButton>
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </dxp:PanelContent>
                            </PanelCollection>
                            <TopLeftCorner Height="9px" 
                                Url="~/App_Themes/Soft Orange/Web/rpTopLeftCorner.png" />
                            <BottomLeftCorner Height="9px" 
                                Url="~/App_Themes/Soft Orange/Web/rpBottomLeftCorner.png" />
                        </dxrp:ASPxRoundPanel>
                        <br />
                        <br />
                        <dxpc:ASPxPopupControl ID="popRecuperarSenha" runat="server" AllowDragging="True"
                            AppearAfter="100" ClientInstanceName="popRecuperarSenha" CloseAction="CloseButton"
                            CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                            DisappearAfter="150" FooterText="" HeaderText="Recuperar Senha" Height="180px"
                            ImageFolder="~/App_Themes/Soft Orange/{0}/" Modal="True" PopupAction="None"
                            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
                            Width="400px">
                            <SizeGripImage Height="12px" />
                            <ContentCollection>
                                <dxpc:PopupControlContentControl runat="server">
                                    <table cellpadding="0" width="100%">
                                        <tr>
                                            <td align="left">
                                                <dxe:ASPxLabel ID="lblEmail" runat="server" ClientInstanceName="lblEmail" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                                                    CssPostfix="Aqua" Text="E-mail:">
                                                </dxe:ASPxLabel>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                <dxe:ASPxTextBox ID="txtEmail" runat="server" ClientInstanceName="txtEmail" 
                                                    CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                                                    MaxLength="90" ToolTip="E-mail do Usuário" Width="150px">
                                                    <ClientSideEvents Validation="function(s, e) {
	OnEmailValidation
}" />
                                                    <ValidationSettings ErrorText="" SetFocusOnError="True">
                                                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                                                        <ErrorFrameStyle ImageSpacing="4px">
                                                            <ErrorTextPaddings PaddingLeft="4px" />
                                                        </ErrorFrameStyle>
                                                        <RegularExpression ErrorText="" 
                                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                                        <RequiredField ErrorText="" IsRequired="True" />
                                                    </ValidationSettings>
                                                </dxe:ASPxTextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="left">
                                                <dxe:ASPxLabel ID="lblCpf" runat="server" ClientInstanceName="lblCpf" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                                                    CssPostfix="Aqua" Text="Cpf:">
                                                </dxe:ASPxLabel>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                <dxe:ASPxTextBox ID="txtCpf" runat="server" ClientInstanceName="txtCpf" 
                                                    CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                                                    MaxLength="11" ToolTip="Cpf do Usuário (sem números)" Width="150px">
                                                    <ClientSideEvents Validation="function(s, e) {
	OnCpfValidation
}" />
                                                    <ValidationSettings ErrorText="">
                                                        <ErrorImage Height="14px" Url="~/App_Themes/Soft Orange/Editors/edtError.png" />
                                                        <ErrorFrameStyle ImageSpacing="4px">
                                                            <ErrorTextPaddings PaddingLeft="4px" />
                                                        </ErrorFrameStyle>
                                                        <RegularExpression ErrorText="" />
                                                        <RequiredField ErrorText="" IsRequired="True" />
                                                    </ValidationSettings>
                                                </dxe:ASPxTextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="left">
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp; &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="left">
                                                &nbsp;
                                            </td>
                                            <td align="center">
                                                &nbsp;</td>
                                            <td align="center">
                                                <dxe:ASPxButton ID="btnRecuperar" runat="server" AutoPostBack="False" 
                                                    ClientInstanceName="btnRecuperar" 
                                                    CssFilePath="~/App_Themes/Soft Orange/{0}/styles.css" CssPostfix="Soft_Orange" 
                                                    Text="Recuperar senha">
                                                </dxe:ASPxButton>
                                            </td>
                                            <td align="center">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </dxpc:PopupControlContentControl>
                            </ContentCollection>
                            <CloseButtonImage Height="18px" />
                            <HeaderStyle >
                            <Paddings PaddingBottom="3px" PaddingTop="3px" />
                            </HeaderStyle>
                        </dxpc:ASPxPopupControl>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <table align="center" cellpadding="0" class="style1">
                <tr>
                    <td align="left">
                        <uc1:rodape ID="rodape1" runat="server" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

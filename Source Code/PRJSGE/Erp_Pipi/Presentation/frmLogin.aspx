<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="Presentation.forms.frmLogin" %>
<%@ OutputCache Duration="180" VaryByParam="none" %>
<%@ Register Src="controls/login.ascx" TagName="login" TagPrefix="uc1" %>
<%@ Register src="controls/cabecalho.ascx" tagname="cabecalho" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SGE - Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <table align="center" cellpadding="0" width="100%" cellspacing="0">
        <tr>
            <td>
                <div>
                    <uc1:login ID="login1" runat="server" />
                </div>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="cabecalho.ascx.cs" Inherits="Presentation.controls.cabecalho" %>
<style type="text/css">
    body{margin:0; padding: 0;}
    .cabecalho
    {
        border-collapse: collapse;
        width: 100%;
        height: 110px;
        border-bottom: 1px solid gray;
    }
</style>
<table cellpadding="0" class="cabecalho" cellspacing="0">
    <tr>
        <td align="left" style="border: 0; background-color: #FFFFFF" valign="top">
            <img alt="" src="imgs/sge_topo.gif" /></td>
            <td valign="bottom" style="font-family: tahoma, Verdana; font-size: 8pt; color: gray; padding-right: 5px;" align="right"><%= DateTime.Now.ToLongDateString() %></td>
    </tr>
</table>

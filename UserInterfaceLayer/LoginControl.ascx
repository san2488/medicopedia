<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginControl.ascx.cs" Inherits="ctrlLogin" %>
<link rel="Stylesheet" type="text/css" href="stylesheets/globalstyle.css" id="style" runat="server" visible="false" />
<table class="standardtable">
    <tr >
        <td class="tblheader">
            Login
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            <asp:Button ID="butLogin" runat="server" OnClick="butLogin_Click" Text="Login" />
        </td>
    </tr>
</table>

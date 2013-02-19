<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditComment.aspx.cs" Inherits="EditComment" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" Runat="Server">
    <table>
<tr>
<td>Advice</td>
<td>
    <asp:Label ID="lblAdvice" runat="server" Text=""></asp:Label>
</tr>
<tr>
<td>Comment</td>
<td>
    <asp:TextBox ID="txtComment" runat="server"></asp:TextBox></td>
</tr>
<tr>
<td colspan="2">
    <asp:Button ID="btnUpdate" runat="server" Text="Update" 
        onclick="btnUpdate_Click" /></td>
</tr>
<tr>
<td colspan="2">
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
</td>
</tr>
</table>
</asp:Content>


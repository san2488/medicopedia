<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PostComment.ascx.cs" Inherits="PostComment" %>
<link href="CSS/Akshay.css" rel="stylesheet" type="text/css" />
<table>
<tr><td>Advice:</td></tr>
<tr>
<td><asp:Label ID="lblAdvice" runat="server" CssClass="PostCommentlabel"></asp:Label></td>
</tr>
<tr><td>Your Comment :</td></tr>
<tr><td colspan = "2"><asp:TextBox ID="txtComment" runat="server" TextMode="MultiLine" Width="390px"></asp:TextBox><br /></td></tr>
<tr><td><asp:Button ID="btnSubmit" runat="server" Text="Submit" 
    onclick="btnSubmit_Click"/></td></tr>
</table>
 
 
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QueryDetails.aspx.cs" Inherits="Default3" Title="Untitled Page" %>
<%@ Register TagName="QueryDetails" TagPrefix="UC1" src="~/QueryDetails.ascx"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" Runat="Server">
<UC1:QueryDetails ID="UserControl1" runat="server" />
</asp:Content>


<%@ Page Language="C#" Title="Search" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" MasterPageFile="MasterPage.master" %>
<%@ Register TagPrefix ="HUC" TagName ="SearchControl"  Src="~/HomeUserControl.ascx" %>


<asp:Content ID="contSearch" ContentPlaceHolderID="cphMain" runat="Server">
    <form id="form1" action="#">
    <div id="content">
        <HUC:SearchControl ID="UC1" runat="server" />
        <br />
    </div>
    </form>
</asp:Content>

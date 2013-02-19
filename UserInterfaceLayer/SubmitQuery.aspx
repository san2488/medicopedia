<%@ Page Title="Submit a Query - Medicopedia" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SubmitQuery.aspx.cs" Inherits="Default3"%>
<%@ Register TagPrefix="UC1" TagName="SubmitQueryControl" Src="~/SubmitQuery.ascx"
 %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" Runat="Server">
<form id="form1" action="#">
    
    <UC1:SubmitQueryControl ID="UserControl" runat="server" />
        
    </form>
</asp:Content>


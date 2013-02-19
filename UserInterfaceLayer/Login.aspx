<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" Title="Login - Medicopedia" %>
<%@ Register Src="LoginControl.ascx" TagName="LoginControl" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
            <uc1:LoginControl ID="lctLogin" runat="server" />
        </AnonymousTemplate>
        <LoggedInTemplate>
            Welcome <%=Session["username"] %>. You are already logged in.
        </LoggedInTemplate>
    </asp:LoginView>
</asp:Content>


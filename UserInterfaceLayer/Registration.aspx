<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" Title="New User Registration" %>

<%@ Register src="RegistrationControl.ascx" tagname="RegistrationControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" Runat="Server">
    <asp:LoginView ID="logvuRegister" runat="server">
        <AnonymousTemplate>
            <uc1:RegistrationControl ID="regCtrlRegister" runat="server" />
        </AnonymousTemplate>
    </asp:LoginView>
</asp:Content>


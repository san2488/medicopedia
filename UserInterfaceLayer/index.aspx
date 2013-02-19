<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="index.aspx.cs" Inherits="index" Title="Welcome to Medicopedia" %>

<%@ Register src="HomeUserControl.ascx" tagname="HomeUserControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
    .style2
    {
        font-size: large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <i><b>
<br />
Medicopedia</b></i> is a web based medical encyclopedia that includes information
    about diseases, tests, symptoms and medicines. It provides an extensive search mechanism.
    Guest users can only view and search the information but registered users are privileged
    to contribute to this community based encyclopedia. Also registered users can seek
    medical advice. Registered doctors are privileged to provide authentic advice for
    such queries. They also are authorized to moderate and modify the content posted
    by the registered users. Registered users can rank different medical advices provided
    by the experts.<br />
<br />
&nbsp;<br />
    <br />
<span class="style2">Search:</span><uc1:HomeUserControl ID="HomeUserControl1" runat="server" />
</asp:Content>


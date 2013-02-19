<%@ Page Language="C#" Title="Error - Try again later" AutoEventWireup="true" CodeFile="Error.aspx.cs" Inherits="Error" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        font-size: xx-large;
        text-align: center;
    }
    .style2
    {
        font-size: small;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" Runat="Server">
    <p>
    <br />
</p>
<p class="style1">
    Error!</p>
<p class="style2">
    Some unidentified error has occured.
</p>
<p class="style2">
    Please notify the administrator or try again later</p>
<p class="style2">
    Sorry for the inconvenience!</p>
<p>
</p>
</asp:Content>


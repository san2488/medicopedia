<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DiseaseList.ascx.cs" Inherits="DiseaseList" %>
<div id="interestlist">
    <asp:DropDownList ID="ddlInterestList" runat="server" CssClass="ddlinterest" 
        AutoPostBack="True" 
        onselectedindexchanged="ddlInterestList_SelectedIndexChanged">
    </asp:DropDownList>
</div>
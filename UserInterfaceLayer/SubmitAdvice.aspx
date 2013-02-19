<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SubmitAdvice.aspx.cs" Inherits="SubmitAdvice" MasterPageFile="MasterPage.master" %>
<%@ Register TagPrefix="UC1" TagName="SubmitAdvice" Src="~/SubmitAdvice.ascx"%>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <form id="form1" action = "#">
    <div>
    <UC1:SubmitAdvice runat="server" ID="UserControl1" />
    </div>
    </form>
    </asp:Content>


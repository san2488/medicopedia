<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SubmitVote.aspx.cs" Inherits="SubmitVote" Title="Submit Your Vote"%>
<%@ Register TagPrefix="UC1" TagName="SubmitVote" Src="~/SubmitVote.ascx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" Runat="Server">
    <form id="form1" action="#">
    <UC1:SubmitVote ID="UserControl1" runat="server" />
    </form>
        </asp:Content>
  

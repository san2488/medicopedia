<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VoteAndCommentInfo.aspx.cs" Inherits="VoteAndCommentInfo" MasterPageFile="~/MasterPage.master" Title="Advices"%>

<%@ Register src="DisplayAdvice.ascx" tagname="DisplayAdvice" tagprefix="uc1" %>

<%@ Register src="PostComment.ascx" tagname="PostComment" tagprefix="uc2" %>
<asp:Content ID ="Content1" ContentPlaceHolderID ="cphMain" Runat ="Server"> 

    <form id="form1" action="#">
    <div>
        <uc1:DisplayAdvice ID="DisplayAdvice1" runat="server" />
        <br />
    </div>
    </form>
</asp:Content> 



<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CommentOnAdvice.aspx.cs" Inherits="CommentOnAdvice" MasterPageFile="~/MasterPage.master" %>

<%@ Register src="PostComment.ascx" tagname="PostComment" tagprefix="uc1" %>

<asp:Content ID ="Content1" ContentPlaceHolderID ="cphMain" Runat ="Server"> 


    <form id="form1" action="#">
    <div>
        <uc1:PostComment ID="PostComment1" runat="server" />
    </div>
    </form>
  </asp:Content>


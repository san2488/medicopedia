<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DisplayAdvice.ascx.cs" Inherits="DisplayAdvice" %>
<link href="CSS/Akshay.css" rel="stylesheet" type="text/css" />
<table style="width:600; font-family:Calibri">
<tr>
<td><asp:Label ID="lblAreaOfInterest" runat="server" CssClass="VoteAndCommentAreaOfInterest"></asp:Label></td>
<td align="right"><asp:ImageButton ID="btnGetXML" 
        runat="server" ImageUrl="images/xml.jpg" onclick="btnGetXML_Click" /><br /> 
    <asp:Label ID="lblXml" runat="server" Text="(File Saved as D:\AdviceInfo.xml)" 
        style="font-size: 9pt; color: #808080"></asp:Label>
   </td>
</tr>
<tr>
<td class="VoteAndCommentQuerySection" colspan="2"><b>Symptoms:&nbsp; </b><asp:Label ID="lblSymptoms" runat="server"></asp:Label></td>
</tr>
<tr>
<td class="VoteAndCommentQuerySection" colspan="2"><b>Medical History:&nbsp;</b> <asp:Label ID="lblMedHistory" runat="server"></asp:Label></td>
</tr>
<tr>
<td class="VoteAndCommentQuerySection" colspan="2">Posted By:&nbsp; 
    <asp:Label ID="lblPostedBy" runat="server" style="font-weight: 700"></asp:Label>&nbsp;On <asp:Label ID="lblpostedOn" runat="server"></asp:Label></td>
</tr>
<tr>
<td class="VoteAndCommentAdviceSection" colspan="2">
    <asp:Label ID="lblAdviceTitle" runat="server" CssClass="VoteAndCommentLabelAdvice"></asp:Label>
    </td>
</tr>
<tr>
<td class="VoteAndCommentAdviceSection" colspan="2">
&nbsp;<asp:Label ID="lblAdvice" runat="server"></asp:Label></td>
</tr>
<tr>
<td class="VoteAndCommentAdviceSection" colspan="2">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Posted by
    <asp:Label ID="lblAdviceUser" runat="server" style="font-weight: 700"></asp:Label>
&nbsp;on
    <asp:Label ID="lblPosted" runat="server"></asp:Label>
    &nbsp;</td>
</tr>
<tr>
<td colspan="2">
    <img alt="likes" src="images/like.png"/><asp:Label 
        ID="lblLikes" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp; <img alt="dislikes" src="images/dislike.png" /><asp:Label 
        ID="lblDislikes" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/images/cast.png" />&nbsp;<a href="SubmitVote.aspx">Cast your vote now!</a>
    </asp:PlaceHolder>
    <br />
    </td>
</tr>
<tr>
<td colspan="2">
<asp:GridView ID="gvShowComments" runat="server" AutoGenerateColumns="False" CellPadding="4" 
        EmptyDataText="There are no data records to display." ForeColor="#333333" 
        GridLines="None" style="font-family: Calibri; font-size: small" 
        AllowPaging="True" AllowSorting="True" Width="323px" 
        onpageindexchanging="gvShowComments_PageIndexChanging" 
        onrowdatabound="gvShowComments_RowDataBound">
        <RowStyle BackColor="White" />
        <Columns>
        <asp:TemplateField>
        <HeaderTemplate>
        <div style="font-size:normal; color: Gray; font-weight:normal; text-align:left">
            <img src="images/comments.png" alt="comments" style="vertical-align:middle" /> All Comments<br />
           <img src="images/hr.png" alt="line" width="620px"/> </div>
        </HeaderTemplate>
         <ItemTemplate>
         <table width="630px" border="0">
         <tr>
         <td width="30px">
             <img src="images/comment.png" alt="comment" /></td>
         <td width="400px"><asp:Label ID="Label1" runat="server" Text='<%#Eval("Username")%>'> </asp:Label>&nbsp;says: </td>
         <td width="200px"><asp:Label ID="Label2" runat="server" Text="Posted on:" CssClass="VoteAndCommentPosted"></asp:Label><asp:Label
                 ID="Label3" runat="server" Text='<%#Eval("CommentDateTime")%>' CssClass="VoteAndCommentPostedBy"></asp:Label></td>
         </tr>
         <tr><td></td>
         <td colspan="2" width="600px"><%#Eval("CommentsField")%></td>
         </tr>
         <tr>
         <td colspan="2">
             <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "EditComment.aspx?CommentId="+ Eval("CommentId")%>'>Edit</asp:HyperLink></td>
         </tr>
         </table>
         </ItemTemplate>
        </asp:TemplateField>
        </Columns>
        <PagerStyle BackColor="White" ForeColor="#0033cc" HorizontalAlign="Center" />
        <HeaderStyle BackColor="White" Font-Bold="True" ForeColor="Black" />
        <%--<AlternatingRowStyle BackColor="White" />--%>
        </asp:GridView>
</td>
</tr>
<tr>
<td colspan="2"><asp:Button ForeColor="White" BackColor="#1582ab" BorderStyle="None" ID="btnGiveComment" runat="server" Text="Pass comment!" 
        onclick="btnGiveComment_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td>
</tr>
</table>



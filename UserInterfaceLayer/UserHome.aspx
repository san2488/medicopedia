<%@ Page Language="C#" Title="My Home - Medicopedia" AutoEventWireup="true" CodeFile="UserHome.aspx.cs" Inherits="UserHome" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID ="Content1" ContentPlaceHolderID ="cphMain" Runat ="Server"> 
<link href="CSS/Akshay.css" rel="stylesheet" type="text/css" />

    <form id="form1" action ="#">
    <table>
    <tr>
    <td colspan="2">
   <br />Welcome! Your top 10 medical advices for 
        <asp:Label ID="lblAreaOfInterest" 
            runat="server" Text="" style="font-weight: 700; color: #333333;"></asp:Label>
        <br /><center>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" 
        EmptyDataText="There are no data records to display." ForeColor="#333333" 
        GridLines="None" style="font-family: Calibri; font-size: small" 
        AllowPaging="True" AllowSorting="True" Width="374px" 
            onpageindexchanging="GridView1_PageIndexChanging">
        <RowStyle BackColor= "White" />
        <Columns>
         <asp:TemplateField >  
         <ItemTemplate>  
         <table width="600px" cellpadding="3">
         <tr>
         <td width="520px">
             <img src="images/bullet.png" alt="Top Advice" width="11px" />&nbsp; <asp:HyperLink ID="hypLnkAdviceDetails" runat="server" NavigateUrl='<%#string.Concat("VoteAndCommentInfo.aspx?AdviceId=", Eval("AdviceId"),"&QueryId=", Eval("QueryId")) %>' Text='<%# Eval("AdviceTitle")%>' CssClass="UserHomeAdviceTitle"/></td> 
         <td width="80px">
             <img src="images/rating.png" width="8px" alt="Rating" />&nbsp;<asp:Label ID="lblRating" runat="server" Text="Rating: "></asp:Label><%# Eval("Rank")%></td>
         </tr>
         <tr>
         <td width="590px" colspan = "2"><asp:Label ID="lblAdviceDescription" runat="server" Text='<%# LimitWords(Eval("AdviceDescription").ToString()) %>' /></td> 
         </tr>
         <tr>
         <td colspan = "2" class="UserHomePosted">Posted by <%#Eval("Username") %> on
          <%# Eval("AdviceDateTime") %>
         </td>
         </tr>
         </table> 
         </ItemTemplate>
        </asp:TemplateField> 
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <EditRowStyle BackColor="White" />
        
    </asp:GridView></center>
    <br />
    </td>
    </tr>
    <tr>
    <td> <center>
        <asp:Button ID="btnPostQuery" runat="server" Text="Post Query" 
            BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White" Width="160px" Height="25px" onclick="btnPostQuery_Click" /></center></td>
        <td>
          <center>  <asp:Button BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" 
                  BackColor="#1582ab" ForeColor="White" ID="btnShowHistory" Width="160px" 
                  Height="25px" runat="server" Text="Query History" 
                  onclick="btnShowHistory_Click" /></center></td>
    </tr>
    </table>
    </form>

</asp:Content > 



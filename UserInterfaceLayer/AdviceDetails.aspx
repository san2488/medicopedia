<%@ Page Language="C#" Title="Advices" AutoEventWireup="true" CodeFile="AdviceDetails.aspx.cs" Inherits="AdviceDetails" MasterPageFile="MasterPage.master" %>
<asp:Content ID ="contAdviceDetails" ContentPlaceHolderID ="cphMain" Runat ="Server">
    <form id="form1" action="#">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" 
        EmptyDataText="There are no data records to display." ForeColor="#333333" 
        GridLines="None" style="font-family: Calibri; font-size: small" 
        AllowPaging="True" AllowSorting="True" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" Width="643px">
        <RowStyle />
        <Columns>
         <asp:TemplateField>  
         <ItemTemplate>  
         <table>
         <tr>
         <td width="100px" style="font-size:large">
             <img src="images/bullet.png" alt="Advice" width="11px" /> <asp:HyperLink ID="hypLnkAdviceDetails" runat="server" NavigateUrl='<%#String.Concat("VoteAndCommentInfo.aspx?AdviceID=",Eval("AdviceId"),"&QueryId=",Request.QueryString["QueryId"].ToString()) %>' Text='<%# Eval("AdviceTitle") %>' />
                   
         </td></tr><tr><td><asp:Label ID="lblAdviceDescription" runat="server" Text='<%# Eval("AdviceDescription") %>' /> 
         </td></tr><tr><td><asp:Label ID="lblUserName" runat="server" Text='<%# Eval("Username") %>' /> 
         posted at <asp:Label ID="lblAdviceDateTime" runat="server" Text='<%# Eval("AdviceDateTime") %>' /> 
         </td>
         </tr>
         </table> 
         </ItemTemplate>
         </asp:TemplateField>
         
           
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="White" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView><br />
    <asp:Button ID="btnAddAdvice" runat="server" Text="Add Advice" 
        onclick="Button2_Click"  BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" ForeColor="White"  />
        <asp:LoginView ID="LoginView1" runat="server">
    <RoleGroups>
        <asp:RoleGroup Roles="2">
            <ContentTemplate>
                <asp:Button ID="Button1" runat="server" Text="Button" BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" ForeColor="White" />
            </ContentTemplate>
        </asp:RoleGroup>
    </RoleGroups>
    </asp:LoginView>
    </form>
</asp:Content>

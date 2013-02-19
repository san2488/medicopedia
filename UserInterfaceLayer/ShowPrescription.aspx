<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowPrescription.aspx.cs" Inherits="Prescriptions" MasterPageFile="MasterPage.master" %>
<asp:Content ID ="contShowPrescription" ContentPlaceHolderID ="cphMain" Runat ="Server"> 
    <form id="form1" action="#">
    <div>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
    
    <asp:Button ID="btnAddPrescription" runat="server" Text="AddPrescription" 
        onclick="btnAddPrescription_Click" />    
    </form>
</asp:Content>
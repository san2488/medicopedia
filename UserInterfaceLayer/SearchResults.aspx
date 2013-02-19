<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchResults.aspx.cs" Inherits="Search1" MasterPageFile="MasterPage.master" Title="Search Results - Medicopedia"%>

<%@ Register src="HomeUserControl.ascx" tagname="HomeUserControl" tagprefix="uc1" %>

<asp:Content ID ="contSearchResults" ContentPlaceHolderID ="cphMain" Runat ="Server"> 
    <form id="form1" action="#">
    <div>
    
        <uc1:HomeUserControl ID="HomeUserControl1" runat="server" />
    
        <br />
        <center>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" AutoGenerateColumns="False" Width="671px">
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="hypLnkQueryDetails" runat="server" NavigateUrl='<%# Eval("QueryId","AdviceDetails.aspx?QueryID={0}") %>' Text="Details" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="UserName" HeaderText="Posted By" />
                <asp:BoundField DataField="Symptoms" HeaderText="Symptoms" />
                <asp:BoundField DataField="MedicalHistory" HeaderText="Medical History" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:BoundField DataField="PostedDateTime" HeaderText="Posted Date" />
                <asp:TemplateField HeaderText="Prescriptions">
                <ItemTemplate>
                        <asp:HyperLink ID="hypLnkPrescriptionDetails" runat="server" NavigateUrl='<%# Eval("QueryId","ShowPrescription.aspx?QueryID={0}") %>' Text="View Prescription" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#1582ab" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1582ab" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView></center>
    
    
    </div>
    </form>
</asp:Content > 




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HomeUserControl.ascx.cs" Inherits="HomeUserControl" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
<table class="style1">
    <tr>
        <td>
            Search by Disease</td>
        <td>
<asp:DropDownList ID="ddlDiseases" runat="server" AutoPostBack="True" 
    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    <asp:ListItem>Cancer</asp:ListItem>
    <asp:ListItem>Diabetes</asp:ListItem>
</asp:DropDownList>
&nbsp;(or)</td>
    </tr>
    <tr>
        <td>
            Search by Medicine</td>
        <td>
<asp:DropDownList ID="ddlMedicines" runat="server" AutoPostBack="True" 
    onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
    style="height: 22px">
</asp:DropDownList>

            &nbsp;(or)</td>
    </tr>
    <tr>
        <td>
            Search by Doctors</td>
        <td>

<asp:DropDownList ID="ddlDoctors" runat="server" AutoPostBack="True" 
    onselectedindexchanged="ddlDoctors_SelectedIndexChanged">
</asp:DropDownList>
&nbsp;(or)</td>
    </tr>
    <tr>
        <td>
            Search by Symptoms</td>
        <td>
<asp:TextBox ID="txtSymptoms" runat="server"></asp:TextBox>


&nbsp;<asp:Button ID="btnSymptoms" runat="server" onclick="btnSymptoms_Click" 
    Text="Search my Symptoms" BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White"/>



        </td>
    </tr>
    </table>





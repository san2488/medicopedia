<%@ Control Language="C#" AutoEventWireup="true" CodeFile="QueryDetails.ascx.cs" Inherits="QueryDetails" %>


 <asp:Label ID="lblQueryDetails" runat="server" Font-Bold="True" 
        Font-Size="Large" Text="Query Details"></asp:Label>
<br />
<br />

<asp:PlaceHolder ID="PlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>

<table>
<tr><td>
    <asp:Button ID="btnNeedsMoreInfo" runat="server" Text="Needs More Info" 
        onclick="btnNeedsMoreInfo_Click"  BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White" /></td><td>
        <asp:Button ID="btnSubmitAdvice" runat="server" Text="Submit Advice" 
            onclick="btnSubmitAdvice_Click"   BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White"/></td></tr>
</table>

</asp:PlaceHolder>

<asp:PlaceHolder ID="PlaceHolder2" runat="server">
<asp:Label ID="lblNeedsMoreInfo" Text="Query marked as 'Needs More Info'." runat="server"></asp:Label>
<br />
<br />
<asp:Button ID="btnGoBack" Text="Go Back" runat="server" 
    onclick="btnGoBack_Click"   BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White"/>
</asp:PlaceHolder>
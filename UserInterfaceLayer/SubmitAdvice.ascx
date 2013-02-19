<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SubmitAdvice.ascx.cs"
    Inherits="WebUserControl" %>
<div>
<asp:PlaceHolder ID="PlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblQueryId" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Submit Advice"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Advice Title:"></asp:Label>
                <br />
                <asp:TextBox ID="txtAdviceTitle" runat="server" Height="23px" Width="169px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Advice Description:"></asp:Label>
                <br />
                <asp:TextBox ID="txtAdvice" runat="server" Height="56px" Width="225px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White" runat="server" Text="Submit" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White" ID="Button2" runat="server" Text="Cancel" />
            </td>
            <td>
            </td>
        </tr>
        <tr><td>
            <asp:Label ID="lblErrorMsg" runat="server" Text=""></asp:Label></td></tr>
    </table>
    </asp:PlaceHolder>
    <asp:PlaceHolder runat="server" ID="PlaceHolder2">
        <asp:Label ID="Label4" runat="server" Text="Thank you!" ></asp:Label>
    </asp:PlaceHolder>
</div>

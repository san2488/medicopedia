<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SubmitVote.ascx.cs" Inherits="SubmitVote" %>

<div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <table style="width: 327px">
        <tr><td>
            <asp:Label ID="lblAdviceId" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr><td>
            <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
            </td></tr>
            <tr>
                <td>
                    
                </td>
            </tr>
            <tr><td>
                <asp:Label ID="lblAdviceDescription" runat="server" 
                    Text=""></asp:Label>
                </td></tr>
            <tr>
                <td>
                
                    <asp:Button ID="VoteFor" runat="server" Text="Vote For" 
                        onclick="VoteFor_Click" BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White" style="height: 26px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="VoteAgainst" runat="server" Text="Vote Against" 
                        onclick="VoteAgainst_Click"  BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White"/>
                
                </td>
            </tr>
        </table>
        </asp:PlaceHolder>
        <asp:PlaceHolder ID="PlaceHolder2" runat="server">
            <asp:Label ID="Label2" runat="server" Text="Thanks for voting."></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnGoBack" runat="server" Text="Go Back" 
            onclick="btnGoBack_Click" BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White"/>
        </asp:PlaceHolder>
    </div>
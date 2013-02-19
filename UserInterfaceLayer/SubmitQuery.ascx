<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SubmitQuery.ascx.cs" Inherits="SubmitQuery" %>
<%@ Register TagPrefix="UC1" TagName="DiseaseList" src="~/DiseaseList.ascx"%>

<div>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <table style="width: 472px; height: 317px">
            <tr>
                <td class="style7">
                    <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    <asp:Label ID="lblAreaOfInterest" runat="server" Text="Please select the condition which you wish to enquire about: "></asp:Label>
                    <br />
                    <br />
                    <asp:DropDownList ID="ddlInterestList" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    <asp:Label ID="lblSymptoms" runat="server" Text="Enter the experienced symptoms(Use comma seperated values):"></asp:Label>
                    &nbsp;<br />
                    <br />
                    <asp:TextBox ID="txtSymptoms" runat="server" Height="34px" TextMode="MultiLine" 
                        Width="204px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblMedHistory" runat="server" Text="Please enter the medical history:"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="txtMedHistory" runat="server" TextMode="MultiLine"></asp:TextBox>
                    &nbsp&nbsp&nbsp<asp:Label ID="lblErrorMessage" Text="" runat="server" />
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtMedHistory" Display="Dynamic" 
                        ErrorMessage="*RequiredFieldValidator" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click1" 
                        style="height: 26px" BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White" ID="Button2" runat="server" Text="Cancel" />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblErrorMsg" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
   </asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server">
        <asp:Label ID="Label2" runat="server" Text="Your query has been submitted. Thank you and have a nice day."></asp:Label>
        <br />
        <br />
	    <asp:Button ID="btnGoBack" Text="Go Back" runat="server" BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White"/>
    </asp:PlaceHolder>
</div>

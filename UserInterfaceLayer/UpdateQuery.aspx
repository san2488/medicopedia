<%@ Page Language="C#" Title="Update a Query" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="UpdateQuery.aspx.cs" Inherits="UpdateQuery" %>
<%@ Register TagPrefix="UC1" TagName="DiseaseList" Src="~/DiseaseList.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" Runat="Server">

    <form id="form1" action="#">
    <div>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
         <br />
        <br />
        <table style="width: 612px; height: 269px">
            <tr>
                <td>
                    <asp:Label ID="lblQueryAreaOfInterest" runat="server" Text="Query Area Of Interest: "></asp:Label>
                </td>
                <td>
                    <UC1:DiseaseList ID="UserControl1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSymptoms" runat="server" Text="Symptoms: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSymptoms" runat="server" Height="49px" Width="282px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMedicalHistory" runat="server" Text="Medical History: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMedicalHistory" runat="server" Height="78px" TextMode="MultiLine"
                        Width="289px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="70px" 
                        onclick="btnUpdate_Click" BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White"  />
                </td>
               
                <td>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="67px" 
                        style="margin-left: 28px"   BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White" onclick="btnCancel_Click" />
                </td>
            </tr>
        </table>
        </asp:PlaceHolder>
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"><br />
        <asp:Label ID="lblSuccess" Text="Query Updated Successfully." runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGoBack" Text="Go Back" runat="server" BorderStyle="Solid" BorderWidth="1px" BorderColor="#1582ab" BackColor="#1582ab" 
            ForeColor="White" onclick="btnGoBack_Click" />
        
        </asp:PlaceHolder>
    </div>
    </form>
</asp:Content>

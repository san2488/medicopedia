<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RegistrationControl.ascx.cs" Inherits="WebUserControl" %>


<link rel="Stylesheet" type="text/css" href="stylesheets/globalstyle.css" id="style" runat="server" visible="false" />
<%--<script src="scripts/Validation.js" type="text/javascript"></script>--%>
<script language="javascript" type="text/javascript">
            /// <summary>
            /// Launches the DatePicker page in a popup window, 
            /// passing a JavaScript reference to the field that we want to set.
            /// </summary>
            /// <param name="strField">String. The JavaScript reference to the field that we want to set, 
/// in the format: FormName.FieldName 
            /// Please note that JavaScript is case-sensitive.</param>
            function calendarPicker(strField)
            {
                window.open('DatePicker.aspx?field=' + strField, 'calendarPopup', 'width=250,height=190,resizable=yes');
            }
</script>

<form id="frmRegister" action="#" method="post">
<table class="standardtable" style="width:300px">
    <tr>
        <td class="tblheader">
            Registration</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUserFullName" runat="server" Text="Full Name:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserFullName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblEmailId" runat="server" Text="Email Id:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDoB" runat="server" Text="Date Of Birth:"></asp:Label>
        </td>
        <td>
            <input id="txtDoB" type="text" runat="server" readonly="readonly"/><%--<input id="butCal" type="button" value="Cal" onclick="calendarPicker('Form1.txtEventDate');"/>--%>
            <a href="javascript:;" onclick="calendarPicker('<%=txtDoB.ClientID %>');" title="Pick Date from Calendar"><img src="images/calender.jpg" alt="Pick Date" style="height:25px;width:25px; border:none;"/></a>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem Value="true" Selected="True">Male</asp:ListItem>
                <asp:ListItem Value="false">Female</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblIsDoctor" runat="server" Text="Are you a Doctor?"></asp:Label>
        </td>
        <td>
            <asp:CheckBoxList ID="cblIsDoctor" runat="server" AutoPostBack="True" 
                onselectedindexchanged="cblIsDoctor_SelectedIndexChanged">
                <asp:ListItem Value="true">Yes</asp:ListItem>
            </asp:CheckBoxList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblLicNo" runat="server" Text="Licence Number:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtLicNo" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblAreaInt" runat="server" 
                Text="Area of Interest/ Specialization:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlInterestList" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr >
        <td style="border-top-style:dashed; border-width: thin; border-color: #1582AB">
            <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
        </td>
        <td style="border-top-style: dashed; border-width: thin; border-color: #1582AB">
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="butSubmit" Text="Register" runat="server" 
                onclick="butSubmit_Click"/>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="lblErrors" runat="server" ForeColor="Red"></asp:Label>
        </td>
    </tr>
</table>
</form>

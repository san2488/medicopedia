<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DatePicker.aspx.cs" Inherits="DatePicker" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <title>DatePicker</title>
    <style type="text/css">
        BODY
        {
            padding-right: 0px;
            padding-left: 0px;
            padding-bottom: 0px;
            margin: 4px;
            padding-top: 0px;
        }
        BODY
        {
            font-size: 9pt;
            font-family: Verdana, Geneva, Sans-Serif;
        }
        TABLE
        {
            font-size: 9pt;
            font-family: Verdana, Geneva, Sans-Serif;
        }
        TR
        {
            font-size: 9pt;
            font-family: Verdana, Geneva, Sans-Serif;
        }
        TD
        {
            font-size: 9pt;
            font-family: Verdana, Geneva, Sans-Serif;
        }
    </style>
</head>
<body onload="this.window.focus();">
    <form id="Form1" method="post" runat="server">
    <table>
    <tr><td>
        <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="True" 
            onselectedindexchanged="JumpToDate">
        </asp:DropDownList>
    </td><td style="text-align:right">
        <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" 
                onselectedindexchanged="JumpToDate">
        </asp:DropDownList>
    </td></tr>
       <tr><td colspan="2"> <asp:Calendar ID="Calendar1" runat="server" 
            BorderColor="White" ondayrender="Calendar1_DayRender" BackColor="White" 
            BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" 
            Height="112px" NextPrevFormat="FullMonth" Width="122px">
            <TodayDayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#333333" Font-Bold="True" 
                VerticalAlign="Bottom" />
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle Font-Size="12pt" Font-Bold="True" ForeColor="#333399" 
                BackColor="White" BorderColor="Black" BorderWidth="4px" />
            <OtherMonthDayStyle ForeColor="#999999" />
        </asp:Calendar>
        </td>
        </tr>
    </table>
    </form>
</body>
</html>



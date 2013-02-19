<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewprescription.aspx.cs" Inherits="viewprescription" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" rel="stylesheet" href="CSS/Style.css" />
    <title>View Prescription</title>
</head>
<body>
    <div id="entire">

        <div id="BnL">
            <center><h1> Banner and Logo </h1></center>
        </div>

        <div id="navipan">
            <center> Navigation Panel </center>
        </div>
        
        <div id="content">
            <div id="SnE">
                <form id="savenedit" runat="server">
                    <table>
                        <tr><td><asp:Button ID="Edit" runat="server" Text="Edit" Enabled="true" onclick="Edit_Click" /></td>
                        <td><asp:Button ID="Save" runat="server" Text="Save" onclick="Save_Click" /></td></tr>
                    </table>
                </form>
            </div>
            <div id="prescribedmedi">
                <table>
                    <tr>
                        <td>Patient ID:</td>
                        <td><asp:Label ID="patientid" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                </table>
                
                <table border="1">
                    <tr align="center">
                        <td width="70"><asp:Label ID="Label1" runat="server" Text="Sr. No."></asp:Label></td>
                        <td width="70"><asp:Label ID="Label2" runat="server" Text="Medicine"></asp:Label></td>
                        <td width="70"><asp:Label ID="Label3" runat="server" Text="Breakfast"></asp:Label></td>
                        <td width="70"><asp:Label ID="Label4" runat="server" Text="Lunch"></asp:Label></td>
                        <td width="70"><asp:Label ID="Label5" runat="server" Text="Dinner"></asp:Label></td>
                        <td width="70"><asp:Label ID="Label7" runat="server" Text="Days"></asp:Label></td>
                        <td width="70"><asp:Label ID="Label6" runat="server" Text="Tablets"></asp:Label></td>                        
                    </tr>
                    
                    <asp:Panel ID="Medicine1Panel" runat="server" Visible="false">
                    <tr align="center"> 
                        <td width="70"><asp:Label ID="sr1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="m1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="nod1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="not1" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine2Panel" runat="server" Visible="false">
                    <tr align="center">
                        <td width="70"><asp:Label ID="sr2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="m2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="nod2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="not2" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine3Panel" runat="server" Visible="false">
                    <tr align="center">
                        <td width="70"><asp:Label ID="sr3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="m3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="nod3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="not3" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine4Panel" runat="server" Visible="false">
                    <tr align="center">
                        <td width="70"><asp:Label ID="sr4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="m4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="nod4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="not4" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine5Panel" runat="server" Visible="false">
                    <tr align="center"> 
                        <td width="70"><asp:Label ID="sr5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="m5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="nod5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="not5" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine6Panel" runat="server" Visible="false">
                    <tr align="center">
                        <td width="70"><asp:Label ID="sr6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="m6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="nod6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="not6" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine7Panel" runat="server" Visible="false">
                    <tr align="center">
                        <td width="70"><asp:Label ID="sr7" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="m7" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br7" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu7" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di7" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="nod7" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="not7" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine8Panel" runat="server" Visible="false">
                    <tr align="center">
                        <td width="70"><asp:Label ID="sr8" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="m8" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br8" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu8" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di8" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="nod8" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="not8" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine9Panel" runat="server" Visible="false">
                    <tr align="center">
                        <td width="70"><asp:Label ID="sr9" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="m9" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br9" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu9" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di9" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="nod9" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="not9" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine10Panel" runat="server" Visible="false">
                    <tr align="center">
                        <td width="70"><asp:Label ID="sr10" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="m10" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br10" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu10" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di10" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="nod10" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="not10" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                </table>
            </div>            
        </div>   
        </div>
</body>
</html>

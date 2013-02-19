<%@ Page Language="C#" Title="Admin Dashboard - Medicopedia" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="DoctorApproval"%>

<asp:Content ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ContentPlaceHolderID="cphMain" runat="server">
    <div style="color:Gray; font-size:large; font-family: Calibri, Verdana">&nbsp;&nbsp;Doctor Approval Requests</div>
    <table><tr><td colspan="2">
   <asp:GridView ID="AdminDoctorView" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataKeyNames="Username"  
        EmptyDataText="There are no doctor records to display." ForeColor="#333333" 
        GridLines="None" style="font-family: Calibri; font-size: small" 
        AllowPaging="True" AllowSorting="True" PageSize="4" 
    onrowdeleting="AdminDoctorView_RowDeleting" 
    onrowupdating="AdminDoctorView_RowUpdating" OnPageIndexChanging="AdminDoctorView_PageIndexChanging">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
         <asp:TemplateField HeaderText="First Name" >  
         <HeaderTemplate>
           <table>
         <tr>
         <td width="90px">Username 
         </td><td width="100px"> Doctor Name</td><td width="40px">Lic. No.</td>
         <td width="150px">Area of Interest</td>
         </tr>
         </table> 
         </HeaderTemplate> 
         <ItemTemplate>  
         <table>
         <tr>
         <td width="100px"><asp:Label ID="userName" runat="server" Text='<%# Eval("Username") %>'/> 
         </td><td width="100px"><asp:Label ID="DocName" runat="server" Text='<%# Eval("DocName") %>' /> 
         </td><td width="45px"><asp:Label ID="DocLicenceNo" runat="server" Text='<%# Eval("DocLicenceNo") %>' /> 
         </td><td width="150px"><asp:Label ID="DocAreaOfInterest" runat="server" Text='<%# Eval("DocAreaOfInterest") %>' /> 
         </td></tr>
         </table> 
         </ItemTemplate>
         </asp:TemplateField>
          <asp:CheckBoxField DataField="DocIsApproved" HeaderText="Approval" 
                SortExpression="DocIsApproved" />
       
<asp:ButtonField ButtonType="Button" ShowHeader="false" Text="Change Approval" CommandName="Update" ControlStyle-BackColor="White" ControlStyle-BorderStyle="Solid" ControlStyle-BorderWidth="1px" ControlStyle-BorderColor="#507CD1" ControlStyle-ForeColor="#507CD1" ControlStyle-Font-Names="Calibri, Verdana" ControlStyle-Width="100px"   />
<asp:ButtonField ButtonType="Button" ShowHeader="false" Text="Delete" CommandName="Delete"  ControlStyle-BackColor="White" ControlStyle-BorderStyle="Solid" ControlStyle-BorderWidth="1px" ControlStyle-BorderColor="#507CD1" ControlStyle-ForeColor="#507CD1" ControlStyle-Font-Names="Calibri, Verdana"   />
        
           
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2AA1CC" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#2AA1CC" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView></td></tr><tr><td style="vertical-align:top; text-align:center">
    <table style="font-family:Calibri, Verdana">
    <tr style="background-color: #2AA1CC; color:White; font-family:Calibri, Verdana; height:25px; text-align:center;"><td> Add Diseases and Medicines</td></tr>
    <tr >
    <td >
    
        <asp:Label ID="result" runat="server" Visible="false"></asp:Label>
        <br /><asp:RadioButton GroupName="category" ID="rdoAddDisease" runat="server" Text="Disease" Checked="true" />
        <asp:RadioButton GroupName="category" ID="rdoAddMedicine" runat="server" Text="Medicine" />
       <br />
        Enter name:         <asp:TextBox ID="txtName" runat="server" Width="97px"></asp:TextBox>
        <br />
    </td></tr><tr><td  style="text-align:right">    <asp:Button ID="btnAdd" runat="server" Text="Add"  
            onclick="btnAdd_Click" BackColor="White" ForeColor="#507CD1" BorderStyle="Inset" BorderWidth="1px" BorderColor="#507CD1"/>
    
    </td>
    </tr>
    </table>    
    
    </td><td style="vertical-align:top">
    <center>
    
      
        <asp:GridView ID="AdminUserView" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataKeyNames="Username"  
        EmptyDataText="There are no user records to display." ForeColor="#333333" 
        GridLines="None" style="font-family: Calibri; font-size: small" 
         AllowPaging="true" PageSize="4" AllowSorting="True" onrowdeleting="AdminUserView_RowDeleting" OnPageIndexChanging="AdminUserView_PageIndexChanging">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
         <asp:TemplateField HeaderText="First Name" >  
         <HeaderTemplate>
           <table>
         <tr>
         <td width="130px">Username 
         </td><td width="140px"> Full Name</td>
         <td width="150px">Email Id</td>
         </tr>
         </table> 
         </HeaderTemplate> 
         <ItemTemplate>  
         <table>
         <tr>
         <td width="130px"><asp:Label ID="Username" runat="server" Text='<%# Eval("Username") %>'/> 
         </td><td width="140px"><asp:Label ID="UserFullName" runat="server" Text='<%# Eval("UserFullName") %>' /> 
         </td><td width="150px"><center><asp:Label ID="UserEmail" runat="server" Text='<%# Eval("UserEmailId") %>' /> </center>
         </td></tr>
         </table> 
         </ItemTemplate>
         </asp:TemplateField>
          
<asp:ButtonField ButtonType="Button" ShowHeader="false" Text="Delete" CommandName="Delete"  ControlStyle-BackColor="White" ControlStyle-BorderStyle="Solid" ControlStyle-BorderWidth="1px" ControlStyle-BorderColor="#507CD1" ControlStyle-ForeColor="#507CD1" ControlStyle-Font-Names="Calibri, Verdana"   />
        
           
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Gray" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#2AA1CC" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView></center></td></tr></table>

</asp:Content>
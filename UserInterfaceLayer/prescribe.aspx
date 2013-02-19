<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="prescribe.aspx.cs" Inherits="prescribe" %>
<asp:Content ContentPlaceHolderID="head" runat="server" ID="prescribeHead">
    <link type="text/css" rel="stylesheet" href="CSS/Style.css" />
   <script type="text/javascript" src="JS/addmed.js">
    </script>
</asp:Content>
<asp:Content ContentPlaceHolderID="cphMain" runat="server" ID="prescribe">

   
   <form id="prescription" method="post" action="#">
    <div id="entire">

        
                 <div>
                        <table id="TableSnR">
                <tr>
                     <asp:RequiredFieldValidator ID="MedicineValidator" runat="server" ErrorMessage="*" ControlToValidate="M1" Text = "Atleast one medicine must be prescribed"></asp:RequiredFieldValidator>
                               <asp:RequiredFieldValidator ID="MedicineValidator1" runat="server" ErrorMessage="*" ControlToValidate="NOD1" Text = "Atleast one day must be prescribed"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="MedicineValidation2" runat="server" ErrorMessage="*" ControlToValidate="NOD1" Text = "Enter valid number of days!" MaximumValue="100" MinimumValue="0" ></asp:RangeValidator>
                </tr>                                          
                            <tr>
                                <td colspan="3">
                                    Username:&nbsp;
                                    <asp:Label ID="user" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp; Query Id:&nbsp;
                                    <asp:Label ID="queryId" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; Prescription Id: &nbsp;<asp:Label ID="prescriptionId" runat="server" Text="1002"></asp:Label>
                                    &nbsp;
                                                            
                                </td>
                            </tr>
                        </table>
                    </div>
        <div id="contents">
           <div id="Medicine">
                <asp:PlaceHolder ID="setpres" runat="server">
                <div align="right" style="width: 630px"><asp:Button ID="previewpres" runat="server" Text="Preview Prescription" 
                                        onclick="previewpres_Click"  BorderColor="#1582AB" BorderStyle="Solid" BorderWidth="1px" BackColor="White"  />
                                    <input type="reset" value="Reset" style="background-color:White; color: #1582AB; border-style:solid; border-width:1px; border-bottom-color: #1582AB; border-left-color: #1582AB; border-right-color: #1582AB; border-top-color:#1582AB" /> <br />   </div>        
                  <div id="MedicineHeader">
                       <br /> <table style="background-color:#1582AB; color:White;" >
                            <tr>
                                <th rowspan="2" width="30"> No. </th>
                                <th rowspan="2" width="121"> Medicine </th>
                                <th colspan="2"> Breakfast </th>
                                <th colspan="2" width="120"> Lunch </th>
                                <th colspan="2" width="120"> Dinner </th>
                                <th rowspan="2" width="49"> Days </th>
                                <th rowspan="2" width="67"> Tablets </th>
                            </tr>
                            
                            <tr>                                
                                <th width="45"> Before </th>
                                <th width="45"> After </th>
                                <th width="45"> Before </th>
                                <th width="45"> After </th>
                                <th width="45"> Before </th>
                                <th width="45"> After </th>
                            </tr>                            
                        </table>
                    </div>
                    <div id="Medicine1">
                        <table id="Table1" cellspacing="0" >                            
                            <tr align="center" style="background-color:#D1DDF1">
                                <td width="30"> <b>1.</b> </td>
                                <td width="80"> <asp:TextBox Width="130px" ID="M1" runat="server" onfocus="displaynext(2)"></asp:TextBox></td>
                                <td width="50"> <asp:CheckBox ID="M1bfbr" GroupName="M1br" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M1afbr" GroupName="M1br" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M1bflu" GroupName="M1lu" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M1aflu" GroupName="M1lu" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M1bfdi" GroupName="M1di" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M1afdi" GroupName="M1di" Checked="true" runat="server" /> </td>
                                
                                <td style="width: 71px"> <asp:TextBox ID="NOD1" runat="server" Width="65px"></asp:TextBox></td>
                                
                                <td style="width: 70px">                                
                                    <asp:DropDownList ID="NOT1" Width="45px" runat="server">
                                        <asp:ListItem Text="1"></asp:ListItem>
                                        <asp:ListItem Text="0.5"></asp:ListItem>
                                        <asp:ListItem Text="1.5"></asp:ListItem>
                                        <asp:ListItem Text="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </td> 
                            </tr>
                            
                        </table>
                    </div>
                    
                    <div id="Medicine2">
                        <table id="Table2" cellspacing="0" >                            
                            <tr align="center" style="background-color:#EFF3FB">
                                <td width="30"> <b>2.</b> </td>
                                <td width="80"> <asp:TextBox Width="130px"  ID="M2" runat="server" onfocus="displaynext(3)"></asp:TextBox></td>
                                
                                <td width="50"> <asp:CheckBox ID="M2bfbr" GroupName="M2br" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M2afbr" GroupName="M2br" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M2bflu" GroupName="M2lu" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M2aflu" GroupName="M2lu" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M2bfdi" GroupName="M2di" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M2afdi" GroupName="M2di" Checked="true" runat="server" /> </td>
                                
                                <td style="width: 71px"> <asp:TextBox ID="NOD2" runat="server" Width="65px"></asp:TextBox></td>
                                
                                <td style="width: 70px">                                
                                    <asp:DropDownList ID="NOT2" Width="45px" runat="server">
                                        <asp:ListItem Text="1"></asp:ListItem>
                                        <asp:ListItem Text="0.5"></asp:ListItem>
                                        <asp:ListItem Text="1.5"></asp:ListItem>
                                        <asp:ListItem Text="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </td> 
                            </tr>                            
                        </table>
                    </div>
                    
                    <div id="Medicine3">
                        <table id="Table3" cellspacing="0" >                            
                            <tr align="center" style="background-color:#D1DDF1">
                                <td width="30"> <b>3.</b> </td>
                                <td width="80"> <asp:TextBox ID="M3" Width="130px"  runat="server" onfocus="displaynext(4)"></asp:TextBox></td>
                                
                                <td width="50"> <asp:CheckBox ID="M3bfbr" GroupName="M3br" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M3afbr" GroupName="M3br" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M3bflu" GroupName="M3lu" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M3aflu" GroupName="M3lu" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M3bfdi" GroupName="M3di" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M3afdi" GroupName="M3di" Checked="true" runat="server" /> </td>
                                
                                <td style="width: 71px"> <asp:TextBox ID="NOD3" runat="server" Width="65px"></asp:TextBox></td>
                                
                                <td style="width: 70px">                                
                                    <asp:DropDownList ID="NOT3" Width="45px" runat="server">
                                        <asp:ListItem Text="1"></asp:ListItem>
                                        <asp:ListItem Text="0.5"></asp:ListItem>
                                        <asp:ListItem Text="1.5"></asp:ListItem>
                                        <asp:ListItem Text="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </td> 
                            </tr>                            
                        </table>
                    </div>
                    
                    <div id="Medicine4">
                        <table id="Table4" cellspacing="0"  >                            
                            <tr align="center" style="background-color:#EFF3FB">
                                <td width="30"> <b>4.</b> </td>
                                <td width="80"> <asp:TextBox Width="130px"  ID="M4" runat="server" onfocus="displaynext(5)"></asp:TextBox></td>
                                
                                <td width="50"> <asp:CheckBox ID="M4bfbr" GroupName="M4br" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M4afbr" GroupName="M4br" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M4bflu" GroupName="M4lu" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M4aflu" GroupName="M4lu" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M4bfdi" GroupName="M4di" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M4afdi" GroupName="M4di" Checked="true" runat="server" /> </td>
                                
                                <td style="width: 71px"> <asp:TextBox ID="NOD4" runat="server" Width="65px"></asp:TextBox></td>
                                
                                <td style="width: 70px">                                
                                    <asp:DropDownList ID="NOT4" Width="45px" runat="server">
                                        <asp:ListItem Text="1"></asp:ListItem>
                                        <asp:ListItem Text="0.5"></asp:ListItem>
                                        <asp:ListItem Text="1.5"></asp:ListItem>
                                        <asp:ListItem Text="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </td> 
                            </tr>                            
                        </table>
                    </div>
                    
                    <div id="Medicine5">
                        <table id="Table5" cellspacing="0" >                            
                            <tr align="center" style="background-color:#D1DDF1">
                                <td width="30"> <b>5.</b> </td>
                                <td width="80"> <asp:TextBox ID="M5" Width="130px"  runat="server" onfocus="displaynext(6)"></asp:TextBox></td>
                                
                                <td width="50"> <asp:CheckBox ID="M5bfbr" GroupName="M5br" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M5afbr" GroupName="M5br" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M5bflu" GroupName="M5lu" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M5aflu" GroupName="M5lu" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M5bfdi" GroupName="M5di" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M5afdi" GroupName="M5di" Checked="true" runat="server" /> </td>
                                
                                <td style="width: 71px"> <asp:TextBox ID="NOD5" runat="server" Width="65px"></asp:TextBox></td>
                                
                                <td style="width: 70px">                                
                                    <asp:DropDownList ID="NOT5" Width="45px" runat="server">
                                        <asp:ListItem Text="1"></asp:ListItem>
                                        <asp:ListItem Text="0.5"></asp:ListItem>
                                        <asp:ListItem Text="1.5"></asp:ListItem>
                                        <asp:ListItem Text="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </td> 
                            </tr>                            
                        </table>
                    </div>
                    
                    <div id="Medicine6">
                        <table id="Table6" cellspacing="0">                            
                            <tr align="center" style="background-color:#EFF3FB">
                                <td width="30"> <b>6.</b> </td>
                                <td width="80"> <asp:TextBox ID="M6" runat="server" Width="130px" onfocus="displaynext(7)"></asp:TextBox></td>
                                
                                <td width="50"> <asp:CheckBox ID="M6bfbr" GroupName="M6br" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M6afbr" GroupName="M6br" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M6bflu" GroupName="M6lu" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M6aflu" GroupName="M6lu" Checked="true" runat="server" /> </td>
                                
                                <td width="50"> <asp:CheckBox ID="M6bfdi" GroupName="M6di" runat="server" /> </td>
                                <td width="50"> <asp:CheckBox ID="M6afdi" GroupName="M6di" Checked="true" runat="server" /> </td>
                                
                                <td style="width: 71px"> <asp:TextBox ID="NOD6" runat="server" Width="65px"></asp:TextBox></td>
                                
                                <td style="width: 70px">                                
                                    <asp:DropDownList ID="NOT6" Width="45px" runat="server">
                                        <asp:ListItem Text="1"></asp:ListItem>
                                        <asp:ListItem Text="0.5"></asp:ListItem>
                                        <asp:ListItem Text="1.5"></asp:ListItem>
                                        <asp:ListItem Text="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </td> 
                            </tr>                            
                        </table>
                    </div>
                    
           
                    
           
                  </asp:PlaceHolder>    
                  
                  
                  <asp:PlaceHolder ID="viewpres" runat="server" Visible="false">
                  <div id="content">
            <div id="SnE">
                <form id="savenedit" action="#">
                    <table>
                        <tr><td><asp:Button ID="Edit" runat="server" Text="Edit" Enabled="true" onclick="Edit_Click" BorderColor="#1582AB" BorderStyle="Solid" BorderWidth="1px" BackColor="White" /></td>
                        <td><asp:Button ID="Save" runat="server" Text="Save" onclick="Save_Click" BorderColor="#1582AB" BorderStyle="Solid" BorderWidth="1px" BackColor="White"  /></td></tr>
                    </table>
                </form>
            </div>
            <div id="prescribedmedi">
                               
                <table cellspacing="0" >
                    <tr align="center" style="background-color:#2AA1CC; color:White; height:30px;">
                        <td width="70"><asp:Label ID="slno" runat="server" Text="Sr. No."></asp:Label></td>
                        <td width="70"><asp:Label ID="medname" runat="server" Text="Medicine"></asp:Label></td>
                        <td width="70"><asp:Label ID="bf" runat="server" Text="Breakfast"></asp:Label></td>
                        <td width="70"><asp:Label ID="lnch" runat="server" Text="Lunch"></asp:Label></td>
                        <td width="70"><asp:Label ID="din" runat="server" Text="Dinner"></asp:Label></td>
                        <td width="70"><asp:Label ID="days" runat="server" Text="Days"></asp:Label></td>
                        <td width="70"><asp:Label ID="tbt" runat="server" Text="Tablets"></asp:Label></td>                        
                    </tr>
                    
                    <asp:Panel ID="Medicine1Panel" runat="server" Visible="false">
                    <tr align="center" style="background-color:#D1DDF1; color:Black; height:25px;"> 
                        <td width="70"><asp:Label ID="sr1" runat="server" Text="1"></asp:Label></td>
                        <td width="70"><asp:Label ID="medname1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="days1" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="tbt1" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine2Panel" runat="server" Visible="false">
                    <tr align="center" style="background-color:#EFF3FB; color:Black; height:25px;">
                        <td width="70"><asp:Label ID="sr2" runat="server" Text="2"></asp:Label></td>
                        <td width="70"><asp:Label ID="medname2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="days2" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="tbt2" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine3Panel" runat="server" Visible="false">
                    <tr align="center" style="background-color:#D1DDF1; color:Black; height:25px;">
                        <td width="70"><asp:Label ID="sr3" runat="server" Text="3"></asp:Label></td>
                        <td width="70"><asp:Label ID="medname3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="days3" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="tbt3" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine4Panel" runat="server" Visible="false">
                    <tr align="center" style="background-color:#EFF3FB; color:Black; height:25px;">
                        <td width="70"><asp:Label ID="sr4" runat="server" Text="4"></asp:Label></td>
                        <td width="70"><asp:Label ID="medname4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="days4" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="tbt4" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine5Panel" runat="server" Visible="false">
                    <tr align="center" style="background-color:#D1DDF1; color:Black; height:25px;"> 
                        <td width="70"><asp:Label ID="sr5" runat="server" Text="5"></asp:Label></td>
                        <td width="70"><asp:Label ID="medname5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="days5" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="tbt5" runat="server" Text=""></asp:Label></td>                    
                    </tr>
                    </asp:Panel>
                    
                    <asp:Panel ID="Medicine6Panel" runat="server" Visible="false">
                    <tr align="center" style="background-color:#EFF3FB; color:Black; height:25px;">
                        <td width="70"><asp:Label ID="sr6" runat="server" Text="6"></asp:Label></td>
                        <td width="70"><asp:Label ID="medname6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="br6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="lu6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="di6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="days6" runat="server" Text=""></asp:Label></td>
                        <td width="70"><asp:Label ID="tbt6" runat="server" Text=""></asp:Label></td>                    
                    </tr>

                    </asp:Panel>
                    
               </table>

            </div>    
            </div>  
            </asp:PlaceHolder>      <br />
            <asp:PlaceHolder ID="success" runat="server" Visible="false">
            <br /><br /><br /><center>Done!<br /><br /> You can now close this window! </center>
            </asp:PlaceHolder>       
            </div> 
     
        </div>
    </div>
            </form>

</asp:Content>
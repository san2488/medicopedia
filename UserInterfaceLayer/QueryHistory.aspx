<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="QueryHistory.aspx.cs" Inherits="QueryHistory" Title="Query History - Medicopedia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <%--<link href="CSS/Akshay.css" rel="stylesheet" type="text/css" />--%>
    <br /><br /><center><table>
    <tr><td>
        <img src="images/error.png" width="15px" /> &nbsp;Queries needing further Info:</td></tr>
    <tr>
    <td>
    <asp:GridView ID="gvShowQuery" runat="server" AutoGenerateColumns="False" CellPadding="4"
        EmptyDataText="There are no data records to display." ForeColor="#333333" GridLines="None"
        Style="font-family: Calibri; font-size: small" AllowPaging="True" AllowSorting="True"
        Width="497px" onpageindexchanged="gvShowQuery_PageIndexChanged" 
        onpageindexchanging="gvShowQuery_PageIndexChanging" PageSize="5">
        <RowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <table width="400px" cellpadding="3">
                        <tr>
                            <td width="300px">
                                <img src="images/bullet.png" alt="Area of Interest" width="11px" />&nbsp;<asp:HyperLink ID="HypLnkQueryDetails"  style="font-size:large" runat="server"  Text='<%# Eval("QueryAreaOfInterest")%>' NavigateUrl='<%# "QueryDetails.aspx?QueryID="+ Eval("QueryID")%>'></asp:HyperLink>
                               </td>
                            <td width="100px">
                               
                            </td>
                        </tr>
                        <tr>
                            <td width="400px" colspan="2">Symptoms:&nbsp
                                <asp:Label ID="lblSymptoms" runat="server" Text='<%# Eval("Symptoms")%>' /><br />
                                 Medical History:&nbsp<asp:Label ID="lblMedicalHistory" runat="server" Text='<%# Eval("MedicalHistory")%>' />
                            </td>
                        </tr>
                        <tr>
                        <tr>
                            <td colspan="2" class="UserHomePosted">
                                Posted on: 
                                <%# Eval("PostedDateTime")%>
                            </td>
                        </tr>

                        </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <EditRowStyle BackColor="White" />
    </asp:GridView>
    </td>
    </tr>
    <tr><td>
        <img src="images/correct.png" alt="No further info" width="15px" />&nbsp;Queries not needing further info:</td></tr>
    <tr>
    <td>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
        EmptyDataText="There are no data records to display." ForeColor="#333333" GridLines="None"
        Style="font-family: Calibri; font-size: small" AllowPaging="True" AllowSorting="True"
        Width="374px" onpageindexchanged="gvShowQuery_PageIndexChanged" 
        onpageindexchanging="gvShowQuery_PageIndexChanging1" PageSize="5">
        <RowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <table width="400px" cellpadding="3">
                        <tr>
                            <td width="300px">
                                <img src="images/bullet.png" alt="Area of Interest" width="11px" /> <b><asp:Label ID="lblAreaOfInterest" style="font-size:large" runat="server" Text='<%# Eval("QueryAreaOfInterest")%>'></asp:Label></b>
                               </td>
                            <td width="100px">
                               
                            </td>
                        </tr>
                        <tr>
                            <td width="400px" colspan="2">Symptoms:&nbsp
                                <asp:Label ID="lblSymptoms" runat="server" Text='<%# Eval("Symptoms")%>' /><br />
                                 Medical History:&nbsp<asp:Label ID="lblMedicalHistory" runat="server" Text='<%# Eval("MedicalHistory")%>' />
                            </td>
                        </tr>
                        <tr>
                        <tr>
                            <td colspan="2" class="UserHomePosted">
                                Posted on: 
                                <%# Eval("PostedDateTime")%>
                            </td>
                        </tr>

                        </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <EditRowStyle BackColor="White" />
    </asp:GridView>
    </td>
    </tr>
    </table>
    </center>
</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorHome.aspx.cs" Inherits="DoctorHome" MasterPageFile="MasterPage.master" %>

<asp:Content ID="contDoctorHome" ContentPlaceHolderID="cphMain" runat="Server">

    <form action="#">
    <div id="content">
        <table width="100%">
            <tr>
                <td colspan="2" align="center">
                    Worklist
                </td>
            </tr>
            <tr>
                <td align="center">
                    Not Attended
                </td>
                <td align="center">
                    Attended
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                        AutoGenerateColumns="False" Width="322px">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:HyperLink ID="hypLnkAdvice" runat="server" NavigateUrl='<%# Eval("QueryId","SubmitAdvice.aspx?QueryID={0}") %>'
                                        Text="Advice" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Username" HeaderText="Username" />
                            <asp:BoundField DataField="PostedDateTime" HeaderText="Posted On" />
                            <asp:BoundField DataField="QueryAreaOfInterest" HeaderText="Department" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
                </td>
                <td>
                    <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                        AutoGenerateColumns="False" Width="334px">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:HyperLink ID="hypLnkAdviceDetails" runat="server" NavigateUrl='<%# Eval("QueryId","AdviceDetails.aspx?QueryID={0}") %>'
                                        Text="Details" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Username" HeaderText="Username" />
                            <asp:BoundField DataField="PostedDateTime" HeaderText="Posted On" />
                            <asp:BoundField DataField="QueryAreaOfInterest" HeaderText="Department" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    </form>
</asp:Content>

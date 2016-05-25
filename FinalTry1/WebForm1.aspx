<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FinalTry1.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1 style="font-family: 'Britannic Bold'; font-size: x-large; text-decoration: underline; display: block">
            Prices Of Unlocking
        </h1>
    </div>

    <div>
        <table>
        <tr>
            <td class="td">ModelName:</td>
            <td>
                <asp:TextBox ID="txtModel" runat="server"></asp:TextBox></td>
            <td>
                <asp:Label ID="ModelName1" runat="server" Visible="false"></asp:Label>&nbsp;</td>
        </tr>
        <tr>
            <td class="td">Rogers:</td>
            <td>
                <asp:TextBox ID="txtRogers" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="td">Bell:</td>
            <td>
                <asp:TextBox ID="txtBell" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="td">Telus</td>
            <td>
                <asp:TextBox ID="txtTelus" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="td">Fido</td>
            <td>
                <asp:TextBox ID="txtFido" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
            <tr>
            <td class="td">Koodo</td>
            <td>
                <asp:TextBox ID="txtKoodo" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
            <tr>
            <td class="td">Virgin</td>
            <td>
                <asp:TextBox ID="txtVirgin" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
            <tr>
            <td class="td">Wind</td>
            <td>
                <asp:TextBox ID="txtWind" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
            <tr>
            <td class="td">Other</td>
            <td>
                <asp:TextBox ID="txtOther" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
              </td>
            <td></td>
        </tr>
    </table>

    </div>


    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="FinalTry1.UnlockingPrice" DeleteMethod="DeleteProduct" InsertMethod="AddProduct" SelectMethod="getProducts" TypeName="FinalTry1.UnlockingPriceClass" UpdateMethod="UpdateProduct"></asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="ObjectDataSource1" PageSize="5" Width="791px" AutoGenerateColumns="False" HorizontalAlign="Center">
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            <asp:BoundField DataField="modelName" HeaderText="modelName" SortExpression="modelName" />
            <asp:BoundField DataField="Rogers" HeaderText="Rogers" SortExpression="Rogers" />
            <asp:BoundField DataField="Bell" HeaderText="Bell" SortExpression="Bell" />
            <asp:BoundField DataField="Telus" HeaderText="Telus" SortExpression="Telus" />
            <asp:BoundField DataField="Fido" HeaderText="Fido" SortExpression="Fido" />
            <asp:BoundField DataField="Koodo" HeaderText="Koodo" SortExpression="Koodo" />
            <asp:BoundField DataField="Virgin" HeaderText="Virgin" SortExpression="Virgin" />
            <asp:BoundField DataField="Wind" HeaderText="Wind" SortExpression="Wind" />
            <asp:BoundField DataField="Other" HeaderText="Other" SortExpression="Other" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
</asp:GridView>
</asp:Content>

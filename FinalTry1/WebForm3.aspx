<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="FinalTry1.WebForm3" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <h1>
        OtterBox Sales History
    </h1>
</div>

    <div>
        <table>
        <tr>
            <td class="td">OtterBox:</td>
            <td>
                <asp:TextBox ID="txtOtterBox" runat="server"></asp:TextBox></td>
            <td>
                <asp:Label ID="OtterBox" runat="server" Visible="false"></asp:Label>&nbsp;</td>
        </tr>
        <tr>
            <td class="td">Type:</td>
            <td>
                <asp:TextBox ID="txtType" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="td">Color:</td>
            <td>
                <asp:TextBox ID="txtColor" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="td">InStock</td>
            <td>
                <asp:TextBox ID="txtInStock" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="td">Sold</td>
            <td>
                <asp:TextBox ID="txtSold" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
            <tr>
            <td class="td">ModelInStock</td>
            <td>
                <asp:TextBox ID="txtModelInStock" runat="server"></asp:TextBox></td>
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


    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="FinalTry1.OtterBoxSales" DeleteMethod="DeleteProduct" InsertMethod="AddProduct" SelectMethod="getProducts" TypeName="FinalTry1.OtterBoxSalesHistory" UpdateMethod="UpdateProduct"></asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="Vertical" PageSize="5" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
            <asp:BoundField DataField="OtterBoxModel" HeaderText="OtterBoxModel" SortExpression="OtterBoxModel" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            <asp:BoundField DataField="InStock" HeaderText="InStock" SortExpression="InStock" />
            <asp:BoundField DataField="Sold" HeaderText="Sold" SortExpression="Sold" />
            <asp:BoundField DataField="ModelStock" HeaderText="ModelStock" SortExpression="ModelStock" />
            <asp:TemplateField>
              <FooterTemplate>
               <asp:LinkButton ID="LkB1" runat="server" CommandName="Select">Insert</asp:LinkButton>
              </FooterTemplate>
           </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
</asp:Content>


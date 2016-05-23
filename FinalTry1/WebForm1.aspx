<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FinalTry1.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>
            Prices Of Unlocking
        </h1>
    </div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="FinalTry1.UnlockingPrice" DeleteMethod="DeleteProduct" InsertMethod="AddProduct" SelectMethod="getProducts" TypeName="FinalTry1.UnlockingPriceClass" UpdateMethod="UpdateProduct"></asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="ObjectDataSource1" PageSize="5" Width="791px" AutoGenerateColumns="False">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
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

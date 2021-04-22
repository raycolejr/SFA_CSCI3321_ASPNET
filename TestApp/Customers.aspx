<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="TestApp.Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Customers</h3>
    <asp:Label ID="lblCustomerCount" runat="server" ></asp:Label>
    
    <br />
    <asp:Table ID="tblCustomers" runat="server" CssClass="table table-stripe">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>CustomerID</asp:TableHeaderCell>
            <asp:TableHeaderCell>Customer Name</asp:TableHeaderCell>
            <asp:TableHeaderCell>Contact Name</asp:TableHeaderCell>
            <asp:TableHeaderCell>Address</asp:TableHeaderCell>
            <asp:TableHeaderCell>City</asp:TableHeaderCell>
            <asp:TableHeaderCell>Postal Code</asp:TableHeaderCell>
            <asp:TableHeaderCell>Country</asp:TableHeaderCell>
        </asp:TableHeaderRow>

    </asp:Table>
    
</asp:Content>

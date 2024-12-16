

<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="FetchProduct.aspx.cs" Inherits="MasterPage.FetchProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

    <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand">
    </asp:DataList>

    

</asp:Content>

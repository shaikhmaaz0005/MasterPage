<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="MasterPage.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView runat="server">
        <columns>
            <asp:TemplateField HeaderText="PID">
                <ItemTemplate> >
            <asp:Label ID="Lable1" runat="server" Text='<%#Eval("pid") %>'></asp:Label>
                    </ItemTemplate
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Image">
    <ItemTemplate> >
<asp:Label ID="Lable1" runat="server" Text='<%#Eval("pic") %>'></asp:Label>
        </ItemTemplate
</asp:TemplateField>

            <asp:TemplateField HeaderText="PName">
    <ItemTemplate> >
<asp:Label ID="Lable2" runat="server" Text='<%#Eval("pname") %>'></asp:Label>
        </ItemTemplate
</asp:TemplateField>
            <asp:TemplateField HeaderText="PCAT">
    <ItemTemplate> >
<asp:Label ID="Lable3" runat="server" Text='<%#Eval("pcat") %>'></asp:Label>
        </ItemTemplate
</asp:TemplateField>

            <asp:TemplateField HeaderText="Price">
    <ItemTemplate> >
<asp:Label ID="Lable4" runat="server" Text='<%#Eval("price") %>'></asp:Label>
        </ItemTemplate
</asp:TemplateField>

            <asp:TemplateField HeaderText="Qty">
    <ItemTemplate> >
<asp:Label ID="Lable5" runat="server" Text='<%#Eval("qty") %>'></asp:Label>
        </ItemTemplate
</asp:TemplateField>

            <asp:TemplateField HeaderText="Total">
    <ItemTemplateTotal> >
<asp:Label ID="Lable6" runat="server" Text='<%#Eval("total") %>'></asp:Label>
        </ItemTemplateTotal
</asp:TemplateField>

            <asp:TemplateField HeaderText="Date">
    <ItemTemplate> >
<asp:Label ID="Lable7" runat="server" Text='<%#Eval("dt") %>'></asp:Label>
        </ItemTemplate
</asp:TemplateField>


            <asp:TemplateField HeaderText="Date">
    <ItemTemplate> >
        <asp:Button ID="Button1" runat="server" CommandName="Delete" Text="Remove" class="btn btn-primary" />
        </ItemTemplate
</asp:TemplateField>






        </columns>
    </asp:GridView>
</asp:Content>

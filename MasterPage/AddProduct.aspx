<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="MasterPage.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Add Product
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    This is my Add Product Page

    <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <title>A</title>
      <style>
        /* General form styles */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f7fc;
            margin: 0;
            padding: 0;
        }

        .form-control {
            max-width: 500px;
            margin: 50px auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
            margin-bottom: 20px;
            color: #333;
        }

        label {
            font-weight: bold;
            color: #555;
        }

        /* Input and TextBox styles */
        .form-control input[type="text"],
        .form-control input[type="file"],
        .form-control select {
            width: 100%;
            padding: 10px;
            margin: 8px 0;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            font-size: 16px;
            background-color: #f9f9f9;
        }

        .form-control input[type="text"]:focus,
        .form-control select:focus,
        .form-control input[type="file"]:focus {
            border-color: #5b9bd5;
            outline: none;
        }

        .form-control .style {
            width: 100%;
        }

        /* Button style */
        .form-control button {
            background-color: #4CAF50;
            color: white;
            padding: 12px 20px;
            margin: 10px 0;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            width: 100%;
            font-size: 18px;
        }

        .form-control button:hover {
            background-color: #45a049;
        }

        /* Adding space between the fields */
        .form-control br {
            line-height: 20px;
        }
    </style>
</head>

<body>
    
        <div>
            <h2>Product Form</h2>
            <label for="TextBox1">Product Name</label>
            <asp:TextBox ID="TextBox1" class="style" runat="server"></asp:TextBox>
            <br />

            <label for="DropDownList1">Product Category</label>
            <asp:DropDownList ID="DropDownList1" class="style" runat="server">
                <asp:ListItem>Electronics</asp:ListItem>
                <asp:ListItem>Foods</asp:ListItem>
                <asp:ListItem>Cloths</asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>
            </asp:DropDownList>
            <br />

            <label for="FileUpload1">Product Image</label>
            <asp:FileUpload ID="FileUpload1" class="style" runat="server" />
            <br />

            <label for="TextBox2">Product Price</label>
            <asp:TextBox ID="TextBox2" class="style" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="Button1" class="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Save" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    
</body>
</html>

</asp:Content>
    



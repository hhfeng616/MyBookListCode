<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="WebFormsEF.ProductDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <asp:FormView ID="Product" runat="server" SelectMethod="Product_GetItem" >
                <ItemTemplate>
                   <table>
                      <tr>
                         <td><b>ID:</b></td>
                         <td><%# Eval("ID") %></td>
                      </tr>
                      <tr>
                         <td><b>Name:</b></td>
                         <td><%# Eval("Name") %></td>
                      </tr>
                      <tr>
                         <td><b>Price</b></td>
                         <td><%# Eval("Price") %></td>
                      </tr>
                      <tr>
                         <td><b>Category</b></td>
                         <td><%# Eval("Category") %></td>
                      </tr>
                   </table>
                </ItemTemplate>
            </asp:FormView>
        </div>
    </form>
</body>
</html>

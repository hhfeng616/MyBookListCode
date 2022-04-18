<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WcfEF.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:1em 0;">
        <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox><asp:Button ID="IdButton" runat="server" Text="搜索" OnClick="IdButton_Click" />
      <asp:Button ID="ProductButton" runat="server" Text="商品列表" OnClick="ProductButton_Click" />
         </div>
        
        <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>
        <asp:GridView ID="ProductGridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>

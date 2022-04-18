﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="WebFormsEF.ProductList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">        

    <div style="margin:1em auto;width:70%;">

        <div style="margin:1em 0;">
        商品名称：<asp:TextBox ID="ProductName" runat="server"></asp:TextBox>
            <asp:Button ID="SearchButton" runat="server" Text="搜索" />
        
        </div>
        <asp:GridView ID="Products" runat="server" 
            SelectMethod="SelectProduct" Width="100%" 
            DataKeyNames="id" UpdateMethod="UpdateProduct" 
            AutoGenerateEditButton="true"
            DeleteMethod="DeleteProduct"  
            AutoGenerateDeleteButton ="true"    
        >
        </asp:GridView>
    </div>
     
    </form>
</body>
</html>

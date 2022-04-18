<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoryProducts.aspx.cs" Inherits="WebFormsR.CategoryProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        选择商品分类　
        <asp:DropDownList ID="CategoryList" runat  ="server"  AutoPostBack="True" 
            DataTextField="Name"  DataValueField="Id" 
            OnSelectedIndexChanged="CategoryList_SelectedIndexChanged"
            SelectMethod="FillCategory"
            >
        </asp:DropDownList>
        <hr />
        <%--<asp:HiddenField ID="CategoryId" runat="server" />--%>
        <asp:GridView ID="Products" runat="server"  ></asp:GridView>

    </div>

    </form>
</body>
</html>

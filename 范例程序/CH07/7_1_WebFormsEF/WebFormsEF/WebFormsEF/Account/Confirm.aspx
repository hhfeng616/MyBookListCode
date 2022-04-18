<%@ Page Title="账户确认" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="WebFormsEF.Account.Confirm" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>。</h2>

    <div>
        <asp:PlaceHolder runat="server" ID="successPanel" ViewStateMode="Disabled" Visible="true">
            <p>
                感谢您确认账户。按一下 <asp:HyperLink ID="login" runat="server" NavigateUrl="~/Account/Login">这里</asp:HyperLink>  登录             
            </p>
        </asp:PlaceHolder>
        <asp:PlaceHolder runat="server" ID="errorPanel" ViewStateMode="Disabled" Visible="false">
            <p class="text-danger">
                发生错误
            </p>
        </asp:PlaceHolder>
    </div>
</asp:Content>

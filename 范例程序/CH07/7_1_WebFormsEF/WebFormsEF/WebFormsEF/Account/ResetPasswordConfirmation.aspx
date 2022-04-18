<%@ Page Title="变更密码" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResetPasswordConfirmation.aspx.cs" Inherits="WebFormsEF.Account.ResetPasswordConfirmation" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <div>
        <p>您的密码已变更。单击 <asp:HyperLink ID="login" runat="server" NavigateUrl="~/Account/Login">这里</asp:HyperLink> 登入 </p>
    </div>
</asp:Content>

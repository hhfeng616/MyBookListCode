<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lockout.aspx.cs" Inherits="WebFormsEF.Account.Lockout" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup>
        <h1>已锁定。</h1>
        <h2 class="text-danger">此账户已锁定，请稍后再试。</h2>
    </hgroup>
</asp:Content>
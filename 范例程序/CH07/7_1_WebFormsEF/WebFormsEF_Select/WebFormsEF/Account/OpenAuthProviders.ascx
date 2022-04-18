<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpenAuthProviders.ascx.cs" Inherits="WebFormsEF.Account.OpenAuthProviders" %>

<div id="socialLoginList">
    <h4>使用其他服务进行登录。</h4>
    <hr />
    <asp:ListView runat="server" ID="providerDetails" ItemType="System.String"
        SelectMethod="GetProviderNames" ViewStateMode="Disabled">
        <ItemTemplate>
            <p>
                <button type="submit" class="btn btn-default" name="provider" value="<%#: Item %>"
                    title="使用您的账户<%#: Item %>登入。">
                    <%#: Item %>
                </button>
            </p>
        </ItemTemplate>
        <EmptyDataTemplate>
            <div>
                <p>未设置任何外部验证服务。请参阅<a href="http://go.microsoft.com/fwlink/?LinkId=252803">本文</a>，取得设置此 ASP.NET 应用程序的详细数据，以支持通过外部服务进行登录。</p>
            </div>
        </EmptyDataTemplate>
    </asp:ListView>
</div>


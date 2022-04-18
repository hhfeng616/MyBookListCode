<%@ Page Title="管理账户" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="WebFormsEF.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <div>
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
            <p class="text-success"><%: SuccessMessage %></p>
        </asp:PlaceHolder>
    </div>

    <div class="row">
        <div class="col-md-12">
            <div class="form-horizontal">
                <h4>变更您的账户设置</h4>
                <hr />
                <dl class="dl-horizontal">
                    <dt>密码:</dt>
                    <dd>
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[变更]" Visible="false" ID="ChangePassword" runat="server" />
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[创建]" Visible="false" ID="CreatePassword" runat="server" />
                    </dd>
                    <dt>外部登录:</dt>
                    <dd><%: LoginsCount %>
                        <asp:HyperLink NavigateUrl="/Account/ManageLogins" Text="[管理]" runat="server" />

                    </dd>
                    <%--
                        电话号码可以当做双因素验证系统中的第二个验证因素。
                        如果设置此 ASP.NET 应用程序以使用 SMS 支持双因素验证的详细数据，请参阅
                       <a href="http://go.microsoft.com/fwlink/?LinkId=403804">此文章</a>。
                        设置双因素验证后请取注释以下的区块
                    --%>
                    <%--
                    <dt>电话号码:</dt>
                    <% if (HasPhoneNumber)
                       { %>
                    <dd>
                        <asp:HyperLink NavigateUrl="/Account/AddPhoneNumber" runat="server" Text="[添加]" />
                    </dd>
                    <% }
                       else
                       { %>
                    <dd>
                        <asp:Label Text="" ID="PhoneNumber" runat="server" />
                        <asp:HyperLink NavigateUrl="/Account/AddPhoneNumber" runat="server" Text="[变更]" /> &nbsp;|&nbsp;
                        <asp:LinkButton Text="[移除]" OnClick="RemovePhone_Click" runat="server" />
                    </dd>
                    <% } %>
                    --%>

                    <dt>双因素验证:</dt>
                    <dd>
                        <p>
                            尚未设置双因素验证提供者。如果设置此 ASP.NET 应用程序以支持双因素验证的详细数据，请参阅
                            <a href="http://go.microsoft.com/fwlink/?LinkId=403804">此文章</a>。
                        </p>
                        <% if (TwoFactorEnabled)
                          { %> 
                        <%--
                        已启用
                        <asp:LinkButton Text="[Disable]" runat="server" CommandArgument="false" OnClick="TwoFactorDisable_Click" />
                        --%>
                        <% }
                          else
                          { %> 
                        <%--
                        已停用
                        <asp:LinkButton Text="[Enable]" CommandArgument="true" OnClick="TwoFactorEnable_Click" runat="server" />
                        --%>
                        <% } %>
                    </dd>
                </dl>
            </div>
        </div>
    </div>

</asp:Content>

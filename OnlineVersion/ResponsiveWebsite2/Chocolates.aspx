<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true"
    CodeBehind="Chocolates.aspx.cs" Inherits="ResponsiveWebsite2.Chocolates" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Chocolates</h1>
    <hr />
    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">
            All Chocolates</div>
        <asp:Repeater ID="rptrChocolates" runat="server">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                             <th>
                                #
                            </th>
                            <th>
                                ItemName
                            </th>
                            <th>
                                Price
                            </th>
                            <th>
                                Remaining
                            </th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <th>
                        <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" Text='<%#Eval("item_id") %>'  runat="server">LinkButton</asp:LinkButton>
                    </th>
                    <td>
                        <%# Eval("item_name") %>
                    </td>
                    <td>
                        <%# Eval("selling_price") %>
                    </td>
                    <td>
                         <%# Eval("rest_items") %>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody> </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true"
    CodeBehind="ProductView.aspx.cs" Inherits="ResponsiveWebsite2.ProductView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="padding-top: 50px">
        <asp:Repeater ID="rptrProducts" runat="server">
            <ItemTemplate>
                <div class="col-sm-3 col-md-3">
                    <a style="text-decoration: none;" href="ProductDetails.aspx?barcode=<%#Eval("barcode") %>" >
                        <div class="thumbnail">
                            <img src="Images/ProductImages/<%#Eval("barcode") + ".jpg" %>"
                                alt="">
                            <div class="caption">
                                <div class="probrand">
                                    <%#Eval("Item_name") %></div>
                                </br>
                                <div class="probrand">
                                Price:
                                    <%#Eval("selling_price")%> Tk.</div>
                                    </br>
                                    <div class="proprice">
                                Stock:
                                    <%#Eval("rest_item")%></div>
                                
                            </div>
                        </div>
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true"
    CodeBehind="ProductDetails.aspx.cs" Inherits="ResponsiveWebsite2.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="padding-top: 50px">
        <asp:Repeater ID="rptrProductDetails" runat="server">
            <ItemTemplate>
                <div class="col-sm-3 col-md-3">
                    <a style="text-decoration: none;" href="">
                        <div class="thumbnail">
                            <img src="Images/ProductImages/<%#Eval("barcode") + ".jpg" %>" alt="">
                            <div class="caption">
                                <div class="probrand">
                                    <%#Eval("item_name") %></div>
                                </br>
                                <div class="probrand">
                                    Price:
                                    <%#Eval("selling_price") %>
                                    Tk.</div>
                                </br>
                                <div class="proName">
                                    In Stock:
                                    <%#Eval("rest_item") %></div>
                                <div class="proName">
                                    Weight:
                                    <%#Eval("weight") %></div>
                                  
                            </div>
                        </div>
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div class="col-md-6" style="padding-top: 50px">
            <asp:Label ID="Label1" runat="server" CssClass="col-md-2 control-label" Text="Quantity"></asp:Label>
            </br>
            <div class="col-md-3">
                <asp:TextBox ID="quantity" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" CssClass="text-danger"
                    runat="server" ErrorMessage="The Quantity field is Required !" ControlToValidate="quantity"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="col-md-6" style="padding-top: 20px">
            <asp:Button ID="add_to_cart_btn" runat="server" Text="Add to Cart" class="btn btn-lg btn-primary"
                OnClick="add_to_cart_btn_Cliked" />
        </div>
    </div>
</asp:Content>

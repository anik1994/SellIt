<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true"
    CodeBehind="Products.aspx.cs" Inherits="ResponsiveWebsite2.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="padding-top: 50px">
        <div class="col-sm-3 col-md-3">
            <a style="text-decoration: none;" href="Chocolates.aspx"  target="">
                <a style="text-decoration:none;" href="ProductView.aspx?type=Chocolate">
                <div class="thumbnail">
                    <img src="Images/chocolate1.jpg" alt="...">
                    <div class="caption">
                        <center>
                            <h3>
                                Chocolates</h3>
                        </center>
                        <!-- <p>...</p> -->
                    </div>
                </div>
            </a>
        </div>
        <div class="col-sm-3 col-md-3">
            <a style="text-decoration: none;" href="">
                <a style="text-decoration:none;" href="ProductView.aspx?type=beverages"> 
                <div class="thumbnail">
                    <img src="Images/beverage1.jpg" alt="...">
                    <div class="caption">
                        <center>
                            <h3>
                                Beverage</h3>
                        </center>
                        <!-- <p>...</p> -->
                    </div>
                </div>
            </a>
        </div>
        <div class="col-sm-3 col-md-3">
            <a style="text-decoration: none;" href="">
                <!-- <a style="text-decoration:none;" href="ProductView.aspx?PID=<%#Eval("PID") %>"> -->
                <div class="thumbnail">
                    <img src="Images/cookkies1.jpg" alt="...">
                    <div class="caption">
                        <center>
                            <h3>
                               Cookkies</h3>
                        </center>
                        <!-- <p>...</p> -->
                    </div>
                </div>
            </a>
        </div>
    </div>
</asp:Content>

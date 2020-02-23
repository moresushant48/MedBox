<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ViewRequests.aspx.cs" Inherits="OnlineMedicineDonation.ViewRequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:MultiView ID="MultiView1" runat="server">

        <asp:View ID="View1" runat="server">
        
        <div class="p-4">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="gridview w-100 container-fluid" GridLines="None">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <div class="border-secondary text-decoration-none text-dark card card-body bg-white w-100">

                            <div class="row mx-2">
                                <h5 class="col"><%# Eval("title") %></h5>
                                <h5 class="col"><%# Eval("desc") %></h5>
                                <h5 class="col"><%# Eval("goal") %> Qty.</h5>
                                <asp:HyperLink ID="lnkDonate" Text="Donate" runat="server" NavigateUrl='<%# Eval("id", "/viewMedicine.aspx?medId={0}") %>'></asp:HyperLink>
                            </div>
                        
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>

        </asp:View>

        <asp:View ID="View2" runat="server">

        </asp:View>

        <asp:View ID="View3" runat="server">

        </asp:View>

    </asp:MultiView>

</asp:Content>

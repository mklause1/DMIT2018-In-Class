<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MenuItems.aspx.cs" Inherits="MenuItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <%--Original menu repeater
        
        <asp:Repeater ID="MenuItemRepeater" runat="server" DataSourceID="MenuItemDataSource">
        <ItemTemplate>
            <%# ((decimal)Eval("CurrentPrice")).ToString("C") %>
            &mdash; <%# Eval("Description") %> &ndash; <%# Eval("Category.Description") %>
            &ndash; <%# Eval("Calories") %> Calories

        </ItemTemplate>

        <SeparatorTemplate>
            <hr />
        </SeparatorTemplate>

    </asp:Repeater>--%>


    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="MenuItemDataSource">
        <ItemTemplate>
            <div class="well well-lg">
            <h3><img src='<%# "Images/" + Eval("Description") + "-1.png" %>' alt="" /> 
            <%# Eval("Description") %></h3>
            <asp:Repeater ID="ItemDetailRepeater" runat="server" DataSource='<%# Eval("MenuItems") %>'>
                <ItemTemplate>
                    <div class="well well-sm">
                        <h4>
                            <%# Eval("Description") %>
                            <span class="badge"><%# Eval("Calories") %> Calories</span>
                            <%# ((decimal)Eval("Price")).ToString("C") %>
                        </h4>
                        <%# Eval("Comment") %>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
                </div>
        </ItemTemplate>

        <SeparatorTemplate>
            <hr />
        </SeparatorTemplate>

    </asp:Repeater>

    <asp:ObjectDataSource runat="server" ID="MenuItemDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListCategorizedMenuItems" TypeName="eRestaurant.BLL.MenuController"></asp:ObjectDataSource>

</asp:Content>


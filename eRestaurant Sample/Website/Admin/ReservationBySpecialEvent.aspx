<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReservationBySpecialEvent.aspx.cs" Inherits="ReservationBySpecialEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    Special Event
    <asp:DropDownList ID="SpecialEventDropDown" runat="server" DataSourceID="SpecialEventDropDownDataObject" DataTextField="EventCode" DataValueField="EventCode" AppendDataBoundItems="true">
        <asp:ListItem>Select an Event</asp:ListItem>
        <asp:ListItem>No Event</asp:ListItem>
    </asp:DropDownList>

    <asp:LinkButton ID="ViewReservationsButton" runat="server">View Reservations</asp:LinkButton>

    <br />
    <br />

    Reservations:
    <br />

    <asp:GridView ID="ReservationsGridView" runat="server" AutoGenerateColumns="False" DataSourceID="ReservationsGridViewDataObject">
        <Columns>
            <asp:BoundField DataField="ReservationID" HeaderText="ReservationID" SortExpression="ReservationID" />
            <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" SortExpression="CustomerName" />
            <asp:BoundField DataField="ReservationDate" HeaderText="ReservationDate" SortExpression="ReservationDate" />
            <asp:BoundField DataField="NumberInParty" HeaderText="NumberInParty" SortExpression="NumberInParty" />
            <asp:BoundField DataField="ContactPhone" HeaderText="ContactPhone" SortExpression="ContactPhone" />
            <asp:BoundField DataField="ReservationStatus" HeaderText="ReservationStatus" SortExpression="ReservationStatus" />
            <asp:BoundField DataField="EventCode" HeaderText="EventCode" SortExpression="EventCode" />
        </Columns>
    </asp:GridView>

    <asp:ObjectDataSource ID="ReservationsGridViewDataObject" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListReservationsBySpecialID" TypeName="eRestaurant.BLL.RestaurantAdminController">
        <SelectParameters>
            <asp:ControlParameter ControlID="SpecialEventDropDown" Name="SpecialEventID" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>

    <asp:ObjectDataSource runat="server" ID="SpecialEventDropDownDataObject" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllSpecialEvents" TypeName="eRestaurant.BLL.RestaurantAdminController"></asp:ObjectDataSource>
</asp:Content>


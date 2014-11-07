<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FrontDesk.aspx.cs" Inherits="FrontDesk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Front Desk</h1>

        

        <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

        <div class="pull-right col-md-5">
               <details open>
                   <summary>Reservations by Date/Time</summary>
                   <asp:Repeater ID="ReservationRepeater" runat="server" ItemType="eRestaurant.Entities.DTOs.ReservationCollection" DataSourceID="ReservationsDataSource">
                       <ItemTemplate>
                           <div>
                               <h4><%# Item.Time %></h4>
                               <%# Item.Reservations.Count %>
                           </div>
                       </ItemTemplate>
                   </asp:Repeater>
                   <asp:ObjectDataSource runat="server" ID="ReservationsDataSource"></asp:ObjectDataSource>
               </details>
        </div>

        <div class="col-md-7">
            <details open>
                <summary>Tables</summary>
            </details>
        </div>

    </div>
</asp:Content>


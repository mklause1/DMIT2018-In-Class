<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FrontDesk.aspx.cs" Inherits="Staff_FrontDesk" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <style type="text/css">
        .seating {
            display: inline-block;
            vertical-align: top;
        }
    </style>

    <div class="row col-md-12">

        <h1>Front Desk</h1>

        </div>

    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

    <div class="pull-right col-md-5">
        <details open>
            <summary>Reservations by Date/Time</summary>
            <h4></h4>
        </details>
    </div>

</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FrontDesk.aspx.cs" Inherits="Staff_FrontDesk" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="well">
        <h4>Mock Date/Time</h4>

        <div class="pull-right col-md-5">
            Last Billed Date/Time:
            <asp:Repeater ID="Repeater1" runat="server"></asp:Repeater>

            <asp:ObjectDataSource ID="AdHocBillDateDataSource" runat="server"></asp:ObjectDataSource>

        </div>

    </div>

</asp:Content>


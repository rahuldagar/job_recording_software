<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Finish_Activity.aspx.cs" Inherits="Finish_Activity" %>

<%@ Register src="view_open_bookings.ascx" tagname="view_open_bookings" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:view_open_bookings ID="view_open_bookings1" runat="server" />
</asp:Content>


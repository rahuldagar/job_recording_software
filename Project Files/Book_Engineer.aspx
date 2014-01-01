<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Book_Engineer.aspx.cs" Inherits="Book_Engineer" %>

<%@ Register src="DataGrid_Engineer.ascx" tagname="DataGrid_Engineer" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:DataGrid_Engineer ID="DataGrid_Engineer1" runat="server" />
</asp:Content>


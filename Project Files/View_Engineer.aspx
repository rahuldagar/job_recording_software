<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="View_Engineer.aspx.cs" Inherits="View_Engineer" %>

<%@ Register src="View_Previous.ascx" tagname="View_Previous" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:View_Previous ID="View_Previous1" runat="server" />
</asp:Content>


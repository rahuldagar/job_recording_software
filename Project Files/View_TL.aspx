<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="View_TL.aspx.cs" Inherits="View_TL" %>

<%@ Register src="View_Drop_D.ascx" tagname="View_Drop_D" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:View_Drop_D ID="View_Drop_D1" runat="server" />
</asp:Content>


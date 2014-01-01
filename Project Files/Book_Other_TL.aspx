<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Book_Other_TL.aspx.cs" Inherits="Book_Other_TL" %>

<%@ Register src="Search_Team_Lead.ascx" tagname="Search_Team_Lead" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:Search_Team_Lead ID="Search_Team_Lead1" runat="server" />
</asp:Content>


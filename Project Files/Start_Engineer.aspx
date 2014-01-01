<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Start_Engineer.aspx.cs" Inherits="Start_Engineer" %>

<%@ Register src="Start_Activity.ascx" tagname="Start_Activity" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:Start_Activity ID="Start_Activity1" runat="server" />
</asp:Content>


<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register src="Login_Web_Control.ascx" tagname="Login_Web_Control" tagprefix="uc1" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        &nbsp;Welcome to JOB RECORDING SOFTWARE
    </h2>
    
    
<uc1:Login_Web_Control ID="Login_Web_Control1" runat="server" />
</asp:Content>

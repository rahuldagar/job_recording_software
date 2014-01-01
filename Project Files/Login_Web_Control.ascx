<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login_Web_Control.ascx.cs" Inherits="Login_Web_Control" %>
<p>
    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="User_Name_Label" runat="server"></asp:TextBox>
</p>
<asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="Password_Label" TextMode="Password" runat="server"></asp:TextBox>
<p style="margin-left: 160px">
    &nbsp; &nbsp;<asp:Button ID="Login_Button" runat="server" onclick="Login_Button_Click" 
        Text="Login" />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Message_Label" runat="server" ForeColor="Red" 
        Text="Please Enter Correct User Name/Password"></asp:Label>
</p>
<p>
    &nbsp;</p>


<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DataGrid_Engineer.ascx.cs" Inherits="DataGrid_Engineer" %>

<asp:DataGrid ID="DataGridEmployee" runat="server" BackColor="#DEBA84" AutoGenerateColumns="false"
    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    CellSpacing="2" align="center">
    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" Mode="NumericPages" />
    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
<Columns>
<asp:TemplateColumn HeaderText="Book">
<ItemTemplate>
<asp:CheckBox ID="Book_Checkbox" runat="server"/>
</ItemTemplate>
</asp:TemplateColumn>

<asp:TemplateColumn HeaderText="Activity Code">
<ItemTemplate>
<asp:Label ID="Activity_Code" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"Activity_Code") %>' Width="40px" Columns=4/>
</ItemTemplate>
</asp:TemplateColumn>

<asp:TemplateColumn HeaderText="Time Required(Hours)">
<ItemTemplate>
<asp:Label ID="Time_Required" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"Time_Required") %>' Width="40px" Columns=4/>
</ItemTemplate>
</asp:TemplateColumn>

<asp:TemplateColumn HeaderText="Status">
<ItemTemplate>
<asp:Label ID="Status" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"Status") %>' Width="40px" Columns=4/>
</ItemTemplate>
</asp:TemplateColumn>


</Columns>

</asp:DataGrid>



<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Update" runat="server" onclick="Update_Click" Text="Update" align="center" />
</p>




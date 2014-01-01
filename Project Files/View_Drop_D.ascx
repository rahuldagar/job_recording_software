<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Drop_D.ascx.cs" Inherits="View_Drop_D" %>
<asp:Label ID="Label1" runat="server" Text="Select Employee Code"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<br />
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
        Text="View " />
    &nbsp;<asp:DropDownList ID="DropDownList2" runat="server">
    <asp:ListItem Text="1" Value=1 Selected=True></asp:ListItem>
    <asp:ListItem Text="2" Value=2  ></asp:ListItem>
    <asp:ListItem Text="3" Value=3 ></asp:ListItem>
    <asp:ListItem Text="4" Value=4 ></asp:ListItem>
<asp:ListItem Text="5" Value=5 ></asp:ListItem>
<asp:ListItem Text="6" Value=6 ></asp:ListItem>
<asp:ListItem Text="7" Value=7 ></asp:ListItem>
<asp:ListItem Text="8" Value=8 ></asp:ListItem>
<asp:ListItem Text="9" Value=9 ></asp:ListItem>
<asp:ListItem Text="10" Value=10 ></asp:ListItem>
<asp:ListItem Text="11" Value=11 ></asp:ListItem>
<asp:ListItem Text="12" Value=12 ></asp:ListItem>
<asp:ListItem Text="13" Value=13 ></asp:ListItem>
<asp:ListItem Text="14" Value=14 ></asp:ListItem>
<asp:ListItem Text="15" Value=15 ></asp:ListItem>
<asp:ListItem Text="16" Value=16 ></asp:ListItem>
<asp:ListItem Text="17" Value=17 ></asp:ListItem>
<asp:ListItem Text="18" Value=18 ></asp:ListItem>
<asp:ListItem Text="19" Value=19 ></asp:ListItem>
<asp:ListItem Text="20" Value=20 ></asp:ListItem>
   <asp:ListItem Text="21" Value=21 ></asp:ListItem>
    </asp:DropDownList>
&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Days Only"></asp:Label>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &nbsp;<asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" 
        Text="View Own" />
</p>
<p>
    &nbsp;</p>
<asp:DataGrid ID="DataGridEmpCode" runat="server" BackColor="#DEBA84" AutoGenerateColumns="false"
    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    CellSpacing="2" align="center">
    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" Mode="NumericPages" />
    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />

<Columns>

<asp:TemplateColumn HeaderText="Activity Code">
<ItemTemplate>
<asp:Label ID="Activity_Code" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"Activity_Code") %>' Width="40px" Columns=4/>
</ItemTemplate>
</asp:TemplateColumn>


<asp:TemplateColumn HeaderText="Employee Code">
<ItemTemplate>
<asp:Label ID="Employee_Code" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"Employee_Code") %>' Width="40px" Columns=4/>
</ItemTemplate>
</asp:TemplateColumn>

<asp:TemplateColumn HeaderText="Start Time">
<ItemTemplate>
<asp:Label ID="Start_Time" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"Start_Time") %>' Width="40px" Columns=4/>
</ItemTemplate>
</asp:TemplateColumn>


<asp:TemplateColumn HeaderText="Stop Time">
<ItemTemplate>
<asp:Label ID="Stop_Time" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"Stop_Time") %>' Width="40px" Columns=4/>
</ItemTemplate>
</asp:TemplateColumn>

</Columns>

</asp:DataGrid>

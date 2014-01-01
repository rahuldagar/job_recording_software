<%@ Control Language="C#" AutoEventWireup="true" CodeFile="view_open_bookings.ascx.cs" Inherits="view_open_bookings" %>
<asp:DataGrid ID="DataGridCloseEmployee" runat="server" BackColor="#DEBA84" AutoGenerateColumns="false"
    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    CellSpacing="2" align="center">
    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" Mode="NumericPages" />
    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    <Columns>
        <asp:TemplateColumn HeaderText="CloseBooking">
            <ItemTemplate>
                <asp:CheckBox ID="CloseBooking_Checkbox" runat="server" />
            </ItemTemplate>
        </asp:TemplateColumn>
        <asp:TemplateColumn HeaderText="Activity Code">
            <ItemTemplate>
                <asp:Label ID="Activity_Code_Close" runat="server" Columns="4" 
                    Text='<%# DataBinder.Eval(Container.DataItem,"Activity_Code") %>' 
                    Width="40px" />
            </ItemTemplate>
        </asp:TemplateColumn>

        <asp:TemplateColumn HeaderText="Employee Code">
            <ItemTemplate>
                <asp:Label ID="Employee_Code_Close" runat="server" Columns="4" 
                    Text='<%# DataBinder.Eval(Container.DataItem,"Employee_Code") %>' 
                    Width="40px" />
            </ItemTemplate>
        </asp:TemplateColumn>

        <asp:TemplateColumn HeaderText="Start Time">
            <ItemTemplate>
                <asp:Label ID="Start_Time_Close" runat="server" Columns="4" 
                    Text='<%# DataBinder.Eval(Container.DataItem,"Start_Time") %>' 
                    Width="40px" />
            </ItemTemplate>
        </asp:TemplateColumn>


        
        <asp:TemplateColumn HeaderText="Stop Time">
            <ItemTemplate>
                <asp:Label ID="Stop_Time_Close" runat="server" Columns="4" 
                    Text='<%# DataBinder.Eval(Container.DataItem,"Stop_Time") %>' 
                    Width="40px" />
            </ItemTemplate>
        </asp:TemplateColumn>

    </Columns>
</asp:DataGrid>

<p>
    &nbsp;</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Close Bookings" />
</p>



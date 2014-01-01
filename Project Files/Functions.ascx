<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Functions.ascx.cs" Inherits="Functions" %>

<body>
    
    <div>
    
        <asp:Panel ID="Engineer_Panel" runat="server" Height="347px" Width="123px">
            <br />
            <asp:Button ID="Make_Booking_Engineer" runat="server" 
                onclick="Make_Booking_Engineer_Click" Text="Make Booking" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="View_Boooking_Engineer" runat="server" 
                onclick="View_Boooking_Engineer_Click" Text="View Booking" Width="124px" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Start_Activity_Engineer" runat="server" 
                onclick="Start_Activity_Engineer_Click" Text="Start Activity" Width="123px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Close_Activity_Engineer" runat="server" 
                onclick="Close_Activity_Engineer_Click" Text="Close Activity" Width="122px" />
            <br />
        </asp:Panel>

      
    
   
        

        <asp:Panel ID="Team_Lead_Panel" runat="server" Height="347px" Width="123px">
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Make_Booking_TL" runat="server" onclick="Make_Booking_TL_Click" 
                Text="Make Booking" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="View_Previous_Booking_TL" runat="server" 
                onclick="View_Previous_Booking_TL_Click" Text="View Pre Booking" 
                Width="121px" />
            <br />
            <br />
            <br />
            <br />

        </asp:Panel>


    <asp:Panel ID="Manager_Panel" runat="server" Height="347px" Width="123px">

            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="View_Booking_Manager" runat="server" 
                onclick="View_Booking_Manager_Click" Text="View Activities" Width="121px" />
            <br />

        </asp:Panel>


    
    </div>
    
</body>

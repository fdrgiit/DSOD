<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="IPAddress.ascx.cs" Inherits="publish.IPAddress" %>
<style type="text/css">
    .style1
    {
        text-align: center;
    }
</style>
<p id="P1" runat="server" style="font-family: Cambria;" class="style1">
    <asp:Label ID="Label1" runat="server">The User's IP address is: </asp:Label>
    <asp:Label ID="ipLabel" runat="server"> </asp:Label>
</p>
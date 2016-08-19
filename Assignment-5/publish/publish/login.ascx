<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="publish.login" %>
<%@ OutputCache duration="10" varybyparam="None" %>
<style type="text/css">
    .style1
    {
        height: 24px;
        width: 50px;
    }
    .style2
    {
        height: 18px;
        width: 50px;
    }
    .style3
    {
        height: 24px;
        width: 163px;
    }
    .style4
    {
        height: 12px;
        width: 50px;
    }
    .style5
    {
        height: 12px;
        width: 163px;
    }
    .style6
    {
        height: 18px;
        width: 163px;
    }
</style>
<table id="loginTable" style="margin-left: auto; margin-right: auto; margin-top: 80px; border: 1px black solid; background: #d7d6d1;" cellspacing="40" runat="server">
    <tr>
        <td class="style1">
            <label id="Label1" runat="server" style="font-family: Cambria;">Username</label>
        </td>
        <td class="style3">
            <asp:TextBox ID="Username" runat="server" Width="200px" style="font-family: Cambria;"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            <label id="Label2" runat="server" width="100px" style="font-family: Cambria;">Password</label>
        </td>
        <td class="style6">
            <asp:TextBox ID="Password" runat="server" Width="200px" TextMode="Password" style="font-family: Cambria;"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
            <label id="Label4" runat="server" width="100px" style="font-family: Cambria;">Role</label>
        </td>
        <td class="style5">
            
            <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="191px">
                <asp:ListItem>Customer</asp:ListItem>
                <asp:ListItem>Staff</asp:ListItem>
            </asp:DropDownList>
            
        </td>
    </tr>
</table>
<br />
<asp:Label ID="Label3" runat="server" 
    style="margin-left: 425px; font-family: Cambria;" BackColor="White" 
    ForeColor="Red" ></asp:Label>



<div id="btndiv" runat="server" style="margin-top: 50px; height: 50px; width: 560px; margin-left: 255px;" >                
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button class="btn" ID="loginBtn" runat="server" Text="SIGN IN" Width="152px" 
        Height="30px" 
        sytle="font-family: Cambria; margin-left: 30px; margin-right: 30px;" 
        onclick="loginBtn_Click"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
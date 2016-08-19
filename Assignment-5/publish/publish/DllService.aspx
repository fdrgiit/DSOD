<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DllService.aspx.cs" Inherits="publish.DllService" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
    .style1
    {
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        STRING SIMILARTY SERVICE (DLL)
    </h2>
<p>
    Description:&nbsp; Determining percentage similarity between two Strings: (Eg: 
    abc and abcd)</p>
<p class="style1">
    First String:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
</p>
<p class="style1">
    Second String:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
        Text="PROCESS STRING..." Width="324px" />
</p>
<asp:Label ID="Label6" runat="server"></asp:Label>
    <p>
        &nbsp;</p>
</asp:Content>


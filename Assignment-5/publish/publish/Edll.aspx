<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edll.aspx.cs" Inherits="publish.Edll" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        STRING ENCRYPTION/DECRYPTION SERVICE (DLL)
    </h2>
<p>
    Description:&nbsp; Getting the encrypted and the original string back from the 
    entered string.</p>
<p>
        &nbsp;Enter the string for encryption:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="242px"></asp:TextBox>
    </p>
    <p>
        &nbsp;The encrypted string is:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" 
            ReadOnly="True" Width="246px"></asp:TextBox>
    </p>
    <p>
        &nbsp;The decrypted string is:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" 
            ReadOnly="True" Width="240px"></asp:TextBox>
    </p>
    <p>
        &nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="PROCESS STRING..." Width="281px" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
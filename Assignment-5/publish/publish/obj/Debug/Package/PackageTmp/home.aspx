<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="publish.home" %>
<%@ Register src="IPAddress.ascx" tagname="IPAddress" tagprefix="uc1" %>

<%@ Register src="Date.ascx" tagname="Date" tagprefix="uc2" %>

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
        Welcome to wordplay</h2>
    <p>
        &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" style="margin-left: 0px" 
            Text="CLEAR COOKIES" Width="191px" onclick="Button1_Click" />
    </p>
    <div id="links" runat="server" class="style1">
                &nbsp;&nbsp;&nbsp;&nbsp; <a id="A1" href="register.aspx" runat="server">New Users</a>/<a id="A2" href="Default.aspx" runat="server">Existing Users</a>
            </div>
   <p class="style1">
   &nbsp;&nbsp;<a id="A3" href="Edll.aspx" runat="server">Encryption/Decryption</a></label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DllService.aspx">String Similarity</asp:HyperLink>
    </p>
    <p class="style1">
        Current User:&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </p>
    <p class="style1">
        Total visits:
                <asp:Label runat="server" ID="totalLabel"></asp:Label>
    </p>
    <p class="style1">
        Number of Current users:
                <asp:Label runat="server" ID="currentLabel"></asp:Label>
    </p><uc1:IPAddress ID="IPAddress1" runat="server"/>
            <uc2:Date ID="Date1" runat="server" />
    </asp:Content>


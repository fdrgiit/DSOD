<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="publish.login1" %>
<%@ Register TagPrefix="gui" TagName="login" Src="~/login.ascx" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        SIGNIN PAGE
    </h2>
    <gui:login runat="server" />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

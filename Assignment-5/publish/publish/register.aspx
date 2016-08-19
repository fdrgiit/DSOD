<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="publish.register" %>



<%@ Register src="Register.ascx" tagname="Register" tagprefix="uc1" %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        SIGNUP PAGE
    </h2>
    <p>
        <uc1:Register ID="Register1" runat="server" />
    </p>
    <p>
        &nbsp;</p>
    
</asp:Content>

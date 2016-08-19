<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Wordplay
    </h2>
    <p>
        &nbsp;&nbsp;&nbsp;
        REQUIRED SERVICE 1: <strong>WordFilter</strong>
    </p>
    <p>
        &nbsp; Description: Analyze a string of words and filter out 
        the function words as well as the element tags.&nbsp;
    </p>
    <p>
        &nbsp;&nbsp; Service Url: &nbsp;<a href="http://localhost:11598/Service1.svc?wsdl">http://localhost:11598/Service1.svc?wsdl</a></p>
    <p>
        &nbsp;&nbsp; Endpoint: &nbsp;string WordFilter(string str)</p>
<p>
        <strong>&nbsp; INPUT STRING:</strong></p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="112px" TextMode="MultiLine" 
            Width="640px"></asp:TextBox>
    </p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="WORD PROCESSING...." Width="636px" />
    </p>
    <p>
        &nbsp; <strong>RESULT:</strong>&nbsp;</p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="107px" TextMode="MultiLine" 
            Width="647px"></asp:TextBox>
    </p>
<p>
        &nbsp;</p>
<p>
        &nbsp;&nbsp;
        REQUIRED SERVICE 2 :<strong> Top10Words </strong></p>
<p>
        &nbsp; Description : Analyze the webpage at a given url and return 
        the ten most-frequently occurred words in the webpage.&nbsp;</p>
    <p>
        &nbsp; Service Url: &nbsp;<a href="http://localhost:1256/Service1.svc?wsdl">http://localhost:1256/Service1.svc?wsdl</a></p>
    <p>
        &nbsp; Endpoint: &nbsp;string[] Top10Words(string url)</p>
<p>
        &nbsp;<strong>&nbsp;INPUT URL:&nbsp; </strong></p>
<p>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="889px">http://</asp:TextBox>
    </p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="PROCESS URL.." Width="260px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p>
        &nbsp;&nbsp; <strong>RESULT:</strong>&nbsp;&nbsp;&nbsp;&nbsp; </p>
<p>
        &nbsp;
        &nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="880px"></asp:TextBox>
    </p>
<p>
        &nbsp;</p>
</asp:Content>

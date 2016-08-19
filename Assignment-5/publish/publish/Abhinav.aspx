<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Abhinav.aspx.cs" Inherits="publish.Abhinav" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 class="style1">
        WELCOME abhinav&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
            Text="RESET COOKIES" Width="162px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" onclick="Button7_Click" Text="SIGNOUT" 
            Width="125px" />
    </h2>
<p class="style1">
&nbsp;&nbsp; REQUIRED SERVICE 1: <strong>WordFilter</strong>
</p>
<p class="style1">
&nbsp; Description: Analyze a string of words and filter out the function words as 
    well as the element tags.</p>
    <p class="style1">
&nbsp;&nbsp;&nbsp; Service Url:
        <a href="http://localhost:1256/Service1.svc?wsdl">
        http://localhost:1256/Service1.svc?wsdl</a>&nbsp;</p>
    <p class="style1">
        &nbsp;
&nbsp;&nbsp; Endpoint: &nbsp;string WordFilter(string str)</p>
<p class="style1">
    <strong>&nbsp; INPUT STRING:</strong></p>
<p class="style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Height="112px" TextMode="MultiLine" 
        Width="640px"></asp:TextBox>
</p>
<p class="style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="WORD PROCESSING...." Width="636px" />
</p>
<p class="style1">
&nbsp; <strong>RESULT:</strong>&nbsp;</p>
<p class="style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Height="107px" TextMode="MultiLine" 
        Width="647px"></asp:TextBox>
</p>
<p class="style1">
    &nbsp;</p>
<p class="style1">
&nbsp;&nbsp; REQUIRED SERVICE 2 :<strong> Top10Words </strong>
</p>
<p class="style1">
&nbsp; Description : Analyze the webpage at a given url and return the ten 
    most-frequently occurred words in the webpage.</p>
    <p class="style1">
&nbsp;&nbsp;&nbsp;&nbsp; Service Url: <a href="http://localhost:1256/Service1.svc?wsdl">
        http://localhost:1256/Service1.svc?wsdl</a></p>
<p class="style1">
&nbsp; Endpoint: &nbsp;string[] Top10Words(string url)</p>
<p class="style1">
    &nbsp;<strong>&nbsp;INPUT URL:&nbsp; </strong>
</p>
<p class="style1">
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox8" runat="server" Width="889px">http://</asp:TextBox>
</p>
<p class="style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
        Text="PROCESS URL...." Width="263px" />
</p>
<p class="style1">
&nbsp;&nbsp; <strong>RESULT:</strong>&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p class="style1">
&nbsp; &nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="880px"></asp:TextBox>
</p>
<p class="style1">
        &nbsp;</p>
<p class="style1">
        &nbsp;ELECTIVE SERVICE 1 :<strong> Top10ContentWords </strong></p>
<p class="style1">
        &nbsp; Description : Analyze the webpage at a given url and return 
        the ten most-frequently occurred words in the webpage.&nbsp;</p>
    <p class="style1">
        &nbsp;&nbsp;&nbsp;&nbsp; Service Url:
        <a href="http://localhost:1256/Service1.svc?wsdl">
        http://localhost:1256/Service1.svc?wsdl</a></p>
    <p class="style1">
        &nbsp; Endpoint: &nbsp;string[] Top10ContentWords(string url)</p>
<p class="style1">
        &nbsp;<strong>&nbsp;INPUT URL:&nbsp; </strong></p>
<p class="style1">
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="889px">http://</asp:TextBox>
    </p>
<p class="style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
            ID="Button3" runat="server" onclick="Button3_Click" Text="PROCESS URL...." 
            Width="320px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p class="style1">
        &nbsp;&nbsp; <strong>RESULT:</strong>&nbsp;&nbsp;&nbsp;&nbsp; </p>
<p class="style1">
        &nbsp;
        &nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="880px" ReadOnly="True"></asp:TextBox>
    </p>
<p class="style1">
        &nbsp;</p>
<p class="style1">
    REQUIRED SERVICE 2 :<strong> Word Permutation </strong>
</p>
<p class="style1">
&nbsp; Description : Takes a string as input and returns all the possible 
    permutations using the characters in the word.</p>
    <p class="style1">
&nbsp;&nbsp;&nbsp;&nbsp; Service Url: <a href="http://localhost:1256/Service1.svc?wsdl">
        http://localhost:1256/Service1.svc?wsdl</a></p>
<p class="style1">
&nbsp; Endpoint: &nbsp;string[] Permutation(string input);</p>
<p class="style1">
    &nbsp;<strong>&nbsp;INPUT STRING:&nbsp; </strong>
</p>
<p class="style1">
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" ontextchanged="TextBox3_TextChanged" 
        Width="889px"></asp:TextBox>
</p>
<p class="style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="PERMUTE" 
        Width="260px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p class="style1">
&nbsp;&nbsp; <strong>RESULT:</strong>&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p class="style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &nbsp;<asp:TextBox ID="TextBox7" runat="server" Height="107px" ReadOnly="True" 
        TextMode="MultiLine" Width="647px"></asp:TextBox>
</p>
<p class="style1">
        &nbsp;</p>
</asp:Content>


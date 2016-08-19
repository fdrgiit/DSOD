<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Wordplay
    </h2>
<p>
        &nbsp;&nbsp;REQUIRED SERVICE 2 :<strong> Word Permutation </strong></p>
<p>
        &nbsp; Description : Takes a string as input and returns all the possible 
        permutations using the characters in the word.</p>
    <p>
        &nbsp; Endpoint: &nbsp;string[] 
        Permutation(string input);</p>
<p>
        &nbsp;<strong>&nbsp;INPUT STRING:&nbsp; </strong></p>
<p>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="889px" 
            ontextchanged="TextBox3_TextChanged"></asp:TextBox>
    </p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="PERMUTE" Width="260px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p>
        &nbsp;&nbsp; <strong>RESULT:</strong>&nbsp;&nbsp;&nbsp;&nbsp; </p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox 
            ID="TextBox7" runat="server" Height="107px" TextMode="MultiLine" 
            Width="647px" ReadOnly="True"></asp:TextBox>
    </p>
<p>
        &nbsp;&nbsp; ELECTIVE SERVICE 2 :<strong> Top10ContentWords </strong></p>
<p>
        &nbsp; Description : Analyze the webpage at a given url and return 
        the ten most-frequently occurred words in the webpage.&nbsp;</p>
    <p>
        &nbsp; Service Url: &nbsp;<a href="http://localhost:1256/Service1.svc?wsdl">http://localhost:1256/Service1.svc?wsdl</a></p>
    <p>
        &nbsp; Endpoint: &nbsp;string[] Top10ContentWords(string url)</p>
<p>
        &nbsp;<strong>&nbsp;INPUT URL:&nbsp; </strong></p>
<p>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="889px">http://</asp:TextBox>
    </p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
            ID="Button3" runat="server" onclick="Button3_Click" Text="PROCESS URL...." 
            Width="320px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p>
        &nbsp;&nbsp; <strong>RESULT:</strong>&nbsp;&nbsp;&nbsp;&nbsp; </p>
<p>
        &nbsp;
        &nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="880px" ReadOnly="True"></asp:TextBox>
    </p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
</asp:Content>

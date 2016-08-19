<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="publish._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
    .style1
    {
        font-size: 0em;
    }
</style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Wordplay
    </h2>
    <h2>
        Welcome,
        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button10" runat="server" onclick="Button10_Click" Text="SIGNOUT" 
            Width="135px" />
    </h2>
<p>
&nbsp;&nbsp; REQUIRED SERVICE 1: <strong>WordFilter</strong>
</p>
<p>
&nbsp; Description: Analyze a string of words and filter out the function words as 
    well as the element tags.&nbsp;
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Service Url:
        <a href="http://localhost:1256/Service1.svc?wsdl">
        http://localhost:1256/Service1.svc?wsdl</a></p>
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
&nbsp;&nbsp; REQUIRED SERVICE 2 :<strong> Top10Words </strong>
</p>
<p>
&nbsp; Description : Analyze the webpage at a given url and return the ten 
    most-frequently occurred words in the webpage.&nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Service Url:
        <a href="http://localhost:1256/Service1.svc?wsdl">
        http://localhost:1256/Service1.svc?wsdl</a></p>
<p>
&nbsp; Endpoint: &nbsp;string[] Top10Words(string url)</p>
<p>
    &nbsp;<strong>&nbsp;INPUT URL:&nbsp; </strong>
</p>
<p>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox8" runat="server" Width="889px">http://</asp:TextBox>
</p>
<p>
    &nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
        Text="PROCESS URL...." Width="263px" />
</p>
<p>
&nbsp;&nbsp; <strong>RESULT:</strong>&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
&nbsp; &nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="880px"></asp:TextBox>
</p>
<p>
        &nbsp;ELECTIVE SERVICE 1 :<strong> Top10ContentWords </strong></p>
<p>
        &nbsp; Description : Analyze the webpage at a given url and return 
        the ten most-frequently occurred words in the webpage.&nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp; Service Url:
        <a href="http://localhost:1256/Service1.svc?wsdl">
        http://localhost:1256/Service1.svc?wsdl</a></p>
    <p>
        &nbsp; Endpoint: &nbsp;string[] Top10ContentWords(string url)</p>
<p>
        &nbsp;<strong>&nbsp;INPUT URL:&nbsp; </strong></p>
<p>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="889px">http://</asp:TextBox>
    </p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
            ID="Button3" runat="server" onclick="Button3_Click" Text="PROCESS URL...." 
            Width="320px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p>
        &nbsp;&nbsp; <strong>RESULT:</strong>&nbsp;&nbsp;&nbsp;&nbsp; </p>
<p>
        &nbsp;
        &nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="880px" ReadOnly="True"></asp:TextBox>
        <span class="style1">&nbsp;</span></p>
<p>
        REQUIRED SERVICE 3 :<strong> Stemming</strong></p>
    <p>
      This service is used to analyze a string of words and replace the inflected or derived words to their stem or root word
        This service haves only one operation listed below: 
    </p>
    <p>
      &nbsp;&nbsp;&nbsp;&nbsp; Service Url:
        <a href="http://localhost:1256/Service1.svc?wsdl">
        http://localhost:1256/Service1.svc?wsdl</a></p>
    <p>
        <b>stemming</b> - This operation requires the word to be provided: 
        The output is stem or the root word
    </p>
    <p>
    <label>Enter the word to get the stem</label> :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:TextBox ID="TextBox9" runat="server" name="textbox1" Width="359px"></asp:TextBox>  
   

    </p>
    <p>
    &nbsp;<asp:Button ID="stemmingButton" runat="server" Text="PROCESS WORD.." 
            OnClick="stemming" Width="257px"  /><br />
    
    </p>
    <p>
        <label>The stem of the word is as follows:</label><br />
    <asp:Label ID="output" runat="server" ></asp:Label> <br />
        
    </p>
<p>
     
     ELECTIVE SERVICE 2 :<strong> Merge Sort </strong>
        
    </p>
    
        <p>Sort the chars using merge sort.</p>
        <p>
       This service can be used to sort the characters in string using merge sort.
        This service haves only one operation listed below: <br />
        <b>Sort</b> - This operation requires the string input to be provided: The output is 
            an array of characters in sorted order.</p>
<p>
       &nbsp;&nbsp;&nbsp;&nbsp; Service Url:
       <a href="http://localhost:1256/Service1.svc?wsdl">
       http://localhost:1256/Service1.svc?wsdl</a></p>
       <p>Endpoint:string Sort(string c)</p> 
        <p>
            I<label>nput:&nbsp</label>
            <asp:TextBox ID="str" Width="750px" runat="server" />    
        </p>
<p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
            <asp:Button ID="Button6" Text="SORT WORDS..." OnClick="msort" runat="server" 
                Height="29px" Width="266px" />
        </p>
<p>
            <br />                  
            <label>Result: &nbsp</label>
            <asp:TextBox ID="TextBox10" Width="750px" runat="server" ReadOnly="True" />
        </p>
<p>
            ELECTIVE SERVICE 3 :<strong> LongestPalindrome </strong>
        </p>
        <p>
       This service can be used to find the length of the longest palindrome sequence in given string.
        This service haves only one operation listed below: <br />
        <b>Find Longest Palindrome</b> - This operation requires the string input to be provided: 
        The output is is the length in integer.
    </p>
<p>
       &nbsp;&nbsp;&nbsp;&nbsp; Service Url:
       <a href="http://localhost:1256/Service1.svc?wsdl">
       http://localhost:1256/Service1.svc?wsdl</a></p>
        <p>Endpoint:int palindrome(string s)</p>
        <p>
            <label>String:&nbsp</label>
            <asp:TextBox ID="TextBox11" Width="300px" runat="server" />    
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
            <asp:Button ID="Button4" Text="FIND" OnClick="longestpalindrome" 
                runat="server" />                    
            <label style="margin-left: 50px">Result: &nbsp</label>
            <asp:TextBox ID="TextBox3" Width="50px" runat="server" ReadOnly="true" 
                Height="25px" />
        </p>
<p>
            ELECTIVE SERVICE 4:<strong> Web2String </strong>
        </p>

        <p>
       WCF service that take URL as parameter, reads a Web page, and return a string with Web contents.  
        This service haves only one operation listed below: <br />
        <b>string GetWebContent(string url)</b> - This operation requires the string input(url) to be provided: 
        The output is is the contents of the web page.
    </p>
          <p>
&nbsp;URL Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox12" runat="server" Width="446px">http://</asp:TextBox>
&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button8" runat="server" onclick="Button8_Click" 
                  Text="PROCESS URL.." Width="219px" />
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button9" runat="server" onclick="Button9_Click" 
        style="text-align: center" Text="CLEAR TEXTBOX" Width="223px" />
</p>
<p>
    <asp:TextBox ID="TextBox13" runat="server" Height="303px" TextMode="MultiLine" 
        Width="677px" ReadOnly="True" style="margin-right: 0px"></asp:TextBox>
</p>

<p>
        &nbsp;</p>
</asp:Content>


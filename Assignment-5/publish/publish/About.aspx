<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="publish.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
 
     <h2>
         Welcome Vinit&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button8" runat="server" onclick="Button8_Click" 
             Text="RESET COOKIES" Width="159px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button9" runat="server" onclick="Button9_Click" Text="SIGNOUT" 
             Width="100px" />
&nbsp;</h2>
     <h2>
        Welcome to Stemming
    </h2>
    <p>
      This service is used to analyze a string of words and replace the inflected or derived words to their stem or root word
        This service haves only one operation listed below: <br />
        <b>stemming</b> - This operation requires the word to be provided: 
        The output is stem or the root word
    </p>
     <p>
      &nbsp;&nbsp;&nbsp;&nbsp; Service Url:
         <a href="http://localhost:1256/Service1.svc?wsdl">
         http://localhost:1256/Service1.svc?wsdl</a></p>
     <p>
    <label>Enter the word to get the stem</label></p>
     <p>


    <asp:TextBox ID="TextBox4" runat="server" name="textbox1" Width="241px"></asp:TextBox>  
   

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
   

    <asp:Button ID="stemmingButton" runat="server" Text="PROCESS WORD" 
            OnClick="stemming" Width="233px"  />
    </p>
     <p>
    
    <label>The stem of the word is as follows:</label><br />
    <asp:Label ID="output" runat="server" ></asp:Label> <br />
        
    </p>
        
        <h2>
        Welcome to Merge Sort Service
    </h2>
    
        <p>Sort the chars using merge sort.</p>
        <p>
       This service can be used to sort the characters in string using merge sort.
        This service haves only one operation listed below: <br />
        <b>Sort</b> - This operation requires the string input to be provided: 
        The output is an array of characters in sorted order.
    </p>
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
            <asp:Button ID="Button6" Text="SORT.." OnClick="msort" runat="server" 
                Height="29px" Width="289px" />
        </p>
     <p>                  
            <label>Result: &nbsp</label>
            <asp:TextBox ID="TextBox1" Width="750px" runat="server" ReadOnly="True" />
        </p>
          <h2>
        Welcome to Longest Palindrome Service
    </h2>
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
            <asp:TextBox ID="TextBox2" Width="300px" runat="server" />    
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
            <asp:Button ID="Button4" Text="FIND" OnClick="longestpalindrome" runat="server" 
                Width="134px" />                    
            <label style="margin-left: 50px">Result: &nbsp</label>
            <asp:TextBox ID="TextBox3" Width="104px" runat="server" ReadOnly="true" 
                Height="25px" />
        </p>

          <h2>
        Welcome to Web to String Service
    </h2>
        <p>
       WCF service that take URL as parameter, reads a Web page, and return a string with Web contents.  
        This service haves only one operation listed below: 
    </p>
     <p>
        <b>string GetWebContent(string url)</b> - This operation requires the string input(url) to be provided: 
        The output is is the contents of the web page.
    </p>
          <p>
&nbsp;URL Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox5" runat="server" Width="446px">http://</asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="PROCESS URL..." 
        Width="212px" />
</p>
<p>
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="CLEAR" 
        Width="249px" />
</p>
<p>
    <asp:TextBox ID="TextBox6" runat="server" Height="303px" TextMode="MultiLine" 
        Width="677px" ReadOnly="True" style="margin-right: 0px"></asp:TextBox>
</p>

   <h2>
        Welcome to Encryption Decryption Service
    </h2>
        <p>
      This service is used to test DLL class library 
            modules,to implement the encryption/decryption function.</p>
          <p>
&nbsp;Enter the string for encryption&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox7" runat="server" Width="446px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;</p>
     <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button7" runat="server" onclick="Button7_Click" 
             Text="PROCESS STRING..." Width="318px" />
     </p>
     <p>
 Encrypted String:        <asp:TextBox ID="TextBox8" runat="server" Width="446px" 
             ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;</p>
     <p>
         &nbsp;Decrypted String:<asp:TextBox ID="TextBox9" runat="server" Width="446px" 
             ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
</p>
     <p>
         &nbsp;</p>
      
        <h2>
            Welcome to Deletechar Service
     </h2>
     <p>
         This service can be used to Delete chars of a string for e.g string 1 contained 
         in another string for e.g string2 and shift the remaining characters 
         correspondingly. This service haves only one operation listed below:
         <br />
         <b>deleteChar</b> - This operation requires the string input string1 to be 
         provided along with the string containing the characters to be deleted string2: 
         The output is a string without the characters in the string 2.
     </p>
     <p>
         &nbsp;&nbsp;&nbsp;&nbsp; Service Url:
         <a href="http://localhost:1256/Service1.svc?wsdl">
         http://localhost:1256/Service1.svc?wsdl</a></p>
     <p>
         Endpoint:string deleteChar(string s1, string s2)</p>
     <p>
         <label>
         String1:&nbsp;</label>
         <asp:TextBox ID="str1" runat="server" Width="300px" />
         <label style="margin-left: 50px">
         String2:&nbsp;</label>
         <asp:TextBox ID="str2" runat="server" Width="300px" />
     </p>
     <p>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button5" runat="server" OnClick="deletechar" 
             Text="PROCESS STRINGS..." Width="325px" />
     </p>
     <p>
         <label>
         Result: &nbsp;</label>
         <asp:TextBox ID="result" runat="server" ReadOnly="true" Width="300px" />
     </p>
     <p>
         &nbsp;</p>



</asp:Content>
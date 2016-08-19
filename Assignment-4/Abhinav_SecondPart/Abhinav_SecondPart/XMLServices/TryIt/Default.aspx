<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="XMLServices._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            font-size: 9.5pt;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
  <h2 style="padding-left: 10px;">
        TRYIT page for XML services</h2>

    <div style="padding-left: 10px; text-align: center;">
        <p>
            <b>
            <span style="font-size:9.5pt;font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;;
color:dimgray">WEB OPERATION 1: VERIFICATION</span></b><span style="font-size:
9.5pt;font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;;color:dimgray"><o:p></o:p></span></p>
        <p>
            <span style="font-size:9.5pt;font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;;color:dimgray">
            WEB OPERATION “VERIFICATION” TAKES THE URL OF AN XML (.XML) FILE AND THE URL OF 
            THE CORRESPONDING XMLS (.XSD) FILE AS INPUT AND VALIDATES THE XML FILE AGAINST 
            THE CORRESPONDING XMLS (XSD) FILE. THE WEB METHOD RETURNS “NO ERROR” OR AN ERROR 
            MESSAGE SHOWING THE AVAILABLE INFORMATION AT THE ERROR POINT.</span>
        </p>
        <p>
            &nbsp;</p>
        ENTER THE XML FILE URL<label>: </label><br />
        <asp:TextBox ID="TextBox4" Width="900px" runat="server" 
            style="margin-bottom: 10px; font-family: Arial;" /><br />
        ENTER THE XSD<label> FILE URL: </label><br />
        <asp:TextBox ID="TextBox5" Width="900px" style="font-family: Arial;" 
            runat="server" />
        <asp:Button ID="Result" Text="VALIDATE XML" OnClick="testValidationService" 
            Width="255px" runat="server" 
            style="margin-top: 10px; margin-bottom: 10px; text-align: center;" /><br />
        <label><strong>RESULT</strong>:<br />
        </label><br />
        <asp:TextBox ID="TextBox6" Width="900px" Height="100px" runat="server" 
            ReadOnly="true" TextMode="MultiLine" style="font-family: Arial;" />
        <br />
    </div>

      <div style="padding-left: 10px; text-align: center;">
          <p>
              <b>
              <span style="font-size:9.5pt;font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;;
color:dimgray">WEB OPERATION 2: TRANSFORMATION</span></b><span 
                  style="font-size:9.5pt;font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;;color:dimgray"><o:p></o:p></span></p>
          <p class="MsoNormal">
              <span class="style1" style="line-height: 107%">WEB OPERATION “TRANSFORMATION” 
              TAKES THE URL OF AN XML (.XML) FILE AND THE URL OF THE XSL FILE AS INPUTS AND 
              GENERATES THE HTML FILE BASED ON THE XML AND XSL FILES.</span><o:p></o:p></p>
          <p class="MsoNormal">
              <o:p></o:p>
          </p>
        
        <label>ENTER THE XML FILE URL: </label><br />
        <asp:TextBox ID="TextBox1" Width="900px" runat="server" style="margin-bottom: 10px; font-family: Arial;" /><br />
          <label>&nbsp;ENTER THE XSL FILE URL: </label><br />
        <asp:TextBox ID="TextBox2" Width="900px" runat="server" style="margin-bottom: 10px; font-family: Arial;" /><br />
        <asp:Button ID="Button1" Text="GENERATE HTML" 
              OnClick="testXMLTransformationService" Width="230px" runat="server" 
              style="margin-top: 10px; margin-bottom: 10px;" /><br />
          RESULT<label>:</label><br />
          <br />
        <asp:TextBox ID="TextBox3" Width="900px" Height="100px" runat="server" ReadOnly="true" TextMode="MultiLine" style="font-family: Arial;" />
          <br />
          <br />
    </div>

</asp:Content>

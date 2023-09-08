<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="AWP3A._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        <asp:Button ID="Button1" runat="server" Text="Button" />Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
    <form>
    <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox><br />
    <asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />
    </form>
   
<asp:Label ID="Label1" runat="server" Text="Enter correct input"></asp:Label>

    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
        onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
        <asp:ListItem>BSCIT</asp:ListItem>
        <asp:ListItem>BCom</asp:ListItem>
        <asp:ListItem>12th</asp:ListItem>
        <asp:ListItem>BMS</asp:ListItem>
    </asp:RadioButtonList>

<asp:Calendar ID="Calendar1" runat="server" Enabled="False" TitleFormat="Month"></asp:Calendar>
</asp:Content>


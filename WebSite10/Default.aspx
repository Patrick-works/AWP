<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
<p>
        <asp:TextBox ID="TextBox2" runat="server" ontextchanged="TextBox2_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" ontextchanged="TextBox3_TextChanged"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </p>
<p>
        <asp:TextBox ID="TextBox4" runat="server" ontextchanged="TextBox4_TextChanged" 
            style="margin-bottom: 4px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

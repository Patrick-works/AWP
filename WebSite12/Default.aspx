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
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataSourceID="SqlDataSource1">
    <Columns>
        <asp:CommandField HeaderText="Select info" ShowSelectButton="true" />
    <asp:CommandField HeaderText="edit  info" ShowEditButton="true" />
    <asp:CommandField HeaderText="Delete info" ShowDeleteButton="true" />
    <asp:CommandField  ShowInsertButton="true" />
        <asp:BoundField DataField="Control_ID" HeaderText="Control_ID" 
            SortExpression="Control_ID" />
        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
        <asp:BoundField DataField="Email_id" HeaderText="Email_id" 
            SortExpression="Email_id" />
        <asp:BoundField DataField="Contactno" HeaderText="Contactno" 
            SortExpression="Contactno" />
        <asp:BoundField DataField="address" HeaderText="address" 
            SortExpression="address" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
    SelectCommand="SELECT * FROM [Student_master]"
    UpdateCommand="UPDATE Student_master SET Control_ID = @Control_ID, name = @name, Email_id = @Email_id, Contactno = @Contactno, address = @address WHERE (Control_ID = @Control_ID)"
    DeleteCommand ="delete from [Student_master] where [Control_ID]= @Control_ID"
    ConflictDetection="CompareAllValues"
        
    
    
    ></asp:SqlDataSource>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
</asp:Content>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
      YA SAHEB YA
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
    <p> <br /><asp:Label ID="Label1" 
                         Text="Enter your for college email only!" 
                         runat="server"> </asp:label>

    <asp:TextBox ID="TextBox1" 
                    TabIndex= "2" 
                    BorderColor="Pink" BackColor= "Beige" 
                    ToolTip="kuch toh dal" runat="server" EnableTheming="True" 
            ontextchanged="TextBox1_TextChanged" ></asp:TextBox> 
                    <br />
                    <br />

            <asp:Label ID="Label2" 
            Text="Please enter a valid password!" 
            runat="server" > </asp:label>

       <asp:TextBox ID="TextBox2" 
            TabIndex= "1" 
            BorderColor="Black" Text="Password" BackColor= "olive" 
            ToolTip="put something init fam" runat="server"  Rows="4" 
            Maxlength= "5" ></asp:TextBox>   
              
    </p>



    <p> <asp:Button ID="Button1" runat="server" Text="Submit" BorderStyle="Inset" 
            ToolTip="Submit" BorderWidth="4px" AccessKey="1" onclick="Button1_Click1"/>
    </p>
</asp:Content>



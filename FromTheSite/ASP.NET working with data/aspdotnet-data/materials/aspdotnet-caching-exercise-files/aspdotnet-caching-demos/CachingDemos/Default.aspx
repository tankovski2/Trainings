<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ OutputCache VaryByCustom="Browser" Location="Any" Duration="60" VaryByParam="_nameTextBox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Enter your name: 
        <asp:TextBox ID="_nameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="_enterNameButton" runat="server" Text="Enter name" 
            onclick="_enterNameButton_Click" />
        <br />
        <asp:Label ID="_nameLabel" runat="server" Text=""></asp:Label>
        <hr />
        <asp:Label ID="_timestamp" Font-Size="X-Large" runat="server" Text="Label"></asp:Label> 
    </div>
    </form>
</body>
</html>

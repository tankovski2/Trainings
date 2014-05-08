<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FragmentCache.aspx.cs" Inherits="FragmentCache" %>

<%@ Register src="CachedUCl.ascx" tagname="CachedUCl" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:Label runat="server" id="_timeStamp" />
    
    
        <br />
        <br />
        <uc1:CachedUCl ID="CachedUCl1" runat="server" />
    
    
    </div>
    </form>
</body>
</html>

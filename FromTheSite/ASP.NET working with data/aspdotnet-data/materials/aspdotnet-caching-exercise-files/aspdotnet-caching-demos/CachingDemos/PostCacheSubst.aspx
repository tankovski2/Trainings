<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PostCacheSubst.aspx.cs" Inherits="PostCacheSubst" %>
<%@ OutputCache VaryByParam="none" Duration="60"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="au_id" DataSourceID="SqlDataSource1" 
            EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:BoundField DataField="au_id" HeaderText="au_id" ReadOnly="True" 
                    SortExpression="au_id" />
                <asp:BoundField DataField="au_lname" HeaderText="au_lname" 
                    SortExpression="au_lname" />
                <asp:BoundField DataField="au_fname" HeaderText="au_fname" 
                    SortExpression="au_fname" />
                <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                <asp:BoundField DataField="address" HeaderText="address" 
                    SortExpression="address" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
                <asp:BoundField DataField="zip" HeaderText="zip" SortExpression="zip" />
                <asp:CheckBoxField DataField="contract" HeaderText="contract" 
                    SortExpression="contract" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:pubsConnectionString1 %>" 
            DeleteCommand="DELETE FROM [authors] WHERE [au_id] = @au_id" 
            InsertCommand="INSERT INTO [authors] ([au_id], [au_lname], [au_fname], [phone], [address], [city], [state], [zip], [contract]) VALUES (@au_id, @au_lname, @au_fname, @phone, @address, @city, @state, @zip, @contract)" 
            ProviderName="<%$ ConnectionStrings:pubsConnectionString1.ProviderName %>" 
            SelectCommand="SELECT [au_id], [au_lname], [au_fname], [phone], [address], [city], [state], [zip], [contract] FROM [authors]" 
            UpdateCommand="UPDATE [authors] SET [au_lname] = @au_lname, [au_fname] = @au_fname, [phone] = @phone, [address] = @address, [city] = @city, [state] = @state, [zip] = @zip, [contract] = @contract WHERE [au_id] = @au_id">
            <DeleteParameters>
                <asp:Parameter Name="au_id" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="au_id" Type="String" />
                <asp:Parameter Name="au_lname" Type="String" />
                <asp:Parameter Name="au_fname" Type="String" />
                <asp:Parameter Name="phone" Type="String" />
                <asp:Parameter Name="address" Type="String" />
                <asp:Parameter Name="city" Type="String" />
                <asp:Parameter Name="state" Type="String" />
                <asp:Parameter Name="zip" Type="String" />
                <asp:Parameter Name="contract" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="au_lname" Type="String" />
                <asp:Parameter Name="au_fname" Type="String" />
                <asp:Parameter Name="phone" Type="String" />
                <asp:Parameter Name="address" Type="String" />
                <asp:Parameter Name="city" Type="String" />
                <asp:Parameter Name="state" Type="String" />
                <asp:Parameter Name="zip" Type="String" />
                <asp:Parameter Name="contract" Type="Boolean" />
                <asp:Parameter Name="au_id" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Substitution ID="timeStampSubst" runat="server" 
            MethodName="GetTimeStamp" />
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="emp_id" DataSourceID="SqlDataSource2" 
            EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:BoundField DataField="emp_id" HeaderText="emp_id" ReadOnly="True" 
                    SortExpression="emp_id" />
                <asp:BoundField DataField="fname" HeaderText="fname" SortExpression="fname" />
                <asp:BoundField DataField="minit" HeaderText="minit" SortExpression="minit" />
                <asp:BoundField DataField="lname" HeaderText="lname" SortExpression="lname" />
                <asp:BoundField DataField="job_id" HeaderText="job_id" 
                    SortExpression="job_id" />
                <asp:BoundField DataField="job_lvl" HeaderText="job_lvl" 
                    SortExpression="job_lvl" />
                <asp:BoundField DataField="pub_id" HeaderText="pub_id" 
                    SortExpression="pub_id" />
                <asp:BoundField DataField="hire_date" HeaderText="hire_date" 
                    SortExpression="hire_date" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:pubsConnectionString1 %>" 
            DeleteCommand="DELETE FROM [employee] WHERE [emp_id] = @emp_id" 
            InsertCommand="INSERT INTO [employee] ([emp_id], [fname], [minit], [lname], [job_id], [job_lvl], [pub_id], [hire_date]) VALUES (@emp_id, @fname, @minit, @lname, @job_id, @job_lvl, @pub_id, @hire_date)" 
            ProviderName="<%$ ConnectionStrings:pubsConnectionString1.ProviderName %>" 
            SelectCommand="SELECT [emp_id], [fname], [minit], [lname], [job_id], [job_lvl], [pub_id], [hire_date] FROM [employee]" 
            UpdateCommand="UPDATE [employee] SET [fname] = @fname, [minit] = @minit, [lname] = @lname, [job_id] = @job_id, [job_lvl] = @job_lvl, [pub_id] = @pub_id, [hire_date] = @hire_date WHERE [emp_id] = @emp_id">
            <DeleteParameters>
                <asp:Parameter Name="emp_id" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="emp_id" Type="String" />
                <asp:Parameter Name="fname" Type="String" />
                <asp:Parameter Name="minit" Type="String" />
                <asp:Parameter Name="lname" Type="String" />
                <asp:Parameter Name="job_id" Type="Int16" />
                <asp:Parameter Name="job_lvl" Type="Byte" />
                <asp:Parameter Name="pub_id" Type="String" />
                <asp:Parameter Name="hire_date" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="fname" Type="String" />
                <asp:Parameter Name="minit" Type="String" />
                <asp:Parameter Name="lname" Type="String" />
                <asp:Parameter Name="job_id" Type="Int16" />
                <asp:Parameter Name="job_lvl" Type="Byte" />
                <asp:Parameter Name="pub_id" Type="String" />
                <asp:Parameter Name="hire_date" Type="DateTime" />
                <asp:Parameter Name="emp_id" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>

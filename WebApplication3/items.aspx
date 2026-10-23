<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="items.aspx.cs" Inherits="WebApplication3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:DataList ID="DataList1" runat="server"		DataKeyField="R_id" DataSourceID="SqlDataSource1" RepeatDirection="Horizontal">
				<ItemTemplate>
					id :
					<asp:Label ID="Label1" runat="server" Text='<%# Eval("R_id") %>'></asp:Label>
					<br />
					name :
					<asp:Label ID="Label2" runat="server" Text='<%# Eval("R_name") %>'></asp:Label>
					<br />
					photo :
					<asp:Image ID="Image1" runat="server" ImageUrl='<%# "upimage/"+Eval("file_name") %>' Width="150px" />
				</ItemTemplate>
			</asp:DataList>
        </div>
    	<asp:SqlDataSource ID="SqlDataSource1"
			runat="server" 
			  ConnectionString="Data Source=DESKTOP-6FS753E\SQLEXPRESS;Initial Catalog=new_project;Integrated Security=True"
            ProviderName="System.Data.SqlClient"
            SelectCommand= "SELECT * FROM Registration INNER JOIN file_upload ON Registration.R_id = file_upload.R_id;"
			
			></asp:SqlDataSource>
    </form>
</body>
</html>

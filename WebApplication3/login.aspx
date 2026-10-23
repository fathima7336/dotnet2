<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication3.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	username :
			<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
    	<p>
			password :
			<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
		</p>
		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="login" />
		<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
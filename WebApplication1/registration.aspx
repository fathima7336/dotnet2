<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication1.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Name :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    	<p>
			Age :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
		</p>
		<p>
			Email :<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
		</p>
		<p>
			Password :<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
		</p>
		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
		<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
			<Columns>
				<asp:BoundField DataField="name" HeaderText="name" />
				<asp:BoundField DataField="age" HeaderText="age" />
				<asp:BoundField DataField="email" HeaderText="email" />
				<asp:BoundField DataField="password" HeaderText="password" />
			</Columns>
		</asp:GridView>
    </form>
</body>
</html>

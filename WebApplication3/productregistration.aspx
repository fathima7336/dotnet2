<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productregistration.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
        	p_name :
			<asp:TextBox ID="p_name" runat="server"></asp:TextBox>
        </div>
    	<p>
			expiry date :
			<asp:DropDownList ID="DropDownList1" runat="server">
			</asp:DropDownList>
			<asp:DropDownList ID="DropDownList2" runat="server">
			</asp:DropDownList>
			<asp:DropDownList ID="DropDownList3" runat="server">
			</asp:DropDownList>
		</p>
		<p>
			p_id :
			<asp:TextBox ID="p_id" runat="server"></asp:TextBox>
		</p>
		<p>
			quantity :
			<asp:TextBox ID="qty" runat="server"></asp:TextBox>
		</p>
		<p>
			company :
			<asp:TextBox ID="company" runat="server" OnTextChanged="password_TextChanged"></asp:TextBox>
		</p>
		<p>
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
		</p>
    </form>
</body>
</html>
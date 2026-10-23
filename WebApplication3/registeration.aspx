<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registeration.aspx.cs" Inherits="WebApplication3.registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	name :
			<asp:TextBox ID="name_text" runat="server"></asp:TextBox>
        </div>
    	<p>
			DOB :
			<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
			</asp:DropDownList>
			<asp:DropDownList ID="DropDownList2" runat="server">
			</asp:DropDownList>
			<asp:DropDownList ID="DropDownList3" runat="server">
			</asp:DropDownList>
		</p>
		<p>
			gender&nbsp;
			<asp:RadioButton ID="RadioButton1" runat="server" Text="male" />
			<asp:RadioButton ID="RadioButton2" runat="server" Text="female" />
		</p>
		<p>
			phone number :
			<asp:TextBox ID="phn_no" runat="server"></asp:TextBox>
		</p>
		<p>
			email :
			<asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
		</p>
		<p>
			password :
			<asp:TextBox ID="password" runat="server"></asp:TextBox>
		</p>
		<p>
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
		</p>
    </form>
</body>
</html>

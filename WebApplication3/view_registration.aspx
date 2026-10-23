<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_registration.aspx.cs" Inherits="WebApplication3.view_registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<br />
			<br />
			<br />
			<br />
			Name :
			<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
			<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="search" />
        </div>
    	<p>
			<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="175px" Width="424px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
				<Columns>
					<asp:BoundField DataField="R_id" HeaderText="id" />
					<asp:BoundField DataField="R_name" HeaderImageUrl="Name" />
					<asp:BoundField DataField="R_dob" HeaderText="dob" />
					<asp:BoundField DataField="gender" HeaderText="gender" />
					<asp:BoundField DataField="phone" HeaderText="phone" />
					<asp:BoundField DataField="email" HeaderText="email" />
					<asp:BoundField DataField="pwd" HeaderText="pwd" />
					<asp:BoundField DataField="type" HeaderText="type" />
					<asp:TemplateField>
						<ItemTemplate>
							<asp:LinkButton CommandArgument='<%# Eval("R_id") %>' ID="LinkButton" runat="server" OnClick="LinkButton1_Click">edit</asp:LinkButton>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:TemplateField>
						<ItemTemplate>
							
							<asp:LinkButton CommandArgument='<%# Eval("R_id") %>' ID="LinkButton1" OnClick="LinkButton_Click1" runat="server">Delete</asp:LinkButton>
							
						</ItemTemplate>
					</asp:TemplateField>
				</Columns>
			</asp:GridView>     
		</p>
    	<p>
			Id : <asp:TextBox ID="text_id" runat="server"></asp:TextBox>
		</p>
        <div>
        	name :
			<asp:TextBox ID="name_text" runat="server" ></asp:TextBox>
        </div>
    	<p>
			DOB :
			<asp:DropDownList ID="DropDownList1" runat="server" >
				<asp:ListItem Value="-1">select</asp:ListItem>
			</asp:DropDownList>
			<asp:DropDownList ID="DropDownList2" runat="server">
				<asp:ListItem Value="-1">select</asp:ListItem>
			</asp:DropDownList>
			<asp:DropDownList ID="DropDownList3" runat="server">
				<asp:ListItem Value="-1">select</asp:ListItem>
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
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="submit" />
		</p>
    </form>
</body>
</html>



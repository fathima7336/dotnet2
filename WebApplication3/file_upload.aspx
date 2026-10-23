<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="file_upload.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<p>
			HLOStaff :
			<asp:DropDownList ID="DropDownList1" runat="server">
			</asp:DropDownList>
		</p>
		<p>
			photo :
			<asp:FileUpload ID="FileUpload1" runat="server" />
		</p>
		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="upload" />
		<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>

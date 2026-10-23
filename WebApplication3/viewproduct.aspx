<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewproduct.aspx.cs" Inherits="WebApplication3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	&nbsp;<br />
			<br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
			<asp:Button ID="search" runat="server" OnClick="search_Click" Text="search" />
			<br />
			<br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:TemplateField HeaderText="p_id">
                    <ItemTemplate>
                        <%# Eval("p_id") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="p_name">
                    <ItemTemplate>
                        <%# Eval("p_name") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="expirydate">
                    <ItemTemplate>
                        <%# Eval("expirydate") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="qty">
                    <ItemTemplate>
                        <%# Eval("qty") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="company">
                    <ItemTemplate>
                        <%# Eval("company") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%# Eval("p_id") %>' OnClick="LinkButton1_Click">edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("p_id") %>' OnClick="LinkButton_Click1">delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="Gray" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <div id="delete">
        	&nbsp;</div>
        <div>
            p_name :
            <asp:TextBox ID="p_name" runat="server" OnTextChanged="p_name_TextChanged"></asp:TextBox>
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
        <p id="edit">
            company :
            <asp:TextBox ID="company" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="submit" />
        </p>
    </form>
</body>
</html>
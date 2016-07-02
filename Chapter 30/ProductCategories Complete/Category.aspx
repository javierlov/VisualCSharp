<%@ Page language="c#" Codebehind="Category.aspx.cs" AutoEventWireup="false" Inherits="ProductCategories.Category" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Product Categories</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" runat="server" Font-Names="Arial Black" Font-Size="X-Large">Product Categories</asp:label><asp:datagrid id=DataGrid1 style="Z-INDEX: 101; LEFT: 13px; POSITION: absolute; TOP: 66px" runat="server" DataSource="<%# dataSet1 %>" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
				<ItemStyle ForeColor="#000066"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
				<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
				<Columns>
					<asp:TemplateColumn HeaderText="Products">
						<ItemTemplate>
							<asp:ImageButton id=ImageButton1 runat="server" ImageUrl="info.gif" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "CategoryID")%>' CommandName="GetProductDetails">
							</asp:ImageButton>
						</ItemTemplate>
					</asp:TemplateColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:datagrid></form>
	</body>
</HTML>

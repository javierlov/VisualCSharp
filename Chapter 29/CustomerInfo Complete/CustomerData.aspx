<%@ Page language="c#" Codebehind="CustomerData.aspx.cs" AutoEventWireup="false" inherits="CustomerInfo.CustomerData" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:datagrid id="DataGrid1" style="Z-INDEX: 101; LEFT: 11px; POSITION: absolute; TOP: 69px" runat="server" PagerStyle-Mode="NumericPages" PagerStyle-PageButtonCount="20" PageSize="8" AllowPaging="True" Width="770px" Height="393px" BorderColor="#CC9966" BorderWidth="1px" BorderStyle="None" BackColor="White" CellPadding="4" DataSource="<%# dataSet1 %>" HeaderStyle-Font-Bold="True" HeaderStyle-BackColor="#990000" HeaderStyle-ForeColor="#FFFFCC" SelectedItemStyle-Font-Bold="True" SelectedItemStyle-ForeColor="#663399" SelectedItemStyle-BackColor="#FFCC66" ItemStyle-ForeColor="330099" ItemStyle-BackColor="White" PagerStyle-HorizontalAlign="Center" PagerStyle-ForeColor="#330099" PagerStyle-BackColor="#FFFFCC" FooterStyle-ForeColor="#330099" FooterStyle-BackColor="#FFFFCC"><COLUMNS>
					<asp:ButtonColumn Text="Delete" ButtonType="PushButton" CommandName="Delete"></asp:ButtonColumn>
					<asp:EditCommandColumn ButtonType="PushButton" EditText="Edit" CancelText="Cancel" UpdateText="Update"></asp:EditCommandColumn>
				</COLUMNS></asp:datagrid>
			<asp:label id="ErrorMessage" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 15px" runat="server" Width="760px" Height="40px"></asp:label>
		</form>
	</body>
</HTML>

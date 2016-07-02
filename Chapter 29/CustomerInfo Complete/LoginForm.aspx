<%@ Page language="c#" Codebehind="LoginForm.aspx.cs" AutoEventWireup="false" Inherits="CustomerInfo.LoginForm" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="LoginForm" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 183px; POSITION: absolute; TOP: 76px" runat="server">User Name:</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 183px; POSITION: absolute; TOP: 133px" runat="server">Password:</asp:Label>
			<asp:Label id="Message" style="Z-INDEX: 106; LEFT: 183px; POSITION: absolute; TOP: 288px" runat="server" Width="272px" Height="19px" ForeColor="Red"></asp:Label>
			<asp:TextBox id="UserName" style="Z-INDEX: 103; LEFT: 305px; POSITION: absolute; TOP: 71px" runat="server"></asp:TextBox>
			<asp:TextBox id="Password" style="Z-INDEX: 104; LEFT: 305px; POSITION: absolute; TOP: 128px" runat="server" TextMode="Password"></asp:TextBox>
			<asp:Button id="Login" style="Z-INDEX: 105; LEFT: 305px; POSITION: absolute; TOP: 210px" runat="server" Text="Login" Width="78px" Height="24px"></asp:Button>
		</form>
	</body>
</HTML>

<%@ Page language="c#" Codebehind="WebForm1.aspx.cs" AutoEventWireup="false" Inherits="EmployeeInfo.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<STYLE>BODY { BACKGROUND-IMAGE: url(computer.bmp); COLOR: blue; FONT-FAMILY: Arial; BACKGROUND-COLOR: transparent }
		</STYLE>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 19px" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="X-Large" Width="630px" Height="36px">Honest John Software Developers</asp:Label>
			<asp:TextBox id="FirstName" style="Z-INDEX: 102; LEFT: 120px; POSITION: absolute; TOP: 81px" runat="server" Width="230px" Height="24px"></asp:TextBox>
			<asp:TextBox id="LastName" style="Z-INDEX: 103; LEFT: 455px; POSITION: absolute; TOP: 81px" runat="server" Width="230px" Height="24px"></asp:TextBox>
			<asp:TextBox id="EmployeeId" style="Z-INDEX: 104; LEFT: 120px; POSITION: absolute; TOP: 123px" runat="server" Width="100px" Height="24px"></asp:TextBox>
			<asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 367px; POSITION: absolute; TOP: 81px" runat="server">Last Name</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 106; LEFT: 24px; POSITION: absolute; TOP: 125px" runat="server">Employee Id</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 107; LEFT: 33px; POSITION: absolute; TOP: 81px" runat="server">First Name</asp:Label>
			<asp:Label id="Label5" runat="server" style="Z-INDEX: 108; LEFT: 53px; POSITION: absolute; TOP: 168px">Position</asp:Label>
			<asp:RadioButton id="PresidentButton" style="Z-INDEX: 109; LEFT: 132px; POSITION: absolute; TOP: 302px" runat="server" Text="President" TextAlign="Left" GroupName="PositionGroup" AutoPostBack="True"></asp:RadioButton>
			<asp:RadioButton id="VPButton" style="Z-INDEX: 110; LEFT: 96px; POSITION: absolute; TOP: 268px" runat="server" Text="Vice President" TextAlign="Left" GroupName="PositionGroup" AutoPostBack="True"></asp:RadioButton>
			<asp:RadioButton id="BossButton" style="Z-INDEX: 111; LEFT: 163px; POSITION: absolute; TOP: 234px" runat="server" Text="Boss" TextAlign="Left" GroupName="PositionGroup" AutoPostBack="True"></asp:RadioButton>
			<asp:RadioButton id="WorkerButton" style="Z-INDEX: 112; LEFT: 148px; POSITION: absolute; TOP: 200px" runat="server" Text="Worker" TextAlign="Left" GroupName="PositionGroup" Checked="True" AutoPostBack="True"></asp:RadioButton>
			<asp:Label id="Label6" style="Z-INDEX: 113; LEFT: 411px; POSITION: absolute; TOP: 168px" runat="server">Role</asp:Label>
			<asp:DropDownList id="PositionRole" style="Z-INDEX: 114; LEFT: 455px; POSITION: absolute; TOP: 168px" runat="server" Width="230px"></asp:DropDownList>
			<asp:Label id="InfoLabel" style="Z-INDEX: 115; LEFT: 16px; POSITION: absolute; TOP: 368px" runat="server" Width="680px" Height="48px"></asp:Label>
			<asp:Button id="SaveButton" style="Z-INDEX: 116; LEFT: 304px; POSITION: absolute; TOP: 325px" runat="server" Text="Save"></asp:Button>
			<asp:Button id="ClearButton" style="Z-INDEX: 117; LEFT: 396px; POSITION: absolute; TOP: 323px" runat="server" Text="Clear"></asp:Button>
		</form>
	</body>
</HTML>

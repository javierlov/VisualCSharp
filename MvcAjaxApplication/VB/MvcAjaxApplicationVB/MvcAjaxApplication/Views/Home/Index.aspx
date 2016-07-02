<%@ Page Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData("Message")) %></h2>
    <p>
      Page Rendered: <%= DateTime.Now.ToLongTimeString() %>
    </p>
    <span id="status">No Status</span>
    <br />   
    <%=Ajax.ActionLink("Update Status", "GetStatus", New AjaxOptions With {.UpdateTargetId = "status"})%>
    <br /><br />
    <% Using (Ajax.BeginForm("UpdateForm", New AjaxOptions With {.UpdateTargetId = "textEntered"}))%>
      <%= Html.TextBox("textBox1","Enter text")%>  
      <input type="submit" value="Submit"/>
      <br />
      <span id="textEntered">Nothing Entered</span>
    <% End Using%>
</asp:Content>

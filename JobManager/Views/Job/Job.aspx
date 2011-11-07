<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Job Manager</title>
    </head>
    <body>
        <h2>Job List</h2>
        <ul>
        <li><%= Html.ActionLink("Job Id: 123456", "Details", new { id = 123456 })%></li>
        <li><%= Html.ActionLink("Job Id: 987654", "Details", new { id = 987654 })%></li>
        <li><%= Html.ActionLink("Job Id: 765432", "Details", new { id = 765432 })%></li>
        </ul>
    </body>
</html>

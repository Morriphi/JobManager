<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<JobManager.Models.JobModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Job Manager</title>
    </head>
    <body>
        <h2>Job Details</h2>
        <h4>Job Id: <%= Model.JobId() %></h4>
        <%= Html.ActionLink("back to list", "List") %>
    </body>
</html>

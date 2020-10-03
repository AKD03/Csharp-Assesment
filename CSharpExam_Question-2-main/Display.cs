@model ExamWebApp.Models.EmpTable[]
@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Display</title>
    <style>
        h1
        {
            background-color: bisque;
            text-align: center;
        }
    </style>
</head>
<body>
    <h1>Employee List</h1>
    <hr />
    <div>
        <table border="1" width="100%">
            <tr>
                <th>Employee ID</th>
                <th>Employee Name</th>
                <th>Employee Address</th>
                <th>Employee Salary</th>
                <th>Options</th>
            </tr>
            @foreach (var emp in Model)
            {
                <tr>
                    <td>@emp.EmpID</td>
                    <td>@emp.EmpName</td>
                    <td>@emp.EmpAddress</td>
                    <td>@emp.EmpSalary</td>
                    <td>
                        @Html.ActionLink("Edit", "Find", new { id = emp.EmpID })
                        @Html.ActionLink("Delete", "DeleteEmployee", new { id = emp.EmpID })
                    </td>
                </tr>
            }
        </table>
    </div>
    <br />
    <div style="text-align:center;">
        <div style="text-align:center; background-color:red;">
            @Html.ActionLink("New Registraion", "AddEmployee")
        </div>
    </div>
    
</body>
</html>
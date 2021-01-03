myapp.controller('employee-controller', function ($scope, employeeService)
{
    loadEmployees(); 
    function loadEmployees()
    {
        var EmployeeRecords = employeeService.GetAllEmployee();

        EmployeeRecords.then(function (d)
        {


            $scope.Employed = d.data;


        },
        function()
        {
            alert("Error occured while fetching employee List");
        })
    }
})

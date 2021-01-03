myapp.service('employeeService', function ($http)
{
    this.GetAllEmployee = function ()
    {
        return $http.get('/Home/GetAllEmployee')
    }
}



);
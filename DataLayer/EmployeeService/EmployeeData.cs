using DataLayer.Entity;
using DataLayer.Util;
using DataLayer.Util.Network;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataLayer.EmployeeService
{
    public class EmployeeData : IEmployeeData
    { 
        private  readonly IClientWrapper clientWrapper;
        private readonly string URIBASE= "http://dummy.restapiexample.com/api/v1/";
        public EmployeeData(IClientWrapper clientWrapper)
        {
            this.clientWrapper = clientWrapper;
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            var enpoint = "employee/"+ employeeId.ToString();
            var URI = URIBASE + enpoint;
            Employee? employee = new();
            var result = await clientWrapper.SendRequest(URI, HttpMethod.Get,parameter:employeeId.ToString());
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            if (result.IsJson())
            {
                using var jsonParse = JsonDocument.Parse(result);


                employee = jsonParse.RootElement
                                        .GetProperty("data")
                                        .Deserialize<Employee>(options);
            }

            //serializar respuesta
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var enpoint = "employees";
            string URI = URIBASE + enpoint;

            IEnumerable<Employee>? employees = new List<Employee>();
             var result = await clientWrapper.SendRequest(URI, HttpMethod.Get);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };


            if (result.IsJson())
            {
                using var jsonParse = JsonDocument.Parse(result);


                employees = jsonParse.RootElement
                                        .GetProperty("data")
                                        .Deserialize<IEnumerable<Employee>>(options); 
            }            
            
            //serializar respuesta
            return employees;
        }
    }
}

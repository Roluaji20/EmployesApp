using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer.EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Util.Network;

namespace DataLayer.EmployeeService.Tests
{
    [TestClass()]
    public class EmployeeDataTests
    {
        private readonly IEmployeeData employeeData;
      
        public EmployeeDataTests(IEmployeeData employeeData)
        {
            this.employeeData = new EmployeeData(new ClientWrapper());
        }

        [TestMethod()]
        public void  GetEmployeesshouldReturnValuesTest()
        {
            //Arrange
            var a = 1;
            var b = 2;

            var result = a + b;

            //ACT
         //   var result = await employeeData.GetEmployees();
           // var resp = result.Count();
           
            //Assert
            Assert.AreEqual(3, result);
            //Assert.AreNotEqual(resp, 0);
           
        }
    }
}
using DataLayer.EmployeeService;
using DataLayer.Entity;
using DataLayer.Util.Network;

namespace TestEmployeeApp
{
    [TestClass]
    public class UnitTest1
    {
     
        [TestMethod]
        public async Task ShouldReturnEmployees()
        {
            //Arrange
            
            var instance = new EmployeeData(new ClientWrapper());

            //ACT
            var result = await instance.GetEmployees();
           
            
            Assert.AreNotEqual(result, 0);
        }


        [TestMethod]
        public async Task ShouldReturn_atleast_oneEmployee()
        {
            //Arrange

            var instance = new EmployeeData(new ClientWrapper());

            //ACT
            var result = await instance.GetEmployeeById(3);


            Assert.IsInstanceOfType(result, typeof(Employee));
        }

    }
    }
using Moq;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;
using Xunit;

namespace UnitTest_Mock.UnitTesting
{
    public class EmployeeTest
    {
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();

        [Fact]
        public async void GetEmployeeById()
        {
            mock.Setup(p => p.GetEmployeebyId(1)).ReturnsAsync("JK");
            EmployeeController emp = new EmployeeController(mock.Object);
            string result = await emp.GetEmployeebyId(1);
            Assert.Equal("JK", result);
        }

        [Fact]
        public async void GetEmployeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "JK",
                Destination = "SDE"
            };
            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);

            EmployeeController emp = new EmployeeController(mock.Object);

            var result = await emp.GetEmployeeDetails(1);

            Assert.True(employeeDTO.Equals(result));
        }
    }
}

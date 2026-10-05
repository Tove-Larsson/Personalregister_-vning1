namespace Personalregister.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void EmployeeShouldStoreName()
		{
			Employee employee = new Employee();

			employee.Name = "Anna";

			Assert.Equal("Anna", employee.Name);
		}

		[Fact]
		public void EmployeeShouldStoreSalary()
		{
			Employee employee = new Employee();

			employee.Salary = 30000m;

			Assert.Equal(30000, employee.Salary);
		}
	}
}

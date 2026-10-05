namespace Personalregister
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}

	public class Employee
	{
		public string Name { get; set; }
		public decimal Salary { get; set; }
	}

	public class EmployeeRegistry
	{
		List<Employee> employees;

		public EmployeeRegistry()
		{
			employees = new List<Employee>();
		}

		public void AddEmployee(Employee employee)
		{
			employees.Add(employee);
		}

	}
	}

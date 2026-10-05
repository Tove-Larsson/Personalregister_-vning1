namespace Personalregister
{
	internal class Program
	{
		static void Main(string[] args)
		{
			EmployeeRegistry employeeList = new EmployeeRegistry();
			Employee employee = new Employee();

			Console.WriteLine("Please input the employees name: ");
			employee.Name = Console.ReadLine();

			Console.WriteLine("Please input the employees salary");
			employee.Salary = decimal.Parse(Console.ReadLine());

			employeeList.AddEmployee(employee);

			employeeList.PrintEmployees();

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

		public void PrintEmployees()
		{
			foreach (Employee emp in employees)
			{
				Console.WriteLine("Name: " + emp.Name + " | Salary: " + emp.Salary);
			}

		}
	}
}

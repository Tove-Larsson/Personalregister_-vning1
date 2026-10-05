namespace Personalregister
{
	internal class Program
	{
		static void Main(string[] args)
		{
			EmployeeRegistry employeeList = new EmployeeRegistry();
			string answer;

			do
			{
				Employee employee = new Employee();

				Console.WriteLine("Please input the employees name:");
				employee.Name = Console.ReadLine();

				while (string.IsNullOrWhiteSpace(employee.Name))
				{
					Console.WriteLine("Name cannot be empty. Please enter a name:");
					employee.Name = Console.ReadLine();
				}

				Console.WriteLine("Please input the employees salary: ");

				decimal salary;

				while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0)
				{
					Console.WriteLine("Please enter a valid salary: ");
				}

				employee.Salary = salary;

				employeeList.AddEmployee(employee);

				Console.WriteLine("Do you want to add another employee? y/n");

				answer = Console.ReadLine();

			} while (answer == "y");

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

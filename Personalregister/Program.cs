namespace Personalregister
{
	internal class Program
	{
		static void Main(string[] args)
		{
			EmployeeRegistry employeeRegistry = new EmployeeRegistry();

			ShowMenu(employeeRegistry);

		}

		static void ShowMenu(EmployeeRegistry employeeRegistry)
		{
			bool running = true;

			while (running)
			{
				Console.WriteLine("\n=== Employee Registry ===");
				Console.WriteLine("1. Add employee");
				Console.WriteLine("2. Show employees");
				Console.WriteLine("3. Exit");
				Console.Write("Choose an option: ");

				string choice = Console.ReadLine();

				switch (choice) 
				{
					case "1":
						Console.WriteLine("Add employee");
						CreateEmployee(employeeRegistry);
						break;
					case "2":
						Console.WriteLine("Show employees");
						employeeRegistry.PrintEmployees();
						break;
					case "3":
						Console.WriteLine("Goodbye");
						running = false;
						break;
					default:
						Console.WriteLine("Invalid option.");
						break;
				}
			}
		}

		static void CreateEmployee(EmployeeRegistry employeeRegistry)
		{
			Employee employee = new Employee();

			Console.WriteLine("Please input the employees name:");
			employee.Name = Console.ReadLine();

			while (string.IsNullOrWhiteSpace(employee.Name))
			{
				Console.WriteLine("Name cannot be empty. Please enter a name:");
				employee.Name = Console.ReadLine();
			}

			Console.WriteLine("Please input the employees salary:");

			decimal salary;

			while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0)
			{
				Console.WriteLine("Please enter a valid salary:");
			}

			employee.Salary = salary;

			employeeRegistry.AddEmployee(employee);

			Console.WriteLine("Employee added successfully!");
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

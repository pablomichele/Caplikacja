using Caplikacja;

Employee employee1 = new Employee("Pawel", "Zakościelny", "30");
Employee employee2 = new Employee("Antosia", "Góra", "23");
Employee employee3 = new Employee("Ptyś", "Głupiutki", "18");

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(0);
employee1.AddScore(1);

employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(4);
employee2.AddScore(9);
employee2.AddScore(10);

employee3.AddScore(1); 
employee3.AddScore(7);
employee3.AddScore(1);
employee3.AddScore(0);
employee3.AddScore(1);

List<Employee> employees = new List<Employee> { employee1, employee2, employee3 };

int maxResult = -1;
Employee EmployeeWithMaxResult = null;

foreach (var employee in employees)
{
 if (employee.Result > maxResult)
{
maxResult = employee.Result;
EmployeeWithMaxResult = employee;
}
}
if (EmployeeWithMaxResult != null)
            {
                Console.WriteLine(EmployeeWithMaxResult.Name);
                Console.WriteLine(EmployeeWithMaxResult.LastName);
                Console.WriteLine(EmployeeWithMaxResult.Age);
                Console.WriteLine("Punkty: " + EmployeeWithMaxResult.Result);
            }    
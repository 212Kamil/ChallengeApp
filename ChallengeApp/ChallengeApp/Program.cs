using ChallengeApp;

User user1 = new User("Adam", "haslo");
User user2 = new User("Monika", "haslo");
User user3 = new User("Zuzia", "haslo");
User user4 = new User("Damian", "haslo");

Employee employee1 = new Employee("Kamil", "abcd1234", "19");
Employee employee2 = new Employee("Maciej", "abcd1234", "25");
Employee employee3 = new Employee("Szymon", "abcd1234", "31");

employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(5);


employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(3);

employee3.AddScore(5);
employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(2);
employee3.AddScore(4);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = 0;
Employee employeeWithMaxResult = null;
foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine(employeeWithMaxResult);

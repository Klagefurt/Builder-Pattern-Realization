//using Builder_pattern;

using Builder_pattern;

List<Employee> employees = new()
{
    new Employee { Name = "Sanya", Salary = 100 },
    new Employee { Name = "John", Salary = 200 },
    new Employee { Name = "Uwe", Salary = 1000 }
};

var builder = new EmployeeReportBuilder(employees);

var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

Console.WriteLine(report);








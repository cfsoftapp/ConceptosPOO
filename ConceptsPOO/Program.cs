// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");
//Date date1 = new Date(2025, 6, 27);
//Console.WriteLine(date1);
//try
//{
//    Console.WriteLine(new Date(2025, 6, 27));
//    Console.WriteLine(new Date(1976, 3, 4));
//    Console.WriteLine(new Date(1985, 12, 5));
//    Console.WriteLine(new Date(2024, 2, 29));
//    Console.WriteLine(new Date(2025, 11, 30));
//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message);
//}
Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815.45M
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Sales = 320000M,
    CommisionPercentaje = 0.03F
};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 2020,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    HourValue = 55.56M,
    Hours = 123.5F
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 2020,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date(1994, 2, 13),
    HiringDate = new Date(2022, 1, 20),
    IsActive = true,
    Base = 1200.50M,
    Sales = 25000M,
    CommisionPercentaje = 0.015F
};
//Console.WriteLine(employee4);

//lista de empleados
ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                             ==================");
Console.WriteLine($"TOTAL                         {$"{payroll:C2}",15}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 16",
    Id = 1,
    Price = 5500M,
    Quantity = 3
};

Invoice invoice2 = new Invoice()
{
    Description = "Pitza",
    Id = 2,
    Price = 60M,
    Quantity = 4
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
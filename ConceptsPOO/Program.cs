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
Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Sales = 32000M,
    CommisionPercentaje = 0.03F
};
Console.WriteLine(employee2);
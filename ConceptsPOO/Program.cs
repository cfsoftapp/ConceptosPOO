// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");
//Date date1 = new Date(2025, 6, 27);
//Console.WriteLine(date1);
try
{
    Console.WriteLine(new Date(2025, 6, 27));
    Console.WriteLine(new Date(1976, 3, 4));
    Console.WriteLine(new Date(1985, 12, 5));
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2025, 11, 30));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
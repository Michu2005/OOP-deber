// See https://aka.ms/new-console-template for more information


using OOP_deber;

try
{
    var fecha1 = new Date()
    {
        Year = 2023,
        Month = 2,
        Day = 28
    };
    Console.WriteLine(fecha1);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
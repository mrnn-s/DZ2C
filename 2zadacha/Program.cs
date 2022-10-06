//По двум заданным числам проверять является ли одно квадратом другого


Console.WriteLine("enter number1" );
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("enter number2" );
int number2 = int.Parse(Console.ReadLine() ?? "0");
double kvadrat = Math.Pow(number1, 2);
double kvadrat2 = Math.Pow(number2, 2);
if (number1 == kvadrat2)
{
    Console.WriteLine("Первое число есть квадрат второго");
}
else if (number2 == kvadrat)
{
    Console.WriteLine("Второе число есть квадрат первого");
}
else
{
    Console.WriteLine("Одно число не является квадратом другого");
}
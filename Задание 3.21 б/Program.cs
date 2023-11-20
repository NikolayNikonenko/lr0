// See https://aka.ms/new-console-template for more information
Console.Write("Введите значение a:");
double a = Convert.ToDouble(Console.ReadLine());
double a2, a4, a6, a10;
a2 = a * a;
a4 = a2 * a2;
a6 = a4 * a2;
a10 = a4 * a6;
Console.WriteLine($"a={a} в 10 степени borista = {a10}");
Console.WriteLine($"a={a} в 10 степени bobr = {a10}");

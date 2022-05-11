// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number%2;

if (result == 0)
{
    Console.WriteLine("Число четное");
}
if (result == 1)
{
    Console.WriteLine("Число нечетное");
}
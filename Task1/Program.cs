// Напишите программу, которая на вход принимает два числа и выдает, 
// какое большее, а какое меньшее.

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Самое большое число: ");
    Console.WriteLine(number1);
    Console.Write("Самое маленькое число: ");
    Console.WriteLine(number2);
}
else;
{
    Console.Write("Самое большое число: ");
    Console.WriteLine(number2);
    Console.Write("Самое маленькое число: ");
    Console.WriteLine(number1);
} 

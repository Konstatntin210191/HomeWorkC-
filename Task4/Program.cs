// Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все четные числа от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    int result = i%2;
    if (result == 0)
    {
        Console.Write(i);
        if (i != number)
        {
            Console.Write(", ");
        }
    }
}
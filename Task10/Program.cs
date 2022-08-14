// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100 || num > 999)
{
    Console.WriteLine("Это число не трехзначное");
}
else
{
    Console.WriteLine($"Вторая цифра этого числа: {num/10%10}");
}
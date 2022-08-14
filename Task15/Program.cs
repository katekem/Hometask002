// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 6 || day == 7)
{
    Console.WriteLine("Этот день - выходной");
}
else if(day >= 1 && day <= 5)
{
    Console.WriteLine("Этот день - НЕ выходной");
}
else
{
    Console.WriteLine("Цифра не соответствует дню недели");
}
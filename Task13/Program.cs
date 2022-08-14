// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string str;
if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    str = num.ToString();
    char[] arr;
    arr = str.ToCharArray(2,1);
    Console.WriteLine(arr);
}

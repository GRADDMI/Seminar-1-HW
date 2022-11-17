// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb % 2 == 1)
{
Console.WriteLine("Число " + numb + " является: НЕЧЁТНЫМ");
}
else
{
Console.WriteLine("Число " + numb + " является: ЧЁТНЫМ");
}


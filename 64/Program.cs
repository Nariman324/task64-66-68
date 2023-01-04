// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter the number... ");
int number = int.Parse(Console.ReadLine()!);

string NumbersAscendOrder(int number)
{
    string num = Convert.ToString(number);
    if (number == 1) return "1";
    else
    {
        number--;
        return num + ", " + NumbersAscendOrder(number);
    }
}

Console.WriteLine($"N = {number} ---> {NumbersAscendOrder(number)}");


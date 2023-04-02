// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1.

string PrintNumbers(int n)
{
    if (n == 1) return 1.ToString();
    return n.ToString() + ", " + PrintNumbers(n - 1);
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write(PrintNumbers(n));
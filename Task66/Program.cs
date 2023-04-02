// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных 
// элементов в промежутке от M до N.

int GetSum(int m, int n)
{
    if (m == n) return m;
    return GetSum(m, n - 1) + n;
}

Console.Clear();
Console.Write("Введите M и N: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"{GetSum(numbers[0], numbers[1])}");
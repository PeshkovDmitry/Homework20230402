// Пользователь вводит скобочные последовательности.
// В последовательности могут встретится скобки вида: {},(),[]
// Написать программу, которая определяет, правильная ли 
// скобочная последовательность была введена
// Правильная (),()[]{}
// Неправильная (], ({)}

bool Correct(string s)
{
    if (s == String.Empty) return true;
    s = s.Replace("{}", "");
    s = s.Replace("[]", "");
    s = s.Replace("()", "");
    if (s.Length > 0)
    {
        if (s.Contains("{}") || s.Contains("[]") || s.Contains("()"))
            Correct(s);
        else return false;
    }
    return true;
}

Console.Write("Введите последовательность: ");
string str = Console.ReadLine();
Console.WriteLine(Correct(str) ? "Последовательность верна" : "Последовательность не верна");
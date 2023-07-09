// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int number = int.Parse(Console.ReadLine());

string WeekendCheck(int num)            // Определяет выходной по номеру дня недели
{
    if (num > 0 && num < 6)
    {
        return $"{num} -> нет";
    }
    else if (num == 6 || num == 7)
    {
        return $"{num} -> да";
    }
    else
    {
        return "В неделе только семь дней.";
    }
}

Console.Write(WeekendCheck(number));
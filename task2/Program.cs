// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int ThirdDigit(int num)            // Находит цифру третьего порядка
{
    return (num - (num / 1000) * 1000 - num % 100) / 100; 
}

int MinusDelet(int num1)            // Если число отрицательное, то переводим в положительное
{
    if (num1 < 0)
    {
        num1 = num1 * -1;
    }
    return num1;
}

if (MinusDelet(number) > 99)
{
    Console.WriteLine(number + " -> " + ThirdDigit(MinusDelet(number)));
}
else
{
    Console.WriteLine($"{number} -> третьей цифры нет.");
}

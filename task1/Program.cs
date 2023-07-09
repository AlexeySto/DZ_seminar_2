//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int SecondDigit(int num)            // Находит цифру второго порядка
{
    return (num - (num / 100) * 100 - num % 10) / 10; 
}

int MinusDelet(int num1)            // Если число отрицательное, то переводим в положительное
{
    if (num1 < 0)
    {
        num1 = num1 * -1;
    }
    return num1;
}

if (MinusDelet(number) > 99 && MinusDelet(number) < 1000)
{
    Console.WriteLine(number + " -> " + SecondDigit(MinusDelet(number)));
}
else
{
    Console.WriteLine("Число не является положительным трехзначным.");
}

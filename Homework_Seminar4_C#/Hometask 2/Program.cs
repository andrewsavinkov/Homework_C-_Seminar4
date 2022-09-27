/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int SumOfDigits(string line)
{
    Console.WriteLine(line);
    string number = Console.ReadLine()??"";
    int sum = 0;
    for (int i = 0; i < number.Count(); i++)
    {
        int charToInt = number[i]-'0';
        sum = sum + charToInt;
    }
    return sum;
}

int number = SumOfDigits("Введите число: ");
Console.WriteLine($"Сумма цифр числа равна: {number}");

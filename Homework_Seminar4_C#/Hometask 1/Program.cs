/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int Power(int basis, int power)
{
    int result = 0;
    if (power == 0)
        return 1;
    else if (power == 1)
    {
        result = basis;
        return result;
    }
    else if (power > 1)
    {
        result = basis;
        for (int i = 2; i <= power; i++)
        {
            result = result * basis;
        }
        return result;
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимое число");
        return -1;
    }

}

int number = Power(2, 5);
Console.WriteLine(number);
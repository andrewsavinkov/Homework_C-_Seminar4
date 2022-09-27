/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/


int[] ArrayFromConsoleInput(string line)
{
    Console.WriteLine(line);
    string array = Console.ReadLine() ?? "";
    string[] arrayTwo = array.Split(',');
    int[] finalArray = new int[arrayTwo.Length];
    for (int i = 0; i < arrayTwo.Length; i++)
    {
        bool correctInput = int.TryParse(arrayTwo[i], out finalArray[i]);
        if (correctInput)
            finalArray[i] = int.Parse(arrayTwo[i]);
        else
            Console.WriteLine($"{i}-й элемент: недопустимое число!");
    }
    return finalArray;
}

int[] array = ArrayFromConsoleInput("Введите числа через запятую: ");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{i + 1}-й элемент массива: {array[i]}");
}
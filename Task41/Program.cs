//Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5 0 7 8 - 2 - 2-> 2

Console.Clear();
Console.Write("Введите число: ");
int quantity = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите {quantity} чисел: ");
double[] array = new double[quantity];
double result = PositiveNumCounter(array);
Console.WriteLine($"Количество чисел больше 0, которые ввёл пользователь: {result}");

int PositiveNumCounter(double[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = double.Parse(Console.ReadLine()!);
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
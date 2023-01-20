// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Please input Numbers quantity:  ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

NumbersInputMethod(array);
Console.WriteLine();
PrintArray(array);

int count = PositiveNumbersCount(array);
Console.WriteLine($" ->  {count}");


int[] NumbersInputMethod(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"number {i + 1}:  ");
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
    }
    return arr;
}

int PositiveNumbersCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}
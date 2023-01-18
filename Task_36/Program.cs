//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] CreateRandomArray(int size, int start, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"| {array[i]} |");
    }
    Console.WriteLine();
}

Console.WriteLine($"Введите размер массива ");
int arraySize = int.Parse(Console.ReadLine());
if (arraySize < 1)
{
    Console.WriteLine($"Размер массива должен быть больше 0");
}
else
{
    int[] myArray = CreateRandomArray(arraySize, -100, 100);
    ShowArray(myArray);
    Console.WriteLine();
    int sumEven = 0;
    int sumOdd = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (i % 2 == 0) sumEven = myArray[i] + sumEven;
        else sumOdd = myArray[i] + sumOdd;         
    }
Console.WriteLine($"Сумма четных элементов массива равна {sumEven}");
Console.WriteLine($"А сумма НЕ четных элементов массива равна {sumOdd}");
}
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// 345, 897, 568, 234] -> 2

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
    int[] myArray = CreateRandomArray(arraySize, 100, 1000);
    ShowArray(myArray);
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0) count++;
    }

    Console.WriteLine($"В данном массиве {count} четных чисел");
}
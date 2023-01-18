// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// 3 7 22 2 78] -> 76
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
    int[] myArray = CreateRandomArray(arraySize, 0, 100);
    ShowArray(myArray);
    Console.WriteLine();
    //Вариант со встроеной функцией
    // int maxElement = myArray.Max<int>();
    // int minElement = myArray.Min<int>();
    // Console.WriteLine($"Разница между максимаьным элементом {maxElement} и минимальным элементом {minElement} будет равна {maxElement - minElement}");
    
    //Вариант с циклом
    int maxElement = myArray[0];
    int minElement = myArray[0];
    for (int i = 1; i < myArray.Length; i++)
    {
        if (myArray[i] > maxElement) maxElement = myArray[i];
        else
        {
            if (myArray[i] < minElement) minElement = myArray[i];
        }
    }
    Console.WriteLine($"Разница между максимаьным элементом {maxElement} и минимальным элементом {minElement} будет равна {maxElement - minElement}");
}
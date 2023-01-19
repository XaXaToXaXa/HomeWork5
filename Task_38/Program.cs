// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// 3 7 22 2 78] -> 76
double[] CreateRandomArray(int size, double start, double end)
{
    double[] RandomArray = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = rand.NextDouble() * (end - start) + start;
    }
    return RandomArray;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"| {array[i]:F2} |");
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
    double[] myArray = CreateRandomArray(arraySize, -100.0, 100.0);
    ShowArray(myArray);
    Console.WriteLine();

    Вариант с циклом
    double maxElement = myArray[0];
    double minElement = myArray[0];
    for (int i = 1; i < myArray.Length; i++)
    {
        if (myArray[i] > maxElement) maxElement = myArray[i];
        else
        {
            if (myArray[i] < minElement) minElement = myArray[i];
        }
    }
    Console.WriteLine($"Разница между максимаьным элементом {maxElement:F2} и минимальным элементом {minElement:F2} будет равна {maxElement - minElement}");
}
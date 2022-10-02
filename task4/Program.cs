void FillArray(int[] collection)
{
    int Length = collection.Length;//получаем длинну массива
    int index = 0;
    while(index < Length)
    {
        collection[index] = new Random().Next(1, 10);//в колекцию положить случайные числа из диапозона 1,10
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; //задали массив в котором будет 10 элементов

FillArray(array);//метод, который заполнил нам массив
PrintArray(array);//метод, который распечатал нам массив
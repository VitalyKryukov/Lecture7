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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    //int position = 0;//Если элемент не входит в область массива, то будет выдавать 0. В строке ниже решение данной проблемы
    int position = -1;//т.е. если нет элемента то будет выдавать -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //задали массив в котором будет 10 элементов

FillArray(array);//метод, который заполнил нам массив
array[4] = 4;
array[6] = 4;
PrintArray(array);//метод, который распечатал нам массив
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
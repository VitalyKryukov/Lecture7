//             0   1   2  3   4   5   6   7
int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length; //array.Length - определяет длинну массива!
int find = 18;
int index = 0;
while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;//прерви - нужен, чтобы не выводить индекс всех повтряющихся значений массива (например 4 и 8)
    }
    //index = index + 1;
    index++;
}
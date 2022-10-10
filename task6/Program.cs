Console.Clear();
// Вид 1. Ничего не возвращают и не принимают.
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1(); //Так вызывается метод

//Вид 2. Ничего не возвращают и принимают.
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

void Method2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2(msg: "Текст сообщения", count: 4);
//Method2(count: 4, msg: "Новый текст");

//Вид 3. Возвращают но ничего не принимают.
int Method3() //Если метод что-либо возвращает обязательно указывается тип данных.
{
    return DateTime.Now.Year; //Если возвращает, обязательно использовать return.
}
int year = Method3();
//Console.WriteLine(year);

//Вид 4. Принимают и возвращают.
//Вариант с while
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res =  Method4(10, "z");
// Console.WriteLine(res);

//Вариант с for.
string Method4(int count, string text)
{
    string result = String.Empty;
    for( int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res =  Method4(10, "z");
//Console.WriteLine(res);

//Цикл в цикле.
//Вывод таблицы умножения на экран.

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
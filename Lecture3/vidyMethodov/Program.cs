
// Виды методов:
// вид 1 и 2 - void методы

// Вид 1: не принимают никаких аргументов, ничего не возвращают

void Method()
{
    Console.WriteLine("можно писать");
}
 
//  Вызов:
Method();

// Вид 2: могут принимать какие-то аргументы, но в то же время ничего не возвращают

void Method2(string  msg)
{
    Console.WriteLine(msg);
}
// вызов;
Method2("текст сообщения");


void Method21 (string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Вид 3: могут что-то возвращать, но не принимают никаких аргументов
// -Пример – случайная генерация данных.
// -Если метод что-то возвращает, то надо обязательно указать тип данных,
// значение которого мы ожидаем.

int Method3()
{
    return DateTime.Now.Year;
}

// Вызов
int year = Method3();
Console.WriteLine(year);

// Вид 4: что-то принимают, что-то возвращают для дальнейшей работы.
// Наиболее часто используется

string Method4(int count, string text)
{
    string result = string.Empty;
    for(int i = 0; i<count; i++)
    {
        result = result + text;
    }
    return result
}

string res = Method4(10, "x");
Console.WriteLine(res); 
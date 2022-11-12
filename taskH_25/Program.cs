// Цикл, принимает на вход жва числа (A и B) и возводит число A в нутуральную стеень B
Console.WriteLine("Введите основание степени");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("Введите показатель степени");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);

if(!isParsedA || !isParsedB)
{
    Console.WriteLine("Ошибка. Не то ввели! ПереВВедите!");
    return;
}


if (b < 0)
{
    Console.WriteLine("Не та цифра");
    return;
}

int result = GetResNum(b);
Console.WriteLine($"{a} в степени {b} равно {result}");


int GetResNum(int number)
{
    int res = 1;
    for( int i = 1; i <= number; i++)
    {
        res = a * res;
        //Console.WriteLine(res);
    }
    return res;
}
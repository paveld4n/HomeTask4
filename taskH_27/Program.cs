// Задача 2. Приянять число N и выдать сумму цифр в числе.

Console.WriteLine("Введите число больше 0");
bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if(!isParsed)
{
    Console.WriteLine("Не правильно введены данные!");
    return;
}

if (n < 1)
{
    Console.WriteLine("Не та цифра");
    return;
}
int result = GetCheckum(n);
Console.WriteLine($"Итоговая сумма = {result}");


int GetCheckum(int number)
{
    int res = 0;
    for( int i = 1; number != 0; i++)
    {
        res = res + number % 10;
        number = number / 10;
        // Console.WriteLine(number);
    }
    return res;
}
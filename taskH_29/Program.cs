// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Задание должно быть выполнено в методах.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите размер массива");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);

if(!isParsedA)
{   
    Console.WriteLine("Ошибка. Не то ввели! ПереВВедите!");
    return;
}

int [] array = GetCreatArray(a);
PrintArray(array);

int [] GetCreatArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива");
        bool isParsedB = int.TryParse(Console.ReadLine(), out int b);
        if(!isParsedB)
        {
            Console.WriteLine("Ошибка. Вы ввели букву! В массиве будет значение по умолчанию - 0.");
        }
        array[i] = b;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[^1]} ] ");
}


/* Задача 49: Задайте двумерный массив.
Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты. */

int GetNumber(string text)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

//Задать матрицу и заполнить ее числами
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }

        Console.WriteLine();
    }
}

// Функция замены элементов
void GetNewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
}

int m = GetNumber("Введите m");
int n = GetNumber("Введите n");

int[,] array = GetArray(m, n);
PrintArray(array);
GetNewArray(array);

Console.WriteLine();
PrintArray(array);

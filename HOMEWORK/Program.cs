/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

// Получить числа с консоли
// int GetNumber(string message)
// {
//     int result = 0;

//     while (true)
//     {
//         Console.WriteLine(message);
//         if (int.TryParse(Console.ReadLine(), out result))
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Ввели не число");
//         }
//     }
//     return result;
// }

// //Задать матрицу и заполнить ее числами
// double[,] GetMatrix(int m, int n)
// {
//     double[,] matrix = new double[m, n];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(-5.0 + rnd.NextDouble() * (-5.0 + 10.5));
//         }
//     }
//     return matrix;
// }

// // Распечатать матрицу
// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int m = GetNumber("введите количество строк: ");
// int n = GetNumber("Введите количество столбцов");

// double[,] matrix = GetMatrix(m, n);

// PrintMatrix(matrix);


//.................................................................................

/* Задача 50. Напишите программу,
которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

/*  1. Создать массив
    2. Принять позицию
    3. Проверка есть элемент или нет его  */

// int m = GetNumber("введите количество строк: ");
// int n = GetNumber("Введите количество столбцов");

// int[,] matrix = GetMatrix(4, 5);

// PrintMatrix(matrix);

// // Получить числа с консоли (Принять позицию)
// int GetNumber(string message)
// {
//     int result = 0;

//     while (true)
//     {
//         Console.WriteLine(message);
//         if (int.TryParse(Console.ReadLine(), out result))
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Ввели не число");
//         }
//     }
//     return result;
// }

// //Задать матрицу и заполнить ее числами (Создать массив)
// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 10);
//         }
//     }
//     return matrix;
// }

// // Распечатать матрицу
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // Проверка есть элемент или нет его

// if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
// {
//     Console.WriteLine(matrix[m, n]);
// }
// else
// {
//     Console.WriteLine($"{m} {n} -> такого числа в массиве нет");
// }

//........................................................................
/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3*/
Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter m:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, m];
int[] sum = new int[m];
Random ran = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = ran.Next(0, 100);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i = 0; i < m; i++)
{
    Console.Write((sum[i] / n) + " ");
}
Console.ReadLine();

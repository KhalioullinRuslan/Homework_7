// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AverageColumns(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if(j <= arr.GetLength(0))
                sum += arr[j, i];
        }
        System.Console.WriteLine(Math.Round(sum/arr.GetLength(0), 1));
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(" " + arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void FillMatrixRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int rows = AddNumber("Введите количество строк: ");
int colums = AddNumber("Введите количество стобцов:");
int[,] matrix = new int[rows, colums];
FillMatrixRandomNumbers(matrix);
PrintMatrix(matrix);
AverageColumns(matrix);

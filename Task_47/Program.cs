// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("    " + arr[i, j] + "    ");
        }
        System.Console.WriteLine();
    }
}

void FillMatrixWithRundomNumbers(double [,] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(rand.Next(-9, 10) + rand.NextDouble(), 1);
        }
    }
}
int EnterNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int rows = EnterNumber("Введите количество столбцов: ");
int columns = EnterNumber("введите количестко строк: ");
double [,] matrix = new double [rows, columns];
FillMatrixWithRundomNumbers(matrix);
PrintMatrix(matrix);

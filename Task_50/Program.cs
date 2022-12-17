// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void FindNumber(string meseg, int[,] arr)
{
    System.Console.WriteLine(meseg);
    string[] desiredNumber = Console.ReadLine().Split("; ");
    int numberY = Convert.ToInt32(desiredNumber[0]);
    int numberX = Convert.ToInt32(desiredNumber[1]);
    if (numberX <= arr.GetLength(0) && numberY <= arr.GetLength(1))
        System.Console.WriteLine("Номер: " + arr[numberX - 1, numberY - 1]);
    else
        System.Console.WriteLine("Нет такого числа: ");
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
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

int EnterNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int columns = EnterNumber("Введите количество строк:");
int rows = EnterNumber("Введите количество столбцов: ");
int[,] matrix = new int[columns, rows];
FillMatrixRandomNumbers(matrix);
PrintMatrix(matrix);
FindNumber("Введите идентификатор номера: (например, 1; 1)", matrix);

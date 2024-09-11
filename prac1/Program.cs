using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность матрицы n:");
        int n = int.Parse(Console.ReadLine());

        double[,] matrix = new double[n, n];
        Console.WriteLine("Введите элементы матрицы:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        CompareDiagonalSums(matrix);
    }

    static void CompareDiagonalSums(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        double mainDiagonalSum = 0;
        double secondaryDiagonalSum = 0;

        for (int i = 0; i < n; i++)

        {
            mainDiagonalSum += matrix[i, i]; // Главная диагональ
            secondaryDiagonalSum += matrix[i, n - 1 - i]; // Побочная диагональ
        }

        Console.WriteLine($"Сумма главной диагонали: {mainDiagonalSum}");
        Console.WriteLine($"Сумма побочной диагонали: {secondaryDiagonalSum}");

        if (mainDiagonalSum > secondaryDiagonalSum)
        {
            Console.WriteLine("Сумма главной диагонали больше суммы побочной диагонали.");
        }
        else if (mainDiagonalSum < secondaryDiagonalSum)
        {
            Console.WriteLine("Сумма побочной диагонали больше суммы главной диагонали.");
        }
        else
        {
            Console.WriteLine("Сумма главной и побочной диагоналей равны.");
        }
    }
}
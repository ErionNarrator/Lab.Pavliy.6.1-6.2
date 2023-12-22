//6.1 Сред

//double[] realNumbers = new double[] { 3.1, 4.7, -5.8, 2.6, -3.2, 6.9, -2.2 };


//int[] integers = realNumbers.Select(r => MyRound(r)).ToArray();

//int maxModulo = MaxModulo(integers);

//Console.WriteLine("Rounded integers:");
//foreach (int num in integers)
//{
//    Console.Write(num + " ");
//}
//Console.WriteLine("\nMaximum modulo number: " + maxModulo);
//static int MyRound(double number)
//{
//    if (number < 0)   
//        return Convert.ToInt32(Math.Ceiling(number - 0.5));
//    else
//        return Convert.ToInt32(Math.Floor(number + 0.5));
//}


//static int MaxModulo(int[] numbers)
//{
//    return numbers.Select(x => Math.Abs(x)).Max();
//}

using ClassLibrary6;
double[,] matrix = new double[6, 4];
double[] maxElements = new double[6];

// Заполнение матрицы 6x4
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"Введите элемент [{i}, {j}]: ");
            matrix[i, j] = double.Parse(Console.ReadLine()!);
    }
}

// Вычисление максимальных элементов строк матрицы
for (int i = 0; i < 6; i++)
{
    double max = matrix[i, 0];
    for (int j = 1; j < 4; j++)
    {
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];
        }
    }
    maxElements[i] = max;
}

Console.WriteLine("Максимальные элементы строк матрицы:");
for (int i = 0; i < 6; i++)
{
    Console.Write(maxElements[i] + " ");
}
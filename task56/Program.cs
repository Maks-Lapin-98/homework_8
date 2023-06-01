int ReadInt(string argument) 
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}
int[,] FillMatrix(int[,] matr) 
{
    Random rnd =new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(0, 10);
        }
    }
    return matr;
}
void PrintMatrix(int[,] matr)  
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int[] StringSumm(int[,] matr)
{
    int[] arraySumm = new int [matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        arraySumm[i] = sum;
    }
    return arraySumm;
}
void FindMinSumm(int[] array)
{
    int index = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) index = i;
    }
    System.Console.WriteLine($"Строка с минимальной суммой: {index}");
}




int str = ReadInt("Введите количество строк: ");
int coll = ReadInt("Введите количество стольбцов: ");
if (str == coll) System.Console.WriteLine("Массив должен быть прямоугольным.");
else
{
    int[,] array = new int[str, coll];
    FillMatrix(array);
    PrintMatrix(array);
    System.Console.WriteLine();
    StringSumm(array);
    System.Console.WriteLine($"Массив с суммами: [{string.Join(",", StringSumm(array))}]");
    System.Console.WriteLine();
    FindMinSumm(StringSumm(array));
}
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void PrintArray (int[,] array) 
{
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] CreateMatrixArray (int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max+1);
        }
    }
    return array;
}
int[] SearchRowSum (int[,] array)
{
    int sum = 0;
    int[] arrayOfSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        arrayOfSum[i] = sum;
        sum = 0;
        Console.WriteLine($" Для удобства сумма каждой строки {i+1}: {arrayOfSum[i]} ");
    }
    return arrayOfSum;
}
void SearchIndexMinimalSum (int[] arrayOfSum)
{
    int min = arrayOfSum[0];
    int index = 0;
    for (int i = 0; i < arrayOfSum.Length; i++)
    {
        if (arrayOfSum[i] < min)
        {
            index = i;
            min = arrayOfSum[i];
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {index+1} строка");
}
int[,] myArray = CreateMatrixArray(3,3,1,8);
PrintArray(myArray);
Console.WriteLine();
int[] arrayOfSum = SearchRowSum(myArray);
SearchIndexMinimalSum(arrayOfSum);

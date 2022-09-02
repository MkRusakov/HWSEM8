// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
void IncreaseMatrix (int[,] firstArray, int[,] secondArray)
{
    if (firstArray.GetLength(1) != secondArray.GetLength(0)) Console.WriteLine("Произведение данных матриц не существует!");
    else 
    {
        int[,] increaseMatrix =  new int[firstArray.GetLength(0), firstArray.GetLength(1)];
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < firstArray.GetLength(1); j++)
            {
                increaseMatrix[i, j] = firstArray[i, j] * secondArray[j, i];
            }
        }
        PrintArray(increaseMatrix);
    }
}
int[,] firstMatrix = CreateMatrixArray(2,4,1,4);
int[,] secondMatrix = CreateMatrixArray(4,2,1,4);
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();
IncreaseMatrix(firstMatrix, secondMatrix);



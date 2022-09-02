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
void SearchMinimalSum (int[,] array)
{
    
}
int[,] myArray = CreateMatrixArray(3,3,1,8);
PrintArray(myArray);
SearchMinimalSum(myArray);
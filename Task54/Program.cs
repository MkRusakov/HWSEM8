// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
int[,] SortMatrixArray (int[,] array, int row = 0)
{
    int[,] SortedArray = new int[array.GetLength(0), array.GetLength(1)];
    int[] arrayForSort = new int[array.GetLength(1)];
    if (row > array.GetLength(0)-1) return SortedArray;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        arrayForSort[i] = array[row, i];
    }
    Array.Sort(arrayForSort);
    Array.Reverse(arrayForSort);
    for (int i = 0; i < array.GetLength(1); i++)
    {
        SortedArray[row, i] = arrayForSort[i];
    }
    SortMatrixArray(array, row+1);
    return SortedArray;
}
int[,] myArray = CreateMatrixArray(3, 4, 1, 8);
PrintArray(myArray);
Console.WriteLine();
int[,] newArray = SortMatrixArray(myArray);
PrintArray(newArray);


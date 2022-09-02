// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
void PrintArrayMatrix (int[,] array) 
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
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
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
int[] ReformArray (int[,] array)
{
    int[] reformArray = new int[array.GetLength(0)*array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            reformArray[count] = array[i, j];
            count++;
        }
    }
    return reformArray; 
}
void NumVocab (int[] array)
{
    for (int i = 0; i <= 9; i++)
    {
        int count = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (i == array[j])
            {
                count++;
            }
        }
        Console.WriteLine($"{i} встречается {count} раз");;
    }
}
int[,] myArray = CreateMatrixArray(3,3,0,8);
PrintArrayMatrix(myArray);
Console.WriteLine();
int[] newArray = ReformArray(myArray);
PrintArray(newArray);
Console.WriteLine();
NumVocab(newArray);

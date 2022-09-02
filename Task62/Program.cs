// Напишите программу, которая заполнит спирально массив 4 на 4.
// Метод SpiralMatrix лучше не открывать =)
int[,] SpiralMatrix ()
{
    int[,] spiralMatrix = new int[4, 4];
    int num = 1;
    for (int i = 0; i < spiralMatrix.GetLength(1); i++)
    {
        spiralMatrix[0, i] = num;
        num++;
    }
    for (int i = 1; i < spiralMatrix.GetLength(1); i++)
    {
        spiralMatrix[i, spiralMatrix.GetLength(1)-1] = num;
        num++;
    }
    for (int i = spiralMatrix.GetLength(1)-2 ; i >= 0 ; i--)
    {
        spiralMatrix[spiralMatrix.GetLength(0)-1, i] = num;
        num++;
    }
    for (int i = spiralMatrix.GetLength(0)-2; i > 0; i--)
    {
        spiralMatrix[i, spiralMatrix.GetLength(1)-4] = num;
        num++;
    }
    for (int i = spiralMatrix.GetLength(1)-3; i < 3; i++)
    {
        spiralMatrix[1, i] = num;
        num++;
    }
    for (int i = spiralMatrix.GetLength(1)-2; i != 0; i--)
    {
        spiralMatrix[spiralMatrix.GetLength(0)-2, i] = num;
        num++;
    }
    return spiralMatrix;
}
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
int[,] myArray = SpiralMatrix();
PrintArrayMatrix(myArray);

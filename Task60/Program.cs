// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] CreateThreetrixArray (int row, int column, int depth, int min)
{
    int[,,] array = new int[row, column, depth];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array[i, j, k] = min++; // Не знаю как по-другому сделать так, чтобы в массиве числа не повторялись
            }
        }
    }
    return array;
}
void PrintThreetrixArrayAndIndex (int[,,] array) 
{
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j ,k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }  
    }
}
int[,,] myArray = CreateThreetrixArray(2, 2, 2, 10);
PrintThreetrixArrayAndIndex(myArray);

// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.



int[,] Create2DArray (int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)  // проход по строчкам
    {
        for (int j = 0; j < columns; j++)  // проход по столбцам
        array[i,j] = new Random().Next(min, max + 1);
    }

    return array;
} 

void Print2DArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)  // проход по строчкам array.GetLength(0) - колличество строк 
    {
        for (int j = 0; j < array.GetLength(1); j++)// проход по столбцам array.GetLength(1) - колличество столбцов
        {
            Console.Write(array[i, j] + " ");
        }
        
        Console.WriteLine();
    }

}

int[,] ChangeRowsArray (int[,] array)

{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)  // проход по строчкам array.GetLength(0) - колличество строк 
    {
        for (int j = 0; j < array.GetLength(1); j++) // проход по столбцам array.GetLength(1) - колличество столбцов
        {
            if (i == 0)
            {
                temp = array[i,j];
                array[i,j] = array[array.GetLength(0) - 1, j];
                array[array.GetLength(0) - 1, j] = temp;
            }
        }
        
    }
    return array;
}


int[,] myArray = Create2DArray(5,5,0,9);
Print2DArray(myArray);
Console.WriteLine();
Print2DArray(ChangeRowsArray(myArray));
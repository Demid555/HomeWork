// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

int[] CreateArray (int[,] array)
{
    int[] array1 = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)  // проход по строчкам array.GetLength(0) - колличество строк 
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)// проход по столбцам array.GetLength(1) - колличество столбцов
        {
            sum = sum + array[i,j];
        }

        array1[i] = sum;
        
    }
        return array1;
}

int MinSum (int[] array)
{   int i = 0;
    int min = 0;
    while (i < array.Length)
    {
        if (array[i] < array[min])
        {
            min = i;
        } 
        i++;
    }
    return min;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
            Console.Write(array[i] + " ");
  
    }
}

void PrintInt (int min)
{
    Console.WriteLine(min);
}

int[,] myArray = Create2DArray(6,5,0,9);
Print2DArray(myArray);
Console.WriteLine();
int[] myArray2 = CreateArray(myArray);
PrintArray(myArray2);
int a = MinSum(myArray2);
Console.WriteLine();
PrintInt(a);

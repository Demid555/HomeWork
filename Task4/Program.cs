// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца


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

int FindMinElementsRows (int[,] array)

{   int min = array[0,0];
    int index_i = 0;

    for (int i = 0; i < array.GetLength(0); i++)  // проход по строчкам array.GetLength(0) - колличество строк 
    {
        for (int j = 0; j < array.GetLength(1); j++)// проход по столбцам array.GetLength(1) - колличество столбцов
        {
            if (min > array[i,j])
            {
                min = array[i,j];
                index_i = i;
                
                
            }
        }
        
       
    }
    return index_i;
}

int FindMinElementsColumns (int[,] array)

{   int min = array[0,0];
    int index_j = 0;

    for (int i = 0; i < array.GetLength(0); i++)  // проход по строчкам array.GetLength(0) - колличество строк 
    {
        for (int j = 0; j < array.GetLength(1); j++)// проход по столбцам array.GetLength(1) - колличество столбцов
        {
            if (min > array[i,j])
            {
                min = array[i,j];
                index_j = j;
                
                
            }
        }
        
       
    }
    return index_j;
}

void PrintInt (int min1, int min2)
{
    Console.Write(min1);
    Console.WriteLine(min2);
}


int[,] NewArrayRow (int[,] array, int row)

{   
    int[,] array2 = new int [array.GetLength(0) - 1, array.GetLength(1)];
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)  // проход по строчкам array.GetLength(0) - колличество строк 
    {
        if (i == row)
        continue;
        for (int j = 0; j < array.GetLength(1); j++)// проход по столбцам array.GetLength(1) - колличество столбцов
        {
            array2[x, j] = array[i, j];
            
            
        }
        x++;
       
    }
    return array2;
}

int[,] NewArrayCol (int[,] array, int col)

{   
    int[,] array2 = new int [array.GetLength(0), array.GetLength(1) - 1];
    
    for (int i = 0; i < array.GetLength(0); i++)  // проход по строчкам array.GetLength(0) - колличество строк 
    {
       
        int x = 0;
        for (int j = 0; j < array.GetLength(1); j++)// проход по столбцам array.GetLength(1) - колличество столбцов
        {
             if (j == col) continue;
       
            array2[i, x] = array[i, j];
            x++;
            
        }
    
       
    }
    return array2;
}


int[,] myArray = Create2DArray(6,5,1,9);
Print2DArray(myArray);
Console.WriteLine();
int a = FindMinElementsRows(myArray);
int b = FindMinElementsColumns(myArray);
PrintInt(a,b);
Console.WriteLine();
int[,] myArray2 = NewArrayRow(myArray, a);
int[,] myArray3 = NewArrayCol(myArray2, b);
Console.WriteLine();
Print2DArray(myArray3);






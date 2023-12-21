// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


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

void EnterIndexArray (int[,] array, int i1, int j1)
{
    // int i1 = Convert.ToInt32(Console.ReadLine()); Есть ли разница как именно задавать переменные i1, j1, вводом с клавиатуры или как это сделано выше?
    // int j1 = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == i1 && j == j1)
            {
               
                // a = array[i1,j1];
                Console.WriteLine(array[i,j]);
            } 

            
        }

    }
    if (i1 >= array.GetLength(0) || j1 >= array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет!");
    }
    // return a;
}





int[,] myArray = Create2DArray(6,5,0,9);
Print2DArray(myArray);
Console.WriteLine();
EnterIndexArray(myArray, 33, 2);
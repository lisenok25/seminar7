

// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateRandom2dArray(int m, int n){
//     double[,] array = new double[m,n];
//     for(int i = 0; i<m; i++)
//         for(int j = 0; j<n; j++)
//             array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
//     return array;
// }

// void Show2dArray(double[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input numb of m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int n = Convert.ToInt32(Console.ReadLine());



// double[,] array = CreateRandom2dArray(m,n);
// Show2dArray(array);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// 1,2 -> 2


// Console.Write("Input numb of i1: ");
// int i1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of j1: ");
// int j1 = Convert.ToInt32(Console.ReadLine());

// int[,] CreateRandom2dArray(int rows, int cols){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(-100, 100);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Calculate(int[,] array){
// for(int i = 0; i<array.GetLength(0); i++){
//     Console.WriteLine();
//     for(int j = 0; j<array.GetLength(1); j++){
//         if(i1==i && j1==j){
//             Console.WriteLine($"Такой элемент есть {array[i,j]}"); 
//         }  
        
    
//     }  

// }

// return array;

// }



// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());



// int[,] array = CreateRandom2dArray(rows,cols);
// Show2dArray(array);

// Calculate(array);
// if (i1 > array.GetLength(0) || j1 > array.GetLength(1))  Console.WriteLine("Такого элемента нет"); 





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] CreateRandom2dArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(1, 10);
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");    
//         }
//     }
//     Console.WriteLine();
// }


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows, cols);
// Show2dArray(array);


// for (int j = 0; j < array.GetLength(1); j++) 
// {
//     double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[i,j];
//     }
//     sum = sum / rows;
//     Console.Write(sum + "; ");
// }

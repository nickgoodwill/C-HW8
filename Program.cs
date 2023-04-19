// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// int [,] CreateArray()
// {
//     int [,] matr = new int [4,4];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,11);
//         }
//     }
//     return matr;
// }

// void PrintArray(int[,] matr)
// {
    
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write(matr[i,j]+" ");
//         }
//         System.Console.WriteLine();
//     }
// }
// void rotation (int [,] newArray)
// {
// int[] temp = new int[newArray.GetLength(0)];
 
// Console.WriteLine("\nСортировка по строкам: ");
// for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//             temp[j] = newArray[i, j];
//         Array.Sort(temp);
//         Array.Reverse(temp);
//         for (int k = 0; k < newArray.GetLength(0); k++)
//             {
//                 newArray[i, k] = temp[k];
//                 Console.Write("{0}\t", newArray[i, k]);
//             }
//         Console.WriteLine();
//     }
// }

// int [,] matr = CreateArray();
// System.Console.WriteLine("Задан массив:");
// PrintArray(matr);

// int [,] newArray = matr;

// rotation(newArray);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка


int [,] CreateArray()
{
    int [,] matr = new int [4,4];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,11);
        }
    }
    return matr;
}

void PrintArray(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i,j]+" ");
        }
        System.Console.WriteLine();
    }
}

void SumRow (int[,] matr)
{
int sum = int.MaxValue;
int row = 0;

  for (int i = 0; i < matr.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            temp += matr[i,j];
             
        }
        if (temp < sum)
            {
               sum = temp;
               row = i; 
            }
    }
    Console.WriteLine();
    Console.WriteLine("Сумма " + row + " строки наименьшая " + sum);
}

//************************************

int [,] matr = CreateArray();
System.Console.WriteLine("Задан массив:");
PrintArray(matr);
SumRow(matr);
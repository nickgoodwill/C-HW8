// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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
void rotation (int [,] newArray)
{
int[] temp = new int[newArray.GetLength(0)];
 
Console.WriteLine("\nСортировка по строкам: ");
for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
            temp[j] = newArray[i, j];
        Array.Sort(temp);
        Array.Reverse(temp);
        for (int k = 0; k < newArray.GetLength(0); k++)
            {
                newArray[i, k] = temp[k];
                Console.Write("{0}\t", newArray[i, k]);
            }
        Console.WriteLine();
    }
}

int [,] matr = CreateArray();
System.Console.WriteLine("Задан массив:");
PrintArray(matr);

int [,] newArray = matr;

rotation(newArray);



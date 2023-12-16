//ДЗ
// Задача 1: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] array = new int [3,4];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ReturnElementArray()
// {
//     System.Console.Write("Введите индекс строки элемента: ");
//     int iFind = Convert.ToInt32(Console.ReadLine());
//     System.Console.Write("Введите индекс столбца элемента: ");
//     int jFind = Convert.ToInt32(Console.ReadLine());
//     bool isFind = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == iFind && j == jFind)
//             {
//                 isFind = true;
//                 System.Console.WriteLine("Значение этого элемента " +array[i,j]);
//                 break;
//             }
//         }
//     }
//     if (isFind == false)
//     {
//         System.Console.WriteLine("Такого элемента нет");
//     }
    
// }

// CreateArray();
// PrintArray();
// ReturnElementArray();


// Задача 2: 
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] array = new int [3,4];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindElementsArray2()
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
    }
   
}

CreateArray();
PrintArray();
FindElementsArray2();
PrintArray();

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
//             System.Console.Write(array[i,j]+" ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElementsArray2()
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[0,j];
//         array[0,j] = array[array.GetLength(0)-1,j];
//         array[array.GetLength(0)-1,j] = temp;
//     }

// }

// CreateArray();
// PrintArray();
// FindElementsArray2();
// PrintArray();





// //Задача 3
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


// int[,] array = new int [4,4];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j <  array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j]+" ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int FindMinSum()
// {
//     int indexRowMinSum = 0;
//     int minSumElements = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumElements = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumElements += array[i,j];
//         }
//         if (i == 0)
//         {
//             minSumElements = sumElements;
//         }
//         else if (sumElements<minSumElements)
//         {
//             indexRowMinSum = i;
//             minSumElements = sumElements;
//         }
//     }
//     return indexRowMinSum;
// }

// CreateArray();
// PrintArray();
// System.Console.WriteLine("строка с наименьшей суммой элементов - строка с индексом "+FindMinSum());





// Задача 4*(не обязательная): 
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца


int[,] array = new int [3,4];
int[,] newArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
int iMin = 0;
int jMin = 0;

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,100);
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
}

int FindMinElement()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]<array[iMin,jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    }
    return array[iMin,jMin];

    }

void DeleteRawColumn()
{
    int iNewArr = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i!=iMin)
        {
            int jNewArr = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j!=jMin)
                {
                    newArray[iNewArr,jNewArr] = array[i,j];
                    if (jNewArr<newArray.GetLength(1)-1)
                    {
                        jNewArr++;
                    }
                            
                }                
            }
            if (iNewArr<newArray.GetLength(0)-1)
            {
                iNewArr++;
            }
           
        }
    }
}
    
void PrintNewArray()
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            System.Console.Write(newArray[i,j]+" ");
        }
        System.Console.WriteLine();
    }
}

CreateArray();
PrintArray();
System.Console.WriteLine("Минимальный элемент массива "+FindMinElement());
DeleteRawColumn();
System.Console.WriteLine();
PrintNewArray();
// (1) Задача 47. Задайте двумерный массив (вручную) размером m×n, 
// заполненный вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// (2) Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве,
// и возвращает индекс этого элемента или же указание, что такого элемента нет.
// Если элементов несколько, то выводим позицию каждого. Двумерный массив задаётся на ваш выбор.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// (3) Задача 52. Задайте двумерный массив (вручную) из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите номер задачи:");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 1) Task47();
else if(n == 2) Task50();
else if(n == 3) Task52();

void Task47() //(1)
{
    Console.WriteLine("Введите m и n:");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt16(Console.ReadLine());
    double [,] array2d = new double[m,n];  
    Console.WriteLine("Введите элементы массива(вещественные числа) через пробел:");
        for(int i=0; i<array2d.GetLength(0); i++)
        {
            string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for(int j=0; j<array2d.GetLength(1); j++)
                array2d[i,j] = Convert.ToDouble(array[j]);
        }
}

void Task50()  //(2)
{
    Console.WriteLine("Введите m и n:");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt16(Console.ReadLine());
    bool flag = false;  // инициируем переменную flag, которая хранит в себе значение false, чтобы сделать проверку вывода
    int [,] array2d = new int[m,n];          
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            array2d[i,j] = new Random().Next(0,10);
            Console.Write($"{array2d[i,j]} ");          
        }
        Console.WriteLine();
    }
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());  
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array2d[i,j] == number)
            {
                Console.WriteLine($"{i},{j}"); 
                flag = true; 
            }      
        }    
    }   
        if (flag == false) 
        Console.WriteLine("Такого числа в массиве нет");
}    

void Task52()  //(3)
{
    Console.WriteLine("Введите m и n: ");
    int m = Convert.ToInt32(Console.ReadLine());  
    int n = Convert.ToInt32(Console.ReadLine());  
    int[,] array2d = new int[m,n];     
    Console.WriteLine("Введите элементы массива в одну строку через запятую:");
    for(int i=0; i<m; i++)
    {
        string[] text = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
        for(int j=0; j<n; j++)
            array2d[i,j] = Convert.ToInt32(text[j]);
    }
    for(int j=0; j<n; j++)
    {
        double sum = 0;
        for (int i=0; i<m; i++)
            sum += array2d[i,j];        
        Console.WriteLine($"{sum / m}");    
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Задача 2. Обнулить заданный диапазон элементов в одномерном массиве.
    /// </summary>
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int size = Size();
        //    int[] omas = Input(size);
        //    if (omas.Length > 2)
        //    {
        //        Array.Clear(omas, 1, 2);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Массив слишком мал для очистки диапазона.");
        //    }
        //    Output(omas);
        //    Console.ReadLine();
        //}

        //static int Size()
        //{
        //    int size;
        //    Console.WriteLine("Введите размер массива:");
        //    while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        //    {
        //        Console.WriteLine("Ошибка. Введите положительное число.");
        //    }
        //    return size;
        //}

        //static int[] Input(int size)
        //{
        //    int[] omas = new int[size];
        //    Console.WriteLine("Введите элементы массива:");
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        while (!int.TryParse(Console.ReadLine(), out omas[i]))
        //        {
        //            Console.WriteLine("Ошибка. Введите число.");
        //        }
        //    }
        //    return omas;
        //}

        //static void Output(int[] omas)
        //{
        //    Console.WriteLine("Содержимое массива:");
        //    foreach (var el in omas)
        //    {
        //        Console.WriteLine(el);
        //    }
        //}
    }
}

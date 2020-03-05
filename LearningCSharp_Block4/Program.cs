﻿using System;

namespace LearningCSharp_Block4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //быстрый поиск
            int index = Array.BinarySearch(numbers, 7); 
            Console.WriteLine(index);

            //копирование элементов массива в массив. С использованием метода класса
            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            // копирование элементов массива в массив. С использованием метода экземпляра
            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);

            //реверсирование
            Array.Reverse(copy);
            foreach(var c in copy)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();


            //сортировка
            Array.Sort(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }

            //обнуляет массив
            Array.Clear(copy, 0, copy.Length);
            Console.WriteLine(copy[2]);



            //две аналогичные строчки создания листа
            Array myarr = new int [5];
            Array myarr2 = Array.CreateInstance(typeof(int), 5);

            myarr.SetValue(12, 0);

            Console.WriteLine(myarr.GetValue(0));
            


        }
    }
}

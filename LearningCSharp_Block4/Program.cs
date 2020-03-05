using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningCSharp_Block4
{
    class Program
    {
        static void Main(string[] args)
        {





        }

        public void ArrayType()
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
            foreach (var c in copy)
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
            Array myarr = new int[5];
            Array myarr2 = Array.CreateInstance(typeof(int), 5);

            myarr.SetValue(12, 0);

            Console.WriteLine(myarr.GetValue(0));
        }

        public void ListType()
        {
            var intList = new List<int>() { 1, 2, 4, 5, 6, 7, 8, 12 };
            intList.Add(7);

            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);


            if (intList.Remove(1)) //первое попадание(удалению по значению)
            {
                //do


            }
            else { }

            intList.RemoveAt(0); //Удаление по индексу

            intList.Reverse();

            bool containse = intList.Contains(3); //определить есть ли этот элемент в листе

            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"MIn = {min}, Max = {max}");

            int indexOf = intList.IndexOf(2); //найти индекс первой попавшейся двойки
            int lastIndexOf = intList.LastIndexOf(2); // найти индекс последней двойки

            Console.WriteLine($"indexof2 = {indexOf}, LastIndexOf2 = {lastIndexOf}");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]}");
            }
            Console.WriteLine();

            foreach (int item in intList)
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadLine();
        }

    }



}

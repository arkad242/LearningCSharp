using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningCSharp_Block4
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"should print out 1:{queue.Peek()}");

            queue.Dequeue();

            Console.WriteLine($"should print out 2:{queue.Peek()}");

            Console.WriteLine("iteratite over the queue");
            foreach (var cur in queue)
            {
                Console.WriteLine(cur);
            }


            Console.ReadLine();

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"should print out 4:{stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"should print out 3:{stack.Peek()}");

            Console.WriteLine("iteratite over the stack");
            foreach (var cur in stack)
            {
                Console.WriteLine(cur);
            }

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

        static void Dictionary()
        {
            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");

            people = new Dictionary<int, string>()
            {
                { 1, "John" },
                { 2, "Bob" },
                { 3, "Alice" },
            };

            string name = people[1];
            Console.WriteLine(name);

            Console.WriteLine("Iterating over keys");
            Dictionary<int, string>.KeyCollection keys = people.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Iterating over values");
            Dictionary<int, string>.ValueCollection values = people.Values;
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Iterating over key-value pairs");
            foreach (var pair in people)
            {
                Console.WriteLine($"Key:{pair.Key}. Value:{pair.Value}");
            }
            Console.WriteLine();

            Console.WriteLine($"Count={people.Count}");

            bool containsKey = people.ContainsKey(2);
            bool containsValue = people.ContainsValue("John");

            Console.WriteLine($"Contains key:{containsKey}. Contains value:{containsValue}");

            people.Remove(1);

            if (people.TryAdd(2, "Elias"))
            {
                Console.WriteLine("Added successfully");
            }
            else
            {
                Console.WriteLine("Failed to add using key 2");
            }

            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key 2, Val={val}");
            }
            else
            {
                Console.WriteLine("Failed to get");
            }

            people.Clear();
        }
    }



}

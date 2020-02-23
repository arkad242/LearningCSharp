using System;




namespace LearningCSharp_Block3
    {
    class Program
    {
        static void Main(string[] args)
        {

            



        }

        public void Homework2()
        {



            int[] numbers = new int[10];

            int inputCount = 0;
            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;

                inputCount++;

                if (number == 0)
                    break;
            }

            int sum = 0;
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += n;
                    count++;
                }
            }

            double average = (double)sum / count;
            Console.WriteLine(average);


        }

        public void Homework3()
        {
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;



            for (int i = 1; i <= n; i++)
            {

                factorial *= i;

            }



            Console.WriteLine(factorial);

        }

        public void Homework4()
        {
            /*Предположим, что логин\пароль для входа в систему: johnsilver\qwerty.
            Запросить у пользователя логин и пароль. Дать пользователю только три попытки для ввода корректной пары логин\пароль.
            Если пользователь произвёл корректный ввод, вывести на консоль: "Enter the System" и прекратить запрос логина\пароля.Если пользователь ошибся трижды -вывести 
            "The number of available tries have been exceeded" и прекратить запрос пары логин\пароль.
*/
            string login = Console.ReadLine();

            int wrong = 0;

            while (wrong != 3)
            {


                string pass = Console.ReadLine();

                if (pass != "qwerty")
                {
                    wrong++;

                    if (wrong == 3)
                    {
                        Console.WriteLine("The number of available tries have been exceeded");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Enter the system");
                    break;
                }




            }
        }
    }
}

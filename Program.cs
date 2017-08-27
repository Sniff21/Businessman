/*
 Игра, симулятор бизнессмена в консольном приложение.
 By Valentin_Bragin
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Businessman
{
    class Program
    {
        private static int balance = 15000; //приватная переменная баланса

        static void Main(string[] args) //главный метод
        {

            string question = "";//вопрос о заходе в меню

            Console.WriteLine("Привет начинающий бизнессмен! Твой баланс: " + balance + "RUB \n");
            Console.WriteLine("Открыть меню, управление бизнессом ?");
            Console.WriteLine("Команды: (Да) - войти (Нет) - закрытие программы  \n");
            Console.Write("Ввод команды: ");  question = Console.ReadLine();
            if (question == "Да" | question == "да")
            {
                Console.Beep();
                Menu();
            }
            else if (question == "Нет" | question == "нет")
            {
                Console.WriteLine("Вы хотите закрыть игру ? \n");
                Console.Write("Ввод команды: ");  question = Console.ReadLine();
                if (question == "Да" | question == "да")
                {
                    Environment.Exit(0);
                }
                else if (question == "Нет" | question == "нет")
                {
                    Console.WriteLine("Вы будете возращены в меню!");
                    Thread.Sleep(1000);
                    Menu();
                }

                }
            }

        public static void Menu() //метод меню
        {
            int question_two = 0; //переменная для выбора в меню и 
            Console.Clear(); //очистка экрана
            Console.WriteLine("Меню управление бизнессом: ");
            Console.WriteLine("Ваш баланс: " + balance + "\n");
            Console.WriteLine("1. Купить торговую точку");
            Console.WriteLine("2. Продать торговую точку");
            Console.WriteLine("3. Мои торговые точки");
            Console.WriteLine("4. Моя статистика");
            Console.WriteLine("5. Банковская ячейка");
            Console.WriteLine("0. Закрыть \n");
            Console.Write("Ввод команды: ");  question_two = Convert.ToInt32(Console.ReadLine());

            switch (question_two) //выбор в меню
            {
                case 1:
                    BuyPoint();
                    break;
                case 2:
                    SalePoint();
                    break;
                case 3:
                    MyPoint();
                    break;
                case 4:
                    Stat();
                    break;
                case 5:
                    Bank();
                    break;
                case 0:
                    string yesornot;
                    Console.WriteLine("Вы действительно хотите закрыть игру ? \n");
                    Console.Write("Ввод команды: "); yesornot = Console.ReadLine();
                    if (yesornot == "Да" | yesornot == "да")
                    {
                        Environment.Exit(0);
                    }
                    else if (yesornot == "Нет" | yesornot == "нет")
                    {
                        Console.WriteLine("Вы будете возращены в меню!");
                        Thread.Sleep(1000);
                        Menu();
                    }

                    break;
                default:
                    Console.WriteLine("Вы нажали что-то другое...");
                    break;
            }
        }

        public static void BuyPoint() //метод покупки точки //ДОПИСАТЬ!
        {
            Console.Clear();
            Console.WriteLine("Вы можете купить 5 торговых точек! \n");
            Console.WriteLine("[1] Хлебный Ларёк - 11000RUB Доход - 5000RUB");
            Console.WriteLine("[2] Продовольственный магазин - 50000RUB Доход - 9000RUB ");
            Console.WriteLine("[3] Зоомагазин - 90000RUB Доход - 20000RUB");
            Console.WriteLine("[4] Универмаг - 120000RUB Доход - 30000RUB");
            Console.WriteLine("[5] Сеть магазинов Восьмёрочка - 320000RUB Доход - 40000RUB");
            int onepoint;
            Console.WriteLine("Выбор точки: "); onepoint = Convert.ToInt32(Console.ReadLine());
            switch(onepoint)
            {
                case 1:
                    if(balance >= 11000)
                    {
                        balance = balance - 11000;
                        Console.WriteLine("Вы успешно приобрели торговую точку, под номером [1]\n");
                        Thread.Sleep(500);
                        Task.Run(() => OnePoint());
                        Menu();
                    }
                    else if (balance < 11000)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }

                    break;
                case 2:
                    if (balance >= 50000)
                    {
                        balance = balance - 50000;
                        Console.WriteLine("Вы успешно приобрели торговую точку, под номером [2]\n");
                        Thread.Sleep(500);
                        Task.Run(() => TwoPoint());
                        Menu();
                    }
                    else if (balance < 50000)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case 3:
                    if (balance >= 90000)
                    {
                        balance = balance - 90000;
                        Console.WriteLine("Вы успешно приобрели торговую точку\n");
                        Thread.Sleep(500);
                        Task.Run(() => ThreePoint());
                        Menu();
                    }
                    else if (balance < 90000)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case 4:
                    if (balance >= 120000)
                    {
                        balance = balance - 120000;
                        Console.WriteLine("Вы успешно приобрели торговую точку\n");
                        Thread.Sleep(500);
                        Task.Run(() => FourPoint());
                        Menu();
                    }
                    else if (balance < 120000)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case 5:
                    if (balance >= 320000)
                    {
                        balance = balance - 320000;
                        Console.WriteLine("Вы успешно приобрели торговую точку\n");
                        Thread.Sleep(500);
                        Task.Run(() => FivePoint());
                        Menu();
                    }
                    else if (balance < 320000)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
            }
        }
                                                                    /*Методы торговых точек*/
        public static void OnePoint() //метод первой точки
        {
            for(int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                balance = balance + 5000;
            }
        }
        public static void TwoPoint() //метод второй точки
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                balance = balance + 9000;
            }
        }
        public static void  ThreePoint() //метод третий точки
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                balance = balance + 20000;
            }
        }
        public static void FourPoint() //метод четвёртой точки
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                balance = balance + 30000;
            }
        }
        public static void FivePoint() //метод пятой точки
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                balance = balance + 40000;
            }
        }
                                                                    /*Методы для меню*/
        public static void SalePoint() //метод продажи точки
        {
            Console.Clear();
            Console.WriteLine("Метод продажи точки");
            Console.WriteLine("Чтобы выйти в меню, нажмите (0)");
            int exit = 90;
            Console.Write("Ввод команды: "); exit = Convert.ToInt32(Console.ReadLine());
            switch (exit)
            {
                case 0:
                    Menu();
                    break;
            }
        }

        public static void MyPoint() //метод моих точек
        {
            Console.Clear();
            Console.WriteLine("Метод моих точек");
            Console.WriteLine("Чтобы выйти в меню, нажмите (0)");
            int exit = 90;
            Console.Write("Ввод команды: "); exit = Convert.ToInt32(Console.ReadLine());
            switch (exit)
            {
                case 0:
                    Menu();
                    break;
            }
        }

        public static void Stat() //метод статистики
        {
            Console.Clear();
            Console.WriteLine("Ваш баланс: " + balance + "RUB");
            Console.WriteLine("Чтобы выйти в меню, нажмите (0)");
            int exit = 90;
            Console.Write("Ввод команды: "); exit = Convert.ToInt32(Console.ReadLine());
            switch (exit)
            {
                case 0:
                    Menu();
                    break;
            }
        }

        public static void Bank() //метод банка
        {
            Console.Clear();
            Console.WriteLine("Метод банка");
            Console.WriteLine("Чтобы выйти в меню, нажмите (0)");
            int exit = 90;
            Console.Write("Ввод команды: "); exit = Convert.ToInt32(Console.ReadLine());
            switch (exit)
            {
                case 0:
                    Menu();
                    break; 
            }
        }

    }
}

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
        private static int exp = 0;
        private static int lvl = 1;
        private static int balance = 15000; //приватная переменная баланса
        private static int balance_bank = 0;
        public static string name;
        static void Main(string[] args) //главный метод
        {
            Console.WriteLine("{0,50}","Для входа введите ваше имя.");
            Console.Write("Введите своё имя: "); name = Console.ReadLine();
            Console.Clear();
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
            Task.Run(() => Exp());
            int question_two = 0; //переменная для выбора в меню и 
            Console.Clear(); //очистка экрана         
            Console.Write("{0,30}", "Ваш баланс: " + balance);
            Console.Write("{0,35}", "Ваш Exp: " + exp);
            Console.WriteLine("{0,40}", "Ваш Lvl: " + lvl + "\n");
            Console.WriteLine("Меню управление бизнессом: "); 
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
            Console.WriteLine("{0,50}", "Вы можете купить 5 торговых точек! \n");
            Console.WriteLine("[1] Хлебный Ларёк - 14000(RUB) Доход - 2000RUB");
            Console.WriteLine("[2] Продовольственный магазин - 70000(RUB) Доход - 5000RUB ");
            Console.WriteLine("[3] Зоомагазин - 120000(RUB) Доход - 12000RUB");
            Console.WriteLine("[4] Универмаг - 500000(RUB) Доход - 20000RUB");
            Console.WriteLine("[5] Сеть магазинов Восьмёрочка - 1200000(MLRUB) Доход - 35000RUB");
            Console.WriteLine("[0] Выйти обратно в меню \n");
            int onepoint;
            Console.WriteLine("Выбор точки: "); onepoint = Convert.ToInt32(Console.ReadLine());
            switch(onepoint)
            {
                case 0:
                    Console.WriteLine("\n"+"Вы будете возращены в меню !");
                    Thread.Sleep(500);
                    Menu();
                    break; 
                case 1:
                    if(balance >= 14000)
                    {
                        exp = exp + 120;
                        balance = balance - 14000;
                        Console.WriteLine("Вы успешно приобрели торговую точку, под номером [1]");
                        Console.WriteLine("Теперь ваш Exp равен: " + exp + "\n");         
                        Thread.Sleep(500);
                        Task.Run(() => OnePoint());
                        Menu();
                    }
                    else if (balance < 14000)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }

                    break;
                case 2:
                    if (balance >= 70000)
                    {
                        exp = exp + 120;
                        balance = balance - 70000;
                        Console.WriteLine("Вы успешно приобрели торговую точку, под номером [2]\n");
                        Thread.Sleep(500);
                        Task.Run(() => TwoPoint());
                        Menu();
                    }
                    else if (balance < 70000)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case 3:
                    if (balance >= 120000)
                    {
                        exp = exp + 120;
                        balance = balance - 120000;
                        Console.WriteLine("Вы успешно приобрели торговую точку\n");
                        Thread.Sleep(500);
                        Task.Run(() => ThreePoint());
                        Menu();
                    }
                    else if (balance < 120000)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case 4:
                    if (balance >= 500000)
                    {
                        exp = exp + 120;
                        balance = balance - 500000;
                        Console.WriteLine("Вы успешно приобрели торговую точку\n");
                        Thread.Sleep(500);
                        Task.Run(() => FourPoint());
                        Menu();
                    }
                    else if (balance < 500000)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case 5:
                    if (balance >= 1200000)
                    {
                        exp = exp + 120;
                        balance = balance - 1200000;
                        Console.WriteLine("Вы успешно приобрели торговую точку\n");
                        Thread.Sleep(500);
                        Task.Run(() => FivePoint());
                        Menu();
                    }
                    else if (balance < 1200000)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
            }
        }
                                                                    /*Методы торговых точек*/
        public static void OnePoint() //метод первой точки
        {
            while(true)
            {
                Thread.Sleep(1500);
                balance = balance + 2000;
            }
        }
        public static void TwoPoint() //метод второй точки
        {
            while (true)
            {
                Thread.Sleep(1500);
                balance = balance + 2000;
            }
        }
        public static void  ThreePoint() //метод третий точки
        {
            while (true)
            {
                Thread.Sleep(1500);
                balance = balance + 5000;
            }
        }
        public static void FourPoint() //метод четвёртой точки
        {
            while (true)
            {
                Thread.Sleep(1500);
                balance = balance + 20000;
            }
        }
        public static void FivePoint() //метод пятой точки
        {
            while (true)
            {
                Thread.Sleep(1500);
                balance = balance + 35000;
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
            Console.WriteLine("{0,50}" , "Информция о вас: ");
            Console.WriteLine("Вы: " + name);
            Console.WriteLine("Ваш баланс: " + balance + "RUB");
            Console.WriteLine("Ваш уровень: " + lvl);
            Console.WriteLine("Ваш exp: " + exp );
            Console.WriteLine("До следующего уровня вам осталось: " + "НЕИЗВЕСТНО");
            Console.WriteLine("Ваш автомобиль: " + "НЕИЗВЕСТНО");
            Console.WriteLine("Ваше жильё: " + "НЕИЗВЕСТНО" + "\n");
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
            Console.WriteLine("{0,50}", "На данный момент ваш баланс равен: " + balance_bank);
            Thread.Sleep(1000);
            Console.WriteLine("Вы хотите перейти в банк?");
            string question = "";
            Console.Write("Ваша команда: "); question = Console.ReadLine();
            if (question == "Да" | question == "да")
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("[1]Положить на счёт, [2]Снять со счёта \n");
                int questiontwo = 53;
                Console.Write("Ваша команда: "); questiontwo = Convert.ToInt32(Console.ReadLine());
                if(questiontwo == 1)
                {
                    Console.WriteLine("Сумма которую хотите положить на счёт: "); balance_bank = Convert.ToInt32(Console.ReadLine());
                    balance = balance -= balance_bank;
                }
                else if (questiontwo == 2)
                {
                    Console.WriteLine("НЕ РЕАЛИЗОВАНО! ");
                    Thread.Sleep(1000);
                    Menu();
                }
            }
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
        public static void Exp() //метод для уровня и Exp
        {
            if (exp >= 100)
            {
                lvl = lvl + 1;
            }
            if (exp >= 200)
            {
                lvl = lvl + 1;
            }
            if (exp >= 350)
            {
                lvl = lvl + 1;
            }
            if (exp >= 500)
            {
                lvl = lvl + 1;
            }
        }
    }
}

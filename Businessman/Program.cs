/*
 Игра, симулятор бизнессмена в консольном приложение.
 By Valentin_Bragin

 ДОПИСАТЬ: сделать продажу точек , настройки.
*/

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Businessman
{
	class Program
	{
				/*Переменные*/
		private static int exp = 0; //приватная переменная Exp
		private static int lvl = 1; //приватная переменная lvl
		private static int balance = 15000; //приватная переменная баланса
		private static int balance_bank = 0; //приватная переменная баланса в банке
		public static string name;
		public static int question_int;
		public static int color = 0;

		static void Main(string[] args) //главный метод
		{
			string text = "Добро пожаловать в игру Бизнессмен, для продолжения нажмите ENTER. " + "\n";
			foreach (var e in text) {
				Thread.Sleep (50);
				Console.Write (e);
			}
			Console.ReadLine ();

			reg1 ();

			if (name == "") {
				Console.WriteLine ("\n" + "НЕВОЗМОЖНОЕ ДЕЙСТВИЕ! Введите хотя-бы символ!" + " Осталась одна попытка!" + "\n");

				Thread.Sleep (1000);
				reg1 ();
			}

			if (name == "") {
				Console.WriteLine ("\n" + "НЕВОЗМОЖНОЕ ДЕЙСТВИЕ! Вы исчерпали попытки!");
				Thread.Sleep (1000);
				Environment.Exit (0);
			}
				reg2 ();
		}


		public static void Menu() //метод меню
		{
			//Task.Run(() => Exp());
			int question_two = 0; //переменная для выбора в меню и 
			Console.Clear(); //очистка экрана
			Console.Write("{0,35}", "Ваш баланс: " + balance);
			Console.Write("\t" + "Ваш Exp: " + exp);
			Console.WriteLine("\t" +  "Ваш Lvl: " + lvl + "\n");
			Console.WriteLine("Меню управление бизнессом: "); 
			Console.WriteLine("1. Купить торговую точку");
			Console.WriteLine("2. Продать торговую точку");
			Console.WriteLine("3. Моя статистика");
			Console.WriteLine("4. Банковская ячейка");
			Console.WriteLine ("5. Обновить экран");
			Console.WriteLine ("6. Настройки игры");
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
				Stat();
				break;
			case 4:
				Bank();
				break;
			case 5:
				Bank();
				break;
			case 6:
				settings ();
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
					if (exp == 120) {
						lvl = lvl + 1;
					}
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
					if (exp == 240)
					{
						lvl = lvl + 1;
					}
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
					if (exp == 360)
					{
						lvl = lvl + 1;
					}
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
					if (exp == 480)
					{
						lvl = lvl + 1;
					} 

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
					exp = exp + 510;
					if (exp == 2140) {
						lvl = lvl + 1;
					}
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
			int vod,vod2;
			Console.Clear(); 
			Console.WriteLine("{0,50}", "Баланс в банке: " + balance_bank + "RUB");
			Thread.Sleep(1000);
			Console.WriteLine("Вы хотите перейти в банк?" + "\n");
			string question = "";
			Console.Write("Ваша команда: "); question = Console.ReadLine();
			if (question == "Да" | question == "да")
			{
				Thread.Sleep(1000);
				Console.Clear();
				Console.WriteLine("[1]Положить на счёт, [2]Снять со счёта " + "\n");
				int questiontwo = 53;
				Console.Write("Ваша команда: "); questiontwo = Convert.ToInt32(Console.ReadLine());
				if(questiontwo == 1)
				{
					Console.Write("Сумма которую хотите положить на счёт: "); vod = Convert.ToInt32(Console.ReadLine());
					if (balance <= 0) {
						Console.WriteLine ("\n" + "НЕВОЗМОЖНОЕ ДЕЙСТВИЕ! Недостаточно средств!");
					}
					else{
						balance = balance - vod;
						balance_bank = balance_bank + vod; 
					}
				}
				else if (questiontwo == 2)
				{
					if(balance_bank <= 0)
					{
						Console.WriteLine ("\n" + "НЕВОЗМОЖНОЕ ДЕЙСТВИЕ! Недостаточно средств в банке!");
					}
						else{
							Console.Write("Сумма которую хотите снять со счёта: "); vod2 = Convert.ToInt32 (Console.ReadLine ());
						balance = balance + vod2;
						balance_bank = balance_bank - vod2;
						}
					Thread.Sleep(1000);
					Menu();
				}
			}
			Console.WriteLine("Чтобы выйти в меню, нажмите (0)" + "\n");
			int exit = 90;
			Console.Write("Ввод команды: "); exit = Convert.ToInt32(Console.ReadLine());
			switch (exit)
			{
			case 0:
				Menu();
				break;
			}

		}

		public static void settings(){ //метод настроек
			Console.Clear();
			Console.WriteLine("Выберите что именно хотите настроить: " + "\n");
			Console.WriteLine("{0,50}", "[1]Размер шрифта. " + "\t" + "[2]Цвет шрифта." + "\n");
			Console.Write("Ввод команды: "); question_int = Convert.ToInt32 (Console.ReadLine());
			if (question_int == 1) {
				
			} else if (question_int == 2) {
				
				Console.WriteLine ("Выберите цвет: " + "\n");
				Console.WriteLine ("{0,50}", "[1]BLACK " + "\t" + "[2]BLUE" + "\t" + "[3]CYAN" + "\t" + "[4]DarkBlue" + "\n" +  "[5]DarkCyan" + "\t" + "[6]DarkGray" + "\t" +
					"[7]DarkGreen" + "\t" + "[8]DarkMegenta" + "\t" + "[9]DarkRed" + "\n" + "[10]DarkYellow" + "\t" + "[11]Gray" + "\t" + "[12]Green" + "\t" + "[13]Megenta" + "\t" +
					"[14]Red" + "\n" + "[15]White" + "\t" + "[16]Yelow" + "\t" + "[17]Yelow" + "\n");
				Console.Write ("Ваша команда: "); color = Convert.ToInt32 (Console.ReadLine ());
				switch(color)
				{
				case 1:
					Console.ForegroundColor = ConsoleColor.Black;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 2:
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 3:
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 4:
					Console.ForegroundColor = ConsoleColor.DarkBlue;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 5:
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 6:
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 7:
					Console.ForegroundColor = ConsoleColor.DarkGreen;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 8:
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;	
				case 9:
					Console.ForegroundColor = ConsoleColor.DarkRed;					
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 10:
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 11:
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 12:
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 13:
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 14:
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 15:
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				case 16:
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine ("Цвет успешно изменён!");
					Thread.Sleep (1000);
					Menu ();
					break;
				}
			}
			else {
				Console.WriteLine ("\n"+"Вы ввели что-то не то!");
				Thread.Sleep (500);
				Console.Clear ();
				settings ();
			}
		}



		public static void reg1 (){ //метод считывание имени
			
			Console.WriteLine ("{0,50}", "Для входа введите ваше имя.");
			Console.Write ("Ваше имя: ");
			name = Console.ReadLine ();

		}

	public static void reg2() //метод вопроса о заходе в меню
	{
			Console.Clear ();
			string question = "";//вопрос о заходе в меню
			Console.WriteLine ("Привет начинающий бизнессмен! Твой баланс: " + balance + "RUB \n");
			Console.WriteLine ("Открыть меню, управление бизнессом ?");
			Console.WriteLine("Команды: (Да) - войти (Нет) - закрытие программы  \n");
			Console.Write("Ввод команды: ");  question = Console.ReadLine();
			if (question == "Да" | question == "да") {
				Console.Beep ();
				Menu ();
			} else if (question == "Нет" | question == "нет") {
				Console.WriteLine ("Вы хотите закрыть игру ? \n");
				Console.Write ("Ввод команды: ");
				question = Console.ReadLine ();
				if (question == "Да" | question == "да") {
					Environment.Exit (0);
				} else if (question == "Нет" | question == "нет") {
					Console.WriteLine ("Вы будете возращены в меню!");
					Thread.Sleep (1000);
					Menu ();
					}
				}
			}
		}
	}


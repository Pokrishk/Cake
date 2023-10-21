using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Торты
{
    internal class Punkt
    {
        private string name;
        private int cost;
        public Punkt(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public static int Strelki(int minStr, int maxStr)
        {
            int pos = 3;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow && pos != minStr)
                    pos--;
                else if (key.Key == ConsoleKey.DownArrow && pos != maxStr)
                    pos++;
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
        public Punkt punkti(int pos)
        {
            ConsoleKeyInfo key;
            Punkt all = new(name, cost);
            do
            {
                switch (pos)
                {
                    case 3:
                        do
                        {
                            Console.Clear();
                            Punkt su1 = new("  Квадрат - ", 200);
                            Punkt su2 = new("  Круг - ", 200);
                            Punkt su3 = new("  Ромб - ", 250);
                            Console.WriteLine("Для выхода нажмите Esc.");
                            Console.WriteLine("Выберите пункт из меню:");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("  " + su1.name + su1.cost);
                            Console.WriteLine("  " + su2.name + su2.cost);
                            Console.WriteLine("  " + su3.name + su3.cost);
                            pos = Strelki(3, 5);
                            switch (pos)
                            {
                                case 3:
                                    all = su1;
                                    break;
                                case 4:
                                    all = su2;
                                    break;
                                case 5:
                                    all = su3;
                                    break;
                            }
                            Console.Clear();
                            break;
                        } while (key.Key != ConsoleKey.Escape || key.Key != ConsoleKey.Enter);
                        break;
                    case 4:
                        do
                        {
                            Console.Clear();
                            Punkt su1 = new("  Маленький - ", 1000);
                            Punkt su2 = new("  Средний - ", 1500);
                            Punkt su3 = new("  Большой - ", 2000);
                            Console.WriteLine("Для выхода нажмите Esc.");
                            Console.WriteLine("Выберите пункт из меню:");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("  " + su1.name + su1.cost);
                            Console.WriteLine("  " + su2.name + su2.cost);
                            Console.WriteLine("  " + su3.name + su3.cost);
                            pos = Strelki(3, 5);
                            switch (pos)
                            {
                                case 3:
                                    all = su1;
                                    break;
                                case 4:
                                    all = su2;
                                    break;
                                case 5:
                                    all = su3;
                                    break;
                            }
                            break;
                        } while (key.Key != ConsoleKey.Escape || key.Key != ConsoleKey.Enter);
                        Console.Clear();
                        break;
                    case 5:
                        do
                        {
                            Console.Clear();
                            Punkt su1 = new("  Ванильный - ", 100);
                            Punkt su2 = new("  Шоколадный - ", 100);
                            Punkt su3 = new("  Клубничный - ", 100);
                            Console.WriteLine("Для выхода нажмите Esc.");
                            Console.WriteLine("Выберите пункт из меню:");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("  " + su1.name + su1.cost);
                            Console.WriteLine("  " + su2.name + su2.cost);
                            Console.WriteLine("  " + su3.name + su3.cost);
                            pos = Strelki(3, 5);
                            switch (pos)
                            {
                                case 3:
                                    all = su1;
                                    break;
                                case 4:
                                    all = su2;
                                    break;
                                case 5:
                                    all = su3;
                                    break;
                            }
                            break;
                        } while (key.Key != ConsoleKey.Escape || key.Key != ConsoleKey.Enter);
                        Console.Clear();
                        break;
                    case 6:
                        do
                        {
                            Console.Clear();
                            Punkt su1 = new("  1 корж - ", 150);
                            Punkt su2 = new("  2 коржа - ", 250);
                            Punkt su3 = new("  3 коржа - ", 400);
                            Console.WriteLine("Для выхода нажмите Esc.");
                            Console.WriteLine("Выберите пункт из меню:");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("  " + su1.name + su1.cost);
                            Console.WriteLine("  " + su2.name + su2.cost);
                            Console.WriteLine("  " + su3.name + su3.cost);
                            pos = Strelki(3, 5);
                            switch (pos)
                            {
                                case 3:
                                    all = su1;
                                    break;
                                case 4:
                                    all = su2;
                                    break;
                                case 5:
                                    all = su3;
                                    break;
                            }
                            break;
                        } while (key.Key != ConsoleKey.Escape || key.Key != ConsoleKey.Enter);
                        Console.Clear();
                        break;
                    case 7:
                        do
                        {
                            Console.Clear();
                            Punkt su1 = new("  Карамельная - ", 150);
                            Punkt su2 = new("  Белая - ", 150);
                            Punkt su3 = new("  Шоколадная - ", 250);
                            Console.WriteLine("Для выхода нажмите Esc.");
                            Console.WriteLine("Выберите пункт из меню:");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("  " + su1.name + su1.cost);
                            Console.WriteLine("  " + su2.name + su2.cost);
                            Console.WriteLine("  " + su3.name + su3.cost);
                            pos = Strelki(3, 5);
                            switch (pos)
                            {
                                case 3:
                                    all = su1;
                                    break;
                                case 4:
                                    all = su2;
                                    break;
                                case 5:
                                    all = su3;
                                    break;
                            }
                            break;
                        } while (key.Key != ConsoleKey.Escape || key.Key != ConsoleKey.Enter);
                        Console.Clear();
                        break;
                    case 8:
                        do
                        {
                            Console.Clear();
                            Punkt su1 = new("  Мастика - ", 300);
                            Punkt su2 = new("  Рисунок - ", 300);
                            Punkt su3 = new("  Фрукты - ", 300);
                            Console.WriteLine("Для выхода нажмите Esc.");
                            Console.WriteLine("Выберите пункт из меню:");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("  " + su1.name + su1.cost);
                            Console.WriteLine("  " + su2.name + su2.cost);
                            Console.WriteLine("  " + su3.name + su3.cost);
                            pos = Strelki(3, 5);
                            switch (pos)
                            {
                                case 3:
                                    all = su1;
                                    break;
                                case 4:
                                    all = su2;
                                    break;
                                case 5:
                                    all = su3;
                                    break;
                            }
                            break;
                        } while (key.Key != ConsoleKey.Escape || key.Key != ConsoleKey.Enter);
                        Console.Clear();
                        break;
                    case 9:
                        Punkt blin = new("", 0);
                            all = blin; 
                        break;
                }
                return all;
            } while (key.Key != ConsoleKey.Enter);
        }
        public static void sohr(int sum, string ord)
        {
            var rstolpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var path = Path.Combine(rstolpath, "Order.txt");
            FileInfo fi1 = new FileInfo(path);
            DateTime date = DateTime.Now;
            if (File.Exists(path))
            {
                File.AppendAllText(path,"\nВаш заказ от " + date + "\nВаш заказ: " + ord + "\nИтого: " + sum);
            }
            else
            {
                using (StreamWriter sw = fi1.CreateText())
                {
                    sw.WriteLine("\nВаш заказ от " + date + "\nВаш заказ: " + ord + "\nИтого: " + sum);
                }
            }
        }
        public static int conv(Punkt all)
        {
            int ss = all.cost;
            return ss;
        }
        public static string Convert(Punkt all)
        {
            string gg = all.name;
            return gg;
        }
    }
}

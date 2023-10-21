namespace Торты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
                int sum = 0;
                string ord = "";
                int pos = 0;
            do
            {
                Console.WriteLine("Торты на ваш уникальный заказ.");
                Console.WriteLine("Выберите параметр торта.");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("  Форма");
                Console.WriteLine("  Размер");
                Console.WriteLine("  Вкус");
                Console.WriteLine("  Количество");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Конец заказа");
                Console.WriteLine("\nЦена заказа: " + sum);
                Console.WriteLine("Ваш заказ: " + ord);
                key = Console.ReadKey();
                pos = Punkt.Strelki(3, 9);
                Punkt menu = new("", 0);
                Punkt all = menu.punkti(pos) ;
                int cost = Punkt.conv(all);
                string name = Punkt.Convert(all);
                sum = sum + cost;
                if (ord == "")
                {
                    ord = name + cost;
                }
                else
                ord = ord + ", " + name + cost;
                if (name == "")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Спасибо за заказ! Если хотите сделать ещё заказ, то нажмите Space.");
                        Punkt.sohr(sum, ord);
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Spacebar)
                            Console.Clear();
                        sum = 0;
                        ord = "";
                    } while (key.Key != ConsoleKey.Spacebar);
                }
            } while (true);
        }
    }
}
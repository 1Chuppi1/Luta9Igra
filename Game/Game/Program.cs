using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            text.Welcome();
            Player player = new Player("Петух", 40, 1000);
            Oleg oleg = new Oleg("Олег - слабочек", 20, 400, 5);
            Anton anton = new Anton("Антон - Качек", 30, 600, 8);
            Mama mama = new Mama("Ну а это мать...", 50, 1000, 15);
            Papa papa = new Papa("Бухой Батек...", 100, 1500, 40);
            Boss boss = new Boss("НЕВЕРОЯТНЫЙ БОСС ЧТОБ ПОЛУЧИТЬ ТРЫНДЫ", 300, 5000, 1000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("И так Петушек, пора тебе повоевать.\n");
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" 1 - Магазин, в котором ты купишь ХП.(Цена: 6 монет) \n 2 - Магазин, в котором ты купишь ДАМААААГ.(Цена: 8 монет) \n 3 - Бой с Олегом (400 ХП, 20 Дамага). \n 4 - Бой с Антоном (600 ХП, 30 Дамага). \n 5 - Бой с Мамой (1000 ХП, 40 Дамага). \n 6 - Бой с Бухим батьком (1500 ХП, 100 Дамага). \n 7 - Битва с босом. \n 8 - Выход из игры.");
                Console.ForegroundColor = ConsoleColor.White;
                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        lvl_hp();
                        break;
                    case 2:
                        Console.Clear();
                        lvl_dm();
                        break;
                    case 3:
                        Console.Clear();
                        Battle_Oleg();
                        break;
                    case 4:
                        Console.Clear();
                        Battle_Anton();
                        break;
                    case 5:
                        Console.Clear();
                        Battle_mama();
                        break;
                    case 6:
                        Console.Clear();
                        Battle_papa();
                        break;
                    case 7:
                        Console.Clear();
                        Battle_Boss();
                        break;
                    case 8:
                        Console.Clear();
                        final();
                        break;
                }
            }
            
        //МЕТОДЫ
        //Качалка ХП епта
        void lvl_hp()
            {

                if (player.Coins < 6)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("у вас не хватает монет");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    player.hp = player.hp += 1500;

                    Console.WriteLine($"вы выбрали бафф хп, количество ваших хп {player.hp}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Монет осталось: {player.Coins -= 6}");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }



            //Качалка дамага
            void lvl_dm()
            {
                if (player.Coins < 8)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("У вас не хватает монет");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    player.damage = player.damage += 25;
                    Console.WriteLine($"Вы выбрали увелечение урона, количество вашего урона {player.damage}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Монет осталось: {player.Coins -= 8}");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            }

            //ОООООООООООООООООООЛЕЕЕЕЕЕЕЕЕЕЕЕЕЕЕЕЕЕЕЕЕЕг
            void Battle_Oleg()
            {
                if (player.hp > 0)
                {

                    Console.WriteLine($"Вы начали битву с Олежкой");
                    while (player.hp > 0 && oleg.hp > 0)
                    {

                        Console.WriteLine($"Вы бьете оставляя Олежке {oleg.hp -= player.damage} здоровья");
                        Console.WriteLine($"Олежик бьет оставляя Петуху {player.hp -= oleg.damage} здоровья");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nВы победили и получили 2 монетку.  Монет в сумке {player.Coins += 2}");
                    Console.ForegroundColor = ConsoleColor.White;
                    oleg.hp += 500;
                }
                else if (player.hp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помер Малыш");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            //ААААААААААААААААААААААНТООООООННННН
            void Battle_Anton()
            {
                if (player.hp > 0)
                {
                    Console.WriteLine($"Вы начали битву с Антошкой");
                    while (player.hp > 0 && anton.hp > 0)
                    {
                        Console.WriteLine($"Вы бьете оставляя Антошке {anton.hp -= player.damage} здоровья");
                        Console.WriteLine($"Антон Павлович бьет оставляя Петуху{player.hp -= anton.damage} здоровья");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nВы победили и получили 5 монетки.  Монет в сумке {player.Coins += 5}");
                    Console.ForegroundColor = ConsoleColor.White;
                    anton.hp += 700;
                }
                else if (player.hp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помер Малыш");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // MAMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            void Battle_papa()
            {
                if (player.hp > 0)
                {
                    Console.WriteLine($"Вы начали битву с Бухим батей");
                    while (player.hp > 0 && mama.hp > 0)
                    {
                        Console.WriteLine($"Вы бьете оставляя Бате {papa.hp -= player.damage} здоровья");
                        Console.WriteLine($"Батек бьет оставляя Петуху {player.hp -= papa.damage} здоровья");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" \n Вы победили и получили 15 монеток.  Монет в сумке {player.Coins += 15}");
                    Console.ForegroundColor = ConsoleColor.White;
                    mama.hp += 900;
                }
                else if (player.hp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помер Малыш");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // PAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAA
            void Battle_mama()
            {
                if (player.hp > 0)
                {
                    Console.WriteLine($"Вы начали битву с мамкой");
                    while (player.hp > 0 && papa.hp > 0)
                    {
                        Console.WriteLine($"Вы бьете оставляя Маме {mama.hp -= player.damage} здоровья");
                        Console.WriteLine($"Мамка бьет оставляя Люсьену {player.hp -= mama.damage} здоровья");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" \n Вы победили и получили 7 монеток.  Монет в сумке {player.Coins += 10}");
                    Console.ForegroundColor = ConsoleColor.White;
                    papa.hp += 900;
                }
                else if (player.hp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помер Малыш");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            void Battle_Boss()
            {
                if (player.hp > 0)
                {
                    Console.WriteLine($"Вы начали битву с магом по имени ЛОПУХ ЕПТИТЬ");
                    while (player.hp > 0 && boss.hp > 0)
                    {
                        Console.WriteLine($"Вы бьете оставляя Якубовичу {boss.hp -= player.damage} здоровья");
                        Console.WriteLine($"Боссик бьет оставляя Люсьену {player.hp -= boss.damage} здоровья");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" \n Вы победили и получили 7 монеток.  Монет в сумке {player.Coins += 45}");
                    Console.ForegroundColor = ConsoleColor.White;
                    boss.hp += 900;
                }
                else if (player.hp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помер Малыш");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }


            void final()
            {
                if (player.Coins < 500)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Чепух, иди бейся петух для начала, что б пришел с 1000 монеток... \n");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    while (false) ;
                    Text text1 = new Text();
                    text1.final();
                }
            }


        }
    }
}

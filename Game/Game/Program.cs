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
            Mama mama = new Mama("Ну а это мать... Ебнутая", 50, 1000, 15);
            Papa papa = new Papa("Бухой Батек...", 100, 1500, 40);
            Boss boss = new Boss("НЕВЕРОЯТНЫЙ БОСС ЧТОБ ПОЛУЧИТЬ ТРЫНДЫ", 300, 5000, 1000);

            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    lvl_hp();
                    break;
                case 2:
                    lvl_dm();
                    break;
                case 3:
                    Battle_oleg();
                    break;
                case 4:
                    Battle_Ork();
                    break;
                case 5:
                    Battle_Wizard();
                    break;
                case 6:
                    final();
                    break;
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
                    player.hp = player.hp += 800;

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
                    Console.WriteLine("у вас не хватает монет");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    player.damage = player.damage += 15;
                    Console.WriteLine($"вы выбрали бафф урона, количество вашего урона {player.damage}");
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
                    Console.WriteLine($"Вы начали битву со скелетом по имени Константин");
                    while (player.hp > 0 && oleg.hp > 0)
                    {

                        Console.WriteLine($"Петучь бьет оставляя Олежке {oleg.hp -= player.damage} здоровья");
                        Console.WriteLine($"Константин бьет оставляя Люсьену {player.hp -= oleg.damage} здоровья");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nВы победили и получили 1 монетку.  Монет в сумке {player.Coins += 1}");
                    Console.ForegroundColor = ConsoleColor.White;
                    oleg.hp += 500;
                }
                else if (player.hp <= 0)
                {
                    Console.WriteLine("Помер Малыш");
                }
            }

            //ААААААААААААААААААААААНТООООООННННН
            void Battle_Anton()
            {
                if (player.hp > 0)
                {
                    Console.WriteLine($"Вы начали битву со орком по имени Ляррррва");
                    while (player.hp > 0 && anton.hp > 0)
                    {
                        Console.WriteLine($"Люсьен бьет оставляя Ляррррве {anton.hp -= player.damage} здоровья");
                        Console.WriteLine($"Ляррррва бьет оставляя Люсьену{player.hp -= anton.damage} здоровья");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nВы победили и получили 3 монетки.  Монет в сумке {player.Coins += 3}");
                    Console.ForegroundColor = ConsoleColor.White;
                    anton.hp += 700;
                }
                else if (player.hp <= 0)
                {
                    Console.WriteLine("Помер Малыш");
                }
            }

            // MAMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            void Battle_Wizard()
            {
                if (player.hp > 0)
                {
                    Console.WriteLine($"Вы начали битву с магом по имени Якубович");
                    while (player.hp > 0 && mama.hp > 0)
                    {
                        Console.WriteLine($"Люсьен бьет оставляя Якубовичу {mama.hp -= player.damage} здоровья");
                        Console.WriteLine($"Якубович бьет оставляя Люсьену {player.hp -= mama.damage} здоровья");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" \n Вы победили и получили 7 монеток.  Монет в сумке {player.Coins += 7}");
                    Console.ForegroundColor = ConsoleColor.White;
                    mama.hp += 900;
                }
                else if (player.hp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ты сдох");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // PAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAA
            void Battle_Papa()
            {
                if (player.hp > 0)
                {
                    Console.WriteLine($"Вы начали битву с магом по имени Якубович");
                    while (player.hp > 0 && papa.hp > 0)
                    {
                        Console.WriteLine($"Люсьен бьет оставляя Якубовичу {papa.hp -= player.damage} здоровья");
                        Console.WriteLine($"Якубович бьет оставляя Люсьену {player.hp -= papa.damage} здоровья");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" \n Вы победили и получили 7 монеток.  Монет в сумке {player.Coins += 7}");
                    Console.ForegroundColor = ConsoleColor.White;
                    papa.hp += 900;
                }
                else if (player.hp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ты сдох");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            void Battle_Boss()
            {
                if (player.hp > 0)
                {
                    Console.WriteLine($"Вы начали битву с магом по имени Якубович");
                    while (player.hp > 0 && boss.hp > 0)
                    {
                        Console.WriteLine($"Люсьен бьет оставляя Якубовичу {boss.hp -= player.damage} здоровья");
                        Console.WriteLine($"Якубович бьет оставляя Люсьену {player.hp -= boss.damage} здоровья");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" \n Вы победили и получили 7 монеток.  Монет в сумке {player.Coins += 7}");
                    Console.ForegroundColor = ConsoleColor.White;
                    boss.hp += 900;
                }
                else if (player.hp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ты сдох");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }


            void final()
            {
                if (player.Coins < 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Чепух, иди попиздись для начала, что б пришел с 1000 монеток... \n");
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

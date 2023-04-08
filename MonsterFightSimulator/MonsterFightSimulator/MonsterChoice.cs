using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFightSimulator
{
    internal class MonsterChoice
    {
        private readonly Monster Orc;
        private readonly Monster Troll;
        private readonly Monster Goblin;

        public int m_choice1;
        public static string choice1 = "";
        public int m_choice2;
        public static string choice2 = "";

        public MonsterChoice(Monster orc, Monster troll, Monster goblin)
        {
            Orc = orc;
            Troll = troll;
            Goblin = goblin;
        }

        public string race1()        // first racechoice
        {
            bool racecheck = false;
            do
            {
                Console.WriteLine("Please choose the monster to fight in the arena.");
                Console.WriteLine("The avaiable monster are Orc = 1, Troll = 2 and Goblin = 3.");
                m_choice1 = Convert.ToInt32(Console.ReadLine());

                switch (m_choice1)
                {
                    case 1:
                        Orc.ChooseStats();
                        choice1 = "Orc";
                        racecheck = true;
                        break;
                    case 2:
                        Troll.ChooseStats();
                        choice1 = "Troll";
                        racecheck = true;
                        break;
                    case 3:
                        Goblin.ChooseStats();
                        choice1 = "Goblin";
                        racecheck = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input.");
                        break;
                }
            } while (racecheck == false);
            return choice1;       
        }

        public string race2()        // second racechoice
        {
            bool racecheck = false;
            do
            {
                //Console.Clear();
                Console.WriteLine("Please choose another monster.");
                Console.WriteLine("The avaiable monster are Orc = 1, Troll = 2 and Goblin = 3.");
                m_choice2 = Convert.ToInt32(Console.ReadLine());

                switch (m_choice2)
                {
                    case 1:
                        Orc.ChooseStats();
                        racecheck = true;
                        choice2 = "Orc";
                        break;
                    case 2:
                        Troll.ChooseStats();
                        racecheck = true;
                        choice2 = "Troll";
                        break;
                    case 3:
                        Goblin.ChooseStats();
                        racecheck = true;
                        choice2 = "Goblin";
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input. Please choose one of the before mentioned races.");
                        break;
                }
            } while (racecheck == false);
            return choice2;
        }
    }
}

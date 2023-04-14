using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFightSimulator
{
    internal class Combat
    {

        private readonly Monster Orc;
        private readonly Monster Troll;
        private readonly Monster Goblin;

        /// <summary>
        /// constructor to save the given parameters
        /// </summary>
        /// <param name="orc"> praviously chosen orc stats given to the combat class </param>
        /// <param name="troll"> praviously chosen troll stats given to the combat class </param>
        /// <param name="goblin"> praviously chosen goblin stats given to the combat class </param>
        public Combat(Monster orc, Monster troll, Monster goblin)
        {
            Orc = orc;
            Troll = troll;
            Goblin = goblin;
        }

        Compare Compare = new Compare();

        /// <summary>
        /// simple switch case to determine which 2 given races are fighting
        /// </summary>
        /// <param name="_choice1"> first chosen race </param>
        /// <param name="_choice2"> second chosen race </param>
        public void Fight(string _choice1, string _choice2)
        {
            switch (_choice1)
            {
                case "Orc":
                    switch (_choice2)
                    {
                        case "Troll":
                            FightStart(Orc, Troll);
                            break;

                        case "Goblin":
                            FightStart(Orc, Goblin);
                            break;
                    }                   
                    break;
                case "Troll":
                    switch (_choice2)
                    {
                        case "Orc":
                            FightStart(Troll, Orc);
                            break;

                        case "Goblin":
                            FightStart(Troll, Goblin);
                            break;
                    }
                    break;
                case "Goblin":
                    switch (_choice2)
                    {
                        case "Orc":
                            FightStart(Goblin, Orc);
                            break;

                        case "Troll":
                            FightStart(Goblin, Troll);
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// Simple Combatloop until one Monster is dead.
        /// </summary>
        /// <param name="_fighter1"> Input of the first monster and its stats </param>
        /// <param name="_fighter2"> Input of the second Monster and its stats </param>
        private void FightStart(Monster _fighter1, Monster _fighter2)
        {
            int i = 0;          // counts the number of rounds taken for combat to finish
            if (Compare.Speed(_fighter1.s, _fighter2.s) == true)
            {
                Console.WriteLine("The {0}'s speed is greater it will have the first móve.", _fighter1.race);
                do
                {
                    _fighter1.Attack(_fighter2);
                    i++;
                    Console.WriteLine("After the {0} round the {1}'s opponent has {2} hp left.", i, _fighter1.race, _fighter2.hp);
                    Console.WriteLine("Meanwhile the {0} has {1} hp left.", _fighter1.race, _fighter1.hp);
                }
                while (_fighter1.hp > 0 && _fighter2.hp > 0);
                Winner(_fighter1, _fighter2, i);
            }
            else
            {
                Console.WriteLine("The Troll's speed is greater it will have the first móve.");
                do
                {
                    _fighter2.Attack(_fighter1);
                    i++;
                    Console.WriteLine("After the {0} round the {1}'s opponent has {2} hp left.", i, _fighter1.race, _fighter2.hp);
                    Console.WriteLine("Meanwhile the {0} has {1} hp left.", _fighter1.race, _fighter1.hp);
                }
                while (_fighter1.hp > 0 && _fighter2.hp > 0);
                Winner(_fighter1, _fighter2, i);
            }
        }

        /// <summary>
        ///  Depending on which Monster one a simple statement who has lost will be posted.
        /// </summary>
        /// <param name="_fighter1"> Input of the first monster and its stats </param>
        /// <param name="_fighter2"> Input of the second monster and its stats </param>
        /// <param name="i"> counter for the number of rounds </param>
        public void Winner(Monster _fighter1, Monster _fighter2, int i)
        {
            Console.WriteLine("The fight has ended after {0} rounds", i);
            if (_fighter1.hp == 0)
            {
                Console.WriteLine("The {0} has lost the battle.", _fighter1.race);
            }
            else
                Console.WriteLine("The {0} has lost the battle.", _fighter2.race);
        }
    }
}

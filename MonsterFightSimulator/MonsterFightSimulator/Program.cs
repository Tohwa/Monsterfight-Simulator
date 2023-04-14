namespace MonsterFightSimulator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string m_firstMonster = "";
            string m_secondMonster = "";

            // create 3 object corresponding to the different monsters available
            Monster Orc = new Orc();
            Monster Troll = new Troll();
            Monster Goblin = new Goblin();

            // create 2 choice objects where the user can make his monster choice and give it stats
            MonsterChoice CMonster1 = new MonsterChoice(Orc, Troll, Goblin);
            MonsterChoice CMonster2 = new MonsterChoice(Orc, Troll, Goblin);
           
            Compare Compare = new Compare();

            // create a object where the monsters are given values are given to
            Combat Combat = new Combat(Orc, Troll, Goblin);

            m_firstMonster = CMonster1.race1();

            if (m_firstMonster == "Orc")
            {
                Console.WriteLine("Your first chosen Monster is an {0}", m_firstMonster);
                Console.WriteLine("It has {0} hp, {1} attack, {2} defense and a speed of {3}.", Orc.hp, Orc.ap, Orc.dp, Orc.s);
            }
            else
            {
                Console.WriteLine("Your first chosen Monster is a {0}", m_firstMonster);
                switch (m_firstMonster)
                {
                    case "Troll":
                        Console.WriteLine("It has {0} hp, {1} attack, {2} defense and a speed of {3}.", Troll.hp, Troll.ap, Troll.dp, Troll.s);
                        break;
                    case "Goblin":
                        Console.WriteLine("It has {0} hp, {1} attack, {2} defense and a speed of {3}.", Goblin.hp, Goblin.ap, Goblin.dp, Goblin.s);
                        break;

                }
            }

            do
            {
                m_secondMonster= CMonster2.race2();
            } while (Compare.Race(m_firstMonster, m_secondMonster) == true);

            if (m_secondMonster == "Orc")
            {
                Console.WriteLine("Your first chosen Monster is an {0}", m_secondMonster);
                Console.WriteLine("It has {0} hp, {1} attack, {2} defense and a speed of {3}.", Orc.hp, Orc.ap, Orc.dp, Orc.s);
            }
            else
            {
                Console.WriteLine("Your first chosen Monster is a {0}", m_secondMonster);
                switch (m_secondMonster)
                {
                    case "Troll":
                        Console.WriteLine("It has {0} hp, {1} attack, {2} defense and a speed of {3}.", Troll.hp, Troll.ap, Troll.dp, Troll.s);
                        break;
                    case "Goblin":
                        Console.WriteLine("It has {0} hp, {1} attack, {2} defense and a speed of {3}.", Goblin.hp, Goblin.ap, Goblin.dp, Goblin.s);
                        break;

                }
            }

            Combat.Fight(MonsterChoice.choice1, MonsterChoice.choice2);
        }
    }
}
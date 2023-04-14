using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFightSimulator
{
    internal class Monster
    {
        public string race;
        public float hp; //health
        public float ap; //attackpower
        public float dp; //defense
        public float s;  //speed

        public Monster(string _race)
        {
            this.race = _race;
        }

        public void ChooseStats()
        {
            bool isChoosingHP = true;
            bool isChoosingAP = true;
            bool isChoosingDP = true;
            bool isChoosingS = true;

            while (isChoosingHP)
            {
                Console.WriteLine($"How high is the {race}'s health?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatHP))
                {
                    isChoosingHP = false;
                    hp += parsedfloatHP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingAP)
            {
                Console.WriteLine($"How high is the {race}'s attackpower?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatAP))
                {
                    isChoosingAP = false;
                    ap += parsedfloatAP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingDP)
            {
                Console.WriteLine($"How high is the {race}'s defense?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatDP))
                {
                    isChoosingDP = false;
                    dp += parsedfloatDP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingS)
            {
                Console.WriteLine($"How fast is the {race}?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatS))
                {
                    isChoosingS = false;
                    s += parsedfloatS;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
        }

        /// <summary>
        /// primary attack method to be overwritten by other classes later on
        /// </summary>
        /// <param name="_opponent"></param>
        /// <returns></returns>
        public virtual void Attack(Monster _opponent) { }

    }

    internal class Orc : Monster
    {
        public Orc() : base("Orc") { }
        
        public override void Attack(Monster _opponent)
        {
            float m_dmg1 = ap - _opponent.dp;
            if (m_dmg1 < 0)
            {
                m_dmg1 = 1;
            }
            _opponent.hp -= m_dmg1;

            if (_opponent.hp < 0)
            {
                _opponent.hp = 0;
                Console.WriteLine("The {0} has {1} hp left", _opponent.race, _opponent.hp);
            }
            else if (_opponent.hp > 0)
            {
                float m_dmg2 = _opponent.ap - dp;
                if (m_dmg2 < 0)
                {
                    m_dmg2 = 1;
                }
                hp -= m_dmg2;

                if (hp < 0)
                {
                    hp = 0;
                }
                Console.WriteLine("The {0} has {1} hp left", race, hp);
            }
        }
    }

    internal class Troll : Monster
    {
        public Troll() : base("Troll") { }       

        public override void Attack(Monster _opponent)
            {
                float m_dmg1 = ap - _opponent.dp;
                if (m_dmg1 < 0)
                {
                    m_dmg1 = 1;
                }
                _opponent.hp -= m_dmg1;

                if (_opponent.hp < 0)
                {
                    _opponent.hp = 0;
                    Console.WriteLine("The {0} has {1} hp left", _opponent.race, _opponent.hp);
                }
                else if (_opponent.hp > 0)
                {
                    float m_dmg2 = _opponent.ap - dp;
                    if (m_dmg2 < 0)
                    {
                        m_dmg2 = 1;
                    }
                    hp -= m_dmg2;

                    if (hp < 0)
                    {
                    hp = 0;
                    }
                    Console.WriteLine("The {0} has {1} hp left", race, hp);
                }
            }
    }

    internal class Goblin : Monster
    {
        public Goblin() : base("Goblin") { }

        public override void Attack(Monster _opponent)
        {
            float m_dmg1 = ap - _opponent.dp;
            if (m_dmg1 < 0)
            {
                m_dmg1 = 1;
            }
            _opponent.hp -= m_dmg1;

            if (_opponent.hp < 0)
            {
                _opponent.hp = 0;
                Console.WriteLine("The {0} has {1} hp left", _opponent.race, _opponent.hp);
            }
            else if (_opponent.hp > 0)
            {
                float m_dmg2 = _opponent.ap - dp;
                if (m_dmg2 < 0)
                {
                    m_dmg2 = 1;
                }
                hp -= m_dmg2;

                if (hp < 0)
                {
                    hp = 0;
                }
                Console.WriteLine("The {0} has {1} hp left", race, hp);
            }
        }
    }
}

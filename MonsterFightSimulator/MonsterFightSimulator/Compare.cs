using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFightSimulator
{
    internal class Compare
    {
        /// <summary>
        /// Simple Method to compare 2 strings if they are equal if yes the method returns true otherwise false
        /// </summary>
        /// <param name="_monster1"> Race of the first chosen Monster </param>
        /// <param name="_monster2"> Race of the second chosen Monster </param>
        /// <returns></returns>
        public bool Race(string _monster1, string _monster2)        
        {
            if (_monster1.Equals(_monster2))
            {
                Console.Clear();
                Console.WriteLine("Two monster of the same race are not allowed to battle each other!");
            }
            return false;
        }

        /// <summary>
        /// Simple method to compare 2 Values to see which is higher. 
        /// </summary>
        /// <param name="_spd1"> Speed of the first Monster </param>
        /// <param name="_spd2"> Speed of the second Monster </param>
        /// <returns></returns>
        public bool Speed(float _spd1, float _spd2)     
        {
            if (_spd1 >= _spd2)
            {
                return true;
            }
            else
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1_1
{
    public class Monster
    {
        public string strName;
        public int iHp;
        public int iAttack;
        

        public void SetDamage(int iAttack)
        {
            iHp -= iAttack;
        }

        public void SetMoster(string _strName, int _iHp, int _iAttack)
        {
            strName = _strName;
            iHp = _iHp;
            iAttack = _iAttack;
        }
        //public Info GetMonster()
        //{
            //return m_tMonster;
        //}
        public void Render()
        {
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("몬스터 : " + strName);
            Console.WriteLine("체력 : " + iHp + "\t공격력 : " + iAttack);
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■");
        }

        public Monster(string name, int hp, int at) 
        {
            this.strName = name;
            this.iHp = hp;
            this.iAttack = at;
        }
        ~Monster() { }
    }
}

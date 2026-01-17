    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Lion_Assignment_1_1
    {
        public class Player
        {
            public string strName;
            public int iHp;
            public int maxHP;
            public Inventory inventory;

            public virtual void SetDamage(int iAttack)
            {
                iHp -= iAttack;
            }

            public string getName()
            {
                return strName;
            }
            public int getHp()
            {
                return iHp;
            }

            public void SetHp(int iHp)
            {
                iHp = iHp;
            }
            public virtual int attack()
            {
                return 0;
            }

            public virtual void Render()
            {

            }

            public virtual void useHealItem()
            {
    
                
            }

            public virtual void ShowDetail()
            {
                
            }

            public void FightInfo(Monster m)
            {
                Console.WriteLine($"당신이 {m.strName}을 공격하였습니다!");
                Console.WriteLine($"{m.strName}이 당신을 공격하였습니다!");
            }

            public Player() { }
            ~Player() { }
        }
    }

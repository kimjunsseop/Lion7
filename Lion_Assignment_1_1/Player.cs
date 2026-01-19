    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    namespace Lion_Assignment_1_1
    {
        abstract public class Player
        {
            public string strName;
            public int iHp;
            public int maxHP;
            public int defense;
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
            public int TotalAttack()
            {
                if(inventory.holdItem != null)
                {
                    return inventory.holdItem.AddAtk;
                }
                return 0;
            }

            public void SetHp(int iHp)
            {
                iHp = iHp;
            }
            public abstract int attack();

            abstract public void Render();
            abstract public void useHealItem();

            abstract public void ShowDetail();

            public void FightInfo(Monster m)
            {
                Console.WriteLine($"당신이 {m.strName}을 공격하였습니다!");
                Console.WriteLine($"{m.strName}이 당신을 공격하였습니다!");
            }

            public Player() { }
            ~Player() { }
        }
    }

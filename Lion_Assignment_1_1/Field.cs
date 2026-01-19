using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1_1
{
    public class Field
    {
        Player m_pPlayer;
        Monster m_pMonster;

        public void SetPlayer(Player mplayer)
        {
            m_pPlayer = mplayer;
        }

        public void Progress()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();

                m_pPlayer.Render();
                DrawMap();
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 5) break;

                if (iInput <= 4)
                {
                    CreateMonster(iInput);
                    Fight();
                }

            }
        }

        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1.공격 2.회복 3.도망 : ");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 1)
                {
                    switch(m_pPlayer)
                    {
                        case Warrior w:
                            w.SetDamage(m_pMonster.iAttack);
                            m_pMonster.SetDamage(w.attack() + w.TotalAttack());
                            w.FightInfo(m_pMonster);
                            w.inventory.money += 10;
                            break;
                        case Wizard z:
                            z.SetDamage(m_pMonster.iAttack);
                            m_pMonster.SetDamage(z.attack() + z.TotalAttack());
                            z.FightInfo(m_pMonster);
                            z.inventory.money += 10;
                            break;
                        case Thief t:
                            t.SetDamage(m_pMonster.iAttack);
                            m_pMonster.SetDamage(t.attack() + t.TotalAttack());
                            t.FightInfo(m_pMonster);
                            t.inventory.money += 10;
                            break;
                        case Archer a:
                            a.SetDamage(m_pMonster.iAttack);
                            m_pMonster.SetDamage(a.attack() + a.TotalAttack());
                            a.FightInfo(m_pMonster);
                            a.inventory.money += 10;
                            break;

                    }
                }
                if (iInput == 2)
                {
                    if (m_pPlayer.inventory.healItem > 0)
                    {
                        m_pPlayer.useHealItem();
                    }
                }
                if (iInput == 3 || m_pMonster.iHp <= 0)
                {
                    m_pMonster = null;
                    break;
                }
            }
        }

        public Monster Create(string _strName, int _iHp, int _iAttack)
        {
            return new Monster(_strName, _iHp, _iAttack);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    m_pMonster = Create("훈련 몬스터", 30, 3);
                    //m_pMonster.Render();
                    break;
                case 2:
                    m_pMonster = Create("새끼 골렘", 60, 6);
                    //m_pMonster.Render();
                    break;
                case 3:
                    m_pMonster = Create("골렘", 90, 9);
                    //m_pMonster.Render();
                    break;
                case 4:
                    m_pMonster = Create("엔더이무기", 300, 20);
                    break;

            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초심자 훈련장");
            Console.WriteLine("2. 던전으로 가는 길");
            Console.WriteLine("3. 던전");
            //Console.WriteLine("4. 인벤토리");
            Console.WriteLine("4. 지옥");
            Console.WriteLine("5. 전단계");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택하세요 : ");
        }
    }
}

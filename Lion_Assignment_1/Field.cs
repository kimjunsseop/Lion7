using Lion_Assignment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1
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
                if (iInput == 4) break;

                if (iInput <= 3)
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
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);
                    m_pPlayer.inventory.money += 10;
                    if (m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        Console.WriteLine("플레이어 사망");
                        break;
                    }
                }
                if(iInput == 2)
                {
                    if (m_pPlayer.inventory.healItem > 0)
                    {
                        m_pPlayer.useHealItem();
                    }
                }
                if (iInput == 3 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break;
                }
            }
        }

        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            Info tMonster = new Info();
            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;
            pMonster.SetMoster(tMonster);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 3, out m_pMonster);
                    //m_pMonster.Render();
                    break;
                case 2:
                    Create("중수몹", 60, 6, out m_pMonster);
                    //m_pMonster.Render();
                    break;
                case 3:
                    Create("초보몹", 90, 9, out m_pMonster);
                    //m_pMonster.Render();

                    break;

            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            //Console.WriteLine("4. 인벤토리");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택하세요 : ");
        }
    }
}

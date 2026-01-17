using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1
{
    public class Player
    {
        public Info m_tInfo;
        public Inventory inventory;

        public void SetDamage(int iAttack)
        {
            m_tInfo.iHp -= iAttack;
        }

        public Info GetInfo()
        {
            return m_tInfo;
        }

        public void SetHp(int iHp)
        {
            m_tInfo.iHp = iHp;
        }

        public void SelectJob()
        {
            m_tInfo = new Info();
            inventory = new Inventory();
            Console.WriteLine("직업을 선택하세요(1.기사 2.마법사 3.도둑) :");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    m_tInfo.strName = "기사";
                    m_tInfo.iHp = 100;
                    m_tInfo.iAttack = 10;
                    break;
                case 2:
                    m_tInfo.strName = "마법사";
                    m_tInfo.iHp = 90;
                    m_tInfo.iAttack = 15;
                    break;
                case 3:
                    m_tInfo.strName = "도둑";
                    m_tInfo.iHp = 85;
                    m_tInfo.iAttack = 13;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("========================");
            Console.WriteLine("직업 이름 : " + m_tInfo.strName);
            Console.WriteLine("체력 : " + m_tInfo.iHp + "\t공격력 : " + m_tInfo.iAttack);
            inventory.ShowInventory();
        }

        public void useHealItem()
        {
            if (inventory != null)
            {
                if (inventory.healItem <= 0)
                {
                    Console.WriteLine("물약이 없습니다");
                }
                else
                {
                    inventory.healItem--;
                    m_tInfo.iHp += 30;
                    switch (m_tInfo.strName)
                    {
                        case "기사":
                            if (m_tInfo.iHp >= 100)
                            {
                                m_tInfo.iHp = 100;
                            }
                            break;
                        case "마법사":
                            if (m_tInfo.iHp >= 90)
                            {
                                m_tInfo.iHp = 90;
                            }
                            break;
                        case "도둑":
                            if (m_tInfo.iHp >= 85)
                            {
                                m_tInfo.iHp = 85;
                            }
                            break;
                    }
                }
            }
        }

        public void ShowDetail()
        {
            while (true)
            {
                Console.Clear();
                int iInput;
                Console.WriteLine("=================");
                Console.WriteLine($"직업 : {m_tInfo.strName}");
                Console.WriteLine($"현재 체력 : {m_tInfo.iHp}");
                switch (m_tInfo.strName)
                {
                    case "기사":
                        Console.WriteLine($"공격력 : {m_tInfo.iAttack}");
                        break;
                    case "마법사":
                        Console.WriteLine($"마력 : {m_tInfo.iAttack}");
                        break;
                    case "도둑":
                        Console.WriteLine($"스틸력 : {m_tInfo.iAttack}");
                        break;
                }
                Console.WriteLine("=================");
                Console.WriteLine("1. 나가기");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 1) break;
            }
        }

        public Player() { }
        ~Player() { }


    }
}

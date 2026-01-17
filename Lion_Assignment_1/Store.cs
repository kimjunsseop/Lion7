using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1
{
    class Store
    {
        public int iInput;
        private int healthMoney = 30;
        private int upgradeMoney = 10;
        public Player player;

        public void Show()
        {
            Console.Clear();
            while (true)
            {
                player.inventory.ShowInventory();
                Console.WriteLine("구매 품목을 입력하시오");
                Console.WriteLine($"1. 물약{30}G 2. 공격력{10}G 3. 나가기 : ");
                Console.WriteLine("3. 전용샵");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 3) break;
                switch (iInput)
                {
                    case 1:
                        sellHealth();
                        break;
                    case 2:
                        sellUpgrade();
                        break;
                }

            }
        }

        public void sellHealth()
        {
            if (player.inventory.money >= healthMoney)
            {
                player.inventory.addHealItem(1);
                player.inventory.money -= healthMoney;
            }
            else
            {
                Console.WriteLine("보유 잔액이 부족합니다.");
            }
        }
        public void sellUpgrade()
        {
            if (player.inventory.money >= upgradeMoney)
            {
                Console.WriteLine($"플레이어의 공격력이 {player.GetInfo().iAttack} + 10 이 되었습니다.");
                player.GetInfo().iAttack += 10;
                player.inventory.money -= upgradeMoney;
            }
            else
            {
                Console.WriteLine("보유 잔액이 부족합니다.");
            }
        }
        public void jobStore()
        {
            Console.Clear();
            int iInput;
            switch(player.m_tInfo.strName)
            {
                case "전사":
                    break;
                case "마법사":
                    break;
                case "도둑":
                    break;
            }
        }
        public void entraceStore(Player player)
        {
            this.player = player;
        }
    }
}

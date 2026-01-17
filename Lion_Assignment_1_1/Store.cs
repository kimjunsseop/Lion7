using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1_1
{
    public class Store
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
                Console.WriteLine($"1. 물약{30}G 2. 전용샵 3. 나가기 : ");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 3) break;
                switch (iInput)
                {
                    case 1:
                        sellHealth();
                        break;
                    case 2:
                        sellUpgrade(player);
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
        public void sellUpgrade(Player player)
        {
            Console.Clear();
            int iInput;
            while (true)
            {
                switch (player)
                {
                    case Warrior w:
                        WarriorUpgrade(w);
                        break;
                    case Wizard i:
                        WizardUpgrade(i);
                        break;
                    case Thief t:
                        ThiefUpgrade(t);
                        break;
                }
                break;
            }
        }
        public void WarriorUpgrade(Warrior w)
        {
            int iInput;
            
            while(true)
            {
                Console.Clear();
                w.Render();
                
                Console.WriteLine("▼ ▼ 업그레이드 항목 ▼ ▼");
                Console.WriteLine();
                Console.WriteLine("1. 방어력(10G) 2. 공격력(10G) 3. 최대체력(10G) 4. 나가기: ");
                iInput = int.Parse(Console.ReadLine());
                switch (iInput)
                {
                    case 1:
                        if(player.inventory.money >= 10)
                        {
                            w.defense += 10;
                        }
                        break;
                    case 2:
                        if (player.inventory.money >= 10)
                        {
                            w.attackPower += 10;
                        }
                        break;
                    case 3:
                        if (player.inventory.money >= 10)
                        {
                            w.maxHP += 10;
                        }
                        break;
                }
                if(iInput == 4) break;

            }
        }
        public void WizardUpgrade(Wizard w)
        {
            int iInput;
            while (true)
            {
                Console.Clear();
                w.Render();
                Console.WriteLine("▼ ▼ 업그레이드 항목 ▼ ▼");
                Console.WriteLine();
                Console.WriteLine("1. 마력(10G) 2. 마나충전(3G) 3. 최대마나(10G) 4. 나가기: ");
                iInput = int.Parse(Console.ReadLine());
                switch (iInput)
                {
                    case 1:
                        if (player.inventory.money >= 10)
                        {
                            w.mpPower += 10;
                        }
                        break;
                    case 2:
                        if (player.inventory.money >= 3)
                        {
                            w.mp += 10;
                        }
                        break;
                    case 3:
                        if (player.inventory.money >= 10)
                        {
                            w.maxMP += 10;
                        }
                        break;
                }
                if (iInput == 4) break;

            }
        }
        public void ThiefUpgrade(Thief t)
        {
            int iInput;
            
            while (true)
            {
                Console.Clear();
                t.Render();
                Console.WriteLine("▼ ▼ 업그레이드 항목 ▼ ▼");
                Console.WriteLine();
                Console.WriteLine("1. 빠른공격(10G) 2. 최대체력(10G) 3. 나가기: ");
                iInput = int.Parse(Console.ReadLine());
                switch (iInput)
                {
                    case 1:
                        if (player.inventory.money >= 10)
                        {
                            t.fastAttack += 10;
                        }
                        break;
                    case 2:
                        if (player.inventory.money >= 10)
                        {
                            t.maxHP += 10;
                        }
                        break;
                }
                if (iInput == 3) break;

            }
        }
        public void entraceStore(Player player)
        {
            switch(player)
            {
                case Warrior w:
                    this.player = (Warrior)player;
                    break;
                case Wizard z:
                    this.player = (Wizard)player;
                    break;
                case Thief t:
                    this.player = (Thief)player;
                    break;

            }
        }
    }
}

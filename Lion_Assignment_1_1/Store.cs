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
                Console.WriteLine();
                Console.WriteLine("🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫");
                Console.WriteLine("🟫                                🟫");
                Console.WriteLine("🟫        ▼ ▼ 구매 항목 ▼ ▼       🟫");
                Console.WriteLine($"🟫   1. 물약{30}G 2. 갑옷(100G) :   🟫");
                Console.WriteLine("🟫                                🟫");
                Console.WriteLine("🟫          ▼ ▼ 항목 ▼ ▼          🟫");
                Console.WriteLine("🟫    3. 전용 스토어 4. 나가기    🟫");
                Console.WriteLine("🟫                                🟫");
                Console.WriteLine("🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 4) break;
                switch (iInput)
                {
                    case 1:
                        sellHealth();
                        break;
                    case 2:
                        if(player.inventory.money >= 100)
                        {
                            player.inventory.isGapot = true;
                            player.defense += 5;
                            player.inventory.money -= 100;
                        }
                        break;
                    case 3:
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
                    case Archer a:
                        ArcherUpgrade(a);
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

                Console.WriteLine("🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫                 ▼ ▼ 업그레이드 항목 ▼ ▼                    🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫      1. 방어력(10G) 2. 공격력(10G) 3. 최대체력(10G) :      🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫                     ▼ ▼ 구매 항목 ▼ ▼                      🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫      4. 녹슨검(100G) 5. 강철검(150G) 6. 절대검(200G) :     🟫");
                Console.WriteLine("🟫                      7. 나가기                             🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫");
                iInput = int.Parse(Console.ReadLine());
                switch (iInput)
                {
                    case 1:
                        if(player.inventory.money >= 10)
                        {
                            w.defense += 10;
                            player.inventory.money -= 10;
                        }
                        break;
                    case 2:
                        if (player.inventory.money >= 10)
                        {
                            w.attackPower += 10;
                            player.inventory.money -= 10;
                        }
                        break;
                    case 3:
                        if (player.inventory.money >= 10)
                        {
                            w.maxHP += 10;
                            player.inventory.money -= 10;
                        }
                        break;
                    case 4:
                        if (player.inventory.money >= 100)
                        {
                            player.inventory.AddItem(new Item("녹슨검", 5, 0));
                            player.inventory.money -= 100;
                        }
                        break;
                    case 5:
                        if (player.inventory.money >= 150)
                        {
                            player.inventory.AddItem(new Item("강철검", 10, 0));
                            player.inventory.money -= 150;
                        }
                        break;
                    case 6:
                        if (player.inventory.money >= 200)
                        {
                            player.inventory.AddItem(new Item("절대검", 15, 0));
                            player.inventory.money -= 200;
                        }
                        break;
                }
                if (iInput == 7)
                {
                    Console.Clear();
                    break;
                }

            }
        }
        public void WizardUpgrade(Wizard w)
        {
            int iInput;
            while (true)
            {
                Console.Clear();
                w.Render();
                Console.WriteLine("🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫                 ▼ ▼ 업그레이드 항목 ▼ ▼                    🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫      1. 마력(10G) 2. 마나충전(3G) 3. 최대마나(10G) :       🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫                     ▼ ▼ 구매 항목 ▼ ▼                      🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫  4. 녹지팡이(100G) 5. 쇠지팡이(150G) 6. 절대지팡이(200G) : 🟫");
                Console.WriteLine("🟫                      7. 나가기                             🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫");
                iInput = int.Parse(Console.ReadLine());
                switch (iInput)
                {
                    case 1:
                        if (player.inventory.money >= 10)
                        {
                            w.mpPower += 10;
                            player.inventory.money -= 10;
                        }
                        break;
                    case 2:
                        if (player.inventory.money >= 3)
                        {
                            if(w.mp + 10 >= w.maxMP)
                            {
                                w.mp = w.maxMP;
                            }
                            else
                            {
                                w.mp += 10;
                            }
                            player.inventory.money -= 3;
                        }
                        break;
                    case 3:
                        if (player.inventory.money >= 10)
                        {
                            w.maxMP += 10;
                            player.inventory.money -= 10;
                        }
                        break;
                    case 4:
                        if (player.inventory.money >= 100)
                        {
                            player.inventory.AddItem(new Item("녹슨지팡이", 5, 0));
                            player.inventory.money -= 100;
                        }
                        break;
                    case 5:
                        if (player.inventory.money >= 150)
                        {
                            player.inventory.AddItem(new Item("쇠지팡이", 10, 0));
                            player.inventory.money -= 150;
                        }
                        break;
                    case 6:
                        if (player.inventory.money >= 200)
                        {
                            player.inventory.AddItem(new Item("절대지팡이", 15, 0));
                            player.inventory.money -= 200;
                        }
                        break;
                }
                if (iInput == 7)
                {
                    Console.Clear();
                    break;
                }

            }
        }
        public void ThiefUpgrade(Thief t)
        {
            int iInput;
            
            while (true)
            {
                Console.Clear();
                t.Render();
                Console.WriteLine("🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫                 ▼ ▼ 업그레이드 항목 ▼ ▼                    🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫             1. 빠른공격(10G) 2. 최대체력(10G) :            🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫                     ▼ ▼ 구매 항목 ▼ ▼                      🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫      3. 녹슨검(100G) 4. 강철검(150G) 5. 절대검(200G) :     🟫");
                Console.WriteLine("🟫                      6. 나가기                             🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫");
                iInput = int.Parse(Console.ReadLine());

                switch (iInput)
                {
                    case 1:
                        if (player.inventory.money >= 10)
                        {
                            t.fastAttack += 10;
                            player.inventory.money -= 10;
                        }
                        break;
                    case 2:
                        if (player.inventory.money >= 10)
                        {
                            t.maxHP += 10;
                            player.inventory.money -= 10;
                        }
                        break;
                    case 3:
                        if(player.inventory.money >= 100)
                        {
                            player.inventory.AddItem(new Item("녹슨검", 5, 0));
                            player.inventory.money -= 100;
                        }
                        break;
                    case 4:
                        if (player.inventory.money >= 150)
                        {
                            player.inventory.AddItem(new Item("녹슨검", 5, 0));
                            player.inventory.money -= 150;
                        }
                        break;
                    case 5:
                        if (player.inventory.money >= 200)
                        {
                            player.inventory.AddItem(new Item("녹슨검", 5, 0));
                            player.inventory.money -= 200;
                        }
                        break;
                }
                if (iInput == 6)
                {
                    Console.Clear();
                    break;
                }

            }
        }

        public void ArcherUpgrade(Archer a)
        {
            int iInput;

            while (true)
            {
                Console.Clear();
                a.Render();
                Console.WriteLine("🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫                 ▼ ▼ 업그레이드 항목 ▼ ▼                    🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫      1. 화살공격(10G) 2. 화살충전(1G) 3. 화살통(5G) :      🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫                     ▼ ▼ 구매 항목 ▼ ▼                      🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫      4. 연습활(100G) 5. 나무활(150G) 6. 절대활(200G) :     🟫");
                Console.WriteLine("🟫                      7. 나가기                             🟫");
                Console.WriteLine("🟫                                                            🟫");
                Console.WriteLine("🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫🟫");
                iInput = int.Parse(Console.ReadLine());
                switch (iInput)
                {
                    case 1:
                        if (player.inventory.money >= 10)
                        {
                            a.bowPower += 5;
                            player.inventory.money -= 10;
                        }
                        break;
                    case 2:
                        if (player.inventory.money >= 1)
                        {
                            if(a.bowNum + 1 >= a.maxBowNum)
                            {
                                a.bowNum = a.maxBowNum;
                            }
                            else
                            {
                                a.bowNum += 1;
                            }
                            player.inventory.money -= 1;
                        }
                        break;
                    case 3:
                        if (player.inventory.money >= 10)
                        {
                            a.maxBowNum += 5;
                            player.inventory.money -= 10;
                        }
                        break;
                    case 4:
                        if (player.inventory.money >= 100)
                        {
                            player.inventory.AddItem(new Item("연습활", 5, 0));
                            player.inventory.money -= 100;
                        }
                        break;
                    case 5:
                        if (player.inventory.money >= 150)
                        {
                            player.inventory.AddItem(new Item("나무활", 10, 0));
                            player.inventory.money -= 150;
                        }
                        break;
                    case 6:
                        if (player.inventory.money >= 200)
                        {
                            player.inventory.AddItem(new Item("절대활", 15, 0));
                            player.inventory.money -= 200;
                        }
                        break;
                }
                if (iInput == 7) break;

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
                case Archer a:
                    this.player = (Archer)player;
                    break;

            }
        }
    }
}

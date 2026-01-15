using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Inventory
    {
        public int healItem;
        public int money;

        public int getHealItem()
        {
            return healItem;
        }

        public void setHealItem(int heal)
        {
            healItem = heal;
        }
        public void addHealItem(int heal)
        {
            healItem += heal;
        }

        public void ShowInventory()
        {
            Console.WriteLine($"인벤토리 물약 보유량 : {healItem}");
            Console.WriteLine($"보유 골드 : {money}G");
        }

        public Inventory()
        {
            healItem = 0;
            money = 0;
        }
        
    }
}
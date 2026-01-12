using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp0112
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printPlayerInfo("kim", 100, 100, 100, 100);
            //GreetPlayer("홍길동");
            //Console.WriteLine();

            //ShowPlayerInfo("전사", 50);
            //Console.WriteLine();

            //DrawHealthBar(75, 100, 20);
            //DrawHealthBar(30, 100, 20);
            //DrawHealthBar(100, 100, 20);
            //Console.WriteLine();

            //ShowDamage("플레이어", "고블린", 85);
            //Console.WriteLine();
            //ShowDamage("드래곤", "플레이어", 120);

            //Attack("홍길동", "몬스터", 10);
            //Attack("홍길동", "몬스터", 5f);
            //Attack("홍길동", "몬스터", 3.0);

            //Healing();
            //Healing(100);
            //Monster("슬라임");
            //Monster("고블린", 5);
            //Monster("드래곤", count: 3);

            //int temp;
            //Add(10, out temp);
            //Console.WriteLine(temp);
            //int a, b, c;
            //cresendo(10, out a, out b, out c);
            //Console.WriteLine($"{a},{b},{c}");

            //int before = 10;
            //upgrade(before, out before);
            //Console.WriteLine(before);
            //int a = 10;
            //add(out a);

            int[] arr = { 100, 80, 90, 70, 80 };
            double mean = MeanFunc(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("=== 평균점수 ===");
            Console.WriteLine(mean);
            int point = 87;
            Console.WriteLine($"점수 {point}점은 {CheckGrade(point)}학점입니다 ");
            int num = 17;
            bool prime = isPrime(num);
            if(prime)
            {
                Console.WriteLine($"숫자 {num}은 소수입니다");
            }
            else
            {
                Console.WriteLine($"숫자 {num}은 소수가 아닙니다");
            }
            int current = 30;
            int get = 40;
            bool isLevelup;
            int NewEx;
            levelUp(current, get, out isLevelup, out NewEx);
            if(isLevelup)
            {
                Console.WriteLine($"레벨업이 가능합니다. 남은경험치는 {NewEx}입니다");
            }
            else
            {
                Console.WriteLine($"레벨업이 불가능합니다. 현재 경험치는 {NewEx}입니다");
            }
            int itemLevel = 7;
            int p;
            Upgrade(itemLevel, out p);
            Console.WriteLine($"아이템 레벨이 {itemLevel}이므로 강화확률은 {p}%입니다");

        }

        static double MeanFunc(int[] arr)
        {
            double mean = 0;
            int total = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            mean = (double)total / arr.Length;
            return mean;
        }

        static char CheckGrade(int point)
        {
            if(point >= 90)
            {
                return 'A';
            }
            else if(point >= 80)
            {
                return 'B';
            }
            else if(point >= 70)
            {
                return 'C';
            }
            else
            {
                return 'D';
            }
        }

        static bool isPrime(int a)
        {
            if (a <= 1) return false;

            if (a == 2) return true;

            if (a % 2 == 0) return false;

            int limit = (int)Math.Sqrt(a);

            for (int i = 3; i <= limit; i += 2)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void levelUp(int current, int add, out bool islevelup, out int NewEx)
        {
            if(current + add >= 100)
            {
                islevelup = true;
                NewEx = 100 - (current + add);
            }
            else
            {
                islevelup = false;
                NewEx = current + add;
            }
            
        }

        static void Upgrade(int level, out int p)
        {
            if(level > 10)
            {
                p = 10;
            }
            else if ( level > 7)
            {
                p = 20;
            }
            else if( level > 5)
            {
                p = 30;
            }
            else if(level > 5)
            {
                p = 40;
            }
            else
            {
                p = 50;
            }
                    
        }




        //static void upgrade(int a, out int attack)
        //{
        //    attack = a + 1;
        //}

        // 이런식의 처리는 안됨 확실한 값을 대입해줘야함.
        //static void add(out int b)
        //{
        //    b++;
        //}

        
        //static void Add(int a, out int b)
        //{
        //    a++;
        //    b = a;
        //}

        //static void cresendo(int a, out int b, out int c, out int d)
        //{
        //    b = a + 1;
        //    c = a + 2;
        //    d = a + 3;
        //}

        //static void Healing(int hp = 50)
        //{
        //    Console.WriteLine($"회복량 : {hp}");
        //}
        //static void Monster(string name, int level = 1, int count = 1)
        //{
        //    Console.WriteLine($"{name} 소환!");
        //    Console.WriteLine($"레벨 : {level}");
        //    Console.WriteLine($"수량 : {count}");
        //}


        //static void Attack(string skillName, string target, int damage)
        //{
        //    Console.WriteLine($"✨ 스킬 발동: {skillName}");
        //    Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!");
        //}

        //static void Attack(string skillName, string target, float damage)
        //{
        //    Console.WriteLine($"✨ 스킬 발동: {skillName}");
        //    Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!!");
        //}

        //static void Attack(string skillName, string target, double damage)
        //{
        //    Console.WriteLine($"✨ 스킬 발동: {skillName}");
        //    Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!!!");
        //}

        //static void GreetPlayer(string name)
        //{
        //    Console.WriteLine($"환영합니다. {name}님!");
        //}

        //static void ShowPlayerInfo(string job, int level)
        //{
        //    Console.WriteLine($"직업 : {job}");
        //    Console.WriteLine($"레벨 : {level}");
        //}

        //static void DrawHealthBar(int current, int max, int barLenght)
        //{
        //    Console.Write("HP [");
        //    int filledLenght = (int)((double)current / max * barLenght);
        //    for(int i = 0; i < barLenght ; i++)
        //    {
        //        if(i< filledLenght)
        //        {
        //            Console.Write("■");
        //        }
        //        else
        //        {
        //            Console.Write("□");
        //        }
        //    }
        //    Console.WriteLine($"] {current} / {max}");
        //}

        //static void ShowDamage(string attacker, string target, int damage)
        //{
        //    Console.WriteLine($"{attacker}의 공격");
        //    Console.WriteLine($"{target}에게 {damage} 데미지");
        //}

        //static void printPlayerInfo(string name, int attackPower, int defense, int speed, int luck)
        //{
        //    Console.WriteLine($"플레이어이름 : {name} ");
        //    Console.WriteLine($"공격력 : {attackPower}");
        //    Console.WriteLine($"방어력 : {defense}");
        //    Console.WriteLine($"민첩 : {speed}");
        //    Console.WriteLine($"운 : {luck}");
        //}

    }
}

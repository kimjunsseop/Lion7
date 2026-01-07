using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sword = null;
            Random rnd = new Random();
            int random = 0;
            for(int i = 0; i < 20; i++)
            {
                random = rnd.Next(1, 101);
                if (random >= 90)
                {
                    sword = "무한의 대검";
                }
                else if(random >= 70)
                {
                    sword = "카타나";
                }
                else if(random >= 40)
                {
                    sword = "엑스칼리버";
                }
                else
                {
                    sword = "정기점검";
                }
                Console.WriteLine(sword);
                Thread.Sleep(500);
            }
            //Console.WriteLine("=== 게임 시작 카운트 다운===");
            //for(int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine($"{i}. . .");
            //}
            //Console.WriteLine("게임 시작");
            //int jobChoice = 0;
            //Console.Write("직업을 선택하시오 : ");
            //jobChoice = int.Parse(Console.ReadLine());
            //Console.WriteLine("=== 캐릭터 생성 ===");
            //switch(jobChoice)
            //{
            //    case 1:
            //        Console.WriteLine("직업 : 전사");
            //        Console.WriteLine("특성 : 강함");
            //        Console.WriteLine("주 무기 : 칼");
            //        Console.WriteLine("스탯 : 체력 + 100");
            //        break;
            //    case 2:
            //        Console.WriteLine("직업 : 궁수");
            //        Console.WriteLine("특성 : 날렵함");
            //        Console.WriteLine("주 무기 : 활");
            //        Console.WriteLine("스탯 : 민첩성 + 100");
            //        break;
            //    case 3:
            //        Console.WriteLine("직업 : 마법사");
            //        Console.WriteLine("특성 : 똑똑함");
            //        Console.WriteLine("주 무기 : 지팡이");
            //        Console.WriteLine("스탯 : 마법력 + 100");
            //        break;
            //    default:
            //        Console.WriteLine("직업 : 다시 입력하시오");
            //        break;
            //}
            //int level = 45;
            //string grade = (level > 50) ? "고급" : 
            //                (level > 30) ? "중급" : "초급";

            //Console.WriteLine("=== 플레이어 등급 ===");
            //Console.WriteLine($"레벨 : {level}");
            //Console.WriteLine($"등급 : {grade}");

            //int health = 30;
            //int maxHealth = 100;

            //string state = (health >= 70) ? "안전" :
            //                (health >= 30) ? "주의" : "위험";

            //Console.WriteLine("=== 플레이어 상태 ===");
            //Console.WriteLine($"{state}");

            //int baseDamage = 50;
            //int bonusDamage = 20;
            //double criticalMultiplier = 1.5;

            //// 잘못된 계산
            //double  damage1 = baseDamage + bonusDamage * criticalMultiplier;
            //// 올바른 계산
            //double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            //Console.WriteLine($"기본 데미지: {baseDamage}");
            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0

            //int score = 75;
            //if(score>=90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if(score>=80)
            //{
            //    Console.WriteLine("B학점");
            //}
            //else if(score>=70)
            //{
            //    Console.WriteLine("C학점");
            //}
            //else
            //{
            //    Console.WriteLine("F학점");
            //}

            //int health = 30;
            //int maxhealth = 100;
            //int enemydistance = 5;
            //int attackrange = 3;
            //console.writeline("** 실행 결과 **");
            //if(50 >= health)
            //{
            //    console.writeline("체력이 50% 이하입니다.");
            //}
            //else if(30 >= health)
            //{
            //    console.writeline("경고 : 체력이 위험합니다!");
            //}
            //else if(0 >= health)
            //{
            //    console.writeline("게임 오버");
            //}

            //if(attackrange >= enemydistance)
            //{
            //    console.writeline("적이 사거리 안에 있습니다!");
            //}
            //else
            //{
            //    console.writeline("범위 내 적이 없습니다!");
            //}

        }
    }
}

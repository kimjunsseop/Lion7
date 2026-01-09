using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열
            //int[] socores = new int[5];
            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //int[] values = { 1, 2, 3, 4, 5 };

            //string[] inventory = new string[5];

            //for(int i = 0; i < inventory.Length; i++)
            //{
            //    inventory[i] = Console.ReadLine();
            //}
            //for(int i = 0;i < inventory.Length; i++)
            //{
            //    Console.WriteLine(inventory[i]);
            //}

            //int[] arr = { 100, 50, 80, 60, 45 };

            //Console.WriteLine("=== 캐릭터 스탯 ===");
            //Console.WriteLine($"HP : {arr[0]}");
            //Console.WriteLine($"MP : {arr[1]}");
            //Console.WriteLine($"공격력 : {arr[2]}");
            //Console.WriteLine($"방어력 : {arr[3]}");
            //Console.WriteLine($"민첩 : {arr[4]}");



            //int[] score = { 85, 92, 78, 95, 88 };
            //int max = 0;
            //int min = 100;

            //for(int i = 0; i < score.Length; i++)
            //{
            //    if(score[i] < min)
            //    {
            //        min = score[i];
            //    }

            //    if(score[i] > max)
            //    {
            //        max = score[i];
            //    }
            //}
            //Console.WriteLine($"최고점 : {max}");
            //Console.WriteLine($"최저점 : {min}");
            //int[] sortedScores = (int[])score.Clone();
            //Array.Sort( sortedScores );
            //Console.WriteLine("정렬 후 :");
            //for(int i = 0;i < sortedScores.Length;i++)
            //{
            //    Console.WriteLine(sortedScores[i]);
            //}
            //Array.Reverse(sortedScores);
            //for (int i = 0; i < sortedScores.Length; i++)
            //{
            //    Console.WriteLine(sortedScores[i]);
            //}
            //foreach(int i in score)
            //{
            //
            //}
            //string[,] seats = { { "A1", "A2", "A3" }, { "B1", "B2", "B3" },
            //                { "C1", "C2", "C3" } };
            //Console.WriteLine("첫 번째 좌석: " + seats[0, 0]);
            //Console.WriteLine("중앙 좌석: " + seats[1, 1]);
            //Console.WriteLine("마지막 좌석: " + seats[2, 2]);

            //int[,] map = new int[5, 5]
            //            {
            //                { 0,0,1,0,0},
            //                { 0,2,1,0,3},
            //                { 0,0,1,0,0},
            //                { 1,1,1,0,0},
            //                { 0,0,0,0,9},
            //            };

            //Console.WriteLine("==던전맵==");
            //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");
            //Console.OutputEncoding = Encoding.UTF8;

            ////맵 출력
            //for (int y = 0; y < map.GetLength(0); y++)
            //{
            //    for (int x = 0; x < map.GetLength(1); x++)
            //    {
            //        switch (map[y, x])
            //        {
            //            case 0:
            //                Console.Write("⬜ ");
            //                break;
            //            case 1:
            //                Console.Write("⬛ ");
            //                break;
            //            case 2:
            //                Console.Write("👹 ");
            //                break;
            //            case 3:
            //                Console.Write("💎 ");
            //                break;
            //            case 9:
            //                Console.Write("🚪 ");
            //                break;
            //        }

            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("=== 성적표 ===");
            //string[] subject =  {"국어", "영어", "수학", "과학" };
            //string[] students = { "김철수", "이영희", "박민수" };
            //int[,] grade = { { 85, 90, 88, 92},
            //                { 78, 85, 90, 87 },
            //                { 92, 88, 95, 90 }};
            //double[] means = new double[3];
            //Console.Write("이름 ");
            //for(int i = 0; i < subject.Length; i++)
            //{
            //    Console.Write(subject[i] + "  ");
            //}
            //for(int i = 0; i < means.Length; i++)
            //{
            //    int sum = 0;
            //    for(int j = 0; j < grade.GetLength(1); j++)
            //    {
            //        sum += grade[i,j];
            //    }
            //    means[i] = (double)sum / 4;
            //}
            //Console.Write("평균");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //for(int i = 0; i < students.Length; i++)
            //{
            //    Console.Write(students[i] + " ");
            //    for(int j = 0; j < subject.Length; j++)
            //    {
            //        Console.Write(grade[i,j] + " ");
                    
            //    }
            //    Console.Write(means[i]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("=== 과목별 평균 ===");
            //for(int i = 0; i<subject.Length -1; i++)
            //{
            //    Console.WriteLine($"{subject[i]} : {means[i]}점");
            //}
            
            //List

            //List<string> inventory = new List<string>();
            //inventory.Add("회복 포션");
            //Console.WriteLine(inventory[0]);

            //Dictionary<string, int> stats = new Dictionary<string, int>();

            //stats.Add("HP", 150);
            //stats.Add("MP", 80);
            //stats.Add("공격력", 75);
            //Console.WriteLine("=== 캐릭터 스탯 ===");
            //foreach (KeyValuePair<string, int> pair in stats)
            //{
            //    Console.WriteLine($"{pair.Key}: {pair.Value}");
            //}
            //Console.WriteLine(stats["HP"]);

            Dictionary<string, int> store = new Dictionary<string, int>();
            Console.WriteLine("=== 상점 아이템 ===");
            store.Add("회복 포션", 50);
            store.Add("마나 포션", 40);
            store.Add("강철 검", 500);
            store.Add("가죽 갑옷", 300);
            store.Add("마법 반지", 1000);
            int myMoney = 600;
            foreach(var item in store)
            {
                Console.WriteLine($"{item.Key} : {item.Value} 골드");
            }

            string itemName = "강철 검";
            if(store.ContainsKey(itemName))
            {
                if (myMoney >= store[itemName])
                {
                    myMoney -= store[itemName];
                    Console.WriteLine(itemName + "구매 성공");
                    Console.WriteLine($"남은 골드 : {myMoney}");
                }
            }
        }
    }
}

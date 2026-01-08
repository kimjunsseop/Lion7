using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int targetX = 50;
            const int targetY = 20;
            int x = 10, y = 10;
            ConsoleKeyInfo keyInfo; // 키입력을 받을 변수

            Console.CursorVisible = false; // 콘솔에서 커서를 가린다

            while(true)
            {
                // 콘솔 클리어
                Console.Clear();

                // x, y 좌표에 맞게 커서위치 세팅
                Console.SetCursorPosition(x, y);

                // 그리기
                Console.Write("●");
                
                
                Console.SetCursorPosition(targetX, targetY);
                Console.Write("🏠");

                // 여기서 락걸린채 입력 대기, 밑에 로직 실행 후
                // 다시 콘솔 클리어 및 물체 그리기 + 집 그리기
                keyInfo = Console.ReadKey(true); // 키 입력받기

                if(x == targetX && y == targetY )
                {
                    Console.Clear();
                    Random rand = new Random();

                    Console.WriteLine(" 대장장이 키우기 ");

                    int pmoney = 100;
                    int input;
                    int rnd;

                    Thread.Sleep(500);


                    //무한반복
                    while (true)
                    {
                        Console.Clear(); //화면지우기
                        Console.WriteLine("1. 나무캐기 ");
                        Console.WriteLine("2. 장비뽑기 ");
                        Console.WriteLine("3. 나가기 ");
                        Console.Write("입력 : ");
                        input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 담기

                        if (input == 1) //나무캐기화면
                        {
                            while (true)
                            {
                                Console.WriteLine("나무캐기(엔터)");
                                Console.WriteLine("뒤로가기 x");

                                string str = Console.ReadLine();

                                pmoney += 100;
                                Console.WriteLine("소지금 : " + pmoney);
                                if (str == "x")
                                {
                                    Console.WriteLine("뒤로가기");
                                    break;
                                }


                            }
                        }
                        else if (input == 2)
                        {
                            //장비뽑기
                            if (pmoney >= 1000) //돈이 있는지 확인후 뽑기
                            {
                                pmoney -= 1000;

                                //20번 뽑기
                                for (int i = 1; i <= 20; i++)
                                {
                                    rnd = rand.Next(1, 101);

                                    if (rnd == 1) // 1퍼
                                    {
                                        Console.WriteLine("도끼등급 SSS");
                                    }
                                    else if (rnd >= 2 && rnd <= 6)
                                    {
                                        Console.WriteLine("도끼등급 SS");
                                    }
                                    else if (rnd >= 7 && rnd <= 17)
                                    {
                                        Console.WriteLine("도끼등급 S");
                                    }
                                    else if (rnd >= 18 && rnd <= 38)
                                    {
                                        Console.WriteLine("도끼등급 A");
                                    }
                                    else if (rnd >= 39 && rnd <= 69)
                                    {
                                        Console.WriteLine("도끼등급 B");
                                    }
                                    else
                                    {
                                        Console.WriteLine("도끼등급 C");
                                    }
                                    Thread.Sleep(500); //0.5초정도로 뽑혀라.

                                }


                            }
                            else
                            {
                                Console.WriteLine("돈이 부족합니다. \n");
                                Thread.Sleep(1000);
                            }
                        }
                        else if (input == 3)
                        {
                            Console.WriteLine("게임을 나갑니다.");
                            Environment.Exit(0);
                        }
                    }
                }

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y > 0) y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if(y < Console.WindowHeight - 1) y++;
                        break ;
                    case ConsoleKey.LeftArrow:
                        if(x > 0) x--;
                        break;
                    case ConsoleKey.RightArrow:
                        if(x < Console.WindowWidth - 1) x++;
                        break ;
                    case ConsoleKey.Spacebar:
                        Console.Write("미사일키");
                        break;
                    case ConsoleKey.Escape:
                        break;
                    default:
                        break;
                }

            }

        }
    }
}

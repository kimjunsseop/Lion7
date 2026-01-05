using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //상수
            //const int maxPlayer = 4;
            //const int startGold = 1000;
            //const string version = "1.0.0";
            //Console.WriteLine("=== 게임 설정 ===");
            //Console.WriteLine($"최대 플레이어: {maxPlayer}명");
            //Console.WriteLine($"시작 골드: {startGold}G");
            //Console.WriteLine($"버전: {version}");

            //int integerNum = 10;
            //float floatNum = 3.14f;
            //double doubleNum = 3.14159;

            //Console.WriteLine(integerNum);
            //Console.WriteLine(floatNum);
            //Console.WriteLine(doubleNum);

            //float moveSpeed = 5.5f;
            //double attackSpeed = 1.25;
            //decimal price = 12.99m;

            //Console.WriteLine("===  캐릭터 능력치 ===");
            //Console.WriteLine($"이동속도 : {moveSpeed}");
            //Console.WriteLine($"공격속도 : {attackSpeed}");
            //Console.WriteLine($"아이템 가격 : {price}");

            //Console.WriteLine("\n=== 타입별 최대값 ===");
            //Console.WriteLine($"byte Max : {byte.MaxValue}");
            //Console.WriteLine($"short Max : {short.MaxValue}");
            //Console.WriteLine($"int Max : {int.MaxValue}");
            //Console.WriteLine($"long Max : {long.MaxValue}");

            //char grade = 'A';
            //char symbol = '★';
            //char number = '9';
            //string playerName = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다!";
            //string emptyString = "";
            //Console.WriteLine("=== RPG 게임 ===");
            //Console.WriteLine($"플레이어: {playerName}");
            //Console.WriteLine($"등급: {grade}등급");
            //Console.WriteLine($"{welcomeMessage}");

            bool isRunning = true;
            bool isStopped = false;
            bool isKey = false;
            bool isAlived = true;
            int hp = 80;
            bool isOpen = true;
            bool isChasing = false;
            bool isHealthy = true;
            

            Console.WriteLine("=== 게임 상태 ===");
            Console.WriteLine($"게임 실행 중: {isRunning}");
            Console.WriteLine($"일시 정지: {isStopped}");
            Console.WriteLine($"열쇠 소지: {isKey}");
            Console.WriteLine($"문 열림: {isOpen}");
            Console.WriteLine($"플레이어 생존: {isAlived}");
            Console.WriteLine("=== 캐릭터 상태 ===");
            Console.WriteLine($"체력: {hp}");
            Console.WriteLine($"건강 상태: {isHealthy}");
            Console.WriteLine($"위험 상태: {isChasing}");

        }
    }
}

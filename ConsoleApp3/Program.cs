using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    //캐릭터 클래스정의
    //class Character
    //{
    //    // 필드 (Field): 클래스의 데이터
    //    private string name;
    //    private int level;
    //    private int hp;
    //    private int maxHP;
    //    private int mp;
    //    private int maxMP;

    //    // 메서드 (Method): 클래스의 기능
    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
    //        Console.WriteLine($"이름: {name}");
    //        Console.WriteLine($"레벨: {level}");
    //        Console.WriteLine($"HP: {hp}/{maxHP}");
    //        Console.WriteLine($"MP: {mp}/{maxMP}");
    //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
    //    }

    //    public Character()
    //    {
    //        name = "홍길동";
    //        level = 10;
    //        hp = 150;
    //        maxHP = 150;
    //        mp = 80;
    //        maxMP = 80;
    //    }

    //    public Character(string name, int level, int hp, int maxHP, int mp, int maxMP)
    //    {
    //        this.name = name;
    //        this.level = level;
    //        this.hp = hp;
    //        this.maxHP = maxHP;
    //        this.mp = mp;
    //        this.maxMP = maxMP;
    //    }

    //    public void TakeDamage(int damage)
    //    {
    //        hp -= damage;
    //        if (hp < 0) hp = 0;

    //        Console.WriteLine($"⚔️ {name}이(가) {damage} 데미지를 받았습니다!");
    //        Console.WriteLine($"   남은 HP: {hp}/{maxHP}");
    //    }


    //    public void Heal(int amount)
    //    {
    //        hp += amount;
    //        if (hp > maxHP) hp = maxHP;

    //        Console.WriteLine($"💚 {name}의 HP가 {amount} 회복되었습니다!");
    //        Console.WriteLine($"   현재 HP: {hp}/{maxHP}");
    //    }

    //}

    class Monster
    {
        public string name;
        public int level;
        public int hp;
        public int attack;
        public int defenes;
        public int expReward;

        public Monster()
        {
            name = "슬라임";
            level = 1;
            hp = 50;
            attack = 10;
            defenes = 5;
            expReward = 10;
        }

        public Monster(string monsterName, int monsterLevel)
        {
            this.name = monsterName;
            this.level = monsterLevel;
            hp = 50 * level;
            attack = 10 * level;
            defenes = 5 * level;
            expReward = 10 * level;
        }

        public void ShowStats()
        {
            Console.WriteLine($"{this.name} (Lv.{this.level})");
            Console.WriteLine($"    HP: {this.hp}");
            Console.WriteLine($"    공격력: {this.attack}");
            Console.WriteLine($"    방어력: {this.defenes}");
            Console.WriteLine($"    경험치: {this.expReward}");
        }
    }


    class Character
    {
        private int att;
        private int height;

        public virtual int Att
        {
            get
            {
                return att;
            }
            set
            {
                att = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
        }
        class Character2 : Character
        {
            public override int Att
            {
                get
                {
                    return base.Att;
                }
                set
                {
                    if (value > 0)
                    {
                        base.Att = value;
                    }
                }
            }
        }

        class Student
        {
            private string name;
            private int score;
            private char grade;

            public string Name
            {
                get
                {
                    return name;
                }
            }
            public int Score
            {
                get
                {
                    return score;
                }
                set
                {
                    if(value >= 0 && value <= 100)
                    {
                        score = value;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
            public char Grade
            {
                get
                {
                    return Grade;
                }
                set
                {
                    if (value >= 90)
                    {
                        grade = 'A';
                    }
                    else if(value >= 80)
                    {
                        grade = 'B';
                    }
                    else if(value >=70)
                    {
                        grade = 'C';
                    }
                    else if (value >= 60)
                    {
                        grade = 'D';
                    }
                    else
                    {
                        grade = 'F';
                    }
                }
            }

            public Student(string studentNmae)
            {
                this.name = studentNmae;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"━━━━━━━━━━━━━━━━");
                Console.WriteLine($"이름: {this.name}");
                Console.WriteLine($"점수: {this.score}");
                Console.WriteLine($"등급: {this.grade}");
                Console.WriteLine($"━━━━━━━━━━━━━━━━");
            }
        }

        class Test
        {
            // 자동 프로퍼티
            public string Name { get; set; }

            //읽기전용 프로퍼티
            public int Age { get; }//private set; }

            public Test(int age)
            {
                Age = age;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                ////절차 지향 프로그래밍 vs 객체지향방식

                //// 객체 생성
                //Character player1 = new Character();


                //// 메서드 호출 출력 
                //player1.ShowInfo();

                ////데미지 50
                //player1.TakeDamage(50);

                ////힐 30
                //player1.Heal(30);

                ////새로운객체 생성해서 임의값 입력후 출력
                //Character player2 = new Character("김영희", 15, 200, 200, 120, 120);

                //player2.ShowInfo();
                ////오류난곳 해결해보기 !
                ///
                //Monster mon = new Monster();
                //mon.ShowStats();

                //Monster mon2 = new Monster("고블린", 5);
                //mon2.ShowStats();

                //Monster[] monsters = new Monster[3];

                //monsters[0] = new Monster("늑대", 3);
                //monsters[1] = mon;
                //monsters[2] = mon2;
                //for(int i = 0; i < 3; i++)
                //{
                //    monsters[i].ShowStats();
                //}

                //Character c = new Character();
                //c.Att = 1;
                //Console.WriteLine("공격력 : " + c.Att);

                //Student student = new Student("홍길동");

                //student.Score = 95;
                //student.ShowInfo();

                //Console.WriteLine();

                //student.Score = 75;
                //student.ShowInfo();

                //Console.WriteLine();

                //// 잘못된 값 입력 시도
                //student.Score = 150;  // 100으로 제한되어야 함
                //student.Score = -10;  // 0으로 제한되어야 함
                //student.ShowInfo();
                //Test t = new Test(10);
                //t.Name = "kim";
                //Console.WriteLine(t.Name);
                //Console.WriteLine(t.Age);
              
            }
        }
    }
}
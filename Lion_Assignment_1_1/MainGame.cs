using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1_1
{
    public class MainGame
    {
        public Player m_pPlayer = null;
        public Field m_pField = null;
        public Store store = null;

        public void Initialize()
        {
            SelectJob(out m_pPlayer);
        }
        public void SelectJob(out Player m_pPlayer)
        {
            Console.WriteLine("★★★ RPG ★★★");
            Console.WriteLine("직업을 선택하세요(1.전사 2.마법사 3.닌자 4.궁수) :");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    m_pPlayer = new Warrior();
                    break;
                case 2:
                    m_pPlayer = new Wizard();
                    break;
                case 3:
                    m_pPlayer = new Thief();
                    break;
                case 4:
                    m_pPlayer = new Archer();
                    break;
                default:
                    m_pPlayer = new Player();
                    break;
            }
        }

        public void Progress()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                Console.WriteLine("1.사냥터 2.상점 3. 인벤토리 4. 내정보 5. 종료 : ");
                iInput = int.Parse(Console.ReadLine());
                switch (iInput)
                {
                    case 1:
                        {
                            if (m_pField == null)
                            {
                                m_pField = new Field();
                                m_pField.SetPlayer(m_pPlayer);
                            }
                            m_pField.Progress();
                        }
                        break;
                    case 2:
                        // 상점 오픈
                        if (store == null)
                        {
                            store = new Store();
                        }
                        store.entraceStore(m_pPlayer);
                        store.Show();
                        break;
                    case 3:
                        m_pPlayer.inventory.Progress(m_pPlayer);
                        break;
                    case 4:
                        m_pPlayer.ShowDetail();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

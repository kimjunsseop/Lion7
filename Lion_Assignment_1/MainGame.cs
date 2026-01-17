using Lion_Assignment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1
{
    class MainGame
    {
        public Player m_pPlayer = null;
        public Field m_pField = null;
        public Store store = null;

        public void Initialize()
        {
            m_pPlayer = new Player();
            m_pPlayer.SelectJob();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Yacht
{
    class Program
    {
        static void AsciYacht()
        {
            Console.WriteLine("YYYYYYY       YYYYYYY                                      hhhhhhh                      tttt          ");
            Console.WriteLine("Y:::::Y       Y:::::Y                                      h:::::h                   ttt:::t          ");
            Console.WriteLine("Y:::::Y       Y:::::Y                                      h:::::h                   t:::::t          ");
            Console.WriteLine("Y::::::Y     Y::::::Y                                      h:::::h                   t:::::t          ");
            Console.WriteLine(" YY:::::Y   Y:::::YY   aaaaaaaaaaaaa       cccccccccccccccc h::::h hhhhh       ttttttt:::::ttttttt    ");
            Console.WriteLine("   Y:::::Y Y:::::Y     a::::::::::::a    cc:::::::::::::::c h::::hh:::::hhh    t:::::::::::::::::t    ");
            Console.WriteLine("    Y:::::Y:::::Y      aaaaaaaaa:::::a  c:::::::::::::::::c h::::::::::::::hh  t:::::::::::::::::t    ");
            Console.WriteLine("     Y:::::::::Y                a::::a c:::::::cccccc:::::c h:::::::hhh::::::h tttttt:::::::tttttt    ");
            Console.WriteLine("      Y:::::::Y          aaaaaaa:::::a c::::::c     ccccccc h::::::h   h::::::h      t:::::t          ");
            Console.WriteLine("       Y:::::Y         aa::::::::::::a c:::::c              h:::::h     h:::::h      t:::::t          ");
            Console.WriteLine("       Y:::::Y        a::::aaaa::::::a c:::::c              h:::::h     h:::::h      t:::::t          ");
            Console.WriteLine("       Y:::::Y       a::::a    a:::::a c::::::c     ccccccc h:::::h     h:::::h      t:::::t    tttttt");
            Console.WriteLine("       Y:::::Y       a::::a    a:::::a c:::::::cccccc:::::c h:::::h     h:::::h      t::::::tttt:::::t");
            Console.WriteLine("    YYYY:::::YYYY    a:::::aaaa::::::a  c:::::::::::::::::c h:::::h     h:::::h      tt::::::::::::::t");
            Console.WriteLine("    Y:::::::::::Y     a::::::::::aa:::a  cc:::::::::::::::c h:::::h     h:::::h        tt:::::::::::tt");
            Console.WriteLine("    YYYYYYYYYYYYY      aaaaaaaaaa  aaaa    cccccccccccccccc hhhhhhh     hhhhhhh          ttttttttttt  \n");
        } // Yacht 아스키 아트

        static void YatchRule()
        {
            Console.WriteLine("[YATCH 룰]");
            Console.WriteLine("1. 주사위 5개를 던진다\n");
            Console.WriteLine("2. 이 중 원하는 주사위들은 고정해 두고 나머지 주사위들을 다시 던진다. \n   다시 던지기는 한 라운드에 두 번까지 가능하며, 앞에서 고정했던 주사위도 원한다면 고정을 풀어 다시 던질 수 있다.\n");
            Console.WriteLine("3. 이렇게 해서 나온 값을 반드시 점수판에 기록해야한다. 기록할 칸이 없는 경우 아무칸에 0으로 기록한다.");
            Console.WriteLine("※기록 방법 : 점수판의 족보 이름 앞에 있는 숫자/기호를 입력한다. 기록이 완료되면 아무 키나 눌러 나온 후 이어서 진행한다.");
            Console.WriteLine("4. 점수판이 12칸이니 총 12라운드를 하면 게임이 끝난다. 점수판의 점수 총합이 더 큰 플레이어가 승자가 된다.");
            Console.WriteLine("[족보]");
            Console.WriteLine("이름             설명                                                            예시"          );
            Console.WriteLine("Aces            1이 나온 주사위 눈의 합                                         2 2 3 5 6 = 0점" );
            Console.WriteLine("Deuces          2이 나온 주사위 눈의 합                                         2 2 2 2 5 = 8점" );
            Console.WriteLine("Threes          3이 나온 주사위 눈의 합                                         1 3 3 3 4 = 9점" );
            Console.WriteLine("Fours           4이 나온 주사위 눈의 합                                         2 3 4 4 4 = 12점");
            Console.WriteLine("Fives           5이 나온 주사위 눈의 합                                         3 4 5 5 5 = 15점");
            Console.WriteLine("Sixes           6이 나온 주사위 눈의 합                                         1 2 3 6 6 = 12점");
            Console.WriteLine("보너스          상단항목에서 합이 63점이 넘을 경우 35점을 추가한다.\n"                               );
            Console.WriteLine("Choice          주사위 5개의 눈의 총합                                          2 2 3 5 6 = 18점");
            Console.WriteLine("Four Of A Kind  주사위 4개 이상의 눈이 동일할 때, 주사위 5개의 합               3 3 3 3 5 = 17점"   );
            Console.WriteLine("Full House      눈이 동일한 주사위가 각각 3개와 2개가 있을 때, 주사위 5개의 합  2 2 2 3 3 = 12점"     );
            Console.WriteLine("Small Straight  주사위 4개 이상의 눈이 이어지는 수일 때, 고정 15점              1 2 3 4 6 = 15점"   );
            Console.WriteLine("Large Straight  주사위 5개의 눈이 이어지는 수일 때, 고정 30점                   2 3 4 5 6 = 30점"   );
            Console.WriteLine("Yacht           주사위 5개의 눈이 모두 같을 때, 고정 50점                       4 4 4 4 4 = 50점"  );
            Console.WriteLine("\n뒤로 가려면 아무 키나 눌러주세요...");
            Console.ReadKey();
        } // Yacht 규칙 설명

        static void ChoiceMode(User User1) 
        {
            while (true)
            {
                int Round = 12;
                Console.Clear();
                AsciYacht();
                Console.WriteLine("1.싱글 플레이");
                Console.WriteLine("2.2P 플레이");
                Console.WriteLine("3.3P 플레이");
                Console.WriteLine("4.4P 플레이");
                Console.WriteLine("0.뒤로 가기");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // 싱글 플레이
                        AI AI1 = new AI();
                        for (int i = 0; i < Round; i++)
                        {
                            User1.Roll(User1, AI1, i + 1);
                            //AI1.Roll(User1, AI1);
                        }
                        Console.Clear();
                        Console.WriteLine("\n\n개발중입니다....");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2: // 2P 플레이
                        User User2_2 = new User("User 2");
                        for (int i = 0; i < Round; i++)
                        {
                            User1.Roll(User1, User2_2, i + 1);
                            User2_2.Roll(User1, User2_2, i + 1);
                        }
                        User1.ScoreBoard(User1, User2_2, 13); // 결과 출력(세번째 인자값이 12를 넘으면 결과값으로 변함)
                        break;
                    case ConsoleKey.D3: // 3P 플레이
                        User User3_2 = new User("User 2");
                        User User3_3 = new User("User 3");
                        for (int i = 0; i < Round; i++)
                        {
                            User1.Roll(User1, User3_2, User3_3, i + 1);
                            User3_2.Roll(User1, User3_2, User3_3, i + 1);
                            User3_3.Roll(User1, User3_2, User3_3, i + 1);
                        }
                        Console.Clear();
                        Console.WriteLine("\n\n개발중입니다....");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4: // 4P 플레이
                        User User4_2 = new User("User 2");
                        User User4_3 = new User("User 3");
                        User User4_4 = new User("User 4");
                        for (int i = 0; i < Round; i++)
                        {
                            User1.Roll(User1, User4_2, User4_3, User4_4, i + 1);
                            User4_2.Roll(User1, User4_2, User4_3, User4_4, i + 1);
                            User4_3.Roll(User1, User4_2, User4_3, User4_4, i + 1);
                            User4_4.Roll(User1, User4_2, User4_3, User4_4, i + 1);
                        }
                        Console.Clear();
                        Console.WriteLine("\n\n개발중입니다....");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D0: // 뒤로 가기
                        return;
                    default:
                        Console.WriteLine("위에 나와있는 숫자만 입력해 주세요.");
                        break;
                } // 모드 선택에 따라 Roll실행
            }
        } // 모드 선택 - > 모드에 따른 Roll실행

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                AsciYacht();
                Console.WriteLine("1. 게임 시작");
                Console.WriteLine("2. 게임 룰");
                Console.WriteLine("0. 게임 종료");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        User User1 = new User("User 1");
                        ChoiceMode(User1);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        YatchRule();
                        break;
                    case ConsoleKey.D0:
                        return;
                    default:
                        Console.WriteLine("위에 나와있는 숫자만 입력해 주세요.");
                        break;
                }
            }
        }
    }
}

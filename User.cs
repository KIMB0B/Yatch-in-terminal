using System;

namespace Cs_Yacht
{
    class User : Player
    {
        public User(string _Name)
        {
            Name = _Name;
        }
        public void Roll(User _User1, AI _AI, int Round)
        {

        } //싱글플레이의 Roll

        public void Roll(User _User1, User _User2, int Round)
        {
            Console.Clear();
            Random rand = new Random();
            int position = 0;
            RollCount = 0;
            for (int i = 0; i < Dice.Length; i++)
            {
                Lock[i] = 0;
                Dice[i] = 0;
            }//Dice, Lock배열 0으로 초기화

            while (RollCount < 4) //4이상이면 턴 종료
            {
                Console.WriteLine("\n[" + Round + "라운드] " + Name + " 이(가) 주사위를 던질 차례 (" + RollCount + "/3)\n\n");

                if(RollCount == 0) 
                {
                    for (int i = 0; i < Dice.Length; i++)
                    {
                        Console.Write("6       ");
                    }
                }//첫 턴일땐 주사위 전부 6으로 맞춤
                else
                {
                    for (int i = 0; i < Dice.Length; i++)
                    {
                        Console.Write(Dice[i] + "       ");
                    }
                }// 첫 턴이 아니면 Dice[i]의 수를 출력
                Console.WriteLine();

                for (int i = 0; i < Dice.Length; i++)
                {
                    if (Lock[i] == 1)
                    {
                        Console.Write("ㅡ      ");
                    }
                    else
                    {
                        Console.Write("        ");
                    }
                }// Lock이 걸린 위치는 밑줄, 아니면 공백
                Console.WriteLine();

                for (int i = 0; i < Dice.Length; i++)
                {
                    if (position == i)
                    {
                        Console.Write("↑      ");
                    }
                    else
                    {
                        Console.Write("        ");
                    }
                }//position의 위치에 화살표, 아니면 공백
                Console.WriteLine();

                Console.WriteLine("\n\n\n\n\n<- : 화살표 왼쪽 이동  -> : 화살표 오른쪽 이동  SpaceBar : 화살표가 가리킨 숫자 고정  \n\nR : 주사위 굴리기  B : 점수판 보기/족보 선택하기");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (position > 0)
                        {
                            position -= 1;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (position < Dice.Length - 1)
                        {
                            position += 1;
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        if (RollCount > 0)
                        {
                            if (Lock[position] == 0)
                            {
                                Lock[position] = 1;
                            }
                            else
                            {
                                Lock[position] = 0;
                            }
                        }
                        break;
                    case ConsoleKey.B:
                        ScoreBoard(_User1, _User2, Round);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        if (RollCount < 3)
                        {
                            for (int i = 0; i < Dice.Length; i++)
                            {
                                if (Lock[i] == 0)
                                {
                                    Dice[i] = rand.Next(1, 7);
                                }
                            }
                            RollCount++;
                        }
                        break;
                    default:
                        break;
                }// 입력된 키에 따라 행동(좌이동, 우이동, Lock, Roll, Board)
                Console.Clear();
            }
        } //2P 플레이의 Roll

        public void Roll(User _User1, User _User2, User _User3, int Round)
        {

        } //3P 플레이의 Roll

        public void Roll(User _User1, User _User2, User _User3, User _User4, int Round)
        {

        } //4P 플레이의 Roll

    }
}

using System;

namespace Cs_Yacht
{
    class Player
    {
        protected int Aces = 0, Deuces = 0, Threes = 0, Fours = 0, Fives = 0, Sixes = 0, SubTotal = 0, Bonus = 0;
        protected int Choice = 0, FOAK = 0, FullHouse = 0, SStraight = 0, LStraight = 0, Yacht = 0, Total = 0, RollCount = 0, AddCount = 0;

        protected int TAces = 0, TDeuces = 0, TThrees = 0, TFours = 0, TFives = 0, TSixes = 0;
        protected int TChoice = 0, TFOAK = 0, TFullHouse = 0, TSStraight = 0, TLStraight = 0, TYacht = 0;

        protected int PAces = 0, PDeuces = 0, PThrees = 0, PFours = 0, PFives = 0, PSixes = 0;
        protected int PChoice = 0, PFOAK = 0, PFullHouse = 0, PSStraight = 0, PLStraight = 0, PYacht = 0;

        protected int[] Dice = new int[5] { 0, 0, 0, 0, 0 };
        protected int[] Lock = new int[5] { 0, 0, 0, 0, 0 };
        protected string Name;

        static void WinAsci()
        {
            Console.WriteLine("`8.`888b                 ,8'            8 8888           b.             8 ");
            Console.WriteLine(" `8.`888b               ,8'             8 8888           888o.          8 ");
            Console.WriteLine("  `8.`888b             ,8'              8 8888           Y88888o.       8 ");
            Console.WriteLine("   `8.`888b     .b    ,8'               8 8888           .`Y888888o.    8 ");
            Console.WriteLine("    `8.`888b    88b  ,8'                8 8888           8o. `Y888888o. 8 ");
            Console.WriteLine("     `8.`888b .`888b,8'                 8 8888           8`Y8o. `Y88888o8 ");
            Console.WriteLine("      `8.`888b8.`8888'                  8 8888           8   `Y8o. `Y8888 ");
            Console.WriteLine("       `8.`888`8.`88'                   8 8888           8      `Y8o. `Y8 ");
            Console.WriteLine("        `8.`8' `8,`'                    8 8888           8         `Y8o.` ");
            Console.WriteLine("         `8.`   `8'                     8 8888           8            `Yo ");
        }

        static void DrawAsci()
        {
            Console.WriteLine("8 888888888o.      8 888888888o.            .8.          `8.`888b                 ,8' ");
            Console.WriteLine("8 8888    `^888.   8 8888    `88.          .888.          `8.`888b               ,8'  ");
            Console.WriteLine("8 8888        `88. 8 8888     `88         :88888.          `8.`888b             ,8'   ");
            Console.WriteLine("8 8888         `88 8 8888     ,88        . `88888.          `8.`888b     .b    ,8'    ");
            Console.WriteLine("8 8888          88 8 8888.   ,88'       .8. `88888.          `8.`888b    88b  ,8'     ");
            Console.WriteLine("8 8888          88 8 888888888P'       .8`8. `88888.          `8.`888b .`888b,8'      ");
            Console.WriteLine("8 8888         ,88 8 8888`8b          .8' `8. `88888.          `8.`888b8.`8888'       ");
            Console.WriteLine("8 8888        ,88' 8 8888 `8b.       .8'   `8. `88888.          `8.`888`8.`88'        ");
            Console.WriteLine("8 8888    ,o88P'   8 8888   `8b.    .888888888. `88888.          `8.`8' `8,`'         ");
            Console.WriteLine("8 888888888P'      8 8888     `88. .8'       `8. `88888.          `8.`   `8'          ");
        }

        public void ScoreBoard(Player _User1, Player _User2, int Round)
        {
            Console.Clear();
            if (Round < 13)
            {
                TAces = 0; TDeuces = 0; TThrees = 0; TFours = 0; TFives = 0; TSixes = 0;
                TChoice = 0; TFOAK = 0; TFullHouse = 0; TSStraight = 0; TLStraight = 0; TYacht = 0;

                if (Dice[0] > 0)
                {
                    for (int i = 0; i < Dice.Length; i++)
                    {
                        switch (Dice[i])
                        {
                            case 1:
                                TAces += 1;
                                break;
                            case 2:
                                TDeuces += 2;
                                break;
                            case 3:
                                TThrees += 3;
                                break;
                            case 4:
                                TFours += 4;
                                break;
                            case 5:
                                TFives += 5;
                                break;
                            case 6:
                                TSixes += 6;
                                break;
                            default:
                                break;

                        }//Aces ~ Sixes

                        TChoice += Dice[i];// Choice

                        if (Dice[i] == 2)
                        {
                            for (int j = 0; j < Dice.Length; j++)
                            {
                                if (Dice[j] == 3)
                                {
                                    for (int k = 0; k < Dice.Length; k++)
                                    {
                                        if (Dice[k] == 4)
                                        {
                                            for (int l = 0; l < Dice.Length; l++)
                                            {
                                                if (Dice[l] == 5)
                                                {
                                                    for (int m = 0; m < Dice.Length; m++)
                                                    {
                                                        if (Dice[m] == 6 || Dice[m] == 1)
                                                        {
                                                            TLStraight = 30;
                                                            TSStraight = 15;
                                                        }
                                                    }
                                                    if (TLStraight != 30)
                                                    {
                                                        TSStraight = 15;
                                                    }
                                                }
                                                else if (Dice[l] == 1)
                                                {
                                                    TSStraight = 15;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }// LStraight, SStraight2345, 3456

                        if (Dice[i] == 1)
                        {
                            for (int j = 0; j < Dice.Length; j++)
                            {
                                if (Dice[j] == 2)
                                {
                                    for (int k = 0; k < Dice.Length; k++)
                                    {
                                        if (Dice[k] == 3)
                                        {
                                            for (int l = 0; l < Dice.Length; l++)
                                            {
                                                if (Dice[l] == 4)
                                                {
                                                    TSStraight = 15;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }// SStraight1234
                    }

                    int YCount = 0; //Dice[0]과 같은 수 count
                    int ENumber = 0; //Dice[0]와 다른 마지막 수
                    int ECount = 0; //ENumber와 같은 수 count
                    for (int i = 0; i < Dice.Length - 1; i++)
                    {
                        if (Dice[0] == Dice[i + 1])
                        {
                            YCount++;
                        }
                        else
                        {
                            ENumber = Dice[i + 1];
                        }
                    } //같은 숫자 카운트 -> YCount

                    if (YCount == 4)
                    {
                        TYacht = 50;
                    } // Yacht

                    if (YCount >= 3)
                    {
                        for (int i = 0; i < Dice.Length; i++)
                        {
                            TFOAK += Dice[i];
                        }
                    } // 첫번째 주사위를 포함한 FOAK
                    else
                    {
                        if (Dice[1] == Dice[2] && Dice[2] == Dice[3] && Dice[3] == Dice[4])
                        {
                            for (int i = 0; i < Dice.Length; i++)
                            {
                                TFOAK += Dice[i];
                            }
                        }
                    } // 첫번째 주사위만 다른 FOAK

                    if (YCount == 2)
                    {
                        for (int i = 0; i < Dice.Length; i++)
                        {
                            if (ENumber == Dice[i])
                            {
                                ECount++;
                            }
                        }
                        if (ECount == 2)
                        {
                            for (int i = 0; i < Dice.Length; i++)
                            {
                                TFullHouse += Dice[i];
                            }
                        }
                    } // 첫번째 주사위 수가 3개인 FullHouse
                    else if (YCount == 1)
                    {
                        for (int i = 0; i < Dice.Length; i++)
                        {
                            if (ENumber == Dice[i])
                            {
                                ECount++;
                            }
                        }
                        if (ECount == 3)
                        {
                            for (int i = 0; i < Dice.Length; i++)
                            {
                                TFullHouse += Dice[i];
                            }
                        }
                    } // 첫번째 주사위 수가 2개인 FullHouse
                } // 족보에따른 TScore 계산
            } // 라운드 진행 중일때 TScore 초기화 후 족보에 따른 TScore 계산

            else
            {
                if (_User1.Total > _User2.Total)
                {
                    WinAsci();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (_User1.Total == _User2.Total)
                {
                    DrawAsci();
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    WinAsci();
                    Console.ReadKey();
                    Console.Clear();
                }
            } // 12라운드 끝난 후 결과 출력

            void TurnWrite()
            {
                if (Round < 13)
                {
                    Console.WriteLine("ㅣ    Turn     ㅣ      ㅣ      ㅣ");
                }
            }

            void RoundWrite()
            {
                if (Round < 13)
                {
                    Console.WriteLine("ㅣ  " + Round.ToString("D2") + " / 12    ㅣ      ㅣ      ㅣ");
                }
                else
                {
                    Console.WriteLine("ㅣ   Result    ㅣ      ㅣ      ㅣ");
                }
            }

            void NameWrite(string Name1, string Name2)
            {
                Console.Write("ㅣ-------------ㅣ");
                if (Name1 == Name)
                {
                    if (Round < 13)
                        Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(Name1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ㅣ");
                if (Name2 == Name)
                {
                    if (Round < 13)
                        Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(Name2);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("ㅣ");
            }//2인용 보드에 Name줄 출력(본인 턴에 빨간 색 됨)

            void ScoreWrite(string _Name, int Score1, int TScore1, int PScore1, int Score2, int TScore2, int PScore2)
            {
                Console.Write(_Name);
                if (PScore1 != 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(TScore1.ToString("D2"));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(Score1.ToString("D2"));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("  ㅣ  ");
                if (PScore2 != 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(TScore2.ToString("D2"));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(Score2.ToString("D2"));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("  ㅣ");
            } //2인용 보드에 Score있는 줄 출력 함수(점수 입력시 색 바뀜)

            void RenderBoard()
            {
                Console.WriteLine(" _______________________________");
                TurnWrite();
                Console.WriteLine("ㅣ             ㅣ      ㅣ      ㅣ");
                RoundWrite();
                NameWrite(_User1.Name, _User2.Name);
                Console.WriteLine("ㅣCategorise   ㅣ      ㅣ      ㅣ");
                Console.WriteLine("ㅣ-------------ㅣ------ㅣ------ㅣ");
                ScoreWrite("ㅣ1.Aces       ㅣ  ", _User1.Aces, _User1.TAces, _User1.PAces, _User2.Aces, _User2.TAces, _User2.PAces);
                ScoreWrite("ㅣ2.Deuces     ㅣ  ", _User1.Deuces, _User1.TDeuces, _User1.PDeuces, _User2.Deuces, _User2.TDeuces, _User2.PDeuces);
                ScoreWrite("ㅣ3.Threes     ㅣ  ", _User1.Threes, _User1.TThrees, _User1.PThrees, _User2.Threes, _User2.TThrees, _User2.PThrees);
                ScoreWrite("ㅣ4.Fours      ㅣ  ", _User1.Fours, _User1.TFours, _User1.PFours, _User2.Fours, _User2.TFours, _User2.PFours);
                ScoreWrite("ㅣ5.Fives      ㅣ  ", _User1.Fives, _User1.TFives, _User1.PFives, _User2.Fives, _User2.TFives, _User2.PFives);
                ScoreWrite("ㅣ6.Sixes      ㅣ  ", _User1.Sixes, _User1.TSixes, _User1.PSixes, _User2.Sixes, _User2.TSixes, _User2.PSixes);
                Console.WriteLine("ㅣ-------------ㅣ------ㅣ------ㅣ");
                Console.WriteLine("ㅣSubtotal     ㅣ " + _User1.SubTotal.ToString("D2") + "/63ㅣ " + _User2.SubTotal.ToString("D2") + "/63ㅣ");
                Console.WriteLine("ㅣ+35 Bonus    ㅣ +" + _User1.Bonus.ToString("D2") + "  ㅣ +" + _User2.Bonus.ToString("D2") + "  ㅣ");
                Console.WriteLine("ㅣ-------------ㅣ------ㅣ------ㅣ");
                ScoreWrite("ㅣ7.Choice     ㅣ  ", _User1.Choice, _User1.TChoice, _User1.PChoice, _User2.Choice, _User2.TChoice, _User2.PChoice);
                ScoreWrite("ㅣ8.4 of a Kindㅣ  ", _User1.FOAK, _User1.TFOAK, _User1.PFOAK, _User2.FOAK, _User2.TFOAK, _User2.PFOAK);
                ScoreWrite("ㅣ9.Full House ㅣ  ", _User1.FullHouse, _User1.TFullHouse, _User1.PFullHouse, _User2.FullHouse, _User2.TFullHouse, _User2.PFullHouse);
                ScoreWrite("ㅣ0.S. Straightㅣ  ", _User1.SStraight, _User1.TSStraight, _User1.PSStraight, _User2.SStraight, _User2.TSStraight, _User2.PSStraight);
                ScoreWrite("ㅣ-.L. Straightㅣ  ", _User1.LStraight, _User1.TLStraight, _User1.PLStraight, _User2.LStraight, _User2.TLStraight, _User2.PLStraight);
                ScoreWrite("ㅣ=.Yacht      ㅣ  ", _User1.Yacht, _User1.TYacht, _User1.PYacht, _User2.Yacht, _User2.TYacht, _User2.PYacht);
                Console.WriteLine("ㅣ-------------ㅣ------ㅣ------ㅣ");
                Console.WriteLine("ㅣ             ㅣ      ㅣ      ㅣ");
                Console.WriteLine("ㅣTotal        ㅣ " + _User1.Total.ToString("D3") + "  ㅣ " + _User2.Total.ToString("D3") + "  ㅣ");
                Console.WriteLine("ㅣ_____________ㅣ______ㅣ______ㅣ");
            } //점수판 출력

            RenderBoard();

            if (Round < 13)
            {
                if (RollCount != 0)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            if (PAces == 0)
                            {
                                Aces = TAces;
                                PAces = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;
                        case ConsoleKey.D2:
                            if (PDeuces == 0)
                            {
                                Deuces = TDeuces;
                                PDeuces = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;
                        case ConsoleKey.D3:
                            if (PThrees == 0)
                            {
                                Threes = TThrees;
                                PThrees = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;
                        case ConsoleKey.D4:
                            if (PFours == 0)
                            {
                                Fours = TFours;
                                PFours = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;
                        case ConsoleKey.D5:
                            if (PFives == 0)
                            {
                                Fives = TFives;
                                PFives = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;

                        case ConsoleKey.D6:
                            if (PSixes == 0)
                            {
                                Sixes = TSixes;
                                PSixes = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;

                        case ConsoleKey.D7:
                            if (PChoice == 0)
                            {
                                Choice = TChoice;
                                PChoice = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;

                        case ConsoleKey.D8:
                            if (PFOAK == 0)
                            {
                                FOAK = TFOAK;
                                PFOAK = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;

                        case ConsoleKey.D9:
                            if (PFullHouse == 0)
                            {
                                FullHouse = TFullHouse;
                                PFullHouse = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;

                        case ConsoleKey.D0:
                            if (PSStraight == 0)
                            {
                                SStraight = TSStraight;
                                PSStraight = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;

                        case ConsoleKey.OemMinus:
                            if (PLStraight == 0)
                            {
                                LStraight = TLStraight;
                                PLStraight = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;

                        case ConsoleKey.OemPlus:
                            if (PYacht == 0)
                            {
                                Yacht = TYacht;
                                PYacht = 1;
                                RollCount = 4;
                                SubTotal = Aces + Deuces + Threes + Fours + Fives + Sixes;
                                if (SubTotal > 62)
                                    Bonus = 35;
                                Total = Aces + Deuces + Threes + Fours + Fives + Sixes + Choice + FOAK + FullHouse + SStraight + LStraight + Yacht + Bonus;
                                Console.Clear();
                                RenderBoard();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                ScoreBoard(_User1, _User2, Round);
                            }
                            break;

                        default:
                            return;

                    }
                } // Roll을 한번 이상 했을때 Board창 입력에 따른 행동
                else
                {
                    Console.ReadKey();
                    Console.Clear();
                } // Roll을 한번도 안하고 입력했을때

                /*******턴이 넘어가면서 Tscore 초기화(안할 시 턴이 넘어가도 전 플레이어 Tscore 초기화 안됨)********/
                TAces = 0; TDeuces = 0; TThrees = 0; TFours = 0; TFives = 0; TSixes = 0;
                TChoice = 0; TFOAK = 0; TFullHouse = 0; TSStraight = 0; TLStraight = 0; TYacht = 0;
            } // 라운드 진행 중일때 보드 입력값에 따른 행동 후 Tscore 초기화

            else
            {
                if (_User1.Total > _User2.Total)
                {
                    Console.WriteLine("" + _User1.Name + "님이 이겼습니다!");
                    Console.WriteLine("1. 메인 화면으로");
                    Console.WriteLine("2. 게임 종료");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            break;
                        case ConsoleKey.D2:
                            Environment.Exit(0);
                            break;
                    }
                }// User1이 이겼을때

                else if (_User1.Total == _User2.Total)
                {
                    Console.WriteLine("" + _User1.Name + "님과 " + _User2.Name + "님이 비겼습니다!");
                    Console.WriteLine("1. 메인 화면으로");
                    Console.WriteLine("2. 게임 종료");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            break;
                        case ConsoleKey.D2:
                            Environment.Exit(0);
                            break;
                    }
                }// 비겼을때

                else
                {
                    Console.WriteLine("" + _User2.Name + "님이 이겼습니다!");
                    Console.WriteLine("1. 메인 화면으로");
                    Console.WriteLine("2. 게임 종료");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            break;
                        case ConsoleKey.D2:
                            Environment.Exit(0);
                            break;
                    }
                }// User2가 이겼을때
            } // 12라운드 끝난 후 누가 이겼는지 출력 후 메뉴OR게임종료
        } // 2P플레이 점수판 출력 후 점수 기록 함수
    }
}
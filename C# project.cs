using System;

namespace MyGameDice

{
    class GameGoUp
    {
        int playerMark;
        void setPlayerMark(int score)
        {
            this.playerMark = score;
        }
        int setPlayerMark()
        {
            return playerMark;
        }
        static void Main(String[] args)
        {
            int player1Mark = 0;

            int player2Mark = 0;

            GameGoUp P1 = new GameGoUp();
            GameGoUp P2 = new GameGoUp();

            void participant1()
            {
                int val_1dice = 0;
                int val_2dice = 0;

                Random randNumR = new Random();

                while (true)
                {
                    Console.WriteLine("Hey  MEMBER 1 press any key to continue..");
                    Console.ReadKey();

                    val_1dice = randNumR.Next(1, 7);
                    val_2dice = randNumR.Next(1, 7);
                    Console.WriteLine("\nDice 1 Mark : " + val_1dice);
                    Console.WriteLine("Dice 2 Mark : " + val_2dice + "\n");

                    if (val_1dice == 1 && val_2dice == 1)
                    {
                        P1.setPlayerMark(0);
                        participant2();
                    }
                    else if (val_1dice == val_2dice)
                    {
                        Console.WriteLine("If two dices gives the Same Value. \nroll dices again. ");

                        val_1dice = randNumR.Next(1, 7);
                        val_2dice = randNumR.Next(1, 7);

                        Console.WriteLine("\nDice 1 Mark : " + val_1dice);
                        Console.WriteLine("Dice 2 Mark : " + val_2dice + "\n");

                        if (val_1dice == 1 && val_2dice == 1)
                        {
                            P1.setPlayerMark(0);
                            participant2();
                        }
                        else if (val_1dice == val_2dice)
                        {
                            participant1();
                        }
                        else
                        {
                            player1Mark = val_1dice + val_2dice;
                            P1.setPlayerMark(P1.setPlayerMark() + player1Mark);
                        }
                    }
                    else
                    {
                        player1Mark = val_1dice + val_2dice;
                        P1.setPlayerMark(P1.setPlayerMark() + player1Mark);
                    }
                    Console.WriteLine("\nMember 1 Score : " + player1Mark);
                    Console.WriteLine("Hey  MEMBER 1 Total Marks : " + P1.setPlayerMark());
                    break;
                }
            }

            void participant2()
            {
                int val_1dice = 0;
                int val_2dice = 0;

                Random randNumR = new Random();

                while (true)
                {
                    Console.WriteLine("Hey  MEMBER 2 press any key to continue..");
                    Console.ReadKey();

                    val_1dice = randNumR.Next(1, 7);
                    val_2dice = randNumR.Next(1, 7);
                    Console.WriteLine("\nDice 1 Mark : " + val_1dice);
                    Console.WriteLine("Dice 2 Mark : " + val_2dice + "\n");

                    if (val_1dice == 1 && val_2dice == 1)
                    {
                        P2.setPlayerMark(0);
                        participant1();
                    }
                    else if (val_1dice == val_2dice)
                    {
                        Console.WriteLine("Two dices gives the Same Value. \nroll dices again. ");

                        val_1dice = 3;
                        val_2dice = 3;
                        Console.WriteLine("\nDice 1 Mark : " + val_1dice);
                        Console.WriteLine("Dice 2 Mark : " + val_2dice + "\n");

                        if (val_1dice == 1 && val_2dice == 1)
                        {
                            P2.setPlayerMark(0);
                            participant1();
                        }
                        else if (val_1dice == val_2dice)
                        {
                            participant2();
                        }
                        else
                        {
                            player2Mark = val_1dice + val_2dice;
                            P2.setPlayerMark(P2.setPlayerMark() + player2Mark);
                        }
                    }
                    else
                    {
                        player2Mark = val_1dice + val_2dice;
                        P2.setPlayerMark(P2.setPlayerMark() + player2Mark);
                    }
                    Console.WriteLine("\nMember 2 Mark : " + player2Mark);
                    Console.WriteLine("Hey  MEMBER 2 Total Marks : " + P2.setPlayerMark());
                    break;
                }
            }


            void letsGo()
            {
                Console.WriteLine("  Hi , this is for 2 player Game - 2.0");
                Console.WriteLine("SELECT option and press ENTER KEY");
                Console.WriteLine("1. play game now");
                Console.WriteLine("2. quit game now");

                int option = 0;
                while (true)
                {
                    option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        game();
                    }
                    else if (option == 2)
                    {
                        break;
                    }
                    else
                    {
                        option = 0;
                    }
                }
            }

            void game()
            {
                int j = 0;
                while (true)
                {
                    if (j == 0)
                    {
                        participant1();
                        j++;
                    }
                    else if (j == 1)
                    {
                        participant2();
                        j--;
                    }

                    if (P1.setPlayerMark() > 100 || P2.setPlayerMark() > 100)
                    {
                        Console.WriteLine("End game");
                        if (P1.setPlayerMark() > 100)
                        {
                            Console.WriteLine("\n###Congragulation###     Participant 1 is the Winner!!!");
                            Console.WriteLine("Hey  MEMBER 1 total marks :" + P1.setPlayerMark());
                            Console.WriteLine("Hey  MEMBER 2 total marks :" + P2.setPlayerMark());
                        }
                        else if (P2.setPlayerMark() > 100)
                        {
                            Console.WriteLine("\n###Congragulation###     Participant 2 is the Winner!!!");
                            Console.WriteLine("Hey  MEMBER 1 total marks :" + P1.setPlayerMark());
                            Console.WriteLine("Hey  MEMBER 2 total marks :" + P2.setPlayerMark());
                        }
                        letsGo();
                        break;
                    }
                }
            }

            letsGo();

        }
    }

}

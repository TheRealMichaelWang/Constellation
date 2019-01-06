using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class TicTacToe
    {
        static string[] movestxt =
        {
            "4,4._",
            "R,4.X,0._,1._,2._,3._,5._,6._,7._,8._",
            "0,1.X,2.X,0._",
            "0,4.X,8.X,0._",
            "0,3.X,6.X,0._",
            "0,1.O,2.O,0._",
            "0,4.O,8.O,0._",
            "0,3.O,4.O,0._",
            "1,0.X,2.X,1._",
            "1,4.X,7.X,1._",
            "1,0.O,2.O,1._",
            "1,4.O,7.O,1._",
            "2,0.X,1.X,2._",
            "2,4.X,6.X,2._",
            "2,5.X,8.X,2._",
            "2,0.O,1.O,2._",
            "2,4.O,6.O,2._",
            "2,5.O,8.O,2._",
            "3,4.X,5.X,3._",
            "3,0.X,6.X,3._",
            "3,4.O,5.O,3._",
            "3,0.O,6.O,3._",
            "4,3.X,5.X,4._",
            "4,1.X,7.X,4._",
            "4,0.X,8.X,4._",
            "4,2.X,6.X,4._",
            "4,3.O,5.O,4._",
            "4,1.O,7.O,4._",
            "4,0.O,8.O,4._",
            "4,2.O,6.O,4._",
            "5,4.X,3.X,5._",
            "5,2.X,8.X,5._",
            "5,4.O,3.O,5._",
            "5,2.O,8.O,5._",
            "6,0.X,3.X,6._",
            "6,7.X,8.X,6._",
            "6,4.X,2.X,6._",
            "6,4.O,2.O,6._",
            "6,0.O,3.O,6._",
            "6,7.O,8.O,6._",
            "7,6.X,8.X,7._",
            "7,4.X,1.X,7._",
            "7,6.O,8.O,7._",
            "7,4.O,1.O,7._",
            "8,6.X,7.X,8._",
            "8,5.X,2.X,8._",
            "8,4.X,0.X,8._",
            "8,6.O,7.O,8._",
            "8,5.O,2.O,8._",
            "8,4.O,0.O,8._"
        };
        static Random random = new Random();

        static string row1 = "___";
        static string row2 = "___";
        static string row3 = "___";

        static string collum1
        {
            get
            {
                return row1[0].ToString() + row2[0].ToString() + row3[0].ToString();
            }
            set
            {
                row1 = value[0].ToString() + row1[1].ToString() + row1[2].ToString();
                row2 = value[1].ToString() + row2[1].ToString() + row2[2].ToString();
                row3 = value[2].ToString() + row3[1].ToString() + row3[2].ToString();
            }
        }
        static string collum2
        {
            get
            {
                return row1[1].ToString() + row2[1].ToString() + row3[1].ToString();
            }
            set
            {
                row1 = row1[0].ToString() + value[0].ToString() + row1[2].ToString();
                row2 = row2[0].ToString() + value[1].ToString() + row2[2].ToString();
                row3 = row3[0].ToString() + value[2].ToString() + row3[2].ToString();
            }
        }
        static string collum3
        {
            get
            {
                return row1[2].ToString() + row2[2].ToString() + row3[2].ToString();
            }
            set
            {
                row1 = row1[0].ToString() + row1[1].ToString() + value[0].ToString();
                row2 = row2[0].ToString() + row2[1].ToString() + value[1].ToString();
                row3 = row3[0].ToString() + row3[1].ToString() + value[2].ToString();
            }
        }

        static bool draw = false;

        /// <summary>
        /// Draws the tic tack toes 9 squares.
        /// </summary>
        static void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_______");
            Console.WriteLine("|" + row1[0] + "|" + row1[1] + "|" + row1[2] + "|");
            Console.WriteLine("|" + row2[0] + "|" + row2[1] + "|" + row2[2] + "|");
            Console.WriteLine("|" + row3[0] + "|" + row3[1] + "|" + row3[2] + "|");
        }
        /// <summary>
        /// Checks if X is the winner.
        /// </summary>
        /// <returns>bool</returns>
        static bool XWin()
        {
            if (row1.Contains("XXX") || row2.Contains("XXX") || row3.Contains("XXX"))
            {
                return true;
            }
            if (collum1.Contains("XXX") || collum2.Contains("XXX") || collum3.Contains("XXX"))
            {
                return true;
            }
            if (row1[0] == 'X' && row2[1] == 'X' && row3[2] == 'X')
            {
                return true;
            }
            if (row1[2] == 'X' && row2[1] == 'X' && row3[0] == 'X')
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Checks if O is the winner.
        /// </summary>
        /// <returns>bool</returns>
        static bool OWin()
        {
            if (row1.Contains("OOO") || row2.Contains("OOO") || row3.Contains("OOO"))
            {
                return true;
            }
            if (collum1.Contains("OOO") || collum2.Contains("OOO") || collum3.Contains("OOO"))
            {
                return true;
            }
            if (row1[0] == 'O' && row2[1] == 'O' && row3[2] == 'O')
            {
                return true;
            }
            if (row1[2] == 'O' && row2[1] == 'O' && row3[0] == 'O')
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Marks a square
        /// </summary>
        /// <param name="i">Index</param>
        /// <param name="tic">Character to Mark With</param>
        static void Mark(int i, char tic)
        {
            if (i == 0)
            {
                row1 = tic + row1[1].ToString() + row1[2].ToString();
                return;
            }
            if (i == 1)
            {
                row1 = row1[0].ToString() + tic + row1[2].ToString();
                return;
            }
            if (i == 2)
            {
                row1 = row1[0].ToString() + row1[1].ToString() + tic;
                return;
            }
            if (i == 3)
            {
                row2 = tic + row2[1].ToString() + row2[2].ToString();
                return;
            }
            if (i == 4)
            {
                row2 = row2[0].ToString() + tic + row2[2].ToString();
                return;
            }
            if (i == 5)
            {
                row2 = row2[0].ToString() + row2[1].ToString() + tic;
                return;
            }
            if (i == 6)
            {
                row3 = tic + row3[1].ToString() + row3[2].ToString();
                return;
            }
            if (i == 7)
            {
                row3 = row3[0].ToString() + tic + row3[2].ToString();
                return;
            }
            if (i == 8)
            {
                row3 = row3[0].ToString() + row3[1].ToString() + tic;
                return;
            }
        }
        /// <summary>
        /// Gets the value of a square
        /// </summary>
        /// <param name="i">The index of the square</param>
        /// <returns></returns>
        static char Square(int i)
        {
            if (i == 0)
            {
                return row1[0];
            }
            if (i == 1)
            {
                return row1[1];
            }
            if (i == 2)
            {
                return row1[2];
            }
            if (i == 3)
            {
                return row2[0];
            }
            if (i == 4)
            {
                return row2[1];
            }
            if (i == 5)
            {
                return row2[2];
            }
            if (i == 6)
            {
                return row3[0];
            }
            if (i == 7)
            {
                return row3[1];
            }
            if (i == 8)
            {
                return row3[2];
            }
            return '-';
        }
        static void MakeMove()
        {
            string[] lines = movestxt;
            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] args = line.Split(',');
                    if (VerifyMove(args))
                    {
                        return;
                    }
                }
            }
        }
        static bool VerifyMove(string[] args)
        {
            for (int i = 1; i < args.Length; i++)
            {
                string[] ark = args[i].Split('.');
                if (Square(int.Parse(ark[0])) != ark[1][0])
                {
                    return false;
                }
            }
            if (args[0] != "R")
            {
                if (Square(int.Parse(args[0])) == 'O')
                {
                    return false;
                }
                Mark(int.Parse(args[0]), 'O');
            }
            else
            {
                RandomMove();
            }
            return true;
        }

        static void RandomMove()
        {
            int i = random.Next(0, 9);
            if (Square(i) == '_')
            {
                Mark(i, 'O');
            }
            else
            {
                try
                {
                    RandomMove();
                }
                catch (StackOverflowException)
                {

                }
            }
        }

        public void Main()
        {
            string input = "";
            bool turn = false;
            Console.Clear();
            Console.WriteLine("Tic Tac Toe\n(C) Michael Wang\n\nPress any key to continue");
            Console.ReadKey();
            while (input != "exit")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Game On");
                Draw();
                if (turn)
                {
                    var boardstatea = row1 + row2 + row3;
                    MakeMove();
                    var boardstateb = row1 + row2 + row3;
                    if (boardstatea == boardstateb)
                    {
                        RandomMove();
                    }
                    turn = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(">");
                    input = Console.ReadLine();
                    try
                    {
                        int i = int.Parse(input);
                        Mark(i, 'X');
                    }
                    catch
                    {
                        Console.WriteLine("HA! YOU TRIED TO CRASH THE PROGRAM... I'LL SKIP YOUR TURN");
                        Console.ReadKey();
                    }
                    turn = true;
                }
                if (draw)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Draw");
                    Draw();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Any Key to Exit");
                    break;
                }
                if (OWin())
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O has won");
                    Draw();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Any Key to Exit");
                    break;
                }
                if (XWin())
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("X has won");
                    Draw();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Any Key to Exit");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}

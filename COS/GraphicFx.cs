using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class GraphicFx
    {
        public string graphicsoption = "standard";
        public void Standard()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ReadKey();
        }
        public void Matrix()
        {
            Tools tools = new Tools();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            while(true)
            {
                for (int j = 1; j <= 7; j++)
                {
                    for (int s = 1; s <= 8; s++)
                    {
                        if(Console.KeyAvailable)
                        {
                            return;
                        }
                        if (tools.RandomInt()==1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        int n = tools.RandomInt();
                        Console.Write(n);
                    }
                    if (j != 7)
                    {
                        Console.Write("    ");
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class BuiltInApps
    {
        Random random;
        ThreadManager manager;
        public BuiltInApps()
        {
            random = new Random();
            manager = new ThreadManager();
        }

        public void Random()
        {
            Console.Clear();
            Console.WriteLine("Random\nThis generates a random number.");
            while (true)
            {
                Console.Write("home/random>");
                string inp = Console.ReadLine();
                if (inp == "exit")
                {
                    return;
                }
                if(inp == "help")
                {
                    Console.WriteLine("You just sit back and press Enter.");
                }
                else if(inp == "threadmanager")
                {
                    manager.OpenThreadManager("Random Generator","home/random","This application generates random numbers.");
                }
                else if(inp == "bin")
                {
                    Console.WriteLine(random.Next(2));
                }
                else
                {
                    for(int i = 0; i < 20; i++)
                    {
                        random.Next();
                    }
                    Console.WriteLine("Rand: " + random.Next());
                }
            }
        }
        public void Calculator()
        {
            Console.Clear();
            Console.WriteLine("Desktop Calculator\nWrite 'exit' to exit and 'help' for help.");
            while (true)
            {
                Console.Write("home/calculator>");
                string inp = Console.ReadLine();
                if (inp == "" || inp == "exit")
                {
                    return;
                }
                if (inp == "help")
                {
                    Console.WriteLine("Seperate each term and function with a space. These are the supported functions; '*', '/', '+', and '-'.");
                }
                else if (inp == "threadmanager")
                {
                    manager.OpenThreadManager("Calculator", "home/calculator", "This application is a basic desktop calculator.");
                }
                else
                {
                    string[] args = inp.Split(' ');
                    try
                    {
                        double a = double.Parse(args[0]);
                        for (int i = 1; i < args.Length; i++)
                        {
                            if (args[i] == "*")
                            {
                                a = a * double.Parse(args[i + 1]);
                            }
                            if (args[i] == "/")
                            {
                                a = a / double.Parse(args[i + 1]);
                            }
                            if (args[i] == "+")
                            {
                                a = a + double.Parse(args[i + 1]);
                            }
                            if (args[i] == "-")
                            {
                                a = a - double.Parse(args[i + 1]);
                            }
                        }
                        Console.WriteLine("= " + a);
                    }
                    catch
                    {
                        Console.WriteLine("Err 002");
                    }
                }
            }
        }

        public void Timer()
        {
            Console.Clear();
            Console.WriteLine("Timer\nType in how many ticks you want to wait. Write 'exit' to exit and 'help' for help");
            while (true)
            {
                Console.Write("home/timer>");
                string inp = Console.ReadLine();
                if (inp == "" || inp == "exit")
                {
                    return;
                }
                if(inp == "help")
                {
                    Console.WriteLine("WAIT         Waits for a given amount of seconds");
                    Console.WriteLine("NOW          Displays the current datetime");
                    Console.WriteLine("UTC          Displays the current uct time");
                }
                if(inp == "now")
                {
                    Console.WriteLine("Current Time: " + DateTime.Now);
                }
                if(inp == "utc")
                {
                    Console.WriteLine("Current UTC: " + DateTime.UtcNow);
                }
                if(inp == "threadmanager")
                {
                    manager.OpenThreadManager("Timer", "home/timer", "System Timer");
                }
                if (inp == "wait")
                {
                    try
                    {
                        Console.Write("home/timer/seconds>");
                        int seconds = int.Parse(Console.ReadLine());
                        DateTime other = DateTime.Now;
                        DateTime waitill = other.AddSeconds(seconds);
                        Console.Clear();
                        Console.WriteLine("Waiting...");
                        while (DateTime.Now!=waitill)
                        {
                            Console.Clear();
                            Console.WriteLine(DateTime.Now);
                        }
                        Console.Clear();
                        Console.WriteLine("Timer Done");
                    }
                    catch
                    {
                        Console.WriteLine("Err 2");
                    }
                }
            }
        }

        public void Statistics()
        {
            Console.Clear();
            Console.WriteLine("Desktop Statistics\nWrite 'exit' to exit and 'help' for help.");
            while (true)
            {
                Console.Write("home/stat>");
                string inp = Console.ReadLine();
                if (inp == "" || inp == "exit")
                {
                    return;
                }
                if (inp == "help")
                {
                    Console.WriteLine("Seperate each term with a ','. Desktop Statistics can then calculate factors");
                }
                else
                {
                    string[] args = inp.Split(',');
                    try
                    {
                        double total = 0;
                        double min = 100;
                        double max = -100;
                        foreach (string arg in args)
                        {
                            if (double.Parse(arg) < min)
                            {
                                min = double.Parse(arg);
                            }
                            if (double.Parse(arg) > max)
                            {
                                max = double.Parse(arg);
                            }
                            total = total + double.Parse(arg); 
                        }
                        
                        Console.WriteLine("Statistic Results");
                        Console.WriteLine("Count: " + args.Length);
                        Console.WriteLine("Total Value: " + total);
                        Console.WriteLine("Mean: " + (total / args.Length));
                        Console.WriteLine("Range: " + (max - min));
                        Console.WriteLine("Min: " + min);
                        Console.WriteLine("Max: " + max);
                    }
                    catch
                    {
                        Console.WriteLine("Err 2");
                    }
                }
            }
        }
    }
}

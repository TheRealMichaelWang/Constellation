using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class ComEx
    {
        public ComEx()
        {

        }
        static List<string> varnames = new List<string>();
        static List<string> varvalues = new List<string>();
        static string[] program = { "" };
        static string iterationmsg = "This iteration has ended. Pres ESC to quit. Do this if th program doen't quit itself.";
        static string GetValue(string name)
        {
            for (int i = 0; i < varnames.Count; i++)
            {
                if (varnames[i] == name)
                {
                    return varvalues[i];
                }
            }
            return "not-found";
        }
        static void SetValue(string name, string value)
        {
            for (int i = 0; i < varnames.Count; i++)
            {
                if (varnames[i] == name)
                {
                    varvalues[i] = value;
                }
            }
        }
        public void Main(string[] args)
        {
            program = args;
            if(program[0] == "comex -warn")
            {
                Console.WriteLine("This program has been marked with the warn mark. Running this program may force you to restart.\nPress escape to return home.");
                ConsoleKey key = Console.ReadKey().Key;
                if(key == ConsoleKey.Escape)
                {
                    return;
                }
            }
            if (program[0].StartsWith("comex"))
            {
                while (true)
                {
                    for (int i = 1; i < program.Length; i++)
                    {
                        string line = program[i];
                        string[] comargs = line.Split(' ');
                        if (comargs[0] != "loop" && comargs[0] != "if" && comargs[0] != "stop")
                        {
                            Execute(comargs);
                        }
                        else
                        {
                            if (comargs.Length == 1)
                            {
                                if (comargs[0] == "stop")
                                {
                                    return;
                                }
                            }
                            if (comargs.Length == 2)
                            {
                                if (comargs[0] == "loop")
                                {
                                    for (double x = 0; x < double.Parse(comargs[1]); x++)
                                    {
                                        Execute(program[i + 1].Split(' '));
                                    }
                                }
                            }
                            if (comargs.Length == 4)
                            {
                                if (comargs[0] == "if")
                                {
                                    if (GetValue(comargs[1]) == comargs[3])
                                    {
                                        if (comargs[2] == "==")
                                        {
                                            Execute(program[i + 1].Split(' '));
                                        }
                                    }
                                    else if (comargs[2] == "!=")
                                    {
                                        Execute(program[i + 1].Split(' '));
                                    }
                                }
                            }
                            i = i + 1;
                        }
                    }
                    Console.WriteLine(iterationmsg);
                    ConsoleKey consoleKey = Console.ReadKey().Key;
                    if(consoleKey == ConsoleKey.Escape)
                    {
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("This isn't a COMEX program\nERR 3");
            }
        }
        static void Execute(string[] comargs)
        {
            if (comargs.Length == 3)
            {
                if (comargs[0] == "var")
                {
                    varnames.Add(comargs[1]);
                    varvalues.Add(comargs[2]);
                }
                if (comargs[0] == "prdouble")
                {
                    if (comargs[1] == "text:")
                    {
                        Console.WriteLine(comargs[2]);
                    }
                    if (comargs[1] == "var:")
                    {
                        Console.WriteLine(GetValue(comargs[2]));
                    }
                }
            }
            if (comargs.Length == 4)
            {
                if (comargs[1] == "=")
                {
                    if (comargs[2] == "prompt")
                    {
                        Console.WriteLine(comargs[3]);
                        SetValue(comargs[0], Console.ReadLine());
                    }
                    if (comargs[2] == "var:")
                    {
                        SetValue(comargs[0], GetValue(comargs[3]));
                    }
                    if (comargs[2] == "text:")
                    {
                        SetValue(comargs[0], comargs[1]);
                    }
                }
            }
            if (comargs.Length == 5)
            {
                if (comargs[1] == "=")
                {
                    double a;
                    try
                    {
                        a = double.Parse(GetValue(comargs[2]));
                    }
                    catch
                    {
                        a = double.Parse(comargs[2]);
                    }
                    var func = comargs[3];
                    double b;
                    try
                    {
                        b = double.Parse(GetValue(comargs[4]));
                    }
                    catch
                    {
                        b = double.Parse(comargs[4]);
                    }
                    if (func == "*" || func == "times")
                    {
                        SetValue(comargs[0], (a * b).ToString());
                    }
                    if (func == "+" || func == "plus")
                    {
                        SetValue(comargs[0], (a + b).ToString());
                    }
                    if (func == "/" || func == "divby")
                    {
                        SetValue(comargs[0], (a / b).ToString());
                    }
                    if (func == "-" || func == "minus")
                    {
                        SetValue(comargs[0], (a - b).ToString());
                    }
                    if (func == "^")
                    {
                        SetValue(comargs[0], ((int)a ^ (int)b).ToString());
                    }
                }
            }
            if (comargs.Length == 1)
            {
                if (comargs[0] == "rdkey")
                {
                    Console.ReadKey();
                }
                if (comargs[0] == "cls" || comargs[0] == "clear")
                {
                    Console.Clear();
                }
            }
        }
    }
}

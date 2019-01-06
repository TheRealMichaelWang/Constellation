using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class SignInSheet
    {
        List<string> sheet;
        ThreadManager threadManager;
        public SignInSheet()
        {
            sheet = new List<string>();
            threadManager = new ThreadManager();
        }
        public bool Registered(string name)
        {
            foreach(string person in sheet)
            {
                string[] args = person.Split(',');
                if(args[0] == name)
                {
                    return true;
                }
            }
            return false;
        }
        public bool SignedIn(string name)
        {
            foreach (string person in sheet)
            {
                string[] args = person.Split(',');
                if (args[0] == name && args.Length == 2)
                {
                    return true;
                }
            }
            return false;
        }
        public int GetListIndex(string name)
        {
            for(int i = 0; i < sheet.Count; i++)
            {
                string[] args = sheet[i].Split(',');
                if(args[0] == name)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Start(NoteBook book)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Sign In Sheet Application\nConsetellation OS (C) Michael Wang\nWrite 'help' for help\n");
                Console.Write("name>");
                string inp = Console.ReadLine();
                if(inp == "exit")
                {
                    return;
                }
                if (inp == "help")
                {
                    Console.WriteLine("Just type in your name, and well do the rest for you. Note that all names are case sensitive, such as 'Michael Wang' won't match 'michael wang'.");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                }
                else if(inp == "peek")
                {
                    Console.Clear();
                    Console.WriteLine("Sign In Sheet");
                    foreach(string person in sheet)
                    {
                        string[] args = person.Split(',');
                        if(args.Length == 2)
                        {
                            Console.WriteLine("Name: " + args[0] + ".\nSigned In: " + args[1] + ". Signed Out: N/A.");
                        }
                        else if(args.Length == 3)
                        {
                            Console.WriteLine("Name: " + args[0] + ".\nSigned In: " + args[1] + ". Signed Out: " + args[2]);
                        }
                        else
                        {
                            Console.WriteLine("CORRUPT POSITION; RAW: "+person);
                        }
                    }
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                }
                else if(inp=="threadmanager")
                {
                    threadManager.OpenThreadManager("Sign In Sheet","signinsheet","This application helps easy sign in and easy sign outs.");
                }
                else if(inp == "save")
                {
                    book.book.Add(sheet);
                }
                else if(inp == "clear")
                {
                    sheet = new List<string>();
                }
                else
                {
                    if(!Registered(inp))
                    {
                        sheet.Insert(0,inp + "," + DateTime.Now);
                        Console.WriteLine("Thank you for signing in");
                    }
                    else
                    {
                        if(SignedIn(inp))
                        {
                            sheet[GetListIndex(inp)] += ","+DateTime.Now;
                            Console.WriteLine("Good Bye. Thank you for signing out.");
                        }
                        else
                        {
                            sheet.Insert(0, inp + "," + DateTime.Now);
                            Console.WriteLine("Welcome back, " + inp + ". Sign in and sign out procedures are still the same.");
                        }
                    }
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                }
            }
        }
    }
}

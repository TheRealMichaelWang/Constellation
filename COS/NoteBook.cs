using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace COS
{
    class NoteBook
    {
        public List<List<string>> book;
        public List<List<string>> appdata;
        ThreadManager threadManager;
        
        public NoteBook()
        {
            book = new List<List<string>>();
            threadManager = new ThreadManager();
            appdata = new List<List<string>>();
        }
        public void StartApp()
        {
            Console.Clear();
            Console.WriteLine("My NoteBook\nWrite 'help' for help");
            while (true)
            {
                Console.Write("notebook>");
                string inp = Console.ReadLine();
                string[] args = inp.Split(' ');
                if(inp == "threadmanager")
                {
                    threadManager.OpenThreadManager("NoteBook","notebook","NoteBook (or My NoteBook) is a word processing program built for consellation OS.");
                }
                if(inp == "exit")
                {
                    return;
                }
                if(inp == "help")
                {
                    Console.WriteLine("ALL          Prints the entire notebook.");
                    Console.WriteLine("PEEK         Prints out all the text on the given page.");
                    Console.WriteLine("EDIT         Edits the text on a page.");
                    Console.WriteLine("NEW          Makes a new page.");
                    Console.WriteLine("EXIT         Exits the notebook app.");
                    Console.WriteLine("CLEAR        Clears the console");
                    Console.WriteLine("CLS          Clears the console.");
                    Console.WriteLine("CLEARBOOK    Clears your notebook");
                }
                if(inp == "new")
                {
                    book.Add(MakePage());
                }
                if(inp == "clear"||inp == "cls")
                {
                    Console.Clear();
                }
                if(inp == "all")
                {
                    int pagenum = 1;
                    foreach(List<string> page in book)
                    {
                        PrintPage(page);
                        Console.WriteLine("PAGE: "+pagenum+"\n");
                        pagenum++;
                    }
                }
                if(inp == "clearbook")
                {
                    book = new List<List<string>>();
                }
                if(args.Length == 2)
                {
                    if (args[0] == "edit")
                    {
                        try
                        {
                            book[int.Parse(args[1]) - 1] = MakePage(book[int.Parse(args[1]) - 1]);
                        }
                        catch
                        {
                            Console.WriteLine("That page doesn't exist");
                        }
                    }
                    if (args[0] == "peek")
                    {
                        try
                        {
                            PrintPage(book[int.Parse(args[1])-1]);
                        }
                        catch
                        {
                            Console.WriteLine("That page doesn't exist.");
                        }
                    }
                }
            }
        }
        public void PrintPage(List<string> page)
        {
            foreach(string line in page)
            {
                Console.WriteLine(line);
            }
        }
        public List<string> MakePage()
        {
            Console.WriteLine("Write 'done' once you are finished");
            List<string> toret = new List<string>();
            string inp = "";
            int line = 1;
            while(true)
            {
                Console.Write("notebook/write>line" + line + ">");
                inp = Console.ReadLine();
                if(inp == "done")
                {
                    break;
                }
                toret.Add(inp);
                line++;
            }
            return toret;
        }
        public List<string> MakePage(List<string> original)
        {
            Console.WriteLine("Write 'done' once you are finished, 'keep' to keep the original line, and 'cancel' to cancel the operation");
            List<string> toret = new List<string>();
            string inp = "";
            int line = 1;
            while (true)
            {
                Console.Write("notebook/write>line" + line + ">");
                inp = Console.ReadLine();
                if (inp == "done")
                {
                    break;
                }
                if(inp == "cancel")
                {
                    return original;
                }
                if(inp == "keep")
                {
                    try
                    {
                        inp = original[line-1];
                        Console.Write("Kept>" + inp);
                        Console.WriteLine();
                    }
                    catch
                    {
                        Console.WriteLine("Original file doens't go that far.");
                    }
                }
                toret.Add(inp);
                line++;
            }
            return toret;
        }
    }
}

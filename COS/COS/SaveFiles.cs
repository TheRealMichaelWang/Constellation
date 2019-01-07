using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace COS
{
    class SaveFiles
    {
        string filesystem = "0:\\";
        public SaveFiles()
        {

        }
        public void SaveNotebook(NoteBook book)
        {
            Tools tools = new Tools();
            int pagenum = 1;
            Console.WriteLine("Making Count File");
            File.WriteAllText(@"0:\notebookcount.dat", book.book.Count.ToString());
            foreach(List<string> page in book.book)
            {
                Console.WriteLine("Saving page " + pagenum.ToString());
                try
                {
                    File.WriteAllLines(filesystem+"page" + pagenum.ToString(), tools.ListToArray(page));
                }
                catch
                {

                }
                pagenum++;
            }
            Console.WriteLine("Done");
        }
        public void LoadNotebook(NoteBook book)
        {
            Tools tools = new Tools();
            book.book = new List<List<string>>();
            Console.WriteLine("Loading Count File");
            int lenght = int.Parse(File.ReadAllText(@filesystem+"notebookcount.dat"));
            for(int i = 1; i <=lenght; i++)
            {
                Console.WriteLine("Loading page " + i.ToString());
                try
                {
                    book.book.Add(tools.ArrayToList(File.ReadAllLines(@"0:\page"+i.ToString())));
                }
                catch
                {
                    
                }
            }
            Console.WriteLine("Done");
        }
        public string GetGfxSettings()
        {
            Console.WriteLine("Loading Graphics Settings");
            if(!File.Exists(filesystem+"graphics.dat"))
            {
                Console.WriteLine("Making Files");
                File.WriteAllText(filesystem + "graphics.dat","standard");
            }
            Console.WriteLine("Done");
            return File.ReadAllText(filesystem + "graphics.dat");
        }
        public void SaveGfxSettings(string settings)
        {
            Console.WriteLine("Saving Graphics Settings");
            File.WriteAllText(filesystem + "graphics.dat", settings);
            Console.WriteLine("Done");
        }
        public void SaveLogs(SystemLogger logger)
        {
            Tools tools = new Tools();
            File.WriteAllLines(filesystem + "logs.dat",tools.ListToArray(logger.log));
        }
        public void StartDiskManager()
        {
            Console.WriteLine("Disk Manager");
            while(true)
            {
                Console.Write(filesystem + ">");
                string input = Console.ReadLine();
                if(input == "filelist")
                {
                    string[] files = Directory.GetFiles(filesystem);
                    foreach(string file in files)
                    {
                        Console.WriteLine(file);
                    }
                }
                else if(input.StartsWith("del "))
                {
                    string path = input.TrimStart("del ".ToCharArray());
                    try
                    {
                        File.Delete(filesystem+path);
                    }
                    catch
                    {

                    }
                }
                else if(input.StartsWith("peek "))
                {
                    string path = input.TrimStart("peek ".ToCharArray());
                    try
                    {
                        Console.WriteLine(File.ReadAllText(filesystem + path));
                    }
                    catch
                    {

                    }
                }
                else if(input.StartsWith("fs "))
                {
                    filesystem = input.TrimStart("fs ".ToCharArray());
                }
                else if(input == "exit")
                {
                    return;
                }
                else if(input == "help")
                {
                    Console.WriteLine("EXIT         Exits the app.");
                    Console.WriteLine("HELP         Gets help.");
                    Console.WriteLine("FS           Changes your filesystem.");
                    Console.WriteLine("FILELIST     Lists all files.");
                    Console.WriteLine("DEL          Deletes a file");
                    Console.WriteLine("PEEK         Peeks inside a file.");
                }
            }
        }
    }
}

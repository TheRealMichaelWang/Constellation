using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class MakeArt
    {
        public string[] clear = {
            "                       ",
            "                       ",
            "                       ",
            "                       ",
            "                       "};
        public string[] picture = {
            "                       ",
            "                       ",
            "                       ",
            "                       ",
            "                       "};
        public string[] field ={
            "         O             ",
            "         |             ",
            "  O      O   O O   O O ",
            "O |  O O/|O /|O| OO|O|O",
            "|/| /|/ |||/||||//|/|/|"};
        public string[] boat = {
            "                       ",
            "  _____                ",
            "  |+++/          _____ ",
            "  |___|_________/ O  / ",
            "  |_________________/  "};
        public string[] computer ={
            " |-------|             ",
            " | |   | |________     ",
            " | \\___/ |    ___|____ ",
            " |-------|   /123450 / ",
            " | O   X |  /_______/  "};
        public MakeArt()
        {
            
        }
        public void Draw()
        {
            Console.WriteLine(picture[0]);
            Console.WriteLine(picture[1]);
            Console.WriteLine(picture[2]);
            Console.WriteLine(picture[3]);
            Console.WriteLine(picture[4]);
        }
        public void Main(NoteBook noteBook)
        {
            Console.Clear();
            Console.WriteLine("Make Art\n(C)Michael Wang\nWrite 'exit' to exit and 'help' for help.");
            while(true)
            {
                Console.Write("home/makeart>");
                string input = Console.ReadLine();
                if(input == "help")
                {
                    Console.WriteLine("GETPX            Gets the pixel at the given coordinates.");
                    Console.WriteLine("EDITPX           Edits the pixel at the given coordinates.");
                    Console.WriteLine();
                    Console.WriteLine("PCIMG            Loads an image of a desktop.");
                    Console.WriteLine("BOAT             Loads an image of a boat.");
                    Console.WriteLine("FEILD            Loads an image of a feild.");
                    Console.WriteLine();
                    Console.WriteLine("SAVE             Saves the image to your notebook");
                    Console.WriteLine("SHOWIMG          Displays the image.");
                    Console.WriteLine("PICCLEAR         Clears the picture.");
                    Console.WriteLine("EXIT             Exits the app.");
                    Console.WriteLine("HELP             Gets Help.");
                    Console.WriteLine("CLEAR            Clears the console.");
                    Console.WriteLine("CLS              Clears the console.");
                }
                else if(input == "cls"||input=="clear")
                {
                    Console.Clear();
                }
                else if(input == "exit")
                {
                    return;
                }
                else if(input == "piccls"||input == "picclear")
                {
                    picture = clear;
                }
                else if(input == "save")
                {
                    Tools tools = new Tools();
                    noteBook.book.Add(tools.ArrayToList(picture));
                    Console.WriteLine("Saved to the last pages last line");
                }
                else if(input == "showimg")
                {
                    Draw();
                }
                else if(input == "feild")
                {
                    picture = field;
                }
                else if(input == "boat")
                {
                    picture = boat;
                }
                else if(input == "pcimg")
                {
                    picture = computer;
                }
                else if(input.StartsWith("editpx "))
                {
                    try
                    {
                        string[] args = input.TrimStart("editpx ".ToCharArray()).Split(' ');
                        int x = int.Parse(args[0]);
                        int y = int.Parse(args[1]);
                        char[] row = picture[y - 1].ToCharArray();
                        row[x - 1] = args[2][0];
                        picture[y - 1] = new string(row);
                        Console.WriteLine("Changes applied");
                    }
                    catch
                    {
                        Console.WriteLine("Err 2");
                    }
                }
                else if (input.StartsWith("getpx "))
                {
                    try
                    {
                        string[] args = input.TrimStart("getpx ".ToCharArray()).Split(' ');
                        int x = int.Parse(args[0]);
                        int y = int.Parse(args[1]);
                        Console.WriteLine("Value: " + picture[y - 1][x - 1]);
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

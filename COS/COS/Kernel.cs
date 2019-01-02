using Cosmos.System.Graphics;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Sys = Cosmos.System;

namespace COS
{
    public class Kernel : Sys.Kernel
    {
        BuiltInApps BuiltInApps;
        ThreadManager threadManager;
        NoteBook noteBook;
        SignInSheet signInSheet;
        TicTacToe ticTacToe;
        SystemLogger systemLogger;
        EssayReviser essayReviser;
        Pong pong;
        protected override void BeforeRun()
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Loading Built In Apps");
                BuiltInApps = new BuiltInApps();
                signInSheet = new SignInSheet();
                ticTacToe = new TicTacToe();
                essayReviser = new EssayReviser();
                pong = new Pong();
                Console.WriteLine("Loading Thread Manager");
                threadManager = new ThreadManager();
                Console.WriteLine("Loading NoteBook");
                noteBook = new NoteBook();
                Console.WriteLine("Constellation OS booted succesfully");
                systemLogger = new SystemLogger();
                systemLogger.Log("Constellation booted up");
            }
            catch(Exception e)
            {
                Console.WriteLine("Err 0; BOOTFALIURE\nMSG: "+e.Message);
                Console.ReadKey();
                Sys.Power.Shutdown();
            }
        }
        
        protected override void Run()
        {
            systemLogger.Log("Entering Main Thread");
            Console.Clear();
            Console.WriteLine("Constellation Operating System\n(C) Michael Wang");
            Console.WriteLine("");
            while(true)
            {
                Console.Write("home>");
                string input = Console.ReadLine();
                if (!execute(input))
                {
                    systemLogger.Log("User typed in '" + input + "'");
                    Console.WriteLine("Constellation OS doesn't recognize the command '" + input + "'or application. Type 'help' for command help.");
                }
            }
        }
        public bool execute(string input)
        {
            bool executed = false;
            systemLogger.Log("Pumped through '"+input+"'");
            if (input.StartsWith("error"))
            {
                string[] args = input.Split(' ');
                if (args.Length == 2)
                {
                    if(args[1] == "3")
                    {
                        Console.WriteLine("Error 3\nThis is a syntax error, where a command isn't found and will return an error. Contact whoever wrote the program or whover made the program. If you hand copied the program, make sure to contact your distributor or check your spelling.");
                    }
                    if (args[1] == "2")
                    {
                        Console.WriteLine("Error 2\nThis is an arithmetic error. Causes:\n-Incomplete Expression\n-Invalid Number");
                    }
                    if (args[1] == "1")
                    {
                        Console.WriteLine("Error 1\nInsufficient arguments have been provided for a command to execute.");
                    }
                    if (args[1] == "0")
                    {
                        Console.WriteLine("Error 0\nThe machine that returned an error 0 has expireinced a fatal boot error, and has shutdown because so.");
                    }
                    if (args[1] == "?")
                    {
                        Console.WriteLine("The error command troubleshoots certain errors");
                    }
                }
                else
                {
                    Console.WriteLine("Err 1");
                }
                executed = true;
            }
            if (input == "shutdown")
            {
                Sys.Power.Shutdown();
                executed = true;
            }
            if (input == "reboot" || input == "restart")
            {
                Sys.Power.Reboot();
                executed = true;
            }
            if (input == "calculator" || input == "calc")
            {
                BuiltInApps.Calculator();
                executed = true;
            }
            if (input == "stat" || input == "statistics")
            {
                BuiltInApps.Statistics();
                executed = true;
            }
            if (input == "notebook")
            {
                noteBook.StartApp();
                executed = true;
            }
            if (input == "signinsheet")
            {
                signInSheet.Start();
                executed = true;
            }
            if (input == "cls" || input == "clear")
            {
                Console.Clear();
                executed = true;
            }
            if (input == "timer")
            {
                BuiltInApps.Timer();
                executed = true;
            }
            if (input == "random" || input == "rand")
            {
                BuiltInApps.Random();
                executed = true;
            }
            if(input == "tictactoe")
            {
                Console.Clear();
                ticTacToe.Main();
                executed = true;
                Console.ForegroundColor = ConsoleColor.White;
            }
            if(input == "pong")
            {
                pong.Main();
            }
            if(input == "essayrev"||input == "essayrevise"||input == "reviser")
            {
                essayReviser.Start(ref noteBook);
                executed = true;
            }
            if (input == "help")
            {
                Console.WriteLine("SHUTDOWN         Shutsdown your computer.");
                Console.WriteLine("REBOOT           Restarts your computer.");
                Console.WriteLine("RESTART          Restarts your computer.");
                Console.WriteLine("SLEEP            Sends the computer to sleep mode.");
                Console.WriteLine("CLS              Clears the console.");
                Console.WriteLine("CLEAR            Clears the console.");
                Console.WriteLine("START            Starts a page from the notebook. Syntax is the same.");
                Console.WriteLine("HELP             Gets command Help. This command works in any app.");
                Console.WriteLine("EXIT             Exits the app you are using.");
                Console.WriteLine("ERROR            Troubleshoots errors.");
                Console.WriteLine("ABOUT            Tells you about Consellation.");
                Console.WriteLine("THREADMANAGER    Gets thread info. This command works in any app.");
                Console.WriteLine();
                Console.WriteLine("NOTEBOOK         Opens the notebook app.");
                Console.WriteLine("ESSAYREV         Opens the essay reviser app.");
                Console.WriteLine("CALCULATOR       Opens the basic desktop calculator.");
                Console.WriteLine("STATISTICS       Opens the desktop statistics calculator.");
                Console.WriteLine("TIMER            Opens the timer.");
                Console.WriteLine("RANDOM           Random number generator.");
                Console.WriteLine("MORE             Displays more apps.");
                executed = true;
            }
            if(input == "more")
            {
                Console.WriteLine("PONG             I think you know what this is.");
                Console.WriteLine("TICTACTOE        Have some fun playing tic tac toe.");
                Console.WriteLine("SAVELOG          Saves the kernels logs.");
                Console.WriteLine("SIGNINSHEET      Opens the sign in sheet app");
                executed = true;
            }
            if (input == "about")
            {
                Console.WriteLine("Constellation Operating System\n(C) Michael Wang\n");
                Console.WriteLine("Michael Wang created the Constellation operating system as a robust os for older/less powerful computers. Just under 20MB of memory, COS only requires 20MB harddisk space and 128KB memory, COS is a single thread operating system.");
                executed = true;
            }
            if (input == "sleep")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                executed = true;
            }
            if (input == "exit")
            {
                Console.WriteLine("Type 'shutdown' to shutdown.");
                Console.WriteLine("Type 'sleep' to sleep.");
            }
            if(input.StartsWith("echo "))
            {
                Console.WriteLine(input.TrimStart("echo ".ToCharArray()));
                executed = true;
            }
            if(input.StartsWith("start "))
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Constellation Program Executor\nConstellation OS (C) Michael Wang");
                    int page = int.Parse(input.TrimStart("start ".ToCharArray()));
                    List<string> lines = noteBook.book[page - 1];
                    int cline = 1;
                    foreach (string line in lines)
                    {
                        if(!execute(line))
                        {
                            Console.WriteLine("Err 3 on line " + cline);
                            break;
                        }
                        cline++;
                    }
                    Console.WriteLine("Done");
                }
                catch
                {
                    Console.WriteLine("Err 1");
                }
                executed = true;
            }
            if (input == "threadmanager")
            {
                threadManager.OpenThreadManager("Constellation Os", "threadmanager", "Type 'about' in the 'home' section to find out more.");
                executed = true;
            }
            if(input == "savelogs")
            {
                systemLogger.SaveLog(noteBook);
                executed = true;
            }
            return executed;
        }
    }
}
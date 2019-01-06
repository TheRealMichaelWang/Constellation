using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class ThreadManager
    {
        public ThreadManager()
        {

        }
        public void OpenThreadManager(string app,string prompt, string info)
        {
            Console.Clear();
            Console.WriteLine("Constellation Thread Manager\n\nApplication: "+app+"\nType 'about' for information on this thread.");
            while(true)
            {
                Console.Write(prompt+"/threadmanager>");
                string inp = Console.ReadLine();
                if(inp == "exit")
                {
                    return;
                }
                if(inp == "about")
                {
                    Console.WriteLine("Thread Info: "+info);
                }
            }
        }
    }
}

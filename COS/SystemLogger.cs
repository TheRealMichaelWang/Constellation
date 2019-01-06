using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class SystemLogger
    {
        public List<string> log;
        public SystemLogger()
        {
            log = new List<string>();
        }
        public void Log(string what,DateTime time)
        {
            log.Add(what + " at " + time.ToString());
        }
        public void Log(string what)
        {
            log.Add(what + " at " + DateTime.Now.ToString());
        }
        public void SaveLog(NoteBook noteBook)
        {
            Console.WriteLine("System Logger");
            Console.WriteLine("Saving as a new page...");
            noteBook.book.Add(log);
            Console.WriteLine("Saved");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class Tools
    {
        public string clipboard;
        public Tools()
        {

        }
        public List<string> ArrayToList(string[] items)
        {
            List<string> toret = new List<string>();
            foreach(string item in items)
            {
                toret.Add(item);
            }
            return toret;
        }
    }
}

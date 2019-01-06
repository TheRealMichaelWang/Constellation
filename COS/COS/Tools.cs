using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class Tools
    {
        public string clipboard;
        public int[] randints = { 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1,0,0,1,0,0,0,1,0,1,0,0,1,1,0,0,0,1,1,0,1,0,1,0,1,1,1,0,0,0,1,0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 2,0,1,0,1,0,0,1};
        int randindex = -1;
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
        public string[] ListToArray(List<string> items)
        {
            string[] toret = new string[items.Count];
            for(int i = 0; i < toret.Length; i++)
            {
                toret[i] = items[i];
            }
            return toret;
        }
        public string RemoveCapitals(string input)
        {
            string all = input;
            all = all.Replace("A", "a");
            all = all.Replace("B", "b");
            all = all.Replace("C", "c");
            all = all.Replace("D", "d");
            all = all.Replace("E", "e");
            all = all.Replace("F", "f");
            all = all.Replace("G", "g");
            all = all.Replace("H", "h");
            all = all.Replace("I", "i");
            all = all.Replace("J", "j");
            all = all.Replace("K", "k");
            all = all.Replace("L", "l");
            all = all.Replace("M", "m");
            all = all.Replace("N", "n");
            all = all.Replace("O", "o");
            all = all.Replace("P", "p");
            all = all.Replace("Q", "q");
            all = all.Replace("R", "r");
            all = all.Replace("S", "s");
            all = all.Replace("T", "t");
            all = all.Replace("U", "u");
            all = all.Replace("V", "v");
            all = all.Replace("W", "w");
            all = all.Replace("X", "x");
            all = all.Replace("Y", "y");
            all = all.Replace("Z", "z");
            return all;
        }
        public int RandomInt()
        {
            if(randindex > randints.Length-1)
            {
                randindex = -1;
            }
            randindex++;
            return randints[randindex];
        }
    }
}

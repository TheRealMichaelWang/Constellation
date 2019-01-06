using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class EssayReviser
    {
        public EssayReviser()
        {

        }
        string[] fancywords = {
            "connosieur",
            "not so mentaly gifted",
            "intelligent",
            "intellegence",
            "abnormal","abnormal","abnormal",
            "brusque","brusque",
            "not very nice person","not very nice person",
            "simple",
            "cacophony",
            "capricous",
            "cloying",
            "elan"};
        string[] words = {
            "expert",
            "stupid",
            "smart",
            "smartness",
            "wierd","dork","awkward",
            "blunt","abrupt",
            "motherfucker","asshole",
            "easy",
            "loud",
            "determined",
            "sweet"
        };
        string[] grammarerror = {"have been"
        ,"your","you're",
        "it's","its",
        "to","too",
        "affect","effect"};
        string[] grammarsoloution = { "Change to: 'has been'. Remember subject-verb agrement",
            "Change to 'you're'. Note this is a poetential error.","Change to 'your'. Note this is a poetential error."
        ,"Change to 'its'. Note this is a poetential error.","Change to 'it's'. Note this is a poetential error.",
        "Change to 'too'. Note this is a poetential error.","Change to 'to'. Note this is a poetential error.",
        "Change to 'effect'. Note this is a poetential error.","Change to 'affect'. Note this is a poetential error."};
        string[] spellerror = {"adres",
        "alot",
        "alterior",
        "athiest",
        "beggining",
        "beleive",
        "cemetary",
        "copywrite",
        "definatley",
        "dispell",
        "facist",
        "enviroment",
        "fivety",
        "dependance",
        "freind",
        "field",
        "hight",
        "lazer",
        "mispell",
        "missle",
        "neccessary",
        "niece",
        "nineth",
        "ninty",
        "oppurtunity"
        ,"noone",
        "occurence",
        "paralell"};
        string[] spellsouloution = {"address",
        "a lot",
        "ulterior",
        "atheist",
        "begining",
        "believe",
        "cemetery",
        "copyright",
        "definitely",
        "dispel",
        "fascist",
        "environment",
        "fifty",
        "dependence",
        "friend",
        "feild",
        "height",
        "laser",
        "misspell",
        "missile",
        "necessary",
        "niece",
        "ninth",
        "ninety",
        "opportunity",
        "no one",
        "occurence",
        "parallel"};
        public void Start(ref NoteBook book)
        {
            Console.WriteLine("Essay Reviser\n(C) Michael Wang");
            Console.Write("Page Number>");
            try
            {
                int pagenum = int.Parse(Console.ReadLine());
                while (true)
                {
                    Console.Write("essayrev>");
                    string inp = Console.ReadLine();
                    if (inp == "help")
                    {
                        Console.WriteLine("HELP             Gets help.");
                        Console.WriteLine("CLS              Clears the console.");
                        Console.WriteLine("CLEAR            Clears the console.");
                        Console.WriteLine("VOCAB            Makes better use of vocabulary.");
                        Console.WriteLine("SPELL            Fixes basic common spelling errors.");
                        Console.WriteLine("GRAMMAR          Detects basic grammatical errors.");
                    }
                    else if (inp == "" || inp == "exit")
                    {
                        return;
                    }
                    else if (inp == "cls" || inp == "clear")
                    {
                        Console.Clear();
                    }
                    else if (inp == "vocab")
                    {
                        for (int i = 0; i < book.book[pagenum - 1].Count; i++) 
                        {
                            for (int x = 0; x < words.Length; x++)
                            {
                                book.book[pagenum - 1][i] = book.book[pagenum - 1][i].Replace(words[x], fancywords[x]);
                            }
                        }
                    }
                    else if(inp == "grammar")
                    {
                        for (int i = 0; i < book.book[pagenum - 1].Count; i++)
                        {
                            for (int x = 0; x < grammarerror.Length; x++)
                            {
                                if(book.book[pagenum - 1][i].Contains(grammarerror[x]))
                                {
                                    Console.WriteLine("Warning Detected on line " + (i + 1)+".\nError: "+grammarerror[x]+"\nSoloution:"+grammarsoloution[x]);
                                }
                            }
                        }
                    }
                    else if(inp == "spell")
                    {
                        for (int i = 0; i < book.book[pagenum - 1].Count; i++)
                        {
                            for (int x = 0; x < spellerror.Length; x++)
                            {
                                book.book[pagenum - 1][i] = book.book[pagenum - 1][i].Replace(spellerror[x], spellsouloution[x]);
                            }
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Err 1");
                return;
            }
        }
    }
}

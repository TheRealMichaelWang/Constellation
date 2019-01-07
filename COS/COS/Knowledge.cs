using System;
using System.Collections.Generic;
using System.Text;
namespace COS
{
    class Knowledge
    {
        bool enabled = true;
        bool jokeboxenabled = false;
        JokeBox jokeBox;
        string[] names = {  "michael wang",
                            "steve jobs",
                            "apple",
                            "apple computer",
                            "apple fruit",
                            "asshole",
                            "anus",
                            "basket",
                            "bank",
                            "bastard",
                            "bitch",
                            "capital one",
                            "capitol hill",
                            "consantinople",
                            "choad",
                            "dick",
                            "damn!",
                            "erect",
                            "east",
                            "fuck you",
                            "enum",
                            "faggot",
                            "fucktard",
                            "fuck",
                            "fun",
                            "hell",
                            "horseface",
                            "nancy pelosi",
                            "idiot",
                            ".iso",
                            "is japan good",
                            "hey google",
                            "hey alexa",
                            "sing a song",
                            "srihan",
                            "constellation",
                            "trump president",
                            "donald trump",
                            "hey siri",
                            "query",
                            "mla format",
                            "kazakhstan",
                            "united states of america",
                            "black mirror",
                            "portola middle school"};
        string[] content = {"Gender: Male\nDateOfBirth: August, 26th, 2005\nDate of Death: N/A\n\nMoreInfo: Michael Wang developed Constellation OS",
                            "Gender: Hippie\nDate Of Birth: Febuary, 25th, 1955\nDate of Death, 5th, 2011\n\nMore Info: Founded the computer company Apple, with steve wozniak to rip people off.",
                            "Please narrow down the query to:\nApple Computer\nApple Fruit",
                            "Date Founded: April, 1st, 1976\nCEO: Tim Kook\n\nMore Info: Don't buy our $100000000... ioshit products.",
                            "About: What the doctor tells you to stuff down your throat when you finally realize your obese.",
                            "Define:\n1. A very impolite word, though necessary at certain situations.\n2. Your butthole",
                            "Translation: BUTT",
                            "What you hold stuff in.",
                            "About: Banks are financial institutions that compose the capitalistic society we see today.",
                            "Define: A male who's parents aren't married.",
                            "Define:\n1. A mean woman\n2. A female dog, wolf, or otter.",
                            "Whats in your wallet?",
                            "Location: Roughly bounded by Virginia Ave., SE., S. Capitol St., G St. NE., and 14th Sts. SE & NE; and roughly bounded by 8th St. NE, I-295, M St. SE and 11th St. SE; Washington, D.C.\n\nMore Info: This is where the untited states of americas legislative branch makes decisions suck as:\n-Are we going to bomb inocent people and let our soldiers die?\nHow about shutting down that autofactory?\nWhy won't those libtards build my wall?\nCan we raise taxes?\nLET THEM IN",
                            "About: Currently it is istanbul and was once the capitol of the eastern roman empire.",
                            "Define: When a penis is wider than its own height.",
                            "Define: A males sexual organ (aka penis)",
                            "Whats all that for!",
                            "Define:\n1. To build.",
                            "Define: The direction east.",
                            "Response: That wasn't very nice.",
                            "Define: A type of object used to represent different types in c, c#, and c++.\n\nUse:\nenum genders\n{\nMale,\n,Female,\n,Other\n",
                            "Define: Hmmm... I wonder who that can be.",
                            "Translation: fucking retards",
                            "Define:\n1. To have sexual intercourse\n2. To be screwed.",
                            "Define: What school lacks...",
                            "Define: The opposite of hevan. This is where bad people go.",
                            "Define: Stormy Daniels",
                            "She is:\n1% Native American\n5% Asian\n10%Hispanic\n10% 'African American'\n100% ASSHOLE",
                            "Define: A very stupid person.",
                            "Define: File extension for a disk image file/",
                            "Response: No, because it was worse than hitler during world war 2. We can still se that it is a puppet state to the US of A.",
                            "Hi I'm google. Based on your search history would you like to go to:\nhttps://pornhub.com\nhttps://you arehornyasfuck.com\nhttps://dontcallmethat.again",
                            "Uh Huh...\n(From SNL)",
                            "Kians pants are falling down\nfalling down\nfalling down\n\nKians pants are falling down\ncause prod\npulled them\n\nKians pants cant go up\ncant go up\nKians pants cant go up\n'cause their\nto tight\n\nNote: This song sounds like london bridges falling down when sung.",
                            "The best fortnite player ever!",
                            "The stuff in the sky (excluding light poloution, aircraft, and laser pointers).",
                            "Ask the libtards who elected that orange cheeto into office.",
                            "Date Of Birth: A long time ago\nDate of Death: Comming soon\n\nMore Info: 45th president of the united states. Thats all you need to know.",
                            "Thinking...",
                            "Ask any question... And Ill try to answer",
                            "What english teachers use for your torture.",
                            "We're the best economy is the middle east because we haven't been bombed by the US (yet).",
                            "We are the greatest country in the world, so fuck all you tiny bastards!",
                            "A tv show on netflix.",
                            "Location: 187530 Linet Street\nPrinicpal: Jenifer U.\n\nMOre Info: DONT FUCKING COME HERE! YOU WILL BE TOURTURED!"};
        public Knowledge()
        {
            jokeBox = new JokeBox();
        }
        
        public bool Query(string query)
        {
            if(query == "jokes.enable")
            {
                Console.WriteLine("WARNING: Some jokes may be offensive!");
                jokeboxenabled = true;
                return true;
            }
            if(query == "jokes.disable")
            {
                jokeboxenabled = false;
                return true;
            }
            if(query == "knowledge.enable")
            {
                this.enabled = true;
                Console.WriteLine("Constellation Knowledge Enabled");
                return true;
            }
            if(query == "knowledge.disable")
            {
                this.enabled = false;
                Console.WriteLine("Constellation Knowlegde Disabled");
                return true;
            }
            if(query =="knowledge.about")
            {
                Console.WriteLine("Constellation Knowledge");
                Console.WriteLine("This is the siri of constellation");
            }
            Tools tools = new Tools();
            string originalq = query;
            query = tools.RemoveCapitals(query);
            query = query.Replace("?", "");
            query = query.Replace(".", "");
            query = query.Replace("!", "");
            if(query.Contains("tell")&&query.Contains("joke"))
            {
                if(jokeboxenabled)
                {
                    if(query.Contains("racist"))
                    {
                        Console.WriteLine(jokeBox.Joke("racist"));
                    }
                    else if(query.Contains("yo mamma")||query.Contains("yo-mamma"))
                    {
                        Console.WriteLine(jokeBox.Joke("yo-mamma"));
                    }
                    else if(query.Contains("sex"))
                    {
                        if (query.Contains("sexist"))
                        {
                            Console.WriteLine(jokeBox.Joke("sexist"));
                        }
                        else
                        {
                            Console.WriteLine(jokeBox.Joke("sex"));
                        }
                    }
                    else
                    {
                        Console.WriteLine(jokeBox.Joke("other"));
                    }
                }
                else
                {
                    Console.WriteLine("Please enable jokebox first");
                }
                return true;
            }
            query = query.Replace("who is ","");
            query = query.Replace("where is ", "");
            query = query.Replace("what is ", "");
            query = query.Replace("when did ", "");
            query = query.Replace("how did ", "");
            query = query.Replace("happen ", "");
            query = query.Replace("why is ", "");
            query = query.Replace("take place", "");
            for (int i = 0; i < names.Length; i++)
            {
                if(names[i] == query)
                {
                    if (enabled)
                    {
                        Console.WriteLine("Constellation Knowledge:");
                        Console.WriteLine("Query: " + originalq);
                        Console.WriteLine("Name: " + tools.RemoveCapitals(names[i]));
                        Console.WriteLine(content[i]);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

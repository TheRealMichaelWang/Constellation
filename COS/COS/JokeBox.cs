using System;
using System.Collections.Generic;
using System.Text;

namespace COS
{
    class JokeBox
    {
        int jokenum = -1;
        public string[] other = { "Teacher: 'Kids, what does the chicken give you?'\nStudent: 'Meat!'\nTeacher: 'Very good! Now what does the pig give you?'\nStudent: 'Bacon!'\nTeacher: 'Great! And what does the fat cow give you?'\nStudent: 'Homework!'", "YOU!",
                                "A boy is selling fish on a corner. To get his customers' attention, he is yelling, 'Dam fish for sale! Get your dam fish here!' A pastor hears this and asks, 'Why are you calling them 'dam fish.' The boy responds, 'Because I caught these fish at the local dam.' The pastor buys a couple fish, takes them home to his wife, and asks her to cook the dam fish. The wife responds surprised, 'I didn't know it was acceptable for a preacher to speak that way.' He explains to her why they are dam fish. Later at the dinner table, he asks his son to pass the dam fish. He responds, 'Thats the spirit, Dad! Now pass the f*cking potatoes!'"};
        public string[] sexist = { "A man is lying on the beach, wearing nothing but a cap over his crotch. A woman passing by remarks, 'If you were any sort of a gentleman, you would lift your hat to a lady.' He replies, 'If you were any sort of a sexy lady, the hat would lift by itself.'",
                                "For all the guys who think a woman's place is in the kitchen, remember that's where the knives are kept.",
                                "How do you know when a woman is about to say something smart? When she starts her sentence with, 'A man once told me...'",
                                "Q: Is Google male or female?\nA: Female, because it doesn't let you finish a sentence before making a suggestion."};
        public string[] yommama = {
                            "Yo mamma is so fat, I took a picture of her last Christmas and it's still printing.",
                            "Yo momma is so fat when she got on the scale it said, 'I need your weight not your phone number.'","Yo momma's so fat and old when God said, 'Let there be light,' he asked your mother to move out of the way.",
                            "Yo momma is so fat that Dora can't even explore her!"};
        public string[] racist = {"I asked a Chinese girl for her number. She said, 'Sex! Sex! Sex! Free sex tonight!' I said, 'Wow!' Then her friend said, 'She means 666-3629.'",
                                "Do not be racist; be like Mario. He's an Italian plumber, who was made by the Japanese, speaks English, looks like a Mexican, jumps like a black man, and grabs coins like a Jew!",
                                "A black Jewish boy runs home from school one day and asks his father, “Daddy, am I more Jewish or more black?” The dad replies, “Why do you want to know, son?” “Because a kid at school is selling a bike for $50 and I want to know if I should talk him down to $40 or just steal it!”",
                                "How do you blindfold a Chinese person? Put floss over their eyes.",
                                "What do you call black people running down the hill? A mudslide.",
                                "WHat do you call a black priest? HOLY SHIT",
                                "A jewish boy asked his dad for $50. His dad said '$50 dollars son, why do you need $40. Isn't $30 to much, how about $20.",
                                "What is a Mexican's favorite sport? Cross-country."};
        public string[] sex = { "Maria went home happy, telling her mother about how she earned $20 by climbing a tree. Her mom responded, 'Maria, they just wanted to see your panties!' Maria replied, 'See Mom, I was smart, I took them off!'",
                                "Kid 1: 'Hey, I bet you're still a virgin.'\nKid 2: 'Yeah, I was a virgin until last night .'\nKid 1: 'As if.'\nKid 2: 'Yeah, just ask your sister.'\nKid 1: 'I don't have a sister.'\nKid 2: 'You will in about nine months.'"};
        public JokeBox()
        {

        }
        public string Joke(string joketype)
        {
            if(joketype == "yo-mamma")
            {
                if(yommama.Length-1 <= jokenum)
                {
                    jokenum = -1;
                }
                jokenum++;
                return yommama[jokenum];
            }
            if (joketype == "racist")
            {
                if (racist.Length-1 <= jokenum)
                {
                    jokenum = -1;
                }
                jokenum++;
                return racist[jokenum];
            }
            if(joketype == "sex")
            {
                if (sex.Length-1<= jokenum)
                {
                    jokenum = -1;
                }
                jokenum++;
                return sex[jokenum];
            }
            if (joketype == "sexist")
            {
                if (sexist.Length-1 <= jokenum)
                {
                    jokenum = -1;
                }
                jokenum++;
                return sexist[jokenum];
            }
            if (joketype == "other")
            {
                if (other.Length-1 <= jokenum)
                {
                    jokenum = -1;
                }
                jokenum++;
                return other[jokenum];
            }
            return "YOU!";
        }
    }
}

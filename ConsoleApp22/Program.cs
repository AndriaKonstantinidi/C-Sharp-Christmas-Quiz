class Program
{
    static void Main(string[] args)
    {
        string[] questions = new string[]
        {
            "What do you find under a Christmas Tree?:Presents",
            "When is Christmas:December 25",
            "What country started the tradition of putting up Christmas Trees?:Germany",
            "Who is Santa Based off of:Saint Nicholas",
            "What Animal helps Pull Santas Sleigh:Reindeer",
            "Which one of the reindeer has a red nose?:Rudolph",
            "What do naughty children get for Christmas?:Coal",
            "What ocean is Christmas Island located in?:Indian Ocean",
            "What Sweet snack is typically left out for Santa?:Cookies",
            "What drink is typically left out for Santa?:Milk",
            "What Country did Christmas caroling originate in?:Austria",
            "What color are Mistletoe berries?:White",
            "How do you say merry christmas in Spanish?:Feliz Navidad",
            "What is a Snowmans nose made out of?:Carrot",
            "Which nuts are 'roasted on an open fire'?:Chestnuts"
        };
        using (StreamWriter qwrite = new StreamWriter("quiz.txt"))
        {
            foreach (string question in questions)
            {
                qwrite.WriteLine(question);
            }
        }

        string[] thinred = File.ReadAllLines("quiz.txt");

            var points = 0;

        foreach (string line in thinred)
        {
            var ss = line.Split(":");
            Console.WriteLine(ss[0]);
            var bb = Console.ReadLine();
            if (bb.ToLower() == ss[1].ToLower())
            {
                Console.WriteLine("Correct");
                points++;
            }
            if(bb != ss[1].ToLower())
            {
                Console.WriteLine($"Incorrect, answer was {ss[1]}");
            }
        }

        if(points == 15)
        {
            Console.WriteLine("Congratulations, you got all 15 points!");
        }
        if(points == 0)
        {
            Console.WriteLine("You got 0 points, try again?");
        }
        else
        {
            Console.WriteLine($"Congratulations, you got {points} out of 15 points");
        }
    }
}
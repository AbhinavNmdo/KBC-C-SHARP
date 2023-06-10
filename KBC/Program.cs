using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KBC
{
    class Program
    {
        public static List<Questions> questions;
        public static int points = 0;
        public static bool ExpertUsed = false;
        public static bool FiftyFiftyUsed = false;

        static void Main(string[] args)
        {
            Console.WriteLine("----------------------Welcome to the KBC----------------------");
            Console.WriteLine("There is 4 options (a, b, c, d) you can press 'e' for Expert Advice and 'f' for Fifty-fifty Life line");
            StoreData();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Your {i} quesction is:.............");
                Questions ques = GetQuestion();
                Console.WriteLine($"Q{i}: {ques.Question}");

                foreach (KeyValuePair<string, string> option in ques.Options)
                {
                    Console.Write($"{option.Key}: {option.Value}" + (option.Key == "d" ? "" : ", "));
                }

            GetInput:
                Console.WriteLine();
                Console.Write("Your ans: ");
                string UserAns = Console.ReadLine();

                switch (UserAns)
                {
                    case "e":
                        Console.WriteLine(ExpertAdvice(ques.Ans));
                        goto GetInput;
                    case "f":
                        Console.WriteLine(FiftyFifty(ques.Options, ques.Ans));
                        goto GetInput;
                    case "a":
                    case "b":
                    case "c":
                    case "d":
                        if (!CheckAns(UserAns, ques.Ans, i * 10))
                        {
                            goto exit_loop;
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter write input");
                        goto GetInput;
                }
            }

        exit_loop:
            Console.WriteLine($"You earn {points}, Press any key to exit");
            Console.ReadLine();
        }

        static void StoreData()
        {
            questions = new List<Questions>();
            questions.Add(new Questions("Who is the father of C language?", new Dictionary<string, string>() { { "a", "Steve Jobs" }, { "b", "James Gosling" }, { "c", "Dennis Ritchie" }, { "d", "Rasmus Lerdorf" } }, "b"));
            questions.Add(new Questions("Which of the following is not a valid C variable name?", new Dictionary<string, string>() { { "a", "int number;" }, { "b", "float rate;" }, { "c", "int variable_count;" }, { "d", "int $main;" } }, "d"));
            questions.Add(new Questions("Which of the following cannot be a variable name in C?", new Dictionary<string, string>() { { "a", "volatile" }, { "b", "true" }, { "c", "friend" }, { "d", "export" } }, "a"));
            questions.Add(new Questions("What is an example of iteration in C?", new Dictionary<string, string>() { { "a", "for" }, { "b", "while" }, { "c", "do-while" }, { "d", "all of the mentioned" } }, "d"));
            questions.Add(new Questions("Functions can return enumeration constants in C?", new Dictionary<string, string>() { { "a", "true" }, { "b", "false" }, { "c", "depends on the compiler" }, { "d", "depends on the standard" } }, "a"));
        }

        static Questions GetQuestion()
        {
            Random random = new Random();
            int ran = random.Next(1, 5);

            return questions[ran];
        }

        static string ExpertAdvice(string Ans)
        {
            if (!ExpertUsed)
            {
                ExpertUsed = true;
                return $"I think the ans is {Ans}";
            }
            else
            {
                return "You cannot use it now";
            }
        }

        static bool CheckAns(string UserAns, string Ans, int Points)
        {
            if (UserAns == Ans)
            {
                points += Points;
                Console.WriteLine($"Congrats, your ans is correct, total points: {points}");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
                return true;
            }
            else
            {
                Console.WriteLine("Oops, your ans is wrong. Press any key to exit");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
                return false;
            }
        }

        static string FiftyFifty(Dictionary<string, string> Options, string Ans)
        {
            if (!FiftyFiftyUsed)
            {
                FiftyFiftyUsed = true;
                string options = $"{Ans}: {Options[Ans]}";
                Options.Remove(Ans);
                List<string> keyList = new List<string>(Options.Keys);
                Random random = new Random();
                int ran = random.Next(0, 2);
                options += $", {keyList[ran]}: {Options[keyList[ran]]}";

                return options;
            }
            else
            {
                return "You cannot use it now";
            }

        }
    }

    public class Questions
    {
        public string Question { get; set; }
        public Dictionary<string, string> Options { get; set; }
        public string Ans { get; set; }

        public Questions(string question, Dictionary<string, string> options, string ans)
        {
            this.Question = question;
            this.Options = options;
            this.Ans = ans;
        }
    }
}


/*Create class for question answer
Element
Question
Answer (A1, A2,A3, A4)
Correct Answer
Difficulty

class of lifeline
{
Enum of lifeline
Message 
used
}

start program 
question list
lifeline

user class
{
user question class list 
}


user question class
{
question obj
answer

}


Start
Function
Parameter(Start Boolean, Question =null(default), Lifeline(default)

if(start true)
{
Print about kbc
question and price money
i - 1000 Rs.

if user say start



}


*/
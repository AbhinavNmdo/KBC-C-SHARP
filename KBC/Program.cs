using KBC.Class;
using KBC.Enum;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KBC
{
    class Program
    {
        static List<Questions> QuestionsList;
        static User UserInfo;
        static List<UserQuestions> UserQuestionsList = new List<UserQuestions>();

        static void Main(string[] args)
        {
            Start(IsStart: true);
            QuestionsList = Questions.StoreQuestion();

            for (int i = 1; i <= 15; i++)
            {
                Random random = new Random();
                List<Questions> QuesList = QuestionsList.Where(x => x.Difficulty == (i <= 5 ? 1 : (i > 10 ? 3 : 2))).ToList();
                int ran = random.Next(0, QuesList.Count());
                Questions Ques = QuesList[ran];
                QuestionsList.Remove(Ques);
                if (!Start(Question: Ques, QuestionNo: i))
                {
                    break;
                }
            }

            Console.WriteLine($"Congratulation {UserInfo.Name}, You won the price money of Rs.{UserInfo.MoneyWon}");
            Console.WriteLine("Press any key to claim your reward");
            Console.ReadLine();
        }

        static bool Start(string Lifeline = null, bool IsStart = false, Questions Question = null, int QuestionNo = 0)
        {
            if (IsStart)
            {
                Console.WriteLine("----------------------Welcome to the C# KBC----------------------");
                Console.Write("Please enter you name: ");
                string UserName = Console.ReadLine();
                UserInfo = new User();
                UserInfo.Name = UserName;
                Console.WriteLine($"Hii {UserInfo.Name}, There are 4 options (a, b, c, d) you can press 'e' for Expert Advice and 'f' for Fifty-fifty Lifeline");
                Console.WriteLine("Press enter to continue: ");
                Console.ReadLine();
                Console.Clear();
                return true;
            }

            if (Question != null)
            {
                Console.WriteLine($"Q{QuestionNo}: " + Question.Question);
                Console.WriteLine("a: " + Question.Option1);
                Console.WriteLine("b: " + Question.Option2);
                Console.WriteLine("c: " + Question.Option3);
                Console.WriteLine("d: " + Question.Option4);
                string UserInput = Console.ReadLine();
                switch (UserInput)
                {
                    case "exit":
                        Console.Clear();
                        Console.WriteLine($"Ok, KBC permit you to exit the game, you won th price money of Rs.{UserInfo.TempMoneyWon}");
                        Console.ReadLine();
                        return false;
                    case "e":
                        Console.WriteLine("Expert advice");
                        Console.Clear();
                        Start(Question: Question, QuestionNo: QuestionNo);
                        return true;
                    case "f":
                        Console.WriteLine("Fifty-Fifty");
                        Console.Clear();
                        Start(Question: Question, QuestionNo: QuestionNo);
                        return true;
                    case "a":
                    case "b":
                    case "c":
                    case "d":
                        UserQuestionsList.Add(new UserQuestions(Question, UserInput));
                        if (Question.Ans == UserInput)
                        {
                            UserInfo.TempMoneyWon = MoneyPrice.Prices[QuestionNo];
                            if (QuestionNo % 5 == 0)
                            {
                                UserInfo.MoneyWon = MoneyPrice.Prices[QuestionNo];
                            }
                            Console.WriteLine($"Congrats {UserInfo.Name}, your answer is right, you won {UserInfo.TempMoneyWon}. Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            return true;
                        }
                        Console.WriteLine($"Oops, your answer is wrong. You rewarded with Rs.{UserInfo.MoneyWon} Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        return false;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter right input");
                        Start(Question: Question, QuestionNo: QuestionNo);
                        return true;
                }
            }
            return false;
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
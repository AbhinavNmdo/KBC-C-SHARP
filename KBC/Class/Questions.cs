using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBC.Class
{
    class Questions
    {
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Ans { get; set; }
        public int Difficulty { get; set; }

        public Questions(string question, string option1, string option2, string option3, string option4, string ans, int difficulty)
        {
            this.Question = question;
            this.Option1 = option1;
            this.Option2 = option2;
            this.Option3 = option3;
            this.Option4 = option4;
            this.Ans = ans;
            this.Difficulty = difficulty;
        }

        public static List<Questions> StoreQuestion()
        {
            List<Questions> Questions = new List<Questions>();

            Questions.Add(new Questions("C# is a programming language, developed by ___.", "Oracle", "Microsoft", "GNU project", "Google", "b", 1));
            Questions.Add(new Questions("C# runs on the ___.", ".NET Framework", "Java Virtual Machine", "Both A. and B.", "None of the above", "a", 1));
            Questions.Add(new Questions("C# programming language is used to develop -", "Web apps", "Desktop apps", "Mobiles apps", "All of the above", "d", 1));
            Questions.Add(new Questions("What is the extension of a C# language file?", ".c", ".cpp", ".cs", ".csp", "c", 1));
            Questions.Add(new Questions("Who is the founder of C# programming language?", "Anders Hejlsberg", "Douglas Crockford", "Rasmus Lerdorf", "Brendan Eich", "a", 1));
            Questions.Add(new Questions("CLR stands for ___.", "Common Type System", "Common Language Specification", "Common Language Runtime", "Java Virtual Machine", "c", 1));
            Questions.Add(new Questions(".Net CLR is equivalent to?", "Common Type System", "Common Language Specification", "Common Language Runtime", "Java Virtual Machine", "d", 1));

            Questions.Add(new Questions("To declare an array, define the variable type with ___.", "Square brackets []", "Curly brackets {}", "Round brackets ()", "None of the above", "a", 2));
            Questions.Add(new Questions("Which statement is correct about the following C# statement?\nint[] x= {10, 20, 30};", "'x' is a reference to the array created on stack", "'x' is a reference to an object created on stack", "'x' is a reference to an object of a 'System.Array' class", "None of the above", "c", 2));
            Questions.Add(new Questions("Which array property is used to get the total number of elements in C#?", "Len", "Length", "Elements", "MaxLen", "b", 2));
            Questions.Add(new Questions("Which array method is used to sort an array alphabetically or in an ascending order in C#?", "sort()", "sorting()", "Sort()", "Sorting()", "c", 2));
            Questions.Add(new Questions("Which of the correct syntax to declare an array with 2 rows and 3 columns in C#?", "int arr[2][3] = new int[2][3];", "int arr[2,3] = new int[2,3];", "int[,] arr = new int[2,3];", "int [,]arr = new [2,3]int;", "c", 2));
            Questions.Add(new Questions("Which keyword is used to define a class in C#?", "Class", "class", "System.Class", "OOPS.class", "b", 2));
            Questions.Add(new Questions("Which is the correct way to declare an object of the class in C#?", "Class_Name Object_Name = new Class_Name();", "Class_Name Object_Name;", "new Object_Name as Class_Name();", "Both A and B", "a", 2));

            Questions.Add(new Questions("Which operator is used to access variables/fields inside a class in C#?", "Arrow Operator (->)", "Dot Operator (.)", "Greater Than (>)", "Dot and Greater Than (.>)", "b", 3));
            Questions.Add(new Questions("Which is not a type of constructor in C#?", "Static Constructor", "Private Constructor", "Body Constructor", "Parameterized Constructor", "c", 3));
            Questions.Add(new Questions("How many types of access modifiers in C#?", "2", "3", "4", "5", "c", 3));
            Questions.Add(new Questions("What does the access modifier do in C#?", "To maintain the syntax", "To define a variable inside the class", "To access the variables defined inside the class", "To control the visibility of class members", "d", 3));
            Questions.Add(new Questions("The internal access modifier is used for ___.", "Types and type members", "Defining a field that can be accessed in all classes", "Defining a field that can be accessed in inherited classes", "All of the above", "a", 3));
            Questions.Add(new Questions("The protected access modifier defines a member that can be accessible within ___.", "its class and all other classes", "its class and by derived class instances", "its class only", "None of the above", "b", 3));
            Questions.Add(new Questions("Which C# concept has the capability of an object to take number of different forms and hence display behaviour as accordingly?", "Polymorphism", "Encapsulation", "Abstraction", "None of the above", "a", 3));

            return Questions;
        }
    }
}

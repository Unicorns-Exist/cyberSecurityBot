using System;

namespace chatBot__POE
{
    internal class botUserActivity
    {

        // Automatic property to store user name
        public string Name { get; set; }

        public void askName()
        {//start method to get name
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("BOT: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter your name:");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("YOU: ");

                Console.ForegroundColor = ConsoleColor.Gray;
                Name = Console.ReadLine();

                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(Name) || Name.Length < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid name. Try again.");
                    Console.ResetColor();
                }

            } while (string.IsNullOrWhiteSpace(Name) || Name.Length < 2);
        }// end of askName

        //================================================================

        // Array Questions
        private string[] questions =
        {
        "Who created you?",
        "What can you inform me about?",
        "How to detect phishing emails?",
        "What are cookies?",
        "What info should I not share?"
    };

        //Array Answers
        private string[] answers =
        {
        "I was created by a 2nd  Year student at Rosebank International, Kamogelo Tamia for cybersecurity awareness Assignment.",
        "I provide tips on staying safe online.",
        "Check sender email, avoid suspicious links.",
        "Cookies store website data. Be careful.",
        "Never share passwords or banking details."
    };

        //============================================================

        public void StartChat()
        {// method to start chatbot interaction
            int choice;

            do
            {
                Console.WriteLine($"\n{Name}, choose a question:");

                for (int i = 0; i < questions.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {questions[i]}");
                }

                Console.WriteLine("6. Exit");

                Console.Write("Choice: ");

                // Prevent crash
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input, enter a number.");
                    continue;
                }

                if (choice >= 1 && choice <= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n" + answers[choice - 1]);
                    Console.ResetColor();
                }
                else if (choice == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nThank you for using the Cybersecurity Awareness Bot!");
                    Console.ResetColor();
                }

            } while (choice != 6);
        }// end  of StartChat method 

    }// end of class

}// end of name class
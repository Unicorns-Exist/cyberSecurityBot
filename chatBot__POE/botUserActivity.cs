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
    "I was created by a second-year student, Kamogelo Tamia, at Rosebank International as part of a Programming POE. My purpose is to promote cybersecurity awareness and help users understand how to stay safe online.",

    "I can inform you about basic cybersecurity practices such as identifying phishing attacks, protecting your personal information, understanding cookies, and following safe browsing habits.",

    "Phishing emails are designed to trick you into giving away sensitive information. You can identify them by checking for suspicious sender addresses, spelling mistakes, urgent or threatening language, and links that don’t match legitimate websites. Always verify before clicking any link.",

    "Cookies are small files stored on your device by websites to remember your preferences and improve your experience. While many cookies are safe, some can track your activity, so it is important to only accept cookies from trusted websites.",

    "You should never share sensitive information such as your passwords, banking details, ID numbers, or personal addresses online. Even on social media, oversharing personal details can put you at risk of identity theft or cyber attacks."
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, enter a number.");
                    Console.ResetColor();
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
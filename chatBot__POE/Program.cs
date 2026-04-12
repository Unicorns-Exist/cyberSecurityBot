using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatBot__POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create objects (instances of classes)
            voiceGreeting audio = new voiceGreeting();   // handles sound
            asciiLogo display = new asciiLogo();         // handles UI (logo, text)
            botUserActivity bot = new botUserActivity(); // handles user + chatbot


            //2. Play welcome audio
            audio.PlayWelcome();

            //3. Show ASCII logo
            display.ShowLogo();

            //4. Ask user name
            bot.askName();
           
            // STEP 5: Show welcome message using the name
            display.ShowWelcome(bot.Name);

            // STEP 6: Start chatbot interaction
            bot.StartChat();

            // STEP 7: enter key program close 
            Console.ReadKey();

        }

    }//end of class
    
}//end of namespace

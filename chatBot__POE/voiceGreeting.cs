using System;
using System.Media;

namespace chatBot__POE
{
    internal class voiceGreeting
    {
        public void PlayWelcome()
        {//method that plays greetingg audio
            try
            {
                // STEP 1: Get current program folder (VERY IMPORTANT)
                string path = AppDomain.CurrentDomain.BaseDirectory;

                // STEP 2: Fix path (remove bin\Debug\)
                string fullPath = path.Replace(@"bin\Debug\", "") + "greetingAudio.wav";

                // STEP 3: Create player
                SoundPlayer player = new SoundPlayer(fullPath);

                // STEP 4: Load and play
                player.Load();
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio file not found.");
                Console.WriteLine(ex.Message);
            }

         }// end of method

        }// end of class

}// end of name space


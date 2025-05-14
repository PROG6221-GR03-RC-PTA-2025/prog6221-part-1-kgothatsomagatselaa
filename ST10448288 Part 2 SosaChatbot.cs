using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace sosaChatbot2
{
    class sosaChatbot
    {
        static string userInterest = "";
        static string userName = "";
        static string userDetails = "";
        static void Main()
        {
            Console.WriteLine("Welcome to the Cybersecurity Sosa Chatbot!");
            Thread.Sleep(5000);
            Console.Write("Before we start I'd like to know your name: ");
            userName = Console.ReadLine();

            Console.WriteLine("Hi " + userName + ", can you tell me a bit about yourself (e.g., your cybersecurity interests)? ");
            userDetails = Console.ReadLine();

            Console.WriteLine("Thanks, " + userName + "! How can I assist you today?");

            while (true)
            {
                Console.Write($"{userName}: ");
                string user = Console.ReadLine().ToLower();

                if (user == "no")
                {
                    Console.WriteLine($"Chatbot: Anymore security questions {userInterest}? Please type 'no' to stop chatbot.");
                    Console.WriteLine("Chatbot: Goodbye! Stay safe online.");
                    break;
                }
                RespondUser(user); 
            }
        }

        static void RespondUser(string user)
        {
            if (user.Contains("password"))
            {
                string[] passwordTips = GetPasswordAwarenessTips();
                Console.WriteLine("SosaChatbot: " + GetRandomTip(passwordTips));
            }
            else if (user.Contains("scam"))
            {
                string[] scamTips = GetScamAwarenessTips();
                Console.WriteLine("SosaChatbot: " + GetRandomTip(scamTips));
            }
            else if (user.Contains("hacking"))
            {
                string[] hackingTips = GetHackingAwarenessTips();
                Console.WriteLine("SosaChatbot: " + GetRandomTip(hackingTips));
            }
            else if (user.Contains("phishing"))
            {
                string[] phishingTips = GetPhishingAwarenessTips();
                Console.WriteLine("SosaChatbot: " + GetRandomTip(phishingTips));
            }
            else if (user.Contains("curious"))
            {
                Console.WriteLine("SosaChatbot: Curiosity is great! Let's dive into more cybersecurity tips.");
            }
            else
            {
                Console.WriteLine("SosaChatbot: I'm not sure I understand. Can you try rephrasing?");
            }
        }

        static string[] GetHackingAwarenessTips()
        {
            string[] hackingArray = new string[5];
            hackingArray[0] = "Don't click suspicious email links.";
            hackingArray[1] = "Keep all your software up to date.";
            hackingArray[2] = "Use strong, unique passwords for every account.";
            hackingArray[3] = "Avoid using public Wi-Fi for private tasks.";
            hackingArray[4] = "Download only from trusted sources.";

            return hackingArray;
        }
        static string[] GetPhishingAwarenessTips()
        {
            string[] phishingArray = new string[5];
            phishingArray[0] = "Don’t trust emails asking for personal info.";
            phishingArray[1] = "Always check the sender’s email address.";
            phishingArray[2] = "Hover over links before clicking them.";
            phishingArray[3] = "Look for spelling and grammar mistakes.";
            phishingArray[4] = "Report suspicious emails to your IT team.";

            return phishingArray;
        }

        static string[] GetScamAwarenessTips()
        {
            string[] scamArray = new string[5];
            scamArray[0] = "If it sounds too good to be true, it is.";
            scamArray[1] = "Never share your PIN or password.";
            scamArray[2] = "Ignore messages asking for urgent money.";
            scamArray[3] = "Check website URLs for fake copies.";
            scamArray[4] = "Verify calls or messages before acting.";

            return scamArray;
        }

        static string[] GetPasswordAwarenessTips()
        {
            string[] passwordArray = new string[5];

            passwordArray[0] = "Use strong passwords with a mix of letters, numbers, and symbols.";
            passwordArray[1] = "Avoid using personal information like birthdates or names in passwords.";
            passwordArray[2] = "Never share your password with anyone, even people you trust.";
            passwordArray[3] = "Change your passwords regularly and avoid reusing old ones.";
            passwordArray[4] = "Enable two-factor authentication (2FA) for extra security whenever possible.";

            return passwordArray;
        }
        
        static string GetRandomTip(string[] tips)
        {
            Random rand = new Random();
            int index = rand.Next(tips.Length);
            return tips[index];
        }
    }
}

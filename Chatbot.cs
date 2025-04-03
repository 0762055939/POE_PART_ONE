using System;
using System.Collections;

namespace POE_PART_ONE
{
    class Chatbot

    {

        private string[] questions;
        private string[] responses;
        private string username;


        public Chatbot()

        {
            StoreResponses();
            Start();

        }
        private void Start()

        {

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("Chatbot: Hello, Welcome to the cybersecurity awareness bot.");
            Console.Write("\nChatbot: Hey, what is your first name? ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            username = Console.ReadLine()?.Trim();
            if (string.IsNullOrWhiteSpace(username))

            {
                username = "Guest";
            }
            string userQuery;
            do

            {

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"\nChatbot: Hey {username}, how can I assist you today? Ask me anything about cybersecurity!");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{username}: ");

                userQuery = Console.ReadLine()?.ToLower().Trim();
                if (!string.IsNullOrEmpty(userQuery) && userQuery != "exit")

                {

                    ProcessQuery(userQuery);

                }



            } while (userQuery != "exit");



            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"\nChatbot: Bye for now, {username}! Stay safe online!");

            Console.ResetColor();

        }



        private void StoreResponses()

        {

            questions = new string[]

            {

            "what is a password?",
            "how do i create a strong password?",
            "why should i use unique passwords?",
            "what is phishing?",
            "how do i avoid phishing?",
            "what is safe browsing?",
            "how can i browse safely?",
            "what is multi-factor authentication?",
            "why is it important to update software?",
            "what are social engineering attacks?"
            };



            responses = new string[]

            {

            "A password is a secure string of characters used to verify a user's identity.",
            "A strong password includes uppercase letters, lowercase letters, numbers, and special characters.",
            "Using unique passwords reduces the risk of all your accounts being compromised.",
            "Phishing is a fraudulent attempt to obtain sensitive information by pretending to be a trustworthy entity.",
            "Always verify the sender's email address and avoid clicking on suspicious links or attachments.",
            "Safe browsing refers to practices that protect users from online threats like malware and phishing.",
            "Check for HTTPS in URLs, avoid public Wi-Fi for sensitive transactions, and keep your browser updated.",
            "Multi-factor authentication adds an extra layer of security to your accounts by requiring a second verification step.",
            "Updates often include patches for newly discovered security vulnerabilities, making your systems safer.",
            "Social engineering attacks trick people into revealing sensitive information by exploiting human trust."

            };

        }



        private void ProcessQuery(string query)

        {
            for (int i = 0; i < questions.Length; i++)
            {

                if (query == questions[i])

                {

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"Chatbot: {responses[i]}");

                    return;

                }

            }



            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Chatbot: I'm sorry, I didn't quite understand that. Could you please rephrase your question?");

        }

    }



}
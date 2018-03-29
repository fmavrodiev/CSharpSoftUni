namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "A")
                {
                    string contactName = tokens[1];
                    string phoneNumber = tokens[2];

                    if (!phonebook.ContainsKey(contactName))
                    {
                        phonebook.Add(contactName, phoneNumber);
                    }
                    phonebook[contactName] = phoneNumber;
                }
                else if (tokens[0] == "S")
                {
                    string contactName = tokens[1];

                    if (phonebook.ContainsKey(contactName))
                    {
                        Console.WriteLine($"{contactName} -> {phonebook[contactName]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {contactName} does not exist.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
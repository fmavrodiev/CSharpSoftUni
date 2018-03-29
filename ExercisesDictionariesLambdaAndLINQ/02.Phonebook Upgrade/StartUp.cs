namespace _02.Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] token = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (token[0] == "A")
                {
                    string contactName = token[1];
                    string phoneNumber = token[2];

                    if (!phonebook.ContainsKey(contactName))
                    {
                        phonebook.Add(contactName, phoneNumber);
                    }
                    phonebook[contactName] = phoneNumber;
                }
                else if (token[0] == "S")
                {
                    string contactName = token[1];

                    if (phonebook.ContainsKey(contactName))
                    {
                        Console.WriteLine($"{contactName} -> {phonebook[contactName]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {contactName} does not exist.");
                    }
                }
                else if (input == "ListAll")
                {
                    PrintPhonebook(phonebook);
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintPhonebook(SortedDictionary<string, string> phonebook)
        {
            foreach (KeyValuePair<string, string> contactName in phonebook)
            {
                Console.WriteLine("{0} -> {1}", contactName.Key, contactName.Value);
            }
        }
    }
}

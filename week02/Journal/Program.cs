using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.displayall();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.savetofile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.loadfromfile(loadFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
            }
        }
        
        public class Journal 
        {
            private List<Entry> entries = new List<Entry>();
        
            public void AddEntry(Entry entry)
            {
                entries.Add(entry);
            }
        
            public void Display()
            {
                foreach (var entry in entries)
                {
                    Console.WriteLine($"{entry.Date} - {entry.Prompt}");
                    Console.WriteLine(entry.Response);
                    Console.WriteLine();
                }
            }
        
            public void SaveToFile(string fileName)
            {
                using (var writer = new StreamWriter(fileName))
                {
                    foreach (var entry in entries)
                    {
                        writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                    }
                }
            }
        
            public void LoadFromFile(string fileName)
            {
                if (File.Exists(fileName))
                {
                    entries.Clear();
                    string[] lines = File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            entries.Add(new Entry(parts[0], parts[1], parts[2]));
                        }
                    }
                }
            }
        }
    }
}
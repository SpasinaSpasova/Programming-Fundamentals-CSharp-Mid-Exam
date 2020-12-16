using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Done")
            {

                string[] tokens = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();

                string command = tokens[0];

                if (command == "Add Book")
                {
                    string book = tokens[1];

                    if (!books.Contains(book))
                    {
                        books.Insert(0, book);
                    }
                }
                else if (command == "Take Book")
                {
                    string book = tokens[1];

                    books.Remove(book);
                }
                else if (command == "Swap Books")
                {
                    string first = tokens[1];
                    string second = tokens[2];
                    if (books.Contains(first) && books.Contains(second))
                    {
                        string temp = books[books.IndexOf(second)];
                        books[books.IndexOf(second)] = books[books.IndexOf(first)];
                        books[books.IndexOf(first)] = temp;
                    }
                }
                else if (command == "Insert Book")
                {
                    string book = tokens[1];

                    
                        books.Add(book);
                    
                }
                else if (command == "Check Book")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index <= books.Count - 1)
                    {
                        Console.WriteLine(books[index]);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", books));
        }
    }
}

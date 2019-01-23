using System;
using System.Collections.Generic;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, bool> mitch = new Dictionary<string, bool>();
            //mitch.Add("Han", true);
            //mitch["Han"] = false;
            //mitch.Remove("Han");

            MyLinkedListFun();

            Console.WriteLine("Welcome to the Person / Height Database");
            Console.WriteLine();

            Console.Write("Would you like to enter another person (yes/no)? ");
            string input = Console.ReadLine().ToLower();

            Dictionary<string, int> heightDict = new Dictionary<string, int>();
            // 1. Let's create a new Dictionary that could hold string, ints
            //      | "Josh"    | 70 |
            //      | "Bob"     | 72 |
            //      | "John"    | 75 |
            //      | "Jack"    | 73 |

            while (input == "yes" || input == "y")
            {
                Console.Write("What is the person's name?: ");
                string name = Console.ReadLine();

                Console.Write("What is the person's height (in inches)?: ");
                int height = int.Parse(Console.ReadLine());

                // 2. Check to see if that name is in the dictionary
                bool exists = heightDict.ContainsKey(name); 
                if (!exists)
                {
                    Console.WriteLine($"Adding {name} with new value.");
                    // 3. Put the name and height into the dictionary
                    heightDict.Add(name, height);
                }
                else
                {
                    Console.WriteLine($"Overwriting {name} with new value.");
                    // 4. Overwrite the current key with a new value
                    heightDict[name] = height;
                }

                Console.WriteLine();
                Console.Write("Would you like to enter another person (yes/no)? ");
                input = Console.ReadLine().ToLower();
            }

            Console.Write("Type \"all\" to print all names OR \"search\" to print out single name: ");
            input = Console.ReadLine().ToLower();

            if (input == "search")
            {
                Console.Write("Which name are you looking for? ");
                input = Console.ReadLine();

                //5. Let's get a specific name from the dictionary
                if (heightDict.ContainsKey(input))
                {
                    int height = heightDict[input];
                    Console.WriteLine($"{input} height: {height}");
                }
                else
                {
                    Console.WriteLine($"{input} does not exist.");
                }
                Console.ReadKey();
            }
            else if (input == "all")
            {
                Console.WriteLine();
                Console.WriteLine(".... printing ...");

                //6. Let's print each item in the dictionary
                PrintDictionary(heightDict);
                Console.ReadKey();
            }

            Console.WriteLine();
            Console.WriteLine("Done...");

            //7. Let's get the average height of the people in the dictionary
            double totalHeight = 0;
            foreach (var item in heightDict.Values)
            {
                totalHeight += item;
            }
            double avg = totalHeight / heightDict.Count;
            Console.WriteLine($"Average height is {avg.ToString("N2")}");

            Console.ReadLine();
        }

        static void PrintDictionary(Dictionary<string, int> database)
        {
            // Looping through a dictionary involves using a foreach loop
            // to look at each item, which is a key-value pair
            foreach (var item in database)
            {
                Console.WriteLine($"{item.Key} is {item.Value} inches tall.");
            }
        }

        public static void MyHashSetFun()
        {
            HashSet<string> states = new HashSet<string>();
            states.Add("Ohio");
            states.Add("Kentucky");
            states.Add("Connecticut");
            states.Add("Ohio");
            states.Add("Connecticut");
            states.Add("Ohio");

            foreach (var item in states)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static void MyLinkedListFun()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            LinkedListNode<string> node = new LinkedListNode<string>("Chris");
            linkedList.AddFirst(node);
            var lastNode = linkedList.AddAfter(node, "Bob");
            var joeNode = linkedList.AddAfter(lastNode, "Joe");
            lastNode = linkedList.AddAfter(joeNode, "Mike");
            lastNode = linkedList.AddAfter(lastNode, "Tracy");
            lastNode = linkedList.AddAfter(lastNode, "Sally");
            linkedList.AddBefore(joeNode, "Micah");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();

            if (node != null)
            {
                Console.WriteLine(node.Value);
                var currentNode = node;
                do
                {
                    currentNode = currentNode.Next;
                    Console.WriteLine(currentNode.Value);                    
                } while (currentNode.Next != null);
            }

            Console.ReadKey();
        }
    }
}

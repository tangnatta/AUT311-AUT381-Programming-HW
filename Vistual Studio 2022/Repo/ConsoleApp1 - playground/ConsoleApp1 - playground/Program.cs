/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/

using System.Diagnostics;
using System.Text.Json;

using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApp1___playground
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionUri = "mongodb+srv://natta:cg5MXwFIWIcZYQAy@ex7.ofn9sro.mongodb.net/?retryWrites=true&w=majority";
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);
            // Send a ping to confirm a successful connection
            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //Exercise5();
            //TrySth();
        }

        static void Example()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, Your name is "+name);
            Console.WriteLine(Console.ReadKey());
            Thread.Sleep((int)System.TimeSpan.FromSeconds(3).TotalMilliseconds); // Delay
        }

        static void Exercise1()
        {
            // This is a simple comment to better understand the code
            Console.WriteLine("Hey ! guys have you ever tried Thailand Food?");
            Console.WriteLine("Not Yet. Is Thai food good?");
            Console.WriteLine("It is really really good guys");
            Console.WriteLine("Thank you. We will try when we get to Thai.");
        }

        static void Exercise2()
        {
            for (int i = 12; i<50; i++)
            {
                Console.SetCursorPosition(i, 12);
                Console.Write(" KOSEN KMUTT Y3 Bonjour.");
                Thread.Sleep(50);
            }
        }

        static void TrySth()
        {
            for (int i = 0; i<5; i++)
            {
                for (int j = 0; j<5; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(i+j);
                    Thread.Sleep(0);

                }
            }
        }
        static void Exercise3()
        {
            for (int i = 12; i < 50; i++)
            {
                Console.SetCursorPosition(i, 12);
                Console.Write(" KOSEN KMUTT Y3 Bonjour.");
                Thread.Sleep(50);
            }
            for (int i = 50; i > 12; i--)
            {
                Console.SetCursorPosition(i, 12);
                Console.Write(" KOSEN KMUTT Y3 Bonjour. ");
                Thread.Sleep(50);
            }
        }

        static void Exercise4()
        {
            //Add a line break. //
            Console.WriteLine();
            //Write a line of text to the console without a line break.//
            Console.Write("A line of text");
            //Write the text on a new line using the \n command.//
            Console.WriteLine("\nAnother line of text");
            //Write the text in two columns using \t.//
            Console.WriteLine("\tName\tAge");
            //Insert and add the values a comma separated list.//
            Console.WriteLine("Welcome {0}!", "Jonas");
            //Create fixed length columns.//
            Console.WriteLine("{0,20}{1,4}", "Jonas", 45);
        }

        static void Exercise5()
        {
            while (true)
            {
                Console.Clear(); // Clear
                Console.WriteLine(Console.WindowWidth); // Read Window Prop.
                Console.WriteLine(Console.WindowHeight); // Read Window Prop.
                Thread.Sleep(1000);
                for (int i = 0; i <= Console.WindowWidth - 1; i++)
                {
                    for (int j = 0; j <= Console.WindowHeight - 2; j++)
                    {
                        Console.SetCursorPosition(i, j);
                        //Console.Write(" {0,3},{0,3} ", Console.WindowHeight, Console.WindowWidth);
                        Console.Write(" {0} ", "Tang");
                    }
                }
                for (int i = Console.WindowWidth - 1; i >= 0; i--)
                {
                    for (int j = Console.WindowHeight - 2; j >= 0; j--)
                    {
                        Console.SetCursorPosition(i, j);
                        //Console.Write(" {0,3},{0,3} ", Console.WindowHeight, Console.WindowWidth);
                        Console.Write(" {0} ", "Tang");
                    }
                }
            }
        }

        private static double Microsecond2Second(double Microsecond)
        {
            return Microsecond * Math.Pow(10, -9);
        }

        private static void NOP(double durationSeconds)
        {
            // Stop Watch Sleep
            
            var durationTicks = Math.Round(durationSeconds * Stopwatch.Frequency);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedTicks < durationTicks)
            {

            }
        }
    }
}
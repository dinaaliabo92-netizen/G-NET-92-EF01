using Microsoft.EntityFrameworkCore;

namespace G_NET_92_EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext context =
                   new AppDbContext())
            {
                bool result = context.Database.EnsureCreated();

                if (result)
                {
                    Console.WriteLine(
                        "Database Created Successfully!");
                }
                else
                {
                    Console.WriteLine(
                        "Database Already Exists!");
                }

                Console.WriteLine("Database Name: ReadMoreBooksDB");

                Console.WriteLine("Tables:");

                Console.WriteLine("1. Books");
                Console.WriteLine("2. Authors");
                Console.WriteLine("3. Categories");
            }

            Console.ReadKey();
        }


    }
           

    }
    


using HomeworkIndexer.Models;
using System;

namespace HomeworkIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Salam", 344, 45);
            Console.WriteLine(room1.ShowInfo());
        }
    }
}

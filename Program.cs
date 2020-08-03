using System;

namespace oop_w05
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b4 = new Building("4","Building 4","11111","22222");
            Room r433 = new Room("433","Room 433","4","4","computer",b4);
            Console.WriteLine(r433.ToString());
        }
    }
}

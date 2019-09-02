using System;

namespace F2019_420._323_Example_Intro_PartialClasses
{
    class Program
    {
        /// <summary>
        /// Demo project to show how partial classes work.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var item1 = new UpcItem("12456789", "2 Man Tent");

            Console.WriteLine(item1);
        }
    }
}

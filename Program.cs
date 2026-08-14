using System;

namespace LooseRunGuide
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LooseRunGuide started.");

            // Create the default guide file
            GuideFile.CreateDefaultGuide();

            Console.WriteLine("Guide file created successfully.");
        }
    }
}

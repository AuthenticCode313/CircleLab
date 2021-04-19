using System;


namespace CircleObjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester!");
            Console.WriteLine();
            CircumferenceAndArea cal = new CircumferenceAndArea();

            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine("Enter a radius: ");
                cal.Radius = double.Parse(Console.ReadLine());

                if (cal.Radius <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a radius greater than 0");
                }
                else
                {
                    Console.WriteLine($"Circumference: {cal.CalculateFormattedCircumference()} \n Area: {cal.CalculatedFormattedArea()}");
                }

                Console.WriteLine("Continue y/n?");
                string loop = Console.ReadLine();
                while (true)
                if (loop == "y")
                {
                    break;
                }
                else if (loop == "n")
                {
                    Console.WriteLine($"Goodbye. You created Circle objects.");
                    runProgram = false;
                    break;
                }
            }

        }
    }
}

using System;



namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first day of Christmass
            Day1 christmass = new Day1();
            List<string> codes = new List<string>
                //{ };
                { "L68", "L30", "R48", "L5", "R60", "L55", "L1", "L99", "R14", "L82" };
            //christmass.inputCodes(codes);
            christmass.deCode(codes);

            //On the second day of Christmass

        }
    }
}
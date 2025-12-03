using System;



namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////On the first day of Christmass
            //Day1 december1st = new Day1();
            //List<string> codes = new List<string>
            //    //{ };
            //    { "L68", "L30", "R48", "L5", "R60", "L55", "L1", "L99", "R14", "L82" };
            ////december1st.inputCodes(codes);
            //december1st.deCode(codes);



            //On the second day of Christmass
            Day2 december2nd = new Day2();                      //what
            List<string> iDs = new List<string>
                //{ };
                { "11-22", "95-115", "998-1012", "1188511880-1188511890", "222220-222224", "1698522-1698528", "446443-446449", "38593856-38593862", "565653-565659", "824824821-824824827", "2121212118-2121212124" };
            //december2nd.scanIdRange("11-22");
            //december2nd.scanIdRange("998-1012");
            //december2nd.scanIdRange("1188511880-1188511890");
            december2nd.goThroughIDs(iDs);
            december2nd.printInfo();


            //On the third day of christmass
            Day3 december3rd = new Day3();




        }
    }
}
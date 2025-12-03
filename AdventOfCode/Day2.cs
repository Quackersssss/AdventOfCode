using System;

namespace AdventOfCode
{
    internal class Day2
    {
        List<string> invalids = new List<string> { };


        //function that iterates through IDs
        public void goThroughIDs(List<string> codes)
        {
            foreach (string idRange in codes)
            {
                scanIdRange(idRange);
                //Console.WriteLine(idRange);
            }
        }



        //function that goes through numbers
        public void scanIdRange(string input)
        {
            //Console.WriteLine("\n\n");

            bool startsWith0 = false;
            string[] minMax = input.Split('-');
            foreach (string id in minMax)
            {
                //Console.WriteLine(id);
                if (id[0] == '0')
                {
                    //Console.WriteLine($"{id} is invalid due to a 0");
                    startsWith0 = true;
                }
            }

            if (startsWith0 == false)
            {
                for (int i = Convert.ToInt32(minMax[0]); i <= Convert.ToInt32(minMax[1]); i++)
                {
                    if (isHalfValid($"{i}"))
                    {
                        invalids.Add($"{i}");
                        //Console.WriteLine($"{i} is invalid");
                    }

                }
            }
            else 
            {
                //Console.WriteLine($"{input} is invalid due to a 0"); 
            }
        }



        //function that checks for duplicate numbers
        public bool isHalfValid(string id)
        {
            int halfWay = (id.Length / 2) - ((id.Length / 2) % 1);
            //Console.WriteLine($"{halfWay} is about half the length of {id}");

            string firstHalf = "";
            string lastHalf = "";

            for (int x = 0; x < halfWay; x++)
            {
                firstHalf += id[x];
            }
            for (int y = halfWay; y < id.Length; y++)
            {
                lastHalf += id[y];
            }

            //Console.WriteLine($"!{firstHalf} {lastHalf}!");

            if (firstHalf == lastHalf)
            {
                //Console.WriteLine($"{id} contains contains duplicates of {firstHalf}");
                return true;
            }
            return false;
        }



        //function that shows invalid ids
        public void printInfo()
        {
            Console.WriteLine($"\n\ninvalids");
            int invalidTotal = 0;
            foreach (string id in invalids)
            {
                Console.WriteLine($" {id}");
                invalidTotal += Convert.ToInt32(id);
            }
            Console.WriteLine($"\ntotal of all: {invalidTotal}");
        }


    }
}

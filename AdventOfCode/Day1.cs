using System;


namespace AdventOfCode
{
    public class Day1
    {
        public int password = 50;
        public int timesToZero = 0;



        public void rotate(char direction, int amount)
        {
            if (direction == 'l' || direction == 'L')
            {
                if (password - amount < 0)
                {
                    password = 100 + password - amount;
                }
                else
                {
                    password -= amount;
                }
            }
            else if (direction == 'r' || direction == 'R')
            {
                if (this.password + amount > 99)
                {
                    password = password + amount - 100;
                }
                else
                {
                    password += amount;
                }
            }
            else
            {
                Console.WriteLine($"{direction}{amount} is an invalid code");
            }
            if (password == 0)
            {
                timesToZero += 1;
            }

            Console.WriteLine(password);
        }


        public void deCode(List<string> codes)
        {
            foreach (string code in codes)
            {
                char direction = code[0];
                string amount;
                if (code.Length > 2)
                {
                    amount = $"{code[1]}{code[2]}";
                }
                else
                {
                    amount = $"{code[1]}";
                }

                this.rotate(direction, Convert.ToInt32(amount));
            }
            Console.WriteLine($"The codes inputed makes the password: {timesToZero} zeros");
        }


        public void inputCodes(List<string> input)
        {
            Console.WriteLine("input code");
            codeLoop:
            string code = Console.ReadLine();

            if (code != "end")
            {
                if (code.Length <= 1 || code.Length >= 4 || (code[0] == 'r' || code[0] == 'l') )
                {
                    Console.WriteLine("code incorectly inputed try again:");
                    goto codeLoop;
                }
                else
                {
                    input.Add(code);
                    this.inputCodes(input);
                }
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberWord
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numberList = new List<string>();
            numberList.Add("Baseball");
            numberList.Add("Bat");
            numberList.Add("Base");
            numberList.Add("Foul");
            numberList.Add("Strike");
            numberList.Add("Umpire");
            numberList.Add("Glove");
            numberList.Add("Pitcher");
            numberList.Add("Catcher");
            numberList.Add("Coach");

            Random random = new Random();

            int oneToTen = random.Next(1, 11);

            Console.WriteLine(oneToTen);

            Console.WriteLine(numberList.ElementAt(oneToTen));

            //computer picks a random number between 1 to 10 and compares it tothe list given. Selects a number at random based on the list given.

            Console.ReadLine();


        }
    }
}

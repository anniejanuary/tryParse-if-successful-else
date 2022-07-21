using System;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = "128";
            int stringParsedIntoInt; //not parsing it yet, just naming it
            bool successfullParse = int.TryParse(numberAsString, out stringParsedIntoInt);

            //Console.WriteLine($"Parse was a success: {successfullParse}");
            //Console.WriteLine($"StringParsedIntoInt is {stringParsedIntoInt}");

            if(successfullParse)
            {
                Console.WriteLine($"Parse was a success, stringParsedIntoInt = {stringParsedIntoInt}");
            }

            else
            {
                Console.WriteLine("Parse was unsuccessfull");
            }

            Console.Read();

        }
    }
}

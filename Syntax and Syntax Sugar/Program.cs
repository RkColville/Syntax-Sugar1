using System;

namespace Syntax_and_Syntax_Sugar
{
    class Program
    {
        static void Main(string[] args)
        {

            var answer = 10;          
            var positiveMessage = (answer < 9) ? " is less than nine" : " is greater than nine";

                Console.WriteLine($"{answer}{positiveMessage}");











            //int answer = 4;
            //string response;

            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is less than nine";
            //}
            //Console.WriteLine(response);



        }
    }
}

           
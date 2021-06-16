using System;

namespace Passcode_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";

            while(code != "secret")
            {
            Console.WriteLine("What is the pass code?");
            code = Console.ReadLine().ToLower();

            if(code == "pass code")
            {
                Console.WriteLine("Nice try, but incorrect");
            }
            else if(code != "secret")
            {
                Console.WriteLine("Access Denied, Please insert correct Pass Code");
            }

            }

            if(code == "secret")
            {
                Console.WriteLine("Access granted");
            }
        }
    }
}

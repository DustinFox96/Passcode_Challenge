using System;

namespace Passcode_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the pass code?");
            var code = Console.ReadLine().ToLower();

            if(code == "secret")
            {
                Console.WriteLine("Access granted");
            }
            else if(code != "secret")
            {
                Console.WriteLine("Access Denied, Please insert correct Pass Code");
            }else if(code == "fake pass code")
            {
                Console.WriteLine("Nice try");
            }

        }
    }
}

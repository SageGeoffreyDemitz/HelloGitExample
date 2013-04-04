using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            // this comment was created on the master branch
            Console.WriteLine("Hello, Git!  It's fun!");
            Console.WriteLine("You've been modified!");
            Console.WriteLine("Today's Fortune: " + GetFortune());
            Console.WriteLine("Have a nice day.");
            Console.ReadKey(); 
        }

        private static  string GetFortune()
        {
            Random rnd = new Random();
            int whichOne = rnd.Next(3);
            switch (whichOne)
            {
                case 1:
                    return "You will meet a tall dark stranger.";
                    
                case 2:
                    return "No bugs!!!";
                    
                case 3:
                    return "Avoid dogs today.";
                    
                default:
                    return "No fortune";
            }
        }
    }
}

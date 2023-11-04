using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utils
{
    public static class MessageLogger
    {
        public static void LogErrorMessage(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;

        }
        public static void LogInformationMessage(string Message) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void LogWarringMessage(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Message);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}

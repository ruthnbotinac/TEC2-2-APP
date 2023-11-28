namespace Application.Utils
{
    public static class MessageLogger
    {
        //Metodos para logear información 
        public static void LogErrorMessage(Exception ex)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void LogInformationMessage(string message)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void LogWarningMessage(string message)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }




    }
}

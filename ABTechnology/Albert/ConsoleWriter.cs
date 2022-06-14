


namespace Albert
{
    /// <summary>
    /// Console Mudle to speed up the process  
    /// </summary>
    public static class ConsoleWriter
    {


        /// <summary>
        /// Clear console and Create a Title
        /// </summary>
        /// <param name="_title">Title</param>
        public static void WriteTitle(string _title)
        {
            //Create a Title
            Clear();
            WriteLine(_title);
            WriteLine("--------------------");



        }


        /// <summary>
        /// Method to exit or return to part  of aconsole application 
        /// </summary>
        /// <param name="_program">Method you want ot go to</param>
        public static void WriteExit(Action _program)
        {
            Write("Do you want to exit?(y/n)\nAnswer:");
            var ans = ReadLine();
            switch (ans)
            {
                case "y":
                    WriteLine("Goodbye!");
                    break;
                case "n":
                    _program.Invoke();
                    break;
            }

        }

        public static void WriteDocument(string _title, string _text)
        {

            WriteLine(_title);    
            WriteLine("---------------------------------------");
            WriteLine(_text);
            WriteLine("---------------------------------------");
        }
        /// <summary>
        /// WriteExit Method for going to another part of the Pragram
        /// </summary>
        /// <param name="_start"></param>
        /// <param name="_program"></param>
        public static void WriteExit(Action _start,Action _program)
        {
            Write("Do you want to exit?(y/n)\nAnswer: ");
            var choice = ReadLine();

            switch(choice)
            {
                case "y":
                    _start.Invoke();
                    break;
                default:
                    _program.Invoke();
                    break;
            }
        }
         
           
       


    }
}

using System;

namespace ServerTAL
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.Title = "ServerTAL";

            Server.Start(50, 26950);
            
            Console.ReadKey();
        }
    }
}
using System;

namespace PongGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ora la funzione Main() della classe Program verrà eseguita");
            new Game().Run();
        }
    }
}
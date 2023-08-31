using System;


namespace superheroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Superheroe superheroe1 = new Superheroe("max", 41, 50, 60);
            Superheroe superheroe2 = new Superheroe("jose", 42, 50, 60);
            Console.WriteLine(superheroe1.Ganador(superheroe2));

        }
    }
}

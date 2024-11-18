using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            USET halmaz = new(5);
            halmaz.Push("Piroska");
            halmaz.Push("Géza");
            halmaz.Push("István");
            halmaz.Push("Piroska");
            halmaz.Push("Péter");
            //halmaz.Push("Ádám");
            Console.WriteLine(halmaz.ToString());
            halmaz.Remove("István");
            Console.WriteLine(halmaz.ToString());
        }
    }
}

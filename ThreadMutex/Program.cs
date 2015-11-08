using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadMutex
{
    class Program
    {
        static void Main(string[] args)
        {
            People Dave = new People();
            Dave.PeopleThread.Name = "Dave";
            People Brice = new People();
            Brice.PeopleThread.Name = "Brice";

            Dave.PeopleThread.Start(3);
            Brice.PeopleThread.Start(2);

            Dave.PeopleThread.Join();
            Brice.PeopleThread.Join();
            Console.ReadKey();
        }
    }
}

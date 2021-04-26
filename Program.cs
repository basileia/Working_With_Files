using System;
using System.Linq;

namespace Working_With_Files
{
    class Program
    {
        static void Main()
        {
 
            GuestBook guestbook = new GuestBook();
            
            if (guestbook.Visits.Any())
            {
                guestbook.ViewVisits();              
            }
            else
            {
                guestbook.AddVisit("Karel", 32);
                guestbook.AddVisit("Petr", 35);
                guestbook.CreateFile();
                guestbook.FileDataProcessing();
                guestbook.ViewVisits();
            }
            
            Console.ReadLine();

        }
    }
}

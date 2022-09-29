/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf
{
    internal class Program
    {
        private static void reserverPlads()
            {
            Console.WriteLine("Vælg venligt et sæde imellem plads 1 og 3");
            string userInput = Console.Readline();
            int seatNumber = int.Parse(userInput);//1. Kunden vælger pladsen

            //index starter med 0, så vil skal skubbe den ned med den
            if (seat[seatNumber - 1].isAvailable == true) // 2. System tjekker om plads er tilgængelig
            {
                Console.WriteLine("Pladsen er tilgængelig, vil du booke det?"); // 3. Meld tilbage til kunden og bekræft om der vil bekræftes
                string userInput2 = Console.Readline();
                if (userinput2.Equals("y"))// 4. Kunden bekæfter resevationen
                {
                 seat[seatNumber-1].isAvailable=false; // 5. Pladsen bliver utilgængelig
                 kunde1.reservations.Add(Seat[seatNumber-1]); // 6. Systemet tildeler paldsen
                 Console.WriteLine("Du har nu booket pladsen");
                }
            }
            }  

    }
}          // Sæt ind i kode */
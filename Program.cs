using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie ("SUI, a Christiano ronaldo autobiofgrafy", 60, 18, 6050, 150);
            Movie movie2 = new Movie ("Fat and Furious, A documentary about Alexander Mikkelsens struggle with obesity", 69, 18, 10800, 110);
            Movie movie3 = new Movie ("They can't see me, The true sad story About The Rock and no steoider", 60, 16, 4800, 110);
            Movie movie4 = new Movie ("John Cena: Battle for the last social credit", 60, 18, 1200, 120);
            Movie movie5 = new Movie ("From me to mountain, documentary about Alexander",60, 18, 7200, 130);

            
            Console.WriteLine("Welcome to HCØL biograf!");

            Console.WriteLine("Enter your name:");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter your alder:");
            string customerAge = Console.ReadLine();
            
            Customer customer = new Customer(1,customerName,int.Parse(customerAge));
            

          
            bool isProgramExiting = false, isInputCorrect = false;

            while (!isProgramExiting)
            {
                Console.WriteLine("You have the folllowing options:");
                Console.WriteLine("[1] Reservating a Ticket");
                Console.WriteLine("[2] Cancel a Ticket Reservation");
                Console.WriteLine("[3] View all movies");
                Console.WriteLine("[0] Quit program");

                int numberInput = -1;
                isInputCorrect = false;

                while (!isInputCorrect)
                {
                    string userInput = Console.ReadLine();

                    try
                    {
                        numberInput = int.Parse(userInput);
                        if (numberInput >= 0 && numberInput <= 3)
                        {
                            isInputCorrect = true;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number for which menu item you want to use");
                    }
                }

                switch (numberInput)
                {
                    case 0:
                        Console.WriteLine("Program is now exiting, bye now");
                        isProgramExiting = true;
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.WriteLine("Choose a film: ");
                        Console.WriteLine("[1] "+movie1.getName());
                        Console.WriteLine("[2] "+movie2.getName());
                        Console.WriteLine("[3] "+movie3.getName());
                        Console.WriteLine("[4] "+movie4.getName());
                        Console.WriteLine("[5] "+movie5.getName());

                        string movieInput2 = Console.ReadLine();
                        int movieInput = int.Parse(movieInput2);

                        if (movieInput == 1)
                        {
                            Console.WriteLine("There are" + movie1.getSeats() + "left, how many seats would you like to reserve?");
                            string dd = Console.ReadLine();
                            if (movie1.reserverPlads(int.Parse(dd)) == true) {
                                Console.WriteLine("Du har bestilt "+dd+" pladser til filmen "+movie1.getName());
                            } else {
                                Console.WriteLine("Der er ikke så mange pladser tilbage til denne film");
                            }

                        } 
                        if (movieInput == 2)
                        {
                        Console.WriteLine("There are" + movie2.getSeats() + "left, how many seats would you like to reserve?");
                            string dd = Console.ReadLine();
                            if (movie2.reserverPlads(int.Parse(dd)) == true) {
                                Console.WriteLine("Du har bestilt "+dd+" pladser til filmen "+movie2.getName());
                            } else {
                                Console.WriteLine("Der er ikke så mange pladser tilbage til denne film");
                            }                       
                        } 
                        if (movieInput == 3) {
                        Console.WriteLine("There are" + movie3.getSeats() + "left, how many seats would you like to reserve?");
                            string dd = Console.ReadLine();
                            if (movie3.reserverPlads(int.Parse(dd)) == true) {
                                Console.WriteLine("Du har bestilt "+dd+" pladser til filmen "+movie3.getName());
                            } else {
                                Console.WriteLine("Der er ikke så mange pladser tilbage til denne film");
                            }
                        }
                        if(movieInput == 4)
                        {
                            Console.WriteLine("There are" + movie4.getSeats() + "left, how many would you like to reserve?");
                            string dd = Console.ReadLine();
                            if (movie4.reserverPlads(int.Parse(dd)) == true) {
                                Console.WriteLine("Du har bestilt "+dd+" pladser til filmen "+movie4.getName());
                            } else {
                                Console.WriteLine("Der er ikke så mange pladser tilbage til denne film");
                            }
                        }
                        if(movieInput == 5)
                        {
                            Console.WriteLine("There are" + movie5.getSeats() + "left, how many would you like to reserve?");
                            string dd = Console.ReadLine();
                            if (movie5.reserverPlads(int.Parse(dd)) == true) {
                                Console.WriteLine("Du har bestilt "+dd+" pladser til filmen "+movie5.getName());
                            } else {
                                Console.WriteLine("Der er ikke så mange pladser tilbage til denne film");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Try writing one of the films numbers you absolute nonce");
                        }
                        
                        
                        break;
                    case 2:
                        //Cancel reservation
                        
                        break;
                    case 3:
                        //Overview of reservations
                        break;
                    default:
                        break;
                }
            }

        
        }
    }
}
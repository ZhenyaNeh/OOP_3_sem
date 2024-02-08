using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_16
{
    static class WorkWhithClient
    {
        public static void Services(TravelAgent travelAgent, string nameClient)
        {
            Console.Clear();
            travelAgent.RegisterClient(nameClient);
            string clientID = travelAgent.GetClientID(nameClient);
            bool isClientLoggedIn = travelAgent.SignIn(nameClient, clientID);

            if (isClientLoggedIn)
            {
                Console.WriteLine("Сlient successfully registered\n");
                Console.WriteLine("Press any button...");
                Console.ReadKey();
                Console.Clear();

                bool repiaat = true;
                int choice = 0;
                string nameTour = "";
                bool hotTure = default;
                double costTour = default;

                while (repiaat)
                {
                    Console.WriteLine("CLIENT SETUP\n");
                    Console.WriteLine("Now you customize Client:");
                    travelAgent.ViewClients();

                    choice.CheckInt("1. Add tours \n" +
                                    "2. Remove tour \n" +
                                    "3. Modify tour \n" +
                                    "4. View Tours \n" +
                                    "5. End services\n\n" +
                                    " Write -> "
                                    );
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Write tour name: ");
                            nameTour = Console.ReadLine();
                            hotTure.CheckBool("It's a hot tour: ");
                            costTour.CheckDouble("Write tour price: ");

                            travelAgent.AddTour(nameTour, hotTure, costTour);
                            break;
                        case 2:
                            Console.WriteLine("Write tour name: ");
                            nameTour = Console.ReadLine();

                            travelAgent.RemoveTour(nameTour);
                            break;
                        case 3:
                            Console.WriteLine("Write tour name: ");
                            nameTour = Console.ReadLine();
                            hotTure.CheckBool("It's a hot tour: ");
                            costTour.CheckDouble("Write new tour price: ");

                            travelAgent.ModifyTour(nameTour, hotTure, costTour);
                            break;
                        case 4:
                            travelAgent.ViewTours();
                            break;
                        case 5:
                            Console.WriteLine("End Services");
                            repiaat = false;
                            break;
                        default:
                            Console.WriteLine("\nError!");
                            Console.WriteLine("You write uncorrect data");
                            Console.WriteLine("Try again");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                    Console.WriteLine("\nPress any button...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
                Console.WriteLine("Something was wrong");
        }
    }
}

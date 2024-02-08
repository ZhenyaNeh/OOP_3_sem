namespace laba_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TravelAgent travelAgent = new TravelAgent();

            int choice = 0;
            bool repiat = true;
            while (repiat)
            {
                choice.CheckInt("1. Register new Client \n" +
                                "2. View All Client and their tours \n" +
                                "3.Exit \n\n" +
                                " Write -> ");
                switch (choice)
                {
                    case 1:
                        string nameClient;
                        Console.WriteLine($"Write Name new Client");
                        nameClient = Console.ReadLine();
                        WorkWhithClient.Services(travelAgent, nameClient);
                        choice = 99999;
                        travelAgent.SeveClient();
                        break;
                    case 2:
                        travelAgent.ViewAllClients();
                        break;
                    case 3:
                        Console.WriteLine("Exit complete");
                        repiat = false;
                        break;
                    default:
                        break;
                }
                if(choice != 99999)
                {
                    Console.WriteLine("\nPress any button...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
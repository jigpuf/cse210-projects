using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        while(choice != "4"){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu:");
            choice = Console.ReadLine();
            if(choice == "1"){
                Breathing breathing = new Breathing();
                    breathing.GetStartingMessage("Breathing");
                    breathing.GetBreathingSummary();
                    breathing.Start();
                    breathing.BreathingActivity();
                    breathing.GetEndingMessage("Breathing");
                //add to make it work
            }
            else if(choice == "2"){
                Reflecting reflecting = new Reflecting();
                    reflecting.GetStartingMessage("Reflecting");
                    reflecting.GetReflectingSummary();
                    reflecting.Start();
                    reflecting.ReflectingActivity();
                    reflecting.GetEndingMessage("Reflecting");

                //add to make it work
            }
            else if(choice == "3"){
                Listing listing = new Listing();
                listing.GetStartingMessage("Listing");
                listing.GetListingSummary();
                listing.Start();
                listing.ListingActivity();
                listing.GetEndingMessage("Listing");

                //add to make it work
            }
            else{
                  Console.WriteLine("Sweet Action!");  //message to pick available number
            }
            //exit message
        }
    
    }
}
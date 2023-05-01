using System;


namespace mis_221_pa_5_clehman1
{
    public class Menu
    {

        public Menu[] menus;

        public void MenuUtility(Menu[] menus){
            this.menus = menus;
        }



        public void ManagerMenu(){

            Trainer[] trainers = new Trainer[20];
            Listing[] listings = new Listing[20];
            Booking[] bookings = new Booking[20];
            Reports[] reports = new Reports[20];


            Trainer_Utility trainerUtility = new Trainer_Utility();
            Listing_Utility listingUtility = new Listing_Utility();
            Booking_Utility bookingUtility = new Booking_Utility();
            Report_Utility reportUtility = new Report_Utility();


            System.Console.WriteLine("Welcome to Train Like a Champion manager menu");
            System.Console.WriteLine("Please select one of the options");

            System.Console.WriteLine("Enter 1 to Add a Trainer to file");
            System.Console.WriteLine("Enter 2 to Update a Trainer on file");
            System.Console.WriteLine("Enter 3 to Delete a Trainer on file");
            System.Console.WriteLine("Enter 4 to Add a Listing to file");
            System.Console.WriteLine("Enter 5 to Update a Listing on file");
            System.Console.WriteLine("Enter 6 to Delete a Listing on file");
            System.Console.WriteLine("Enter 7 to View a Booking session");
            System.Console.WriteLine("Enter 8 to Add a Booking Session");
            System.Console.WriteLine("Enter 9 to Update Booking to file");
            System.Console.WriteLine("Enter 10 to view Individual Customer Sessions");
            System.Console.WriteLine("Enter 11 to view Historical Customer Sessions");
            System.Console.WriteLine("Enter 12 to view historical Revenue Reports");
            System.Console.WriteLine("Enter 13 to exit");
            string input = Console.ReadLine();

            while(input != "13"){
                if(input == "1"){
                    trainerUtility.AddTrainer();
                }
                else if(input == "2"){
                    trainerUtility.UpdateTrainer();
                }
                else if(input == "3"){
                    trainerUtility.DeleteTrainer();
                }
                else if(input == "4"){
                    listingUtility.AddListings();
                }
                else if(input == "5"){
                    listingUtility.UpdateListing();
                }
                else if(input == "6"){
                    listingUtility.DeleteListing();
                }
                else if(input == "7"){
                   bookingUtility.GetAllBookingsFromFile();
                }
                else if(input == "8"){
                    bookingUtility.AddBooking();
                    
                }
                else if(input == "9"){
                    bookingUtility.UpdateBooking();
                }
                else if(input == "10"){
                    reportUtility.IndividualCustomerSessions();
                }
                else if(input == "11"){
                    reportUtility.HistoricalCustomerSessions();
                }
                else if(input == "12"){
                    reportUtility.HistoricalRevenueReport();
                }
                else{
                    System.Console.WriteLine("Invalid option try again");
                }
            System.Console.WriteLine("Welcome to Train Like a Champion manager menu");
            System.Console.WriteLine("Please select one of the options");

            System.Console.WriteLine("Enter 1 to Add a Trainer to file");
            System.Console.WriteLine("Enter 2 to Update a Trainer on file");
            System.Console.WriteLine("Enter 3 to Delete a Trainer on file");
            System.Console.WriteLine("Enter 4 to Add a Listing to file");
            System.Console.WriteLine("Enter 5 to Update a Listing on file");
            System.Console.WriteLine("Enter 6 to Delete a Listing on file");
            System.Console.WriteLine("Enter 7 to View a Booking session");
            System.Console.WriteLine("Enter 8 to Add a Booking Session");
            System.Console.WriteLine("Enter 9 to Update Booking to file");
            System.Console.WriteLine("Enter 10 to view Individual Customer Sessions");
            System.Console.WriteLine("Enter 11 to view Historical Customer Sessions");
            System.Console.WriteLine("Enter 12 to view historical Revenue Reports");
            System.Console.WriteLine("Enter 13 to exit");
            input = Console.ReadLine();

            }
           
            

        }

    }
  
}
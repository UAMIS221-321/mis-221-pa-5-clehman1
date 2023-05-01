

namespace mis_221_pa_5_clehman1
{
    public class Booking_Utility
    {
        private Booking[] bookings;

        public Booking_Utility()
        {
            bookings = new Booking[100];
        }


        public void GetAllBookingsFromFile(){
            System.Console.WriteLine("Please enter the name of the customer who's session you are looking for");
            string customerName = Console.ReadLine();

            StreamReader inFile = new StreamReader("transactions.txt");
            string line = inFile.ReadLine();

           
            
            while (line != null)
            {
                
                string[] temp = line.Split('#');
                if(temp[2] == customerName){
                    System.Console.WriteLine($"Session Available: {temp[8]} ");
                }
                else{
                     System.Console.WriteLine("Booking does not exist try again");
                }
                line = inFile.ReadLine();
            }

            inFile.Close();
           
        
        }
        public void AddBooking(){
            System.Console.WriteLine("Please enter the Session ID");
            Booking myBooking = new Booking();
            myBooking.SetSessionID(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("Please enter the customer ID");
            myBooking.SetCustomerID(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("Please enter the customer name");
            myBooking.SetCustomerName(Console.ReadLine());

            System.Console.WriteLine("Please enter the customer email");
            myBooking.SetCustomerEmail(Console.ReadLine());

            System.Console.WriteLine("Please enter the number of sessions the customer has attended");
            myBooking.SetCustomerSessions(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("Please enter a valid training Date that occurs on the calendar in 2023");
            myBooking.SetTrainingDate(Console.ReadLine());

            System.Console.WriteLine("Please enter the ID of the trainer");
            myBooking.SetTrainerID(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("Please enter the name of the trainer");
            myBooking.SetTrainerName(Console.ReadLine());

            //System.Console.WriteLine("Please enter the status of the booking");

            bool bookingStatus = true;
            myBooking.SetBookingStatus(bookingStatus);

            bookings[Booking.GetCount()] = myBooking;
            Booking.IncCount();

            Save();

                
        }
        private void Save()
        {
            StreamWriter outFile = new StreamWriter("transactions.txt");

            for (int i = 0; i < Booking.GetCount(); i++)
            {
                outFile.WriteLine(bookings[i].GetSessionID() + "#" + bookings[i].GetCustomerID() + "#" + bookings[i].GetTrainerName() + "#" + bookings[i].GetCustomerEmail() + "#" + bookings[i].GetCustomerSessions() + "#" + bookings[i].GetTrainingDate() + "#" + bookings[i].GetTrainerID() + "#" + bookings[i].GetTrainerName() + "#" + bookings[i].GetBookingStatus());
            }
            outFile.Close();
        }
       

        public void UpdateBooking(){
            StreamReader inFile = new StreamReader("transactions.txt");
            System.Console.WriteLine("What is the session ID of the booking needs to be updated?");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
                System.Console.WriteLine("Please enter the Session ID");
                Booking myBooking = new Booking();
                bookings[foundIndex].SetSessionID(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Please enter the customer ID");
                bookings[foundIndex].SetCustomerID(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Please enter the customer name");
                bookings[foundIndex].SetCustomerName(Console.ReadLine());

                System.Console.WriteLine("Please enter the customer email");
                bookings[foundIndex].SetCustomerEmail(Console.ReadLine());

                System.Console.WriteLine("Please enter a valid training Date that occurs on the calendar in 2023");
                bookings[foundIndex].SetTrainingDate(Console.ReadLine());

                System.Console.WriteLine("Please enter the ID of the trainer");
                bookings[foundIndex].SetTrainerID(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Please enter the name of the trainer");
                bookings[foundIndex].SetTrainerName(Console.ReadLine());

                System.Console.WriteLine("Has the booking been completed");

                DeleteBooking();

                // bool bookingStatus = false;
                // myBooking.SetBookingStatus(false);
                // bookings[foundIndex].SetBookingStatus(Console.ReadLine());

                
            }
            else{
                System.Console.WriteLine("Booking does not exist");
            }
            inFile.Close();
        }
        private int Find(int searchVal){
            StreamReader inFile = new StreamReader("transactions.txt");
            string num = inFile.ReadLine();

            string[] temp = num.Split("#");

            for(int i = 0; i < Booking.GetCount(); i++){
                if(temp[0] == searchVal.ToString()){
                    return i;
                }
            }
            inFile.Close();
            return -1;
        }
        public void DeleteBooking()
        {
            StreamReader inFile = new StreamReader("transactions.txt");
            Console.WriteLine("What is the session ID of the booking you want to delete");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = Find(searchVal);
    
            if (foundIndex != -1)
            {
                bookings[foundIndex].SetBookingStatus(false);
            Save();
            }
            else
            {
                Console.WriteLine("Booking does not exist");
            }
            inFile.Close();
        }

    }
}

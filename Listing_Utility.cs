

namespace mis_221_pa_5_clehman1
{
    public class Listing_Utility
    {
        private Listing[] listings;

        public Listing_Utility()
        {
            listings = new Listing[100];
        }

        public Listing[] GetAllListingsFromFile()
        {
           StreamReader inFile = new StreamReader("listing.txt");

            Listing.SetCount(0);
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split("#");
                listings[Listing.GetCount()] = new Listing(int.Parse(temp[0]), temp[1], temp[2], double.Parse(temp[3]),double.Parse(temp[4]));
                Listing.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
            return listings;
        }
        //menu option 4
        public void AddListings()
        {
           System.Console.WriteLine("Please enter the Session ID you want");
           Listing myListing = new Listing();
           myListing.SetSessionID(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("Please enter the name of the Trainer");
            myListing.SetTrainerName(Console.ReadLine());

            System.Console.WriteLine("Please enter the date of training Session");
            myListing.SetDate(Console.ReadLine());

            System.Console.WriteLine("Please enter the time of the session. Enter a valid time in the form of a decimal");
            myListing.SetTime(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("Please enter the cost of the session");
            myListing.SetCost(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("Your session has been added to listing.txt with availabilty and deleted at the end.");

            bool available = true;
            myListing.SetAvailability(true);

            bool deleted = false;
            myListing.SetDeleted(deleted);

            listings[Listing.GetCount()] = myListing;
            Listing.IncCount();

            Save();
        }

        private void Save()
        {
            StreamWriter outFile = new StreamWriter("listing.txt");

            for (int i = 0; i < Listing.GetCount(); i++)
            {
                outFile.WriteLine(listings[i].GetSessionID() + "#" + listings[i].GetTrainerName() + "#" + listings[i].GetDate() + "#" + listings[i].GetTime() + "#" + listings[i].GetCost() + "#" + listings[i].GetAvailability() + "#" + listings[i].GetDeleted());
            }
            outFile.Close();
        }

        private int Find(int searchVal)
        {
            StreamReader inFile = new StreamReader("listing.txt");

            for (int i = 0; i < Listing.GetCount(); i++)
            {
                if (listings[i].GetSessionID() == searchVal)
                {
                    return i;
                }
            }
            inFile.Close();
            return -1;
        }
        // menu option 5
        public void UpdateListing()
        {
        Console.WriteLine("What is the Session ID of the listing that needs to be updated?");
        int searchVal = int.Parse(Console.ReadLine());
        int foundIndex = Find(searchVal);

        if (foundIndex != -1)
        {
            Console.WriteLine("Please enter the Session ID of the Listing");
            listings[foundIndex].SetSessionID(int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter the name of the Trainer");
            listings[foundIndex].SetTrainerName(Console.ReadLine());

            Console.WriteLine("Please enter the date of the Session");
            listings[foundIndex].SetDate(Console.ReadLine());

            Console.WriteLine("Please enter the time of the session. Please enter a valid time in the form of a decimal");
            listings[foundIndex].SetTime(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("Please enter the cost of the session");
            listings[foundIndex].SetCost(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("Your listing has been updated");

            // System.Console.WriteLine("Please enter if you are available");
            // listings[foundIndex].SetAvailability(Console.ReadLine());
            Save();
        }
        else
        {
            Console.WriteLine("Listing does not exist");
        }
        }   
        //menu option 6
        public void DeleteListing()
        {
            Console.WriteLine("What is the Id of the Listing you want to delete");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = Find(searchVal);
    
            if (foundIndex != -1)
            {
                listings[foundIndex].SetDeleted(true);
            Save();
            }
            else
            {
                Console.WriteLine("Listing does not exist");
            }
        }
    }
}





































// public Listing[] listing;

//         public void ListingUtility(Listing[] listing){
//             this.listing = listing;
//         }


//         public Listing[] GetAllListingsFromFile(){
//         StreamReader inFile = new StreamReader("listing.txt");

//         Listing.SetCount(0);
//         string line = inFile.ReadLine();
//         while(line != null){
//             string[] temp = line.Split("#");
//             listing[Listing.GetCount()] = new Listing(temp[0], int.Parse(temp[1]), temp[2], temp[3], int.Parse(temp[4]), int.Parse(temp[5]));
//             Listing.IncCount();
//             line = inFile.ReadLine();
//         }
//         inFile.Close();
//         return listing;
//         }


//         public void AddListing(){
//         System.Console.WriteLine("Please enter the trainer name");
//         Listing myListing = new Listing();
//         myListing.SetTrainerName(Console.ReadLine());

//         System.Console.WriteLine("Please enter the trainer ID");
//         myListing.SetTrainerID(int.Parse(Console.ReadLine()));

//         System.Console.WriteLine("Please enter the date of the listing");
//         myListing.SetDate(Console.ReadLine());

//         System.Console.WriteLine("Please enter the availability of trainers");
//         myListing.SetAvailability(Console.ReadLine());

//         System.Console.WriteLine("Please enter the time of the session");
//         myListing.SetTime(int.Parse(Console.ReadLine()));

//         System.Console.WriteLine("Please enter the cost of the session");
//         myListing.SetCost(int.Parse(Console.ReadLine()));

//         listing[Listing.GetCount()] = myListing;
//         Listing.IncCount();

//         Save();
//         }

//         private void Save(){
//             StreamWriter outFile = new StreamWriter("listing.txt");


//             for(int i = 0; i < Listing.GetCount(); i++){
//                 outFile.WriteLine(listing[i].ToFile());
//             }
//             outFile.Close();
//         }
//         private int Find(int searchVal){
//             for(int i = 0; i < listing.SetCount(); i++){
//                 if(listing[i].SetTrainerID() == searchVal){
//                     return i;
//                 }
//             }
//             return -1;
//         }
//         public void UpdateListing(){
//             System.Console.WriteLine("What listing needs to be updated?");
//             int searchVal = Console.ReadLine();
//             int foundIndex = Find(searchVal);

//             if(foundIndex != -1){
//                 System.Console.WriteLine("Please enter the trainer name");
//                 Listing myListing = new Listing();
//                 listing[foundIndex].SetTrainerName(Console.ReadLine());

//                 System.Console.WriteLine("Please enter the trainer ID");
//                 listing[foundIndex].SetTrainerID(int.Parse(Console.ReadLine()));

//                 System.Console.WriteLine("Please enter the date of the listing");
//                 listing[foundIndex].SetDate(Console.ReadLine());

//                 System.Console.WriteLine("Please enter the availability of trainers");
//                 listing[foundIndex].SetAvailability(Console.ReadLine());

//                 System.Console.WriteLine("Please enter the time of the session");
//                 listing[foundIndex].SetTime(double.Parse(Console.ReadLine()));

//                 System.Console.WriteLine("Please enter the cost of the session");
//                 listing[foundIndex].SetCost(double.Parse(Console.ReadLine()));

//                 Save();
//             }
//             else{
//                 System.Console.WriteLine("Listing does not exist");
//             }
//         }
//         public void DeleteListing(){
//             System.Console.WriteLine("What is the session ID of the listing you want to delete");
//             int searchVal = int.Parse(Console.ReadLine());
//             int foundIndex = Find(searchVal);
//             if(foundIndex != -1) {
//                 listing[foundIndex].SetDeleted(true);
//             }
//             Save();
//             }
//         }
using mis_221_pa_5_clehman1;


Trainer[] trainers = new Trainer[20];
Listing[] listings = new Listing[20];
Booking[] bookings = new Booking[20];


Trainer_Utility trainerUtility = new Trainer_Utility();
Listing_Utility listingUtility = new Listing_Utility();
Booking_Utility bookingUtility = new Booking_Utility();


Menu menus = new Menu();

menus.ManagerMenu();


// new Trainer("Crawford Lehman", "crawfordlehman@icloud.com", "205-561-8028")
//0, new Trainer("Edward Lehman", "edwardlehman@icloud.com", "205-310-7567"));
//new Listing(1, "Crawford Lehman", "crawfordlehman@icloud.com", "205-561-8028"));
//(0, new Listing(2, "Edward Lehman", "edwardlehman@icloud.com", "205-310-7567"));

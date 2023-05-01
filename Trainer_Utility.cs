

namespace mis_221_pa_5_clehman1
{
    public class Trainer_Utility
    {
        private Trainer[] trainers;

        public Trainer_Utility()
        {
            trainers = new Trainer[100];
        }
        //Used to access files before the menu. Test Practice
        public Trainer[] GetAllTrainersFromFile()
        {
           StreamReader inFile = new StreamReader("trainer.txt");

            Trainer.SetCount(0);
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split("#");
                trainers[Trainer.GetCount()] = new Trainer(temp[0], temp[1], temp[2], int.Parse(temp[3]));
                Trainer.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
            return trainers;
        }
        //menu option 1
        public void AddTrainer()
        {
           System.Console.WriteLine("Please enter the name of the Trainer");
           Trainer myTrainer = new Trainer();
           myTrainer.SetName(Console.ReadLine());

            System.Console.WriteLine("Please enter the email of the Trainer");
            myTrainer.SetEmail(Console.ReadLine());

            System.Console.WriteLine("Please enter the address of the address of the Trainer");
            myTrainer.SetAddress(Console.ReadLine());

            System.Console.WriteLine("Please enter the Trainer's ID");
            myTrainer.SetID(int.Parse(Console.ReadLine()));


            bool deleted = false;
            myTrainer.SetDeleted(deleted);

            trainers[Trainer.GetCount()] = myTrainer;
            Trainer.IncCount();

            Save();
        }

        private void Save()
        {
            StreamWriter outFile = new StreamWriter("trainer.txt");

            for (int i = 0; i < Trainer.GetCount(); i++)
            {
                outFile.WriteLine(trainers[i].GetName() + "#" + trainers[i].GetEmail() + "#" + trainers[i].GetAddress() + "#" + trainers[i].GetID() + "#" + trainers[i].GetDeleted());
            }
            outFile.Close();
        }

        private int Find(int searchVal)
        {
            StreamReader inFile = new StreamReader("trainer.txt");

            for (int i = 0; i < Trainer.GetCount(); i++)
            {
                if (trainers[i].GetID() == searchVal)
                {
                    return i;
                }
            }
            inFile.Close();
            return -1;
        }
        //menu option 2
        public void UpdateTrainer()
        {
        Console.WriteLine("What is the ID of the trainer that needs to be updated?");
        int searchVal = int.Parse(Console.ReadLine());
        int foundIndex = Find(searchVal);

        if (foundIndex != -1)
        {
            Console.WriteLine("Please enter the name of the Trainer");
            trainers[foundIndex].SetName(Console.ReadLine());

            Console.WriteLine("Please enter the email of the Trainer");
            trainers[foundIndex].SetEmail(Console.ReadLine());

            Console.WriteLine("Please enter the address of the Trainer");
            trainers[foundIndex].SetAddress(Console.ReadLine());

            Console.WriteLine("Please enter the Trainer's Id");
            trainers[foundIndex].SetID(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("Your trainer has been updated");

            Save();
        }
        else
        {
            Console.WriteLine("Trainer does not exist");
        }
        }   
        //menu option 3
        public void DeleteTrainer()
        {
            Console.WriteLine("What is the Id of the trainer you want to delete");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = Find(searchVal);
    
            if (foundIndex != -1)
            {
                trainers[foundIndex].SetDeleted(true);
            Save();
            }
            else
            {
                Console.WriteLine("Trainer does not exist");
            }
        }
    }
}
    
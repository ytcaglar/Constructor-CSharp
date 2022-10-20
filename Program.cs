using System;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            worker1.Name="Yusuf Tolunay";
            worker1.Surname="Çağlar";
            worker1.PersonalID=11232201;
            worker1.Department="Electrical & Elektronics Engineer";
            worker1.WorkerInfo();

            Worker worker2 = new Worker(){Name = "Berk", Surname="Koşucu", PersonalID=11232202, Department="Electrical & Elektronics Engineer"};
            worker2.WorkerInfo();

            Worker worker3 = new Worker("Fevzi Burak", "Kurtçu", 11232203, "Electrical & Elektronics Engineer");
            worker3.WorkerInfo();

            Worker worker4 = new Worker("Eray", "Nurtekin");
            worker4.WorkerInfo();
        }
    }

    class Worker
    {
        public string Name;
        public string Surname;
        public int PersonalID;
        public string Department;

        public Worker(string name, string surname, int personalID, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.PersonalID = personalID;
            this.Department = department;
        }
        public Worker(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Worker()
        {
            
        }

        public void WorkerInfo(){
            Console.WriteLine("Personal Information:");
            Console.WriteLine("Name: {0}",this.Name);
            Console.WriteLine("Surname: {0}",this.Surname);
            Console.WriteLine("Personal ID no: {0}",this.PersonalID);
            Console.WriteLine("Department: {0}",this.Department);
        }
    }
}
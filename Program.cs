using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12ClassUml
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Username:admin");
            Console.WriteLine("Password:password");
            string userName;
            bool pass;

            do
            {
                Console.WriteLine("What is your username?");
                userName = Console.ReadLine().ToLower();
                Console.WriteLine("what is your password?");
                pass = Validator.VerifyPassword("password");
                Console.Clear();
            } while (!(userName == "admin" && pass));


            List < Person > members = InitializeList();
            while (true)
            {
                Console.WriteLine("Would you like to print the current list, add a student/staff member, or Quit?(1/2/3)");
                int choice = Validator.GetIntChoice(1, 3);
                if (choice == 0)
                {
                    Console.Clear();
                    PrintList(members);
                    Console.WriteLine("Press ESC to the menu");
                    while (Console.ReadKey(true).Key != ConsoleKey.Escape)
                    {

                    }
                    Console.Clear();
                }
                else if (choice == 1)
                {
                    Console.Clear();
                    members = AddPerson(members);
                    Console.Clear();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Goodbye, press any key to exit...");
                    Console.ReadKey(true);
                    System.Environment.Exit(0);

                }
            }


        }
        public static List<Person> InitializeList()
        {
            List<Person> members = new List<Person>()
            {
                new Student("Amilia Oliver", "124 X street, Detroit,MI", "C#.Net", 1, 9000),
            new Student("Nate Simpson", "176 Teach street, Otisville,MI", "C#.Net", 1, 9000),
            new Student("Rote Kampfflieger", "080 Red rd, Detroit,MI", "Bush-Plane Pilot", 2, 150000),
            new Staff("Teacher", "on earth", "Grand Circus", 70000),
            new Staff("Teacher Assistent", "on earth", "Grand Circus", 60000)
            };

            return members;
        }
        public static void PrintList(List<Person> people)
        {
            Console.Clear();
            foreach (Person pep in people)
            {
                Console.WriteLine(pep);
            }
        }
        public static List<Person> AddPerson(List<Person> members)
        {
            Console.WriteLine("Is your addition a Student or Staff member?(1/2)");
            int choice = Validator.GetIntChoice(1,2);
            if (choice == 1)
            {
                bool conf = Validator.GetYN($"Are you sure you want to add a Student?");
                if (conf)
                {
                    Console.Clear();
                    members.Add(AddStudent());
                    return members;
                }
            }
            else
            {
                bool conf = Validator.GetYN($"Are you sure you want to add a Staff member?");
                if (conf)
                {
                    Console.Clear();
                    members.Add(AddStaff());
                    return members;
                }
            }
            return members;
        }
        public static Student AddStudent()
        {
             
            string name = Validator.VerifyNames("\nWhat is their name?");
            string address = Validator.GetString("\nWhat is their address?");
            string program = Validator.GetString("\nWhat program are they in?");
            double fee = Validator.ValidateDouble("\nWhat is their fee?");
            Console.WriteLine("\nWhat year of class is it for them?");
            int year = Validator.GetIntChoice(0, 10);
            Student stu = new Student(name, address, program, year, fee);
            return stu;
        }
        public static Staff AddStaff()
        {
            string name = Validator.VerifyNames("\nWhat is their name?");
            string address = Validator.GetString("\nWhat is their address?");
            string school = Validator.GetString("\nWhat school do they work for?");
            double pay = Validator.ValidateDouble("\nWhat is their pay?");
            Staff stf = new Staff(name, address, school, pay);
            return stf;
        }
    }
}

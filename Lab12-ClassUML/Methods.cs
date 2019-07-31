using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab12_ClassUML
{
    class Methods
    {

        public static bool AddNewPerson(string message, List<Person> list)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            Console.WriteLine("");
            if(input == "view" || input == "1")
            {
                PrintPersonList(list);
                return true;
            }
            else if(input == "add" || input == "2")
            {
                AddPerson(list);
                return true;
            }
            else if(input == "quit" || input == "3")
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
            else
            {
                Console.WriteLine("That isn't an option.");
                return AddNewPerson(message, list);
            }
        }
        public static void PrintPersonList(List<Person> list)
        {
            Console.WriteLine("List of Students and Staff:\n");
            Console.WriteLine("Students:");
            foreach (var item in list)
            {
                var students = item as Student;
                if (students != null)
                {
                    Console.WriteLine($"\tName: {students.Name}, Address: {students.Address}, Program:{students.Program}, " +
                        $"Year: {students.Year}, Fee: {students.Fee} ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Staff:");
            foreach (var item in list)
            {
                var staff = item as Staff;
                if (staff != null)
                {
                    Console.WriteLine($"\tName: {staff.Name}, Address: {staff.Address}, School:{staff.School}, Pay: {staff.Pay}");
                }
            }
            Console.WriteLine("");
        }
        public static void PrintStudentList(List<Person> list)
        {
            Console.WriteLine("List of Students\n");
            foreach (var item in list)
            {
                var students = item as Student;
                if (students != null)
                {
                    Console.WriteLine(students.Name);
                }
            }
            Console.WriteLine("");
        }
        public static void PrintStaffList(List<Person> list)
        {
            Console.WriteLine("List of Staff\n");
            foreach (var item in list)
            {
                var staff = item as Student;
                if (staff != null)
                {
                    Console.WriteLine(staff.Name);
                }
            }
            Console.WriteLine("");
        }
        public static void AddPerson(List<Person> list)
        {
            Console.WriteLine("Which would you like to add?\n1.Student\n2.Staff");
            string input = Console.ReadLine();
            Console.WriteLine("");
            if (int.TryParse(input, out int num))
            {
                if (num == 1)
                {
                    AddStudent(list);
                }
                else if (num == 2)
                {
                    AddStaff(list);
                }
                else
                {
                    Console.WriteLine("That isn't an option.");
                    AddPerson(list);
                }
            }
            else
            {
                Console.WriteLine("That isn't an option.");
                AddPerson(list);
            }
        }
        public static void AddStudent(List<Person> list)
        {
            Student student = new Student();

            bool askAgain = true;
            while (askAgain)
            {
                Console.WriteLine("What is the student's name?");
                string name = Console.ReadLine();
                if (Regex.IsMatch(name, @"^[a-zA-Z]+[ ]*[a-zA-Z]*$"))
                {
                    student.Name = name;
                    askAgain = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid name");
                    askAgain = true;
                }
            }
            askAgain = true;
            while (askAgain)
            {
                Console.WriteLine("What is their Address?");
                string address = Console.ReadLine();
                if (Regex.IsMatch(address, @"^[0-9]+[ ]+[a-zA-Z]+[ ]*[a-zA-Z]*[ ]*[a-zA-Z]*[ ]*[0-9]*$"))
                {
                    student.Address = address;
                    askAgain = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid address");
                    askAgain = true;
                }
            }
            askAgain = true;
            while (askAgain)
            {
                Console.WriteLine("What is their degree program?");
                string program = Console.ReadLine();
                if (Regex.IsMatch(program, @"^[a-zA-Z]+[ ]*[a-zA-Z]*[ ]*[a-zA-Z]*$"))
                {
                    student.Program = program;
                    askAgain = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid degree program");
                    askAgain = true;
                }
            }
            askAgain = true;
            while (askAgain)
            {
                Console.WriteLine("What year are they in?");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int year))
                {
                    student.Year = year;
                    askAgain = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid year");
                    askAgain = true;
                }
            }
            askAgain = true;
            while (askAgain)
            {
                Console.WriteLine("How much do they owe this semester?");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double tuition))
                {
                    student.Fee = tuition;
                    askAgain = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid amount");
                    askAgain = true;
                }
            }
            Console.WriteLine("");
            Program.peopleList.Add(student);
        }
        public static void AddStaff(List<Person> list)
        {
            Staff staff = new Staff();

            bool askAgain = true;
            while (askAgain)
            {
                Console.WriteLine("What is the teacher's name?");
                string name = Console.ReadLine();
                if (Regex.IsMatch(name, @"^[a-zA-Z]+[ ]*[a-zA-Z]*$"))
                {
                    staff.Name = name;
                    askAgain = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid name");
                    askAgain = true;
                }
            }
            askAgain = true;
            while (askAgain)
            {
                Console.WriteLine("What is their Address?");
                string address = Console.ReadLine();
                if (Regex.IsMatch(address, @"^[0-9]+[ ]+[a-zA-Z]+[ ]*[a-zA-Z]*[ ]*[a-zA-Z]*[ ]*[0-9]*$"))
                {
                    staff.Address = address;
                    askAgain = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid address");
                    askAgain = true;
                }
            }
            askAgain = true;
            while (askAgain)
            {
                Console.WriteLine("What school do they teach at?");
                string school = Console.ReadLine();
                if (Regex.IsMatch(school, @"^[a-zA-Z]+[ ]*[a-zA-Z]*[ ]*[a-zA-Z]*$"))
                {
                    staff.School = school;
                    askAgain = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid school.");
                    askAgain = true;
                }
            }
            askAgain = true;
            while (askAgain)
            {
                Console.WriteLine("What is their annual salary?");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double salary))
                {
                    staff.Pay = salary;
                    askAgain = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid salary.");
                    askAgain = true;
                }
            }
            Console.WriteLine("");
            Program.peopleList.Add(staff);
            Console.WriteLine("");
        }
    }

}


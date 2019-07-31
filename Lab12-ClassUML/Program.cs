using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_ClassUML
{
    class Program
    {
        public static List<Person> peopleList = new List<Person>
            {

                new Staff("Western Michigan University", 70000.00, "Dennis", "10 East Boulevard"),
                new Student("Computer Science", 2, 2000.50, "Joshua", "5151 Bluefield Lane"),
                new Student("English", 3, 1500.00, "Janice", "307 Henderson Apt 101"),
                new Student("Undeclared", 1, 4000.39, "Dave", "4989 Rosewood"),
                new Staff("Western Michigan University", 75000.00, "Alice", "587 Birch Street")
            };
        static void Main(string[] args)
        {

            bool addPerson = true; 
            while (addPerson)
            {
                addPerson = Methods.AddNewPerson("Would you like to:\n1. View current students and staff (type 1 or view)\n2. Add a staff member or a student (type 2 or add)" +
                    "\n3. Quit (type 3 or quit)", peopleList);
            }
        }
    }
}

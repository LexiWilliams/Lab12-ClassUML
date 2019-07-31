using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_ClassUML
{
    class Student : Person
    {
        #region Fields and Properties
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }
        #endregion
        #region Constructors
        public Student() : base()
        {

        }
        public Student(string program, int year, double fee, string name, string address)
            : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Student[Person[name: {Name}, address: {Address}], program: {Program}], year: {Year}, fee: {Fee}]";
        }
        #endregion
    }
}

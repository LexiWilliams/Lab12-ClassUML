using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_ClassUML
{
    abstract class Person
    {
        #region Fields + Properties
        public string Name { get; set; }
        public string Address { get; set; }
        #endregion
        #region Constructors
        public Person()
        {

        }
        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Person[name: {Name}, address: {Address}]";
        }
        #endregion
    }
}

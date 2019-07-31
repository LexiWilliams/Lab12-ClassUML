using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_ClassUML
{
    class Staff : Person
    {
        #region Fields and Properties
        public string School { get; set; }
        public double Pay { get; set; }
        #endregion
        #region Constructors
        public Staff() : base()
        {

        }
        public Staff(string school, double pay, string name, string address)
            : base(name, address)
        {
            School = school;
            Pay = pay;

        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Staff[name: {Name}, address: {Address}], school: {School}], pay: {Pay}]";
        }
        #endregion
    }
}

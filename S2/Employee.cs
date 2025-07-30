using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2
{
    internal struct Employee
    {
        #region Attributes
        public int EmpId;

        private string? EmpName;

        private decimal Empsalary;
        #endregion

        #region Constructors

        public Employee(int id, string name, decimal salary)
        {
            EmpId = id;
            //EmpName = name;
            SetName(name);
            Salary = salary;
        }

        #endregion

        #region Encapsulation

        #region Getter and Setter


        public string GetName()
        { 
            return EmpName; 
        }

        private void SetName(string name)
        { 
            EmpName = name.Length>10 ? name.Substring(0,10): name;
        }


        #endregion
        #region Properties

        #region Full Property

        public decimal Salary
        {
            get { return Empsalary; }
            set { Empsalary = value > 5000 ? 5000 : value; }
        }

        

        #endregion

        #region Automatic Property

        public int Age { get; set; }

        public int Hamada { get; set; }

        //private decimal deduction;

        public decimal Deduction // read only property
        {
            get { return Salary * 0.1M;  } 
        }

        #endregion
        #endregion

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Id : {EmpId}\nName : {EmpName}\nSalary : {Salary:c}";
        }

        #endregion
    }
}

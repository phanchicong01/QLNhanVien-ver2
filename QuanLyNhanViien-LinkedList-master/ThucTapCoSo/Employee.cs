using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapCoSo
{
    class Employee
    {
        private string name;
        private string office;
        private DateTime birthday;
        private double salary;
        private int stt;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Office
        {
            get { return office; }
            set { office = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int Stt
        {
            get {  return stt; }
            set {  stt = value; }
        }

        public Employee()
        {
            Name = string.Empty;
            Office = string.Empty;
            Birthday = DateTime.Now;
            Salary = 1;
           
        }

    }
}

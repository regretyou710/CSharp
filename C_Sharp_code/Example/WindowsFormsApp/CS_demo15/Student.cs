using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo15
{
    class Student
    {
        private int _no;
        private string _name;
        private string _major;

        public int No
        {
            get
            {
                return _no;
            }
            set
            {
                this._no = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name  = value;
            }
        }
        public string Major
        {
            get
            {
                return _major;
            }
            set
            {
                this._major = value;
            }
        }
    }
}

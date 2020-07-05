using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo29
{
    class Car
    {
        private int _no;
        private string _model;

        public Car(int no, string model)
        {
            _no = no;
            _model = model;
        }
        public string Model
        {
            set
            {
                _model = value;
            }
        }

        public override string ToString()
        {
            return "No:" + _no + "\tModel:" + _model;
        }
    }
}

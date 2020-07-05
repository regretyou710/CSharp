using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo16
{
    public class Car
    {
        private int _no;
        private string _model;

        public Car()
        {
            throw new System.NotImplementedException();
        }

        public string Model
        {
            get => default;
            set
            {
                _model = value;
            }
        }

        public int getNo()
        {
            return _no;
        }

        public void setNo(int no)
        {
            _no = no;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtnesionMethod
{
    class Student
    {
        public string StuInfo()
        {
            return "學生基本訊息";
        }

        public string getStuInfo(int id,string name)
        {
            return string.Format("學號:{0}\t姓名:{1}",id,name);
        }
    }
}

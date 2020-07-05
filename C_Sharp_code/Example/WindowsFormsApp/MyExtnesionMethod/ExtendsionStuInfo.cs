using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtnesionMethod
{
    static class ExtendsionStuInfo
    {
        //方法擴充1.靜態類別2.靜態方法3.方法第一個參數需為this加上要擴展的類(型)別跟變數名稱
        //在現有class加入方法不需額外建立衍伸class
        
        public static string _ExtendsionStuInfo(this Student stu)
        {
            return stu.StuInfo();
        }

        public static string _ExtendsionGetStuInfo(this Student stu, int id, string name)
        {
            return stu.getStuInfo(id, name);
        }

        public static string Add(this string str,int i,int j)
        { int sum = i + j;
            return sum.ToString();
        }
        public static string Add(this string str)
        {
            
            return "NA";
        }
    }
}

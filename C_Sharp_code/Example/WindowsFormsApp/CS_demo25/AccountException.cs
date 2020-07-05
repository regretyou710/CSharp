using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo25
{   
    class AccountException:Exception
    {
        private string 帳戶名稱;

        //將自定例外的建構式參數(msg)傳入父類別建構式參數
        public AccountException(string msg,string 帳戶名稱):base(msg)
        {
            this.帳戶名稱 = 帳戶名稱;
        }
        public string get帳戶名稱()
        {
            return 帳戶名稱;
        }
    }
}

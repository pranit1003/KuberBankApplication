using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuberBankApplication
{
    public class Bank
    {
        public int Bankid { get; set; }
        public string BankName { get; set; }
        public string BankAdress { get; set; }

        public List<Admin> adminlist = new List<Admin>();
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuberBankApplication
{
    public class Payee
    {
        public int PayeeId { get; set; }
        public string PayeeName { get; set; }
        public int PayeeAccountNum { get; set; }
        public double PayeeAccountBalance { get; set; }

        public void DisplayPayeeBalance()
        {

        }

        public override string ToString()
        {
            return $" Payee Id is :{PayeeId} Payee Name is : {PayeeName} Payee Account Number is : {PayeeAccountNum} Payee Account Balance is : {PayeeAccountBalance}"; 
        }
    }

    
}

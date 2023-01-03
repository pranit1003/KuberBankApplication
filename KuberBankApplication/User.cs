using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuberBankApplication
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public double UserAccountBalance { get; set; }
        public int UserAccountNum { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; }
        public string UserStatus { get; set; }
        public double MinHardCodedBalance { get; set; }

        public void SeeBalance(int id)
        {
             
            
        }
        public void AddPayee()
        {

        }
        public void RemovePayee(int payeeId)
        {

        }
        public void TransferAmount(string payeeName, int payeeAccountNumber)
        {

        }
        public void DepositMoney(double money)
        {

        }
        public void WithdrawMoney(double money)
        {

        }
       

        public override string ToString()
        {
            return $"User id is :{UserId} User Name is :{UserName}  User Account Number is :{UserAccountNum}User Account Balance is :{UserAccountBalance+MinHardCodedBalance} User Password is {UserPassword} User Role is : {UserRole} User Status is : {UserStatus}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuberBankApplication
{
   public class Admin
    {
       public List<User> userlist = new List<User>();

        public int AdminId { get; set; }
        public  string AdminName { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
        public double AdminBalance { get; set; }

        public void AddUser(int userid, string username, int useraccoutNum, string userRole, string userStatus, double minBalance, string upassword)
        {
            userlist.Add(new User { UserId=userid, UserName= username, UserAccountNum = useraccoutNum, UserRole= userRole, UserStatus= userStatus, MinHardCodedBalance= minBalance, UserPassword= upassword});
        }
        public void UpdateUser(int id, string name,string role)
        {
            foreach (User u in userlist)
            {
                if(u.UserId == id)
                {
                    u.UserName = name;
                    u.UserRole = role;
                }

            }
        }
        public void DeleteUser(int id)
        {
            foreach (User u in userlist)
            {
                if(u.UserId== id)
                {
                    userlist.Remove(u);
                    break;
                }
            }
        }
        public void ActivateDeactivateUser(int id)
        {
            foreach (User u in userlist)
            {
                if(u.UserId ==id)
                {
                    if(u.MinHardCodedBalance > u.UserAccountBalance)
                    {
                        u.UserStatus = "Deactivate";
                    }
                    else
                    {
                        u.UserStatus = "Activate";
                    }
                }
            }
        }
        
        public void DisplayUser()
        {
            foreach (User u in userlist)
            {
                Console.WriteLine(u);
            }
        }


        public override string ToString()
        {
            return $"Admin id is :{AdminId} Admin Name is :{AdminName} Admin User Name is :{AdminUserName} Admin Password is {AdminPassword} Admin balance is : {AdminBalance}"; 
        }


    }
}

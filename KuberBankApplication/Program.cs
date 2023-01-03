using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuberBankApplication
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Bank b = new Bank();
            
            List<User> userlist = new List<User>();
            
            List<Admin> adminlist = new List<Admin>();
            Admin a = new Admin();
            a.AdminId = 10;
            a.AdminName = "arun";
            a.AdminPassword = "12345";
            a.AdminUserName = "arun100";
            a.AdminBalance = 2000;

            User s = new User();
            s.UserId = 100;
            s.UserName = "ritika";
            s.UserPassword = "ritika1234";
            s.UserRole = "user";
            s.UserStatus = "active";
            s.MinHardCodedBalance = 2000;

            Console.WriteLine("---------------Welcome to Kuber Bank-------------");

            Console.WriteLine("If you are admin press 1 \nIf you are user press 2");
            
            
            //Console.WriteLine("Admin password "+a. );

            char chMain;
            do
            {
                Console.WriteLine("Please select given Role");
                Console.WriteLine(" 1.  Admin ");
                Console.WriteLine(" 2.  User");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("please enter Password");
                string Password = Console.ReadLine();
                Console.Clear();
                
                if (Password.Equals(a.AdminPassword))
                {
                    switch (choice)
                    {
                        case 1:
                            char ans;
                            do
                            {

                                Console.WriteLine("1.        AddUser");
                                Console.WriteLine("2.        UpdateUser");
                                Console.WriteLine("3.        DeleteUser");
                                Console.WriteLine("4.        Activate / Deactive User");
                                Console.WriteLine("5.        DisplayUser");

                                Console.WriteLine("Enter your choice as a Admin");
                                int adminChoice = Convert.ToInt32(Console.ReadLine());

                                switch (adminChoice)
                                {
                                    case 1:
                                        char ans1;
                                        do
                                        {
                                            Console.WriteLine("Enter [userId, userName, userAccountNumber, userRole, userStatus, MinBalance ]");
                                            int uid = Convert.ToInt32(Console.ReadLine());

                                            string uname = Console.ReadLine();

                                            int uaccnum = Convert.ToInt32(Console.ReadLine());

                                            string urole = Console.ReadLine();

                                            string ustatus = Console.ReadLine();

                                            double minBal = Convert.ToDouble(Console.ReadLine());
                                            string upassword = Console.ReadLine();

                                            a.AddUser(uid, uname, uaccnum, urole, ustatus, minBal, upassword);
                                            Console.WriteLine("Do you want to add another account..! if yes then press'Y'");
                                            ans1 = Convert.ToChar(Console.ReadLine());
                                        } while (ans1 == 'y' || ans1 == 'Y');
                                        Console.Clear();
                                        break;

                                    case 2:
                                        do
                                        {
                                            Console.WriteLine("Enter Id which you want to update");
                                            int uid = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Please enter new Name and Role");
                                            string newname = Console.ReadLine();
                                            string newrole = Console.ReadLine();
                                            a.UpdateUser(uid, newname, newrole);

                                            Console.WriteLine("Do you want to Update another account..! if yes then press'Y'");
                                            ans1 = Convert.ToChar(Console.ReadLine());
                                        } while (ans1 == 'y' || ans1 == 'Y');
                                        break;
                                    case 3:
                                        do
                                        {
                                            Console.WriteLine("Plesase enter id which you want to delete user Id");
                                            int udelete = Convert.ToInt32(Console.ReadLine());
                                            a.DeleteUser(udelete);
                                            Console.WriteLine("Do you want to Delete another account..! if yes then press'Y'");
                                            ans1 = Convert.ToChar(Console.ReadLine());
                                        } while (ans1 == 'y' || ans1 == 'Y');
                                        break;

                                    case 4:
                                        do
                                        {


                                            Console.WriteLine("Enter Id which you want check status");
                                            int uid1 = Convert.ToInt32(Console.ReadLine());
                                            a.ActivateDeactivateUser(uid1);
                                            Console.WriteLine("Do you want to Check another account Status..! if yes then press'Y'");
                                            ans1 = Convert.ToChar(Console.ReadLine());
                                        } while (ans1 == 'y' || ans1 == 'Y');
                                        break;
                                    case 5:
                                        a.DisplayUser();
                                        break;
                                    default:
                                        Console.WriteLine("Incorrect Choice");
                                        break;

                                }
                                Console.WriteLine("Do you want to see admin menu again..? If yes then press Y ");
                                ans = Convert.ToChar(Console.ReadLine());
                            } while (ans == 'y' || ans == 'Y');
                            Console.Clear();
                            break;

                        case 2:

                            Console.WriteLine("1.        SeeBalance");
                            Console.WriteLine("2.        AddPayee");
                            Console.WriteLine("3.        RemovePayee");
                            Console.WriteLine("4.        TransferAmount");
                            Console.WriteLine("5.        DepositMoney");
                            Console.WriteLine("6.        WithdrawMoney");
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("Your password is incorrect");
                }
                Console.WriteLine(  "If you want to go for MAIN Menu...! then pres 'Y' ");
                chMain = Convert.ToChar(Console.ReadLine());
            } while (chMain== 'Y' || chMain =='y');
        }
       */
    }
}

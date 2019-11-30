using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var tran = new TransactionScope())
            //{
                var context = new TestDBContext();

                //update user infor
                var user = context.UserInfoes.First(x => x.UserId == 1);
                user.FirstName = "Anshul5";
                user.LastName = "Agarwal5";
                //Update phone no.
                var userPhone = context.UserPhones.First(x => x.UserId == 1 && x.UserPhoneId == 2);
                userPhone.Phone = "3546";
                context.SaveChanges();


                var user1 = context.UserInfoes.First(x => x.UserId == 1);
                user1.FirstName = "Anshul5";
                user1.LastName = "Agarwal5";
                //Update phone no.
                var userPhone1 = context.UserPhones.First(x => x.UserId == 1 && x.UserPhoneId == 2);
                userPhone1.Phone = "3546";
                context.SaveChanges();
            //    tran.Complete();
            //}
            
        }
    }
}

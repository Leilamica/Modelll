using Dataa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesssss
{
    public class VerifyID
    {
        public static bool VerifyIDS(string UserID)
        {
            UserDataService dataService = new UserDataService();
            var result = dataService.GetAccount(UserID);

            return result.UserID != null ? true : false;
        }
        public bool VerifyPassword(string Password)
        {
            UserDataService PasswordService = new UserDataService();
            var result = PasswordService.GetPassword(Password);

            return result.Password != null ? true : false;
        }
    }
}
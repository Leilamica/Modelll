using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelll;

namespace Dataa
{
    public class UserDataService
    {
        List<Class1> dummyAcc = new List<Class1>();

        public UserDataService()
        {
            CreateDummyAccount();
        }

        private void CreateDummyAccount()
        {
            Class1 dummy1 = new Class1
            {
                UserID = "Elie",
                Password = "123"
            };
            dummyAcc.Add(dummy1);

            Class1 dummy2 = new Class1
            {
                UserID = "Leila",
                Password = "Mica"
            };
            dummyAcc.Add(dummy2);

            Class1 dummy3 = new Class1
            {
                UserID = "Eliezer",
                Password = "Mojar"
            };
            dummyAcc.Add(dummy3);

            Class1 dummy4 = new Class1
            {
                UserID = "Missyou",
                Password = "uwi na"
            };
            dummyAcc.Add(dummy4);

            Class1 dummy5 = new Class1
            {
                UserID = "Joke only",
                Password = "char lang maam"
            };
            dummyAcc.Add(dummy5);
        }
        public Class1 GetAccount(string UserID)
        {
            Class1 FoundAccount = new Class1();

            foreach (var dummy in dummyAcc)
            {
                if (UserID == dummy.UserID)
                {
                    FoundAccount = dummy;
                }

            }

            return FoundAccount;

        }
        public Class1 GetPassword(string Password)
        {
            Class1 FoundAccount = new Class1();

            foreach (var dummy in dummyAcc)
            {
                if (Password == dummy.Password)
                {
                    FoundAccount = dummy;
                }

            }

            return FoundAccount;

        }
    }
}
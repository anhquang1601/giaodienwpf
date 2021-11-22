using System;
using System.Collections.Generic;
using System.Text;

namespace BTL
{
    class ManageAccount
    {
        public string Id { get; set; }
        public String NameAccount { get; set; }
        public string PassWord { get; set; }

        public ManageAccount(string id, string nameaccount, string password)
        {
            Id = id;
            NameAccount = nameaccount;
            PassWord = password;
        }

        public ManageAccount()
        {
        }
    }
}

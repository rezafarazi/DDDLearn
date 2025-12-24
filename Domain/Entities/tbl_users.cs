using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class tbl_users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string email{ get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string create_at { get; set; }
        public string update_at { get; set; }


        public tbl_users()
        {

        }


        public tbl_users(string Name,string Family,string Username,string Password,string Email)
        {
            name = Name;
            family = Family;
            username = Username;
            password = Password;
            email = Email;
            create_at = DateTime.UtcNow.ToString();
        }


        public void update(string Name, string Family, string Username, string Password, string Email)
        {
            name = Name;
            family = Family;
            username = Username;
            password = Password;
            email = Email;
            update_at = DateTime.UtcNow.ToString();
        }

    }
}

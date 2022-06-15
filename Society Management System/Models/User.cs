using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Society_Management_System.Models
{
    public class User
    {
        public Boolean isConnected = false;

        public Boolean loginSucceed = false;

        //Database fields
        public String Id { get; set; }
        public String UserName { get; set; }
        public String Role { get; set; }

        public User()
        {
            this.isConnected = false;
            this.loginSucceed = false;
        }
        public User(String Id, String UserName,String Role)
        {
            this.isConnected= true;
            this.loginSucceed = true;

            this.Id = Id;
            this.UserName = UserName;
            this.Role= Role;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPlanner
{
    public class User
    {
        private int id;
        private string user_name;
        private string password;
        private string email;
        private string first_name;
        private string name;
        private string avatar;
        public string role;
        private List<User> usersAssigned;

        public User(int id, string user_name, string password, string email, string first_name, string name, string avatar, string role)
        {
            this.id = id;
            this.user_name = user_name;
            this.password = password;
            this.email = email;
            this.first_name = first_name;
            this.name = name;
            this.avatar = avatar;
            this.role = role;
            this.usersAssigned = new List<User>();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string UserName
        {
            get { return user_name; }
            set { user_name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }
        public string LastName
        {
            get { return name; }
            set { name = value; }
        }
        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public List<User> UsersAssigned
        {
            get { return usersAssigned; }
            set { usersAssigned = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public void AddUser(User user)
        {
            usersAssigned.Add(user);
        }
    }
}

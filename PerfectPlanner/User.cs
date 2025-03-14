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
        private string username;
        private string password;
        private string email;
        private string firstName;
        private string lastName;
        private string avatar;
        public string role;
        private List<User> usersAssigned;

        public User(int id, string username, string password, string email, string firstName, string lastName, string avatar, string role)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
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
            get { return username; }
            set { username = value; }
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
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
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

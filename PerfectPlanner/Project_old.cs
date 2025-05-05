using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPlanner
{
    public class Project_old
    {
        private int id;
        private string project_name;
        private List<User_old> admins = new List<User_old>();
        private List<User_old> users = new List<User_old>();

        public Project_old(int id, string project_name)
        {
            this.id = id;
            this.project_name = project_name;
            this.admins = new List<User_old>();
            this.users = new List<User_old>();
        }

        public void AddAdmin(User_old user)
        {
            admins.Add(user);
        }
        public void AddAssignee(User_old user)
        {
            users.Add(user);
        }

        public void RemoveAdmin(User_old user)
        {
            admins.Remove(user);
        }
        public void RemoveAssignee(User_old user)
        {
            users.Remove(user);
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string ProjectName
        {
            get { return project_name; }
            set { project_name = value; }
        }

        public List<User_old> Admins
        {
            get { return admins; }
            set { admins = value; }
        }
        public List<User_old> Users
        {
            get { return users; }
            set { users = value; }
        }

        public String DisplayAdmins
        {
            get
            {
                String admins = "";
                foreach (var admin in this.admins)
                {
                    admins += admin.UserName + ", ";
                }
                admins = admins.TrimEnd(',', ' ');
                return admins;
            }
        }
        public String DisplayUsers
        {
            get
            {
                String users = "";
                foreach (var user in this.users)
                {
                    users += user.UserName + ", ";
                }
                users = users.TrimEnd(',', ' ');
                return users;
            }
        }
    }
}

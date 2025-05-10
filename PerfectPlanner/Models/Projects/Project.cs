using PerfectPlanner.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPlanner.Models.Projects
{
    public class Project
    {
        public int id { get; set; }
        public string project_name { get; set; }
        public List<User> admins { get; set; } = new List<User>();
        public List<User> users { get; set; } = new List<User>();

        public Project(int id, string projectName)
        {
            this.id =  id;
            this.project_name = projectName;
            this.admins = new List<User>();
            this.users = new List<User>();
        }

        public String DisplayAdmins
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (admins != null)
                {
                    foreach (User user in admins)
                    {
                        sb.Append(user.first_name + " " + user.name + ", ");
                    }
                    if (sb.Length > 0)
                    {
                        sb.Remove(sb.Length - 2, 2);
                    }
                }
                return sb.ToString();
            }
        }
        public String DisplayUsers
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (users != null)
                {
                    foreach (User user in users)
                    {
                        sb.Append(user.first_name + " " + user.name + ", ");
                    }
                    if (sb.Length > 0)
                    {
                        sb.Remove(sb.Length - 2, 2);
                    }
                }
                return sb.ToString();
            }
        }

        public List<int> UsersIds
        {
            get
            {
                List<int> ids = new List<int>();
                if (users != null)
                {
                    foreach (User user in users)
                    {
                        ids.Add(user.id);
                    }
                }
                if (admins != null)
                {
                    foreach (User user in admins)
                    {
                        ids.Add(user.id);
                    }
                }
                return ids;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPlanner
{
    public class Project
    {
        private int id;
        private string name;
        private List<User> admins = new List<User>();
        private List<User> assignees = new List<User>();

        public Project(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.admins = new List<User>();
            this.assignees = new List<User>();
        }

        public void AddAdmin(User user)
        {
            admins.Add(user);
        }
        public void AddAssignee(User user)
        {
            assignees.Add(user);
        }

        public void RemoveAdmin(User user)
        {
            admins.Remove(user);
        }
        public void RemoveAssignee(User user)
        {
            assignees.Remove(user);
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<User> Admins
        {
            get { return admins; }
            set { admins = value; }
        }
        public List<User> Assignees
        {
            get { return assignees; }
            set { assignees = value; }
        }
    }
}

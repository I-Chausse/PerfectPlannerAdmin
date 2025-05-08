using PerfectPlanner.Models.Avatars;
using PerfectPlanner.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectPlanner.Models.Users
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string user_name { get; set; }
        public Avatar avatar { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public List<User> assignees { get; set; }
        public Role role { get; set; }

        public String role_name
        {
            get
            {
                if (role != null)
                {
                    return role.label;
                }
                return "";
            }
        }
        public String display_assignees
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (assignees != null)
                {
                    foreach (User user in assignees)
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

        public List<int> userIds
        {
            get
            {
                List<int> ids = new List<int>();
                if (assignees != null)
                {
                    foreach (User user in assignees)
                    {
                        ids.Add(user.id);
                    }
                }
                return ids;
            }
        }
        public int role_id
        {
            get
            {
                if (role != null)
                {
                    return role.id;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}

using PerfectPlanner.Models.Avatars;
using PerfectPlanner.Models.UserRoles;
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
        public UserRole role { get; set; }

    }
}

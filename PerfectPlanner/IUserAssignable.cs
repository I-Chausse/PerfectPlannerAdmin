using PerfectPlanner.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPlanner
{
    public interface IUserAssignable
    {
        void AddUser(User user);
        void RemoveUser();
    }
}

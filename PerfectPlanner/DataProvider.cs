using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPlanner
{
    public class DataProvider
    {
        public static List<User> users = new List<User>();
        public static List<Project> projects = new List<Project>();
        public static List<User> GetUsers()
        {
            if (users.Count > 0)
            {
                return users;
            }
                users.Add(new User(1, "JDupond", "admin", "j-dupond@perfect-planner.com", "Jean", "Dupond", "https://openclipart.org/image/800px/22099", "Gestionnaire"));
            users.Add(new User(2, "JMartin", "admin", "j-martin@entreprise.com", "Jean", "Martin", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Avatar_Marco_Heiles.png/960px-Avatar_Marco_Heiles.png?20210728120659r", "Utilisateur"));
            users.Add(new User(3, "JLeclerc", "admin", "j-leclerc@moulin.ch", "Jean", "Leclerc", "https://vectorportal.com/storage/s-face_free_vector_1_6289.jpg", "Utilisateur"));
            users[0].AddUser(users[1]);
            users[0].AddUser(users[2]);
            return users;
        }

        public static List<Project> GetProjects()
        {
            if (projects.Count > 0)
            {
                return projects;
            }
            projects.Add(new Project(1, "Projet 1"));
            projects.Add(new Project(2, "Projet 2"));
            projects[0].AddAdmin(new User(1, "JDupond", "admin", "j-dupond@perfect-planner.com", "Jean", "Dupond", "avatar", "Gestionnaire"));
            projects[0].AddAssignee(new User(2, "JMartin", "admin", "j-martin@matrin.ch", "Jean", "Martin", "avatar", "Utilisateur"));
            projects[0].AddAdmin(new User(3, "JLeclerc", "admin", "j-leclerc@moulin.ch", "Jean", "Leclerc", "avatar", "Utilisateur"));
            return projects;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class Repository
    {
        private List<User> users = new List<User>();        

        private string path;

        public const string Separator = "#";

        public Repository(string path) 
        {
            this.path = path;
        }

        public List<User> Users
        {
            get
            {
                return users;
            }
        }

        public void Load()
        {
            using(StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null) 
                {
                    string[] parts = line.Split(Separator);
                    int id = int.Parse(parts[0]);
                    users.Add(new User(id, parts[1], parts[2], parts[3], parts[4], parts[5]));                    
                }
            }
        }

        public void Save() 
        {
            using (StreamWriter sw = new StreamWriter(path)) 
            {


            }

        }

        public User FindId(int id) 
        {
            
            for(int i = 0; i < users.Count; i++) 
            {
                if (Users[i].Id == id) 
                {
                    return Users[i];
                }
            }
            return null;
        }



    }
}

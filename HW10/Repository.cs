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
            if (!File.Exists(path))
            {
                //File.Create(path).Close();
                FileStream file = File.Create(path);
                file.Close();
            }
            
            using (StreamReader sr = new StreamReader(path))
            {
                users.Clear();
                string line;
                while((line = sr.ReadLine()) != null) 
                {
                    string[] parts = line.Split(Separator);
                    int id = int.Parse(parts[0]);
                    users.Add(new User(id, parts[1], parts[2], parts[3], parts[4], parts[5]));

                    User curUser = new User(id, parts[1], parts[2], parts[3], parts[4], parts[5]);
                    HistoryLoad(curUser);


                }
            }
        }

        public void Save(List <User> users) 
        {       

            using (StreamWriter sw = new StreamWriter(path)) 
            {
                for (int i = 0; i < users.Count; i++)
                {
                    sw.WriteLine(PrintToSave(users[i]));
                    HistorySave(users[i]);
                }
            }
        }

        //public void Save2()
        //{
        //    StringBuilder sb = new StringBuilder();

          
        //    for (int i = 0; i < users.Count; i++)
        //    {
        //        sb.AppendLine(PrintToSave(users[i]));
              
        //        //WriteLine(PrintToSave(users[i]));
        //    }
        //    File.WriteAllText(path, sb.ToString());
        //}

        public string PrintToSave(User user)
        {
            return string.Join(Separator, user.Id, user.LastName, user.FirstName, user.Patronymic, user.Phone, user.Passport);
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


        protected void HistoryLoad(User user)
        {
            if (!File.Exists($"{user.Id}.txt")) 
            {
                return;
            }
            

        }

        protected void HistorySave(User user) 
        {
            using (StreamWriter sw = new StreamWriter($"{user.Id}.txt"))
            {
                for (int i = 0; i < user.histories.Count ; i++)
                {
                    sw.WriteLine(PrintToHistorySave(user.histories[i]));
                }
            }

        }


        protected string PrintToHistorySave(History history)
        {
            return string.Join(Separator, history.WhoEdit, history.WhatEdit, history.TimeEdit);
        }


    }
}

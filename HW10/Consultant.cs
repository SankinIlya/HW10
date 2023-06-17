﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class Consultant
    {


        public virtual User Read(User user)
        {
            User newUser = new User(user);
            newUser.Passport = "********";
            return newUser;
        }

        public virtual User Edit(User user, User editUser)
        {
            user = editUser;
            if(editUser.Phone == string.Empty) 
            {
                throw new Exception("Номер не введен");
            }
            return editUser;
        }



    }
}
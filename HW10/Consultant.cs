using System;
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

        public virtual bool TryEdit(User user, User editUser)
        {
            bool checkResult = editUser.Phone != string.Empty && CheckInfo(user, editUser);
            if (checkResult && user.Phone != editUser.Phone)
            {
                editUser.histories.Add(new History
                {
                    WhatEdit = $"Телефон {user.Phone} поменялся на {editUser.Phone}",
                    WhoEdit = "Консультант"
                });
            }
            return checkResult;
        }

        protected virtual bool CheckInfo(User user, User editUser)
        {
            if (user.Id == editUser.Id && user.LastName == editUser.LastName && user.FirstName == editUser.FirstName
                && user.Patronymic == editUser.Patronymic && user.Passport == editUser.Passport)
            {
                return true;
            }
            return false;
        }

    }
}

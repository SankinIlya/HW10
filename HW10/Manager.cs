using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class Manager : Consultant, IUserCreator
    {

        public override User Read(User user)
        {
            return user;
        }


        public override bool TryEdit(User user, User editUser)
        {

            if (editUser.Phone == string.Empty)
            {
                return false;
            }
            if (editUser.Phone != user.Phone)
            {
                editUser.histories.Add(new History
                {
                    WhatEdit = $"Телефон {user.Phone} поменялся на {editUser.Phone}",
                    WhoEdit = "Менеджер"
                });
            }
            if (editUser.FirstName != user.FirstName)
            {
                editUser.histories.Add(new History
                {
                    WhatEdit = $"Имя {user.FirstName} поменялось на {editUser.FirstName}",
                    WhoEdit = "Менеджер"
                });
            }
            if (editUser.Passport != user.Passport)
            {
                editUser.histories.Add(new History
                {
                    WhatEdit = $"Пасспорт {user.Passport} поменялся на {editUser.Passport}",
                    WhoEdit = "Менеджер"
                });
            }
            if (editUser.LastName != user.LastName)
            {
                editUser.histories.Add(new History
                {
                    WhatEdit = $"Фамилия {user.LastName} поменялась на {editUser.LastName}",
                    WhoEdit = "Менеджер"
                });
            }
            if (editUser.Patronymic != user.Patronymic)
            {
                editUser.histories.Add(new History
                {
                    WhatEdit = $"Отчество {user.Patronymic} поменялось на {editUser.Patronymic}",
                    WhoEdit = "Менеджер"
                });
            }
            return true;
        }

        protected override bool CheckInfo(User user, User editUser)
        {

            return true;
        }

        public bool TryCreateUser(User user)
        {
            if (user.Phone != string.Empty)
            {
                return true;
            }
            return false;
        }
    }
}

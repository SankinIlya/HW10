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
            user = editUser;
            if (editUser.Phone == string.Empty)
            {
                return false;
            }
            return true;
        }

        public bool CheckInfo(User user, User editUser)
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
